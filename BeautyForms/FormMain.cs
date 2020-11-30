using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BeautyForms
{
	enum MenuStatusBar
	{
		Shown,
		Hidden
	}
	public partial class FormMain : Form
	{
		private MenuStatusBar menuStatus = MenuStatusBar.Hidden;
		private int initialWidth;
		public FormMain()
		{
			InitializeComponent();

			initialWidth = this.tableLayoutPanelCardList.Width + 19;
			this.Width = initialWidth;
		}
		//853
		private void buttonGetCards_Click(object sender, EventArgs e)
		{
			menuStatus = (MenuStatusBar)(((int)menuStatus + 1) % 2);

			this.Width = menuStatus == MenuStatusBar.Shown ? (int)Math.Round((double)(this.Width * 1.3)) : initialWidth;

			string title = "";

			switch (menuStatus)
			{
				case MenuStatusBar.Shown:
					title = "Hide\nMenu";
					break;
				case MenuStatusBar.Hidden:
					title = "Show\nMenu";
					break;
				default:
					break;
			}

			buttonShowHideMenu.Text = title;
		}

		private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
		{

		}

		private void button1_Click(object sender, EventArgs e)
		{
			new FormTransferController().Show();
		}
	}
}
