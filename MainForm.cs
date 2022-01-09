using System.Windows.Forms;
using MetroSuite;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Threading;
using System.Net.Http;
using System.Reflection;
using System.Net;
using System.Text;

public partial class MainForm : MetroForm
{
    public List<string> hmacs;
    public char[] characters = "abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789_".ToCharArray();
    public int valid = 0, invalid = 0;
    public bool checking = false;
    public Thread checkThread;
    public ResourceSemaphore validSemaphore, invalidSemaphore;
    public List<string> validHmacs, invalidHmacs;

    public MainForm()
    {
        InitializeComponent();
        hmacs = new List<string>();
        validHmacs = new List<string>();
        invalidHmacs = new List<string>();
        CheckForIllegalCrossThreadCalls = false;
        Process.GetCurrentProcess().PriorityClass = ProcessPriorityClass.RealTime;

        Thread thread = new Thread(updateAll);
        thread.Priority = ThreadPriority.Highest;
        thread.Start();

        validSemaphore = new ResourceSemaphore();
        invalidSemaphore = new ResourceSemaphore();

        System.Net.ServicePointManager.DefaultConnectionLimit = int.MaxValue;
        System.Net.ServicePointManager.MaxServicePoints = int.MaxValue;
        System.Net.ServicePointManager.SecurityProtocol = SecurityProtocolType.Tls12;
    }

    public void updateAll()
    {
        while (true)
        {
            Thread.Sleep(10);

            metroLabel2.Text = valid.ToString();
            metroLabel3.Text = invalid.ToString();
        }
    }

    private void gunaButton1_Click(object sender, System.EventArgs e)
    {
        if (openFileDialog1.ShowDialog().Equals(DialogResult.OK))
        {
            gunaLineTextBox1.Text = openFileDialog1.FileName;
        }
    }

    private void gunaButton3_Click(object sender, System.EventArgs e)
    {
        if (!File.Exists(gunaLineTextBox1.Text))
        {
            MessageBox.Show("The specified file does not exist on your PC.", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Error);
            return;
        }

        if (!Path.GetExtension(gunaLineTextBox1.Text).ToLower().Equals(".txt"))
        {
            MessageBox.Show("The specified file has no valid extension. Please, try again.", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Error);
            return;
        }

        foreach (string line in File.ReadAllLines(gunaLineTextBox1.Text))
        {
            string newLine = line.Replace(" ", "").Replace('\t'.ToString(), "");

            if (newLine.Length != 192)
            {
                continue;
            }

            int dots = 0;

            foreach (char c in line.ToCharArray())
            {
                if (c.Equals('.'))
                {
                    dots++;
                }

                if (dots >= 3)
                {
                    break;
                }
            }

            if (dots >= 3)
            {
                continue;
            }

            string[] splitted = line.Split('.');

            if (splitted[0].Length != 94)
            {
                continue;
            }

            if (splitted[1].Length != 32)
            {
                continue;
            }

            if (splitted[2].Length != 64)
            {
                continue;
            }

            if (hmacs.Contains(newLine))
            {
                continue;
            }

            hmacs.Add(newLine);
        }

        metroLabel32.Text = hmacs.Count.ToString();
    }

    private void gunaButton4_Click(object sender, System.EventArgs e)
    {
        hmacs.Clear();
        metroLabel32.Text = "0";
    }

    private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
    {
        Process.GetCurrentProcess().Kill();
    }

    private void gunaButton2_Click(object sender, System.EventArgs e)
    {
        validHmacs = new List<string>();
        invalidHmacs = new List<string>();

        if (!checking)
        {
            gunaButton3.Enabled = false;
            gunaButton1.Enabled = false;
            gunaButton4.Enabled = false;
            gunaLineTextBox1.Enabled = false;

            valid = 0;
            invalid = 0;
            gunaButton2.Text = "Stop checking Guilded HMACs";
            checking = true;

            validSemaphore = new ResourceSemaphore();
            invalidSemaphore = new ResourceSemaphore();

            checkThread = new Thread(Check);
            checkThread.Priority = ThreadPriority.Highest;
            checkThread.Start();
        }
        else
        {
            Stop();
        }
    }

    public void Stop()
    {
        checking = false;
        gunaButton2.Text = "Check loaded Guilded HMACs";

        validSemaphore = new ResourceSemaphore();
        invalidSemaphore = new ResourceSemaphore();

        gunaButton3.Enabled = true;
        gunaButton1.Enabled = true;
        gunaButton4.Enabled = true;
        gunaLineTextBox1.Enabled = true;

        Save();

        try
        {
            checkThread.Abort();
        }
        catch
        {

        }
    }

    public void Save()
    {
        string validString = "", invalidString = "";

        foreach (string validHmac in validHmacs)
        {
            if (validString == "")
            {
                validString = validHmac;
            }
            else
            {
                validString += "\r\n" + validHmac;
            }
        }

        foreach (string invalidHmac in invalidHmacs)
        {
            if (invalidString == "")
            {
                invalidString = invalidHmac;
            }
            else
            {
                invalidString += "\r\n" + invalidHmac;
            }
        }

        if (System.IO.File.Exists("valid.txt"))
        {
            if (System.IO.File.ReadAllText("valid.txt").Replace(" ", "").Trim().Replace('\t'.ToString(), "") == "")
            {
                System.IO.File.WriteAllText("valid.txt", validString);
            }
            else
            {
                System.IO.File.AppendAllText("valid.txt", "\r\n" + validString);
            }
        }
        else
        {
            System.IO.File.WriteAllText("valid.txt", validString);
        }

        if (System.IO.File.Exists("invalid.txt"))
        {
            if (System.IO.File.ReadAllText("invalid.txt").Replace(" ", "").Trim().Replace('\t'.ToString(), "") == "")
            {
                System.IO.File.WriteAllText("invalid.txt", invalidString);
            }
            else
            {
                System.IO.File.AppendAllText("invalid.txt", "\r\n" + invalidString);
            }
        }
        else
        {
            System.IO.File.WriteAllText("invalid.txt", invalidString);
        }
    }

    public void Check()
    {
        foreach (string hmac in hmacs)
        {
            if (!checking)
            {
                return;
            }

            Thread.Sleep(1);

            Thread thread = new Thread(() => CheckHMAC(hmac));
            thread.Priority = ThreadPriority.Highest;
            thread.Start();

            if (!checking)
            {
                return;
            }
        }

        while (valid + invalid != hmacs.Count)
        {
            Thread.Sleep(1000);

            if (!checking)
            {
                return;
            }
        }

        Stop();
    }

    public static byte[] ReadFully(Stream input)
    {
        using (MemoryStream ms = new MemoryStream())
        {
            input.CopyTo(ms);
            return ms.ToArray();
        }
    }

    public void CheckHMAC(string hmac)
    {
        if (checking)
        {
            try
            {
                var request = (HttpWebRequest)WebRequest.Create("https://www.guilded.gg/api/users/me/teams/status");

                request.Proxy = null;
                request.UseDefaultCredentials = false;
                request.AllowAutoRedirect = false;

                var field = typeof(HttpWebRequest).GetField("_HttpRequestHeaders", BindingFlags.Instance | BindingFlags.NonPublic);

                request.Method = "GET";

                var headers = new CustomWebHeaderCollection(new Dictionary<string, string>
                {
                    ["Host"] = "www.guilded.gg",
                    ["Cookie"] = $"hmac_signed_session={hmac}",
                });

                field.SetValue(request, headers);

                var response = request.GetResponse();
                bool isValid = false;
                string content = Encoding.UTF8.GetString(ReadFully(response.GetResponseStream()));

                if (content.Contains("userId"))
                {
                    isValid = true;
                }

                response.Close();
                response.Dispose();

                if (isValid)
                {
                    Interlocked.Increment(ref valid);

                    while (validSemaphore.IsResourceNotAvailable())
                    {
                        Thread.Sleep(1000);
                    }

                    if (validSemaphore.IsResourceAvailable())
                    {
                        validSemaphore.LockResource();
                        validHmacs.Add(hmac);
                        validSemaphore.UnlockResource();
                    }
                }
                else
                {
                    Interlocked.Increment(ref invalid);

                    while (invalidSemaphore.IsResourceNotAvailable())
                    {
                        Thread.Sleep(1000);
                    }

                    if (invalidSemaphore.IsResourceAvailable())
                    {
                        invalidSemaphore.LockResource();
                        invalidHmacs.Add(hmac);
                        invalidSemaphore.UnlockResource();
                    }
                }
            }
            catch
            {
                Interlocked.Increment(ref invalid);

                while (invalidSemaphore.IsResourceNotAvailable())
                {
                    Thread.Sleep(1000);
                }

                if (invalidSemaphore.IsResourceAvailable())
                {
                    invalidSemaphore.LockResource();
                    invalidHmacs.Add(hmac);
                    invalidSemaphore.UnlockResource();
                }
            }
        }
    }
}