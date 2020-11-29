using CommunicationEntities;
using DBEntities;
using DbWorker;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleServer.Controllers
{
	public class CardsController
	{
		public static Response GetCardsByUserId(string parameters)
		{
			int userID = int.Parse(parameters);

			List<Card> cards = DbManager.GetInstance().TableCards.GetCardsByUserId(userID);

			return new Response()
			{
				Status = Response.StatusList.OK,
				Data = JsonConvert.SerializeObject(cards)
			};
		}

	}
}
