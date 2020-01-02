using System;
using System.Collections.Generic;

namespace Gravity
{
	public class Log
	{
		string allResults;
		string lastResult;

		public List<User> users = new List<User>();

		public Log()
		{
		}

		public string NewResult(User user, Planet planet)
		{
			UserResult res = new UserResult(user);
			res.Result = String.Format("Użytkownik {0} na planecie {1} ma {2:F2} lat i waży {3:F2}kg.\n", user.UserName, planet.PlanetName, user.AgeOnPlanet(planet), user.WeightOnPlanet(planet));
			user.Results.Add(res);
			lastResult = res.Result;
			return lastResult;
		}

		public string ShowAllResults()
		{
			string allLogResults = "";
			foreach (User user in users)
			{
				allLogResults += ShowUserResults(user);
			}
			this.allResults = allLogResults;
			return allLogResults;
		}

		public string ClearAllResults()
		{
			foreach (User user in users)
			{
				user.Results.Clear();
			}
			users.Clear();
			return this.allResults = "";
		}

		public string ShowUserResults(User user)
		{
			string userLogResults = "";
			foreach (UserResult res in user.Results)
			{
				userLogResults += res.Result + "\n";
			}
			return userLogResults;
		}
	}
}
