namespace WFClient.View
{
	partial class FormMain
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
			this.label1 = new System.Windows.Forms.Label();
			this.labelCardsList = new System.Windows.Forms.Label();
			this.dataGridViewCardsList = new System.Windows.Forms.DataGridView();
			this.buttonGetCards = new System.Windows.Forms.Button();
			((System.ComponentModel.ISupportInitialize)(this.dataGridViewCardsList)).BeginInit();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(12, 9);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(35, 13);
			this.label1.TabIndex = 0;
			this.label1.Text = "label1";
			// 
			// labelCardsList
			// 
			this.labelCardsList.AutoSize = true;
			this.labelCardsList.Font = new System.Drawing.Font("Microsoft Tai Le", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.labelCardsList.Location = new System.Drawing.Point(203, 27);
			this.labelCardsList.Name = "labelCardsList";
			this.labelCardsList.Size = new System.Drawing.Size(100, 27);
			this.labelCardsList.TabIndex = 1;
			this.labelCardsList.Text = "CardsList";
			// 
			// dataGridViewCardsList
			// 
			this.dataGridViewCardsList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dataGridViewCardsList.Location = new System.Drawing.Point(15, 57);
			this.dataGridViewCardsList.Name = "dataGridViewCardsList";
			this.dataGridViewCardsList.Size = new System.Drawing.Size(511, 277);
			this.dataGridViewCardsList.TabIndex = 2;
			// 
			// buttonGetCards
			// 
			this.buttonGetCards.Location = new System.Drawing.Point(410, 28);
			this.buttonGetCards.Name = "buttonGetCards";
			this.buttonGetCards.Size = new System.Drawing.Size(116, 23);
			this.buttonGetCards.TabIndex = 3;
			this.buttonGetCards.Text = "Get cards";
			this.buttonGetCards.UseVisualStyleBackColor = true;
			this.buttonGetCards.Click += new System.EventHandler(this.buttonGetCards_Click);
			// 
			// FormMain
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(538, 346);
			this.Controls.Add(this.buttonGetCards);
			this.Controls.Add(this.dataGridViewCardsList);
			this.Controls.Add(this.labelCardsList);
			this.Controls.Add(this.label1);
			this.Name = "FormMain";
			this.Text = "FormMain";
			this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormMain_FormClosing);
			this.Load += new System.EventHandler(this.FormMain_Load);
			((System.ComponentModel.ISupportInitialize)(this.dataGridViewCardsList)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		public System.Windows.Forms.Label label1;
		public System.Windows.Forms.Label labelCardsList;
		public System.Windows.Forms.Button buttonGetCards;
		public System.Windows.Forms.DataGridView dataGridViewCardsList;
	}
}