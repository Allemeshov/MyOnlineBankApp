
namespace BeautyForms
{
	partial class FormMain
	{
		/// <summary>
		/// Обязательная переменная конструктора.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Освободить все используемые ресурсы.
		/// </summary>
		/// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Код, автоматически созданный конструктором форм Windows

		/// <summary>
		/// Требуемый метод для поддержки конструктора — не изменяйте 
		/// содержимое этого метода с помощью редактора кода.
		/// </summary>
		private void InitializeComponent()
		{
			this.labelWelcome = new System.Windows.Forms.Label();
			this.labelCardsList = new System.Windows.Forms.Label();
			this.dataGridViewCardsList = new System.Windows.Forms.DataGridView();
			this.buttonShowHideMenu = new System.Windows.Forms.Button();
			this.tableLayoutPanelCardList = new System.Windows.Forms.TableLayoutPanel();
			this.panelCardList = new System.Windows.Forms.Panel();
			this.tableLayoutPanelFloor = new System.Windows.Forms.TableLayoutPanel();
			this.tableLayoutPanelSideMenu = new System.Windows.Forms.TableLayoutPanel();
			this.buttonTransfer = new System.Windows.Forms.Button();
			this.buttonCreateNewCard = new System.Windows.Forms.Button();
			this.buttonAddMoney = new System.Windows.Forms.Button();
			this.panelTransfer = new System.Windows.Forms.Panel();
			this.panelCreateNewCard = new System.Windows.Forms.Panel();
			this.panelAddMoney = new System.Windows.Forms.Panel();
			((System.ComponentModel.ISupportInitialize)(this.dataGridViewCardsList)).BeginInit();
			this.tableLayoutPanelCardList.SuspendLayout();
			this.panelCardList.SuspendLayout();
			this.tableLayoutPanelFloor.SuspendLayout();
			this.tableLayoutPanelSideMenu.SuspendLayout();
			this.panelTransfer.SuspendLayout();
			this.panelCreateNewCard.SuspendLayout();
			this.panelAddMoney.SuspendLayout();
			this.SuspendLayout();
			// 
			// labelWelcome
			// 
			this.labelWelcome.AutoSize = true;
			this.labelWelcome.Font = new System.Drawing.Font("Elephant", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.labelWelcome.Location = new System.Drawing.Point(4, 0);
			this.labelWelcome.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.labelWelcome.Name = "labelWelcome";
			this.labelWelcome.Padding = new System.Windows.Forms.Padding(0, 10, 0, 0);
			this.labelWelcome.Size = new System.Drawing.Size(173, 36);
			this.labelWelcome.TabIndex = 0;
			this.labelWelcome.Text = "Welcome, Alex";
			// 
			// labelCardsList
			// 
			this.labelCardsList.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.labelCardsList.AutoSize = true;
			this.labelCardsList.Font = new System.Drawing.Font("Elephant", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.labelCardsList.Location = new System.Drawing.Point(54, 30);
			this.labelCardsList.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.labelCardsList.Name = "labelCardsList";
			this.labelCardsList.Size = new System.Drawing.Size(167, 37);
			this.labelCardsList.TabIndex = 1;
			this.labelCardsList.Text = "CardsList";
			// 
			// dataGridViewCardsList
			// 
			this.dataGridViewCardsList.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.dataGridViewCardsList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.tableLayoutPanelCardList.SetColumnSpan(this.dataGridViewCardsList, 3);
			this.dataGridViewCardsList.Location = new System.Drawing.Point(4, 115);
			this.dataGridViewCardsList.Margin = new System.Windows.Forms.Padding(4);
			this.dataGridViewCardsList.Name = "dataGridViewCardsList";
			this.dataGridViewCardsList.RowHeadersWidth = 51;
			this.dataGridViewCardsList.Size = new System.Drawing.Size(841, 588);
			this.dataGridViewCardsList.TabIndex = 2;
			// 
			// buttonShowHideMenu
			// 
			this.buttonShowHideMenu.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.buttonShowHideMenu.FlatAppearance.BorderSize = 3;
			this.buttonShowHideMenu.Font = new System.Drawing.Font("Elephant", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.buttonShowHideMenu.Location = new System.Drawing.Point(744, 4);
			this.buttonShowHideMenu.Margin = new System.Windows.Forms.Padding(4);
			this.buttonShowHideMenu.Name = "buttonShowHideMenu";
			this.tableLayoutPanelCardList.SetRowSpan(this.buttonShowHideMenu, 2);
			this.buttonShowHideMenu.Size = new System.Drawing.Size(101, 103);
			this.buttonShowHideMenu.TabIndex = 3;
			this.buttonShowHideMenu.Text = "Show\r\nMenu";
			this.buttonShowHideMenu.UseVisualStyleBackColor = true;
			this.buttonShowHideMenu.Click += new System.EventHandler(this.buttonGetCards_Click);
			// 
			// tableLayoutPanelCardList
			// 
			this.tableLayoutPanelCardList.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.tableLayoutPanelCardList.ColumnCount = 3;
			this.tableLayoutPanelCardList.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
			this.tableLayoutPanelCardList.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33334F));
			this.tableLayoutPanelCardList.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33334F));
			this.tableLayoutPanelCardList.Controls.Add(this.dataGridViewCardsList, 0, 2);
			this.tableLayoutPanelCardList.Controls.Add(this.labelWelcome, 0, 0);
			this.tableLayoutPanelCardList.Controls.Add(this.panelCardList, 1, 0);
			this.tableLayoutPanelCardList.Controls.Add(this.buttonShowHideMenu, 2, 0);
			this.tableLayoutPanelCardList.Location = new System.Drawing.Point(3, 3);
			this.tableLayoutPanelCardList.Name = "tableLayoutPanelCardList";
			this.tableLayoutPanelCardList.RowCount = 3;
			this.tableLayoutPanelCardList.RowStyles.Add(new System.Windows.Forms.RowStyle());
			this.tableLayoutPanelCardList.RowStyles.Add(new System.Windows.Forms.RowStyle());
			this.tableLayoutPanelCardList.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
			this.tableLayoutPanelCardList.Size = new System.Drawing.Size(849, 707);
			this.tableLayoutPanelCardList.TabIndex = 4;
			this.tableLayoutPanelCardList.Paint += new System.Windows.Forms.PaintEventHandler(this.tableLayoutPanel1_Paint);
			// 
			// panelCardList
			// 
			this.panelCardList.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.panelCardList.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.panelCardList.Controls.Add(this.labelCardsList);
			this.panelCardList.Location = new System.Drawing.Point(285, 3);
			this.panelCardList.Name = "panelCardList";
			this.tableLayoutPanelCardList.SetRowSpan(this.panelCardList, 2);
			this.panelCardList.Size = new System.Drawing.Size(277, 105);
			this.panelCardList.TabIndex = 4;
			// 
			// tableLayoutPanelFloor
			// 
			this.tableLayoutPanelFloor.ColumnCount = 2;
			this.tableLayoutPanelFloor.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
			this.tableLayoutPanelFloor.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 120F));
			this.tableLayoutPanelFloor.Controls.Add(this.tableLayoutPanelCardList, 0, 0);
			this.tableLayoutPanelFloor.Controls.Add(this.tableLayoutPanelSideMenu, 1, 0);
			this.tableLayoutPanelFloor.Dock = System.Windows.Forms.DockStyle.Fill;
			this.tableLayoutPanelFloor.Location = new System.Drawing.Point(0, 0);
			this.tableLayoutPanelFloor.Name = "tableLayoutPanelFloor";
			this.tableLayoutPanelFloor.RowCount = 1;
			this.tableLayoutPanelFloor.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
			this.tableLayoutPanelFloor.Size = new System.Drawing.Size(1066, 713);
			this.tableLayoutPanelFloor.TabIndex = 5;
			// 
			// tableLayoutPanelSideMenu
			// 
			this.tableLayoutPanelSideMenu.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.tableLayoutPanelSideMenu.ColumnCount = 1;
			this.tableLayoutPanelSideMenu.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
			this.tableLayoutPanelSideMenu.Controls.Add(this.panelTransfer, 0, 0);
			this.tableLayoutPanelSideMenu.Controls.Add(this.panelCreateNewCard, 0, 1);
			this.tableLayoutPanelSideMenu.Controls.Add(this.panelAddMoney, 0, 2);
			this.tableLayoutPanelSideMenu.Location = new System.Drawing.Point(858, 3);
			this.tableLayoutPanelSideMenu.Name = "tableLayoutPanelSideMenu";
			this.tableLayoutPanelSideMenu.RowCount = 4;
			this.tableLayoutPanelSideMenu.RowStyles.Add(new System.Windows.Forms.RowStyle());
			this.tableLayoutPanelSideMenu.RowStyles.Add(new System.Windows.Forms.RowStyle());
			this.tableLayoutPanelSideMenu.RowStyles.Add(new System.Windows.Forms.RowStyle());
			this.tableLayoutPanelSideMenu.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
			this.tableLayoutPanelSideMenu.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
			this.tableLayoutPanelSideMenu.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
			this.tableLayoutPanelSideMenu.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
			this.tableLayoutPanelSideMenu.Size = new System.Drawing.Size(205, 707);
			this.tableLayoutPanelSideMenu.TabIndex = 5;
			// 
			// buttonTransfer
			// 
			this.buttonTransfer.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.buttonTransfer.Font = new System.Drawing.Font("Elephant", 10.2F, System.Drawing.FontStyle.Bold);
			this.buttonTransfer.Location = new System.Drawing.Point(4, 5);
			this.buttonTransfer.Name = "buttonTransfer";
			this.buttonTransfer.Size = new System.Drawing.Size(189, 127);
			this.buttonTransfer.TabIndex = 0;
			this.buttonTransfer.Text = "Transfer";
			this.buttonTransfer.UseVisualStyleBackColor = true;
			this.buttonTransfer.Click += new System.EventHandler(this.button1_Click);
			// 
			// buttonCreateNewCard
			// 
			this.buttonCreateNewCard.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.buttonCreateNewCard.Font = new System.Drawing.Font("Elephant", 10.2F, System.Drawing.FontStyle.Bold);
			this.buttonCreateNewCard.Location = new System.Drawing.Point(4, 4);
			this.buttonCreateNewCard.Name = "buttonCreateNewCard";
			this.buttonCreateNewCard.Size = new System.Drawing.Size(189, 128);
			this.buttonCreateNewCard.TabIndex = 1;
			this.buttonCreateNewCard.Text = "Create\r\nNew Card";
			this.buttonCreateNewCard.UseVisualStyleBackColor = true;
			// 
			// buttonAddMoney
			// 
			this.buttonAddMoney.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.buttonAddMoney.Font = new System.Drawing.Font("Elephant", 10.2F, System.Drawing.FontStyle.Bold);
			this.buttonAddMoney.Location = new System.Drawing.Point(4, 4);
			this.buttonAddMoney.Name = "buttonAddMoney";
			this.buttonAddMoney.Size = new System.Drawing.Size(189, 124);
			this.buttonAddMoney.TabIndex = 2;
			this.buttonAddMoney.Text = "Add\r\nMoney";
			this.buttonAddMoney.UseVisualStyleBackColor = true;
			// 
			// panelTransfer
			// 
			this.panelTransfer.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.panelTransfer.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.panelTransfer.Controls.Add(this.buttonTransfer);
			this.panelTransfer.Location = new System.Drawing.Point(3, 3);
			this.panelTransfer.Name = "panelTransfer";
			this.panelTransfer.Size = new System.Drawing.Size(199, 138);
			this.panelTransfer.TabIndex = 3;
			// 
			// panelCreateNewCard
			// 
			this.panelCreateNewCard.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.panelCreateNewCard.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.panelCreateNewCard.Controls.Add(this.buttonCreateNewCard);
			this.panelCreateNewCard.Location = new System.Drawing.Point(3, 147);
			this.panelCreateNewCard.Name = "panelCreateNewCard";
			this.panelCreateNewCard.Size = new System.Drawing.Size(199, 138);
			this.panelCreateNewCard.TabIndex = 4;
			// 
			// panelAddMoney
			// 
			this.panelAddMoney.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.panelAddMoney.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.panelAddMoney.Controls.Add(this.buttonAddMoney);
			this.panelAddMoney.Location = new System.Drawing.Point(3, 291);
			this.panelAddMoney.Name = "panelAddMoney";
			this.panelAddMoney.Size = new System.Drawing.Size(199, 138);
			this.panelAddMoney.TabIndex = 5;
			// 
			// FormMain
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(1066, 713);
			this.Controls.Add(this.tableLayoutPanelFloor);
			this.Margin = new System.Windows.Forms.Padding(4);
			this.Name = "FormMain";
			this.Text = "FormMain";
			((System.ComponentModel.ISupportInitialize)(this.dataGridViewCardsList)).EndInit();
			this.tableLayoutPanelCardList.ResumeLayout(false);
			this.tableLayoutPanelCardList.PerformLayout();
			this.panelCardList.ResumeLayout(false);
			this.panelCardList.PerformLayout();
			this.tableLayoutPanelFloor.ResumeLayout(false);
			this.tableLayoutPanelSideMenu.ResumeLayout(false);
			this.panelTransfer.ResumeLayout(false);
			this.panelCreateNewCard.ResumeLayout(false);
			this.panelAddMoney.ResumeLayout(false);
			this.ResumeLayout(false);

		}
		#endregion

		public System.Windows.Forms.Label labelWelcome;
		public System.Windows.Forms.Label labelCardsList;
		public System.Windows.Forms.Button buttonShowHideMenu;
		public System.Windows.Forms.DataGridView dataGridViewCardsList;
		private System.Windows.Forms.TableLayoutPanel tableLayoutPanelCardList;
		private System.Windows.Forms.Panel panelCardList;
		private System.Windows.Forms.TableLayoutPanel tableLayoutPanelFloor;
		private System.Windows.Forms.TableLayoutPanel tableLayoutPanelSideMenu;
		private System.Windows.Forms.Button buttonTransfer;
		private System.Windows.Forms.Button buttonCreateNewCard;
		private System.Windows.Forms.Button buttonAddMoney;
		private System.Windows.Forms.Panel panelAddMoney;
		private System.Windows.Forms.Panel panelCreateNewCard;
		private System.Windows.Forms.Panel panelTransfer;
	}
}

