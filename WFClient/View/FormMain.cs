using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WFClient.Controller;

namespace WFClient.View
{
	public partial class FormMain : Form
	{
		private ControllerFormMain controller;
		public FormMain()
		{
			InitializeComponent();
		}

		private void FormMain_Load(object sender, EventArgs e)
		{
			controller = new ControllerFormMain(this);
			controller.UpdateLabel();
		}

		private void FormMain_FormClosing(object sender, FormClosingEventArgs e)
		{
			controller.CloseUp();
		}

		private async void buttonGetCards_Click(object sender, EventArgs e)
		{
			await controller.CardsGetCardsByUserId();
		}
	}
}
