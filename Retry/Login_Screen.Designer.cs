namespace Retry
{
    partial class Login_Screen
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login_Screen));
            this.label1 = new System.Windows.Forms.Label();
            this.Login_text = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.Password_text = new System.Windows.Forms.TextBox();
            this.Enter = new System.Windows.Forms.Button();
            this.incorrect_login = new System.Windows.Forms.Label();
            this.incorrect_pass = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(53, 58);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Login";
            // 
            // Login_text
            // 
            this.Login_text.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Login_text.Location = new System.Drawing.Point(153, 58);
            this.Login_text.Name = "Login_text";
            this.Login_text.Size = new System.Drawing.Size(135, 23);
            this.Login_text.TabIndex = 0;
            this.Login_text.Click += new System.EventHandler(this.Login_text_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(53, 84);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(69, 17);
            this.label2.TabIndex = 0;
            this.label2.Text = "Password";
            // 
            // Password_text
            // 
            this.Password_text.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Password_text.Location = new System.Drawing.Point(153, 84);
            this.Password_text.Name = "Password_text";
            this.Password_text.PasswordChar = '*';
            this.Password_text.Size = new System.Drawing.Size(135, 23);
            this.Password_text.TabIndex = 1;
            this.Password_text.Click += new System.EventHandler(this.Password_text_Click);
            // 
            // Enter
            // 
            this.Enter.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Enter.Location = new System.Drawing.Point(153, 136);
            this.Enter.Name = "Enter";
            this.Enter.Size = new System.Drawing.Size(135, 32);
            this.Enter.TabIndex = 2;
            this.Enter.Text = "Enter";
            this.Enter.UseVisualStyleBackColor = true;
            this.Enter.Click += new System.EventHandler(this.Enter_Click);
            // 
            // incorrect_login
            // 
            this.incorrect_login.AutoSize = true;
            this.incorrect_login.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.incorrect_login.ForeColor = System.Drawing.Color.Red;
            this.incorrect_login.Location = new System.Drawing.Point(313, 57);
            this.incorrect_login.Name = "incorrect_login";
            this.incorrect_login.Size = new System.Drawing.Size(106, 17);
            this.incorrect_login.TabIndex = 3;
            this.incorrect_login.Text = "* incorrect login";
            this.incorrect_login.Visible = false;
            // 
            // incorrect_pass
            // 
            this.incorrect_pass.AutoSize = true;
            this.incorrect_pass.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.incorrect_pass.ForeColor = System.Drawing.Color.Red;
            this.incorrect_pass.Location = new System.Drawing.Point(313, 84);
            this.incorrect_pass.Name = "incorrect_pass";
            this.incorrect_pass.Size = new System.Drawing.Size(136, 17);
            this.incorrect_pass.TabIndex = 3;
            this.incorrect_pass.Text = "* incorrect password";
            this.incorrect_pass.Visible = false;
            // 
            // button1
            // 
            this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button1.Image = ((System.Drawing.Image)(resources.GetObject("button1.Image")));
            this.button1.Location = new System.Drawing.Point(437, -5);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(27, 30);
            this.button1.TabIndex = 4;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Login_Screen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(464, 186);
            this.ControlBox = false;
            this.Controls.Add(this.button1);
            this.Controls.Add(this.incorrect_pass);
            this.Controls.Add(this.incorrect_login);
            this.Controls.Add(this.Enter);
            this.Controls.Add(this.Password_text);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Login_text);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.KeyPreview = true;
            this.Name = "Login_Screen";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login Screen";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Login_Screen_KeyDown);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox Login_text;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox Password_text;
        private System.Windows.Forms.Button Enter;
        private System.Windows.Forms.Label incorrect_login;
        private System.Windows.Forms.Label incorrect_pass;
        private System.Windows.Forms.Button button1;
    }
}