namespace WFClient.View
{
	partial class AuthenForm
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
			this.textBoxLogin = new System.Windows.Forms.TextBox();
			this.textBoxPassword = new System.Windows.Forms.TextBox();
			this.labelLogin = new System.Windows.Forms.Label();
			this.labelPassword = new System.Windows.Forms.Label();
			this.buttonAuth = new System.Windows.Forms.Button();
			this.textBoxResult = new System.Windows.Forms.TextBox();
			this.SuspendLayout();
			// 
			// textBoxLogin
			// 
			this.textBoxLogin.Location = new System.Drawing.Point(15, 35);
			this.textBoxLogin.Name = "textBoxLogin";
			this.textBoxLogin.Size = new System.Drawing.Size(100, 20);
			this.textBoxLogin.TabIndex = 0;
			// 
			// textBoxPassword
			// 
			this.textBoxPassword.Location = new System.Drawing.Point(144, 35);
			this.textBoxPassword.Name = "textBoxPassword";
			this.textBoxPassword.Size = new System.Drawing.Size(100, 20);
			this.textBoxPassword.TabIndex = 1;
			// 
			// labelLogin
			// 
			this.labelLogin.AutoSize = true;
			this.labelLogin.Location = new System.Drawing.Point(12, 9);
			this.labelLogin.Name = "labelLogin";
			this.labelLogin.Size = new System.Drawing.Size(35, 13);
			this.labelLogin.TabIndex = 2;
			this.labelLogin.Text = "label1";
			// 
			// labelPassword
			// 
			this.labelPassword.AutoSize = true;
			this.labelPassword.Location = new System.Drawing.Point(141, 9);
			this.labelPassword.Name = "labelPassword";
			this.labelPassword.Size = new System.Drawing.Size(35, 13);
			this.labelPassword.TabIndex = 3;
			this.labelPassword.Text = "label2";
			// 
			// buttonAuth
			// 
			this.buttonAuth.Location = new System.Drawing.Point(15, 72);
			this.buttonAuth.Name = "buttonAuth";
			this.buttonAuth.Size = new System.Drawing.Size(229, 23);
			this.buttonAuth.TabIndex = 4;
			this.buttonAuth.Text = "button1";
			this.buttonAuth.UseVisualStyleBackColor = true;
			this.buttonAuth.Click += new System.EventHandler(this.buttonAuth_Click);
			// 
			// textBoxResult
			// 
			this.textBoxResult.Location = new System.Drawing.Point(15, 106);
			this.textBoxResult.Name = "textBoxResult";
			this.textBoxResult.Size = new System.Drawing.Size(229, 20);
			this.textBoxResult.TabIndex = 5;
			this.textBoxResult.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			// 
			// AuthenForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(265, 138);
			this.Controls.Add(this.textBoxResult);
			this.Controls.Add(this.labelLogin);
			this.Controls.Add(this.labelPassword);
			this.Controls.Add(this.textBoxLogin);
			this.Controls.Add(this.textBoxPassword);
			this.Controls.Add(this.buttonAuth);
			this.Name = "AuthenForm";
			this.Text = "WFClient";
			this.Load += new System.EventHandler(this.AuthenForm_Load);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion
		private System.Windows.Forms.Label labelLogin;
		private System.Windows.Forms.Label labelPassword;
		public System.Windows.Forms.TextBox textBoxLogin;
		public System.Windows.Forms.TextBox textBoxPassword;
		public System.Windows.Forms.TextBox textBoxResult;
		public System.Windows.Forms.Button buttonAuth;
	}
}