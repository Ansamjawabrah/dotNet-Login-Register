
namespace LoginRegister
{
    partial class Login
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
            this.picbox1 = new Guna.UI2.WinForms.Guna2PictureBox();
            this.Label1 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.UsernameTB = new Guna.UI2.WinForms.Guna2TextBox();
            this.PasswordTB = new Guna.UI2.WinForms.Guna2TextBox();
            this.lb2 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.loginbtn = new Guna.UI2.WinForms.Guna2GradientButton();
            this.guna2HtmlLabel1 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.guna2HtmlLabel2 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.guna2CircleButton1 = new Guna.UI2.WinForms.Guna2CircleButton();
            this.guna2CircleButton2 = new Guna.UI2.WinForms.Guna2CircleButton();
            this.guna2CircleButton3 = new Guna.UI2.WinForms.Guna2CircleButton();
            this.button1 = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.picbox1)).BeginInit();
            this.SuspendLayout();
            // 
            // picbox1
            // 
            this.picbox1.Image = ((System.Drawing.Image)(resources.GetObject("picbox1.Image")));
            this.picbox1.Location = new System.Drawing.Point(156, 73);
            this.picbox1.Margin = new System.Windows.Forms.Padding(2);
            this.picbox1.Name = "picbox1";
            this.picbox1.ShadowDecoration.Parent = this.picbox1;
            this.picbox1.Size = new System.Drawing.Size(307, 393);
            this.picbox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picbox1.TabIndex = 0;
            this.picbox1.TabStop = false;
            // 
            // Label1
            // 
            this.Label1.AutoSize = false;
            this.Label1.BackColor = System.Drawing.Color.Transparent;
            this.Label1.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(62)))), ((int)(((byte)(62)))));
            this.Label1.Location = new System.Drawing.Point(536, 73);
            this.Label1.Margin = new System.Windows.Forms.Padding(2);
            this.Label1.Name = "Label1";
            this.Label1.Size = new System.Drawing.Size(136, 24);
            this.Label1.TabIndex = 1;
            this.Label1.Text = "Welcome back!";
            // 
            // UsernameTB
            // 
            this.UsernameTB.Animated = true;
            this.UsernameTB.AutoRoundedCorners = true;
            this.UsernameTB.BorderColor = System.Drawing.SystemColors.ControlDark;
            this.UsernameTB.BorderRadius = 22;
            this.UsernameTB.BorderThickness = 2;
            this.UsernameTB.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.UsernameTB.DefaultText = "";
            this.UsernameTB.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.UsernameTB.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.UsernameTB.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.UsernameTB.DisabledState.Parent = this.UsernameTB;
            this.UsernameTB.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.UsernameTB.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.UsernameTB.FocusedState.Parent = this.UsernameTB;
            this.UsernameTB.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UsernameTB.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.UsernameTB.HoverState.Parent = this.UsernameTB;
            this.UsernameTB.IconLeft = ((System.Drawing.Image)(resources.GetObject("UsernameTB.IconLeft")));
            this.UsernameTB.IconLeftOffset = new System.Drawing.Point(5, 0);
            this.UsernameTB.Location = new System.Drawing.Point(480, 122);
            this.UsernameTB.Margin = new System.Windows.Forms.Padding(6);
            this.UsernameTB.Name = "UsernameTB";
            this.UsernameTB.PasswordChar = '\0';
            this.UsernameTB.PlaceholderForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.UsernameTB.PlaceholderText = "Email";
            this.UsernameTB.SelectedText = "";
            this.UsernameTB.ShadowDecoration.Parent = this.UsernameTB;
            this.UsernameTB.Size = new System.Drawing.Size(249, 47);
            this.UsernameTB.TabIndex = 2;
            this.UsernameTB.TextChanged += new System.EventHandler(this.UsernameTB_TextChanged);
            // 
            // PasswordTB
            // 
            this.PasswordTB.Animated = true;
            this.PasswordTB.AutoRoundedCorners = true;
            this.PasswordTB.BorderColor = System.Drawing.SystemColors.ControlDark;
            this.PasswordTB.BorderRadius = 22;
            this.PasswordTB.BorderThickness = 2;
            this.PasswordTB.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.PasswordTB.DefaultText = "";
            this.PasswordTB.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.PasswordTB.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.PasswordTB.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.PasswordTB.DisabledState.Parent = this.PasswordTB;
            this.PasswordTB.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.PasswordTB.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.PasswordTB.FocusedState.Parent = this.PasswordTB;
            this.PasswordTB.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PasswordTB.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.PasswordTB.HoverState.Parent = this.PasswordTB;
            this.PasswordTB.IconLeft = ((System.Drawing.Image)(resources.GetObject("PasswordTB.IconLeft")));
            this.PasswordTB.IconLeftOffset = new System.Drawing.Point(5, 0);
            this.PasswordTB.Location = new System.Drawing.Point(480, 180);
            this.PasswordTB.Margin = new System.Windows.Forms.Padding(6);
            this.PasswordTB.Name = "PasswordTB";
            this.PasswordTB.PasswordChar = '\0';
            this.PasswordTB.PlaceholderForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.PasswordTB.PlaceholderText = "Password";
            this.PasswordTB.SelectedText = "";
            this.PasswordTB.ShadowDecoration.Parent = this.PasswordTB;
            this.PasswordTB.Size = new System.Drawing.Size(249, 47);
            this.PasswordTB.TabIndex = 2;
            this.PasswordTB.UseSystemPasswordChar = true;
            // 
            // lb2
            // 
            this.lb2.AutoSize = false;
            this.lb2.BackColor = System.Drawing.Color.Transparent;
            this.lb2.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(62)))), ((int)(((byte)(62)))));
            this.lb2.Location = new System.Drawing.Point(638, 235);
            this.lb2.Margin = new System.Windows.Forms.Padding(2);
            this.lb2.Name = "lb2";
            this.lb2.Size = new System.Drawing.Size(91, 17);
            this.lb2.TabIndex = 1;
            this.lb2.Text = "Forgot Password?";
            // 
            // loginbtn
            // 
            this.loginbtn.Animated = true;
            this.loginbtn.AutoRoundedCorners = true;
            this.loginbtn.BorderRadius = 22;
            this.loginbtn.CheckedState.Parent = this.loginbtn;
            this.loginbtn.CustomImages.Parent = this.loginbtn;
            this.loginbtn.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(60)))), ((int)(((byte)(40)))));
            this.loginbtn.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(188)))), ((int)(((byte)(44)))));
            this.loginbtn.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.loginbtn.ForeColor = System.Drawing.Color.White;
            this.loginbtn.HoverState.Parent = this.loginbtn;
            this.loginbtn.Location = new System.Drawing.Point(533, 265);
            this.loginbtn.Name = "loginbtn";
            this.loginbtn.ShadowDecoration.Parent = this.loginbtn;
            this.loginbtn.Size = new System.Drawing.Size(143, 47);
            this.loginbtn.TabIndex = 4;
            this.loginbtn.Text = "Login";
            this.loginbtn.Click += new System.EventHandler(this.loginbtn_Click);
            // 
            // guna2HtmlLabel1
            // 
            this.guna2HtmlLabel1.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel1.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2HtmlLabel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(62)))), ((int)(((byte)(62)))));
            this.guna2HtmlLabel1.Location = new System.Drawing.Point(553, 334);
            this.guna2HtmlLabel1.Margin = new System.Windows.Forms.Padding(2);
            this.guna2HtmlLabel1.Name = "guna2HtmlLabel1";
            this.guna2HtmlLabel1.Size = new System.Drawing.Size(109, 18);
            this.guna2HtmlLabel1.TabIndex = 1;
            this.guna2HtmlLabel1.Text = "- Or connect using -";
            // 
            // guna2HtmlLabel2
            // 
            this.guna2HtmlLabel2.AutoSize = false;
            this.guna2HtmlLabel2.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel2.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2HtmlLabel2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(62)))), ((int)(((byte)(62)))));
            this.guna2HtmlLabel2.Location = new System.Drawing.Point(520, 448);
            this.guna2HtmlLabel2.Margin = new System.Windows.Forms.Padding(2);
            this.guna2HtmlLabel2.Name = "guna2HtmlLabel2";
            this.guna2HtmlLabel2.Size = new System.Drawing.Size(170, 17);
            this.guna2HtmlLabel2.TabIndex = 1;
            this.guna2HtmlLabel2.Text = "Dont have an account? Sign Up";
            // 
            // guna2CircleButton1
            // 
            this.guna2CircleButton1.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(89)))), ((int)(((byte)(152)))));
            this.guna2CircleButton1.BorderThickness = 3;
            this.guna2CircleButton1.CheckedState.Parent = this.guna2CircleButton1;
            this.guna2CircleButton1.CustomImages.Parent = this.guna2CircleButton1;
            this.guna2CircleButton1.FillColor = System.Drawing.Color.Empty;
            this.guna2CircleButton1.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.guna2CircleButton1.ForeColor = System.Drawing.Color.White;
            this.guna2CircleButton1.HoverState.Parent = this.guna2CircleButton1;
            this.guna2CircleButton1.Image = ((System.Drawing.Image)(resources.GetObject("guna2CircleButton1.Image")));
            this.guna2CircleButton1.Location = new System.Drawing.Point(508, 367);
            this.guna2CircleButton1.Name = "guna2CircleButton1";
            this.guna2CircleButton1.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.guna2CircleButton1.ShadowDecoration.Parent = this.guna2CircleButton1;
            this.guna2CircleButton1.Size = new System.Drawing.Size(60, 60);
            this.guna2CircleButton1.TabIndex = 5;
            // 
            // guna2CircleButton2
            // 
            this.guna2CircleButton2.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(172)))), ((int)(((byte)(237)))));
            this.guna2CircleButton2.BorderThickness = 3;
            this.guna2CircleButton2.CheckedState.Parent = this.guna2CircleButton2;
            this.guna2CircleButton2.CustomImages.Parent = this.guna2CircleButton2;
            this.guna2CircleButton2.FillColor = System.Drawing.Color.Empty;
            this.guna2CircleButton2.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.guna2CircleButton2.ForeColor = System.Drawing.Color.White;
            this.guna2CircleButton2.HoverState.Parent = this.guna2CircleButton2;
            this.guna2CircleButton2.Image = ((System.Drawing.Image)(resources.GetObject("guna2CircleButton2.Image")));
            this.guna2CircleButton2.Location = new System.Drawing.Point(574, 367);
            this.guna2CircleButton2.Name = "guna2CircleButton2";
            this.guna2CircleButton2.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.guna2CircleButton2.ShadowDecoration.Parent = this.guna2CircleButton2;
            this.guna2CircleButton2.Size = new System.Drawing.Size(60, 60);
            this.guna2CircleButton2.TabIndex = 5;
            // 
            // guna2CircleButton3
            // 
            this.guna2CircleButton3.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(61)))), ((int)(((byte)(0)))));
            this.guna2CircleButton3.BorderThickness = 3;
            this.guna2CircleButton3.CheckedState.Parent = this.guna2CircleButton3;
            this.guna2CircleButton3.CustomImages.Parent = this.guna2CircleButton3;
            this.guna2CircleButton3.FillColor = System.Drawing.Color.Empty;
            this.guna2CircleButton3.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.guna2CircleButton3.ForeColor = System.Drawing.Color.White;
            this.guna2CircleButton3.HoverState.Parent = this.guna2CircleButton3;
            this.guna2CircleButton3.Image = ((System.Drawing.Image)(resources.GetObject("guna2CircleButton3.Image")));
            this.guna2CircleButton3.Location = new System.Drawing.Point(640, 367);
            this.guna2CircleButton3.Name = "guna2CircleButton3";
            this.guna2CircleButton3.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.guna2CircleButton3.ShadowDecoration.Parent = this.guna2CircleButton3;
            this.guna2CircleButton3.Size = new System.Drawing.Size(60, 60);
            this.guna2CircleButton3.TabIndex = 5;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(520, 229);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 6;
            this.button1.Text = "get";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(533, 93);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 7;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(862, 584);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.guna2CircleButton3);
            this.Controls.Add(this.guna2CircleButton2);
            this.Controls.Add(this.guna2CircleButton1);
            this.Controls.Add(this.loginbtn);
            this.Controls.Add(this.PasswordTB);
            this.Controls.Add(this.UsernameTB);
            this.Controls.Add(this.guna2HtmlLabel1);
            this.Controls.Add(this.guna2HtmlLabel2);
            this.Controls.Add(this.lb2);
            this.Controls.Add(this.Label1);
            this.Controls.Add(this.picbox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Login";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Log In";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.Login_Load);
            ((System.ComponentModel.ISupportInitialize)(this.picbox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI2.WinForms.Guna2PictureBox picbox1;
        private Guna.UI2.WinForms.Guna2HtmlLabel Label1;
        private Guna.UI2.WinForms.Guna2TextBox UsernameTB;
        private Guna.UI2.WinForms.Guna2TextBox PasswordTB;
        private Guna.UI2.WinForms.Guna2HtmlLabel lb2;
        private Guna.UI2.WinForms.Guna2GradientButton loginbtn;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel1;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel2;
        private Guna.UI2.WinForms.Guna2CircleButton guna2CircleButton1;
        private Guna.UI2.WinForms.Guna2CircleButton guna2CircleButton2;
        private Guna.UI2.WinForms.Guna2CircleButton guna2CircleButton3;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox textBox1;
    }
}

