partial class MainForm
{
    private System.ComponentModel.IContainer components = null;

    protected override void Dispose(bool disposing)
    {
        if (disposing && (components != null))
        {
            components.Dispose();
        }

        base.Dispose(disposing);
    }

    private void InitializeComponent()
    {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.gunaControlBox3 = new Guna.UI.WinForms.GunaControlBox();
            this.gunaControlBox1 = new Guna.UI.WinForms.GunaControlBox();
            this.gunaLineTextBox1 = new Guna.UI.WinForms.GunaLineTextBox();
            this.gunaButton1 = new Guna.UI.WinForms.GunaButton();
            this.metroLabel32 = new MetroSuite.MetroLabel();
            this.metroLabel31 = new MetroSuite.MetroLabel();
            this.gunaButton4 = new Guna.UI.WinForms.GunaButton();
            this.gunaButton2 = new Guna.UI.WinForms.GunaButton();
            this.gunaButton3 = new Guna.UI.WinForms.GunaButton();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.metroLabel1 = new MetroSuite.MetroLabel();
            this.metroLabel2 = new MetroSuite.MetroLabel();
            this.metroLabel3 = new MetroSuite.MetroLabel();
            this.metroLabel4 = new MetroSuite.MetroLabel();
            this.SuspendLayout();
            // 
            // gunaControlBox3
            // 
            this.gunaControlBox3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.gunaControlBox3.Animated = true;
            this.gunaControlBox3.AnimationHoverSpeed = 0.07F;
            this.gunaControlBox3.AnimationSpeed = 0.03F;
            this.gunaControlBox3.ControlBoxType = Guna.UI.WinForms.FormControlBoxType.MinimizeBox;
            this.gunaControlBox3.IconColor = System.Drawing.Color.White;
            this.gunaControlBox3.IconSize = 15F;
            this.gunaControlBox3.Location = new System.Drawing.Point(403, 7);
            this.gunaControlBox3.Name = "gunaControlBox3";
            this.gunaControlBox3.OnHoverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(196)))), ((int)(((byte)(0)))));
            this.gunaControlBox3.OnHoverIconColor = System.Drawing.Color.LightGray;
            this.gunaControlBox3.OnPressedColor = System.Drawing.Color.Black;
            this.gunaControlBox3.Size = new System.Drawing.Size(45, 29);
            this.gunaControlBox3.TabIndex = 4;
            // 
            // gunaControlBox1
            // 
            this.gunaControlBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.gunaControlBox1.Animated = true;
            this.gunaControlBox1.AnimationHoverSpeed = 0.07F;
            this.gunaControlBox1.AnimationSpeed = 0.03F;
            this.gunaControlBox1.IconColor = System.Drawing.Color.White;
            this.gunaControlBox1.IconSize = 15F;
            this.gunaControlBox1.Location = new System.Drawing.Point(454, 7);
            this.gunaControlBox1.Name = "gunaControlBox1";
            this.gunaControlBox1.OnHoverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(196)))), ((int)(((byte)(0)))));
            this.gunaControlBox1.OnHoverIconColor = System.Drawing.Color.LightGray;
            this.gunaControlBox1.OnPressedColor = System.Drawing.Color.Black;
            this.gunaControlBox1.Size = new System.Drawing.Size(45, 29);
            this.gunaControlBox1.TabIndex = 3;
            // 
            // gunaLineTextBox1
            // 
            this.gunaLineTextBox1.Animated = true;
            this.gunaLineTextBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.gunaLineTextBox1.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.gunaLineTextBox1.FocusedLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(196)))), ((int)(((byte)(0)))));
            this.gunaLineTextBox1.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.gunaLineTextBox1.LineColor = System.Drawing.Color.Gainsboro;
            this.gunaLineTextBox1.LineSize = 1;
            this.gunaLineTextBox1.Location = new System.Drawing.Point(24, 52);
            this.gunaLineTextBox1.MaxLength = 2147483647;
            this.gunaLineTextBox1.Name = "gunaLineTextBox1";
            this.gunaLineTextBox1.PasswordChar = '\0';
            this.gunaLineTextBox1.Size = new System.Drawing.Size(384, 26);
            this.gunaLineTextBox1.TabIndex = 5;
            this.gunaLineTextBox1.Text = "Insert the path of the usernames text file to check here...";
            this.gunaLineTextBox1.TextOffsetX = 0;
            // 
            // gunaButton1
            // 
            this.gunaButton1.Animated = true;
            this.gunaButton1.AnimationHoverSpeed = 0.07F;
            this.gunaButton1.AnimationSpeed = 0.03F;
            this.gunaButton1.BackColor = System.Drawing.Color.Transparent;
            this.gunaButton1.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(196)))), ((int)(((byte)(0)))));
            this.gunaButton1.BorderColor = System.Drawing.Color.Transparent;
            this.gunaButton1.DialogResult = System.Windows.Forms.DialogResult.None;
            this.gunaButton1.FocusedColor = System.Drawing.Color.Empty;
            this.gunaButton1.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.gunaButton1.ForeColor = System.Drawing.Color.White;
            this.gunaButton1.Image = null;
            this.gunaButton1.ImageSize = new System.Drawing.Size(24, 24);
            this.gunaButton1.Location = new System.Drawing.Point(418, 54);
            this.gunaButton1.Name = "gunaButton1";
            this.gunaButton1.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(196)))), ((int)(((byte)(0)))));
            this.gunaButton1.OnHoverBorderColor = System.Drawing.Color.Black;
            this.gunaButton1.OnHoverForeColor = System.Drawing.Color.White;
            this.gunaButton1.OnHoverImage = null;
            this.gunaButton1.OnPressedColor = System.Drawing.Color.Black;
            this.gunaButton1.Size = new System.Drawing.Size(68, 26);
            this.gunaButton1.TabIndex = 13;
            this.gunaButton1.Text = "...";
            this.gunaButton1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.gunaButton1.Click += new System.EventHandler(this.gunaButton1_Click);
            // 
            // metroLabel32
            // 
            this.metroLabel32.BackColor = System.Drawing.Color.Transparent;
            this.metroLabel32.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.metroLabel32.Location = new System.Drawing.Point(24, 164);
            this.metroLabel32.Name = "metroLabel32";
            this.metroLabel32.Size = new System.Drawing.Size(462, 19);
            this.metroLabel32.TabIndex = 24;
            this.metroLabel32.Text = "0";
            this.metroLabel32.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // metroLabel31
            // 
            this.metroLabel31.BackColor = System.Drawing.Color.Transparent;
            this.metroLabel31.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.metroLabel31.Location = new System.Drawing.Point(21, 143);
            this.metroLabel31.Name = "metroLabel31";
            this.metroLabel31.Size = new System.Drawing.Size(465, 19);
            this.metroLabel31.TabIndex = 23;
            this.metroLabel31.Text = "Loaded Guilded HMACs";
            this.metroLabel31.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // gunaButton4
            // 
            this.gunaButton4.Animated = true;
            this.gunaButton4.AnimationHoverSpeed = 0.07F;
            this.gunaButton4.AnimationSpeed = 0.03F;
            this.gunaButton4.BackColor = System.Drawing.Color.Transparent;
            this.gunaButton4.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(196)))), ((int)(((byte)(0)))));
            this.gunaButton4.BorderColor = System.Drawing.Color.Transparent;
            this.gunaButton4.DialogResult = System.Windows.Forms.DialogResult.None;
            this.gunaButton4.FocusedColor = System.Drawing.Color.Empty;
            this.gunaButton4.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.gunaButton4.ForeColor = System.Drawing.Color.White;
            this.gunaButton4.Image = null;
            this.gunaButton4.ImageSize = new System.Drawing.Size(24, 24);
            this.gunaButton4.Location = new System.Drawing.Point(24, 196);
            this.gunaButton4.Name = "gunaButton4";
            this.gunaButton4.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(196)))), ((int)(((byte)(0)))));
            this.gunaButton4.OnHoverBorderColor = System.Drawing.Color.Black;
            this.gunaButton4.OnHoverForeColor = System.Drawing.Color.White;
            this.gunaButton4.OnHoverImage = null;
            this.gunaButton4.OnPressedColor = System.Drawing.Color.Black;
            this.gunaButton4.Size = new System.Drawing.Size(225, 42);
            this.gunaButton4.TabIndex = 25;
            this.gunaButton4.Text = "Reset loaded Guilded HMACs";
            this.gunaButton4.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.gunaButton4.Click += new System.EventHandler(this.gunaButton4_Click);
            // 
            // gunaButton2
            // 
            this.gunaButton2.Animated = true;
            this.gunaButton2.AnimationHoverSpeed = 0.07F;
            this.gunaButton2.AnimationSpeed = 0.03F;
            this.gunaButton2.BackColor = System.Drawing.Color.Transparent;
            this.gunaButton2.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(196)))), ((int)(((byte)(0)))));
            this.gunaButton2.BorderColor = System.Drawing.Color.Transparent;
            this.gunaButton2.DialogResult = System.Windows.Forms.DialogResult.None;
            this.gunaButton2.FocusedColor = System.Drawing.Color.Empty;
            this.gunaButton2.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.gunaButton2.ForeColor = System.Drawing.Color.White;
            this.gunaButton2.Image = null;
            this.gunaButton2.ImageSize = new System.Drawing.Size(24, 24);
            this.gunaButton2.Location = new System.Drawing.Point(255, 196);
            this.gunaButton2.Name = "gunaButton2";
            this.gunaButton2.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(196)))), ((int)(((byte)(0)))));
            this.gunaButton2.OnHoverBorderColor = System.Drawing.Color.Black;
            this.gunaButton2.OnHoverForeColor = System.Drawing.Color.White;
            this.gunaButton2.OnHoverImage = null;
            this.gunaButton2.OnPressedColor = System.Drawing.Color.Black;
            this.gunaButton2.Size = new System.Drawing.Size(231, 42);
            this.gunaButton2.TabIndex = 26;
            this.gunaButton2.Text = "Check loaded HMACs";
            this.gunaButton2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.gunaButton2.Click += new System.EventHandler(this.gunaButton2_Click);
            // 
            // gunaButton3
            // 
            this.gunaButton3.Animated = true;
            this.gunaButton3.AnimationHoverSpeed = 0.07F;
            this.gunaButton3.AnimationSpeed = 0.03F;
            this.gunaButton3.BackColor = System.Drawing.Color.Transparent;
            this.gunaButton3.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(196)))), ((int)(((byte)(0)))));
            this.gunaButton3.BorderColor = System.Drawing.Color.Transparent;
            this.gunaButton3.DialogResult = System.Windows.Forms.DialogResult.None;
            this.gunaButton3.FocusedColor = System.Drawing.Color.Empty;
            this.gunaButton3.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.gunaButton3.ForeColor = System.Drawing.Color.White;
            this.gunaButton3.Image = null;
            this.gunaButton3.ImageSize = new System.Drawing.Size(24, 24);
            this.gunaButton3.Location = new System.Drawing.Point(24, 88);
            this.gunaButton3.Name = "gunaButton3";
            this.gunaButton3.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(196)))), ((int)(((byte)(0)))));
            this.gunaButton3.OnHoverBorderColor = System.Drawing.Color.Black;
            this.gunaButton3.OnHoverForeColor = System.Drawing.Color.White;
            this.gunaButton3.OnHoverImage = null;
            this.gunaButton3.OnPressedColor = System.Drawing.Color.Black;
            this.gunaButton3.Size = new System.Drawing.Size(462, 42);
            this.gunaButton3.TabIndex = 27;
            this.gunaButton3.Text = "Upload Guilded HMACs to check";
            this.gunaButton3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.gunaButton3.Click += new System.EventHandler(this.gunaButton3_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.Filter = "Text file (*.txt)|*.txt";
            // 
            // metroLabel1
            // 
            this.metroLabel1.BackColor = System.Drawing.Color.Transparent;
            this.metroLabel1.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.metroLabel1.Location = new System.Drawing.Point(24, 249);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(225, 19);
            this.metroLabel1.TabIndex = 28;
            this.metroLabel1.Text = "Valid Guilded HMACs";
            this.metroLabel1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // metroLabel2
            // 
            this.metroLabel2.BackColor = System.Drawing.Color.Transparent;
            this.metroLabel2.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.metroLabel2.Location = new System.Drawing.Point(24, 274);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(225, 19);
            this.metroLabel2.TabIndex = 29;
            this.metroLabel2.Text = "0";
            this.metroLabel2.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // metroLabel3
            // 
            this.metroLabel3.BackColor = System.Drawing.Color.Transparent;
            this.metroLabel3.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.metroLabel3.Location = new System.Drawing.Point(252, 274);
            this.metroLabel3.Name = "metroLabel3";
            this.metroLabel3.Size = new System.Drawing.Size(234, 19);
            this.metroLabel3.TabIndex = 31;
            this.metroLabel3.Text = "0";
            this.metroLabel3.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // metroLabel4
            // 
            this.metroLabel4.BackColor = System.Drawing.Color.Transparent;
            this.metroLabel4.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.metroLabel4.Location = new System.Drawing.Point(252, 249);
            this.metroLabel4.Name = "metroLabel4";
            this.metroLabel4.Size = new System.Drawing.Size(234, 19);
            this.metroLabel4.TabIndex = 30;
            this.metroLabel4.Text = "Invalid Guilded HMACs";
            this.metroLabel4.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // MainForm
            // 
            this.AccentColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(196)))), ((int)(((byte)(0)))));
            this.AllowResize = false;
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(506, 307);
            this.Controls.Add(this.metroLabel3);
            this.Controls.Add(this.metroLabel4);
            this.Controls.Add(this.metroLabel2);
            this.Controls.Add(this.metroLabel1);
            this.Controls.Add(this.gunaButton3);
            this.Controls.Add(this.gunaButton2);
            this.Controls.Add(this.gunaButton4);
            this.Controls.Add(this.metroLabel32);
            this.Controls.Add(this.metroLabel31);
            this.Controls.Add(this.gunaButton1);
            this.Controls.Add(this.gunaLineTextBox1);
            this.Controls.Add(this.gunaControlBox3);
            this.Controls.Add(this.gunaControlBox1);
            this.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.State = MetroSuite.MetroForm.FormState.Custom;
            this.Style = MetroSuite.Design.Style.Dark;
            this.Text = "GuildedChecker";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainForm_FormClosing);
            this.ResumeLayout(false);

    }

    private Guna.UI.WinForms.GunaControlBox gunaControlBox3;
    private Guna.UI.WinForms.GunaControlBox gunaControlBox1;
    private Guna.UI.WinForms.GunaLineTextBox gunaLineTextBox1;
    private Guna.UI.WinForms.GunaButton gunaButton1;
    private MetroSuite.MetroLabel metroLabel32;
    private MetroSuite.MetroLabel metroLabel31;
    private Guna.UI.WinForms.GunaButton gunaButton4;
    private Guna.UI.WinForms.GunaButton gunaButton2;
    private Guna.UI.WinForms.GunaButton gunaButton3;
    private System.Windows.Forms.OpenFileDialog openFileDialog1;
    private MetroSuite.MetroLabel metroLabel1;
    private MetroSuite.MetroLabel metroLabel2;
    private MetroSuite.MetroLabel metroLabel3;
    private MetroSuite.MetroLabel metroLabel4;
}