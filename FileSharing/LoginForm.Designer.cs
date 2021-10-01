namespace FileSharing
{
    partial class LoginForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LoginForm));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.Login_Btn = new System.Windows.Forms.Button();
            this.UserName_Edit = new System.Windows.Forms.TextBox();
            this.Password_Edit = new System.Windows.Forms.TextBox();
            this.Password_ShowState = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Harlow Solid Italic", 26.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(134, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(107, 45);
            this.label1.TabIndex = 0;
            this.label1.Text = "Login";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Harlow Solid Italic", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(31, 138);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(91, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "User Name:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Harlow Solid Italic", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(32, 188);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(76, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "Password:";
            // 
            // Login_Btn
            // 
            this.Login_Btn.Location = new System.Drawing.Point(238, 375);
            this.Login_Btn.Name = "Login_Btn";
            this.Login_Btn.Size = new System.Drawing.Size(75, 23);
            this.Login_Btn.TabIndex = 3;
            this.Login_Btn.Text = "OK";
            this.Login_Btn.UseVisualStyleBackColor = true;
            this.Login_Btn.Click += new System.EventHandler(this.Login_Btn_Click);
            // 
            // UserName_Edit
            // 
            this.UserName_Edit.Location = new System.Drawing.Point(129, 138);
            this.UserName_Edit.Name = "UserName_Edit";
            this.UserName_Edit.Size = new System.Drawing.Size(184, 20);
            this.UserName_Edit.TabIndex = 4;
            // 
            // Password_Edit
            // 
            this.Password_Edit.Location = new System.Drawing.Point(128, 188);
            this.Password_Edit.Name = "Password_Edit";
            this.Password_Edit.PasswordChar = '*';
            this.Password_Edit.Size = new System.Drawing.Size(185, 20);
            this.Password_Edit.TabIndex = 5;
            // 
            // Password_ShowState
            // 
            this.Password_ShowState.AutoSize = true;
            this.Password_ShowState.Location = new System.Drawing.Point(128, 233);
            this.Password_ShowState.Name = "Password_ShowState";
            this.Password_ShowState.Size = new System.Drawing.Size(102, 17);
            this.Password_ShowState.TabIndex = 6;
            this.Password_ShowState.Text = "Show Password";
            this.Password_ShowState.UseVisualStyleBackColor = true;
            this.Password_ShowState.CheckedChanged += new System.EventHandler(this.CheckBox1_CheckedChanged);
            // 
            // LoginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(369, 442);
            this.Controls.Add(this.Password_ShowState);
            this.Controls.Add(this.Password_Edit);
            this.Controls.Add(this.UserName_Edit);
            this.Controls.Add(this.Login_Btn);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "LoginForm";
            this.Text = "LoginForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button Login_Btn;
        private System.Windows.Forms.TextBox UserName_Edit;
        private System.Windows.Forms.TextBox Password_Edit;
        private System.Windows.Forms.CheckBox Password_ShowState;
    }
}