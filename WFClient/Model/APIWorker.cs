using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using ClientLibrary;
using CommunicationEntities;
using System.Threading;

namespace WFClient.Model
{
	public class APIWorker
	{
		private static APIWorker instance = null;
		private Client client = null;
		private string APIKey;
		public static APIWorker GetInstance()
		{
			if (instance == null)
			{
				instance = new APIWorker();
			}
			return instance;
		}
		public APIWorker()
		{
			client = new Client();
			APIKey = "228papichNNN1337";
		}

		public Task<Response> UsersGetUserByLoginPassword(string login, string password)
		{
			Dictionary<string, string> userParams = new Dictionary<string, string>();
			userParams["login"] = login;
			userParams["password"] = password;

			Request request = new Request()
			{
				Command = "Users.GetUserByLoginPassword",
				Parameters = JsonConvert.SerializeObject(userParams),
				APIKey = APIKey
			};

			return client.RetrieveServerResponseAsync(request);
		}

		public Task<Response> CardsGetCardsByUserId(int userID)
		{

			Request request = new Request()
			{
				Command = "Cards.GetCardsByUserId",
				Parameters = userID.ToString(),
				APIKey = APIKey
			};

			return client.RetrieveServerResponseAsync(request);
		}

	}
}
