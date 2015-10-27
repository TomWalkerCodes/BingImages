using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using System.Net.Http;
using Newtonsoft.Json;

namespace BingImages.Shared
{
	public class BingHelper
	{

		public List<BingImage> Images { get; set;}
		public BingHelper ()
		{
			Images = new List<BingImage> ();
		}

		public async Task<bool> QueryBingImages(string query)
		{
			var bingQuery = string.Format ("https://api.datamarket.azure.com/Bing/Search/v1/Image?Query=%27{0}%27&Adult=%27Strict%27&ImageFilters=%27Size%3AMedium%27&$format=json", query);
			var handler = new HttpClientHandler {
				Credentials = new System.Net.NetworkCredential(key, key)
			};
			var client = new HttpClient (handler);
			var result = await client.GetStringAsync (bingQuery);

			if (string.IsNullOrWhiteSpace (result))
				return false;

			Images = JsonConvert.DeserializeObject<BingQuery> (result).Query.Results;

			return true;
		}















		private const string key = "ciIV3KGqkX4pXsJdEhXaobn5JEXUZPvyVH6hxm0N9p4";

	}
}

