using CommunicationEntities;
using DBEntities;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WFClient.Model;
using WFClient.View;

namespace WFClient.Controller
{
	public class ControllerFormMain
	{
		private FormMain form = null;
		private APIWorker API = null;
		private User user;

		public ControllerFormMain(FormMain form)
		{
			this.form = form;
			API = APIWorker.GetInstance();
			user = (User)DataStorage.Get("user");
		}

		public void UpdateLabel()
		{
			form.labelWelcome.Text = $"Welcome, {user.Name}!";
		}
		public void CloseUp()
		{
			Application.Exit();
		}
		public async Task CardsGetCardsByUserId()
		{
			//Task.Run(() => { System.Threading.Thread.Sleep(5000); });
			//form.buttonGetCards.Enabled = false;

			Response response = await API.CardsGetCardsByUserId(user.Id);

			if (response.Status == Response.StatusList.OK)
			{
				
				List<Card> cards = JsonConvert.DeserializeObject<List<Card>>(response.Data);
				form.dataGridViewCardsList.DataSource = null;
				form.dataGridViewCardsList.DataSource = cards;
			}
			else
			{
				MessageBox.Show($"Error {response.Data}");
			}
			//form.buttonGetCards.Enabled = true;
		}

	}
}
