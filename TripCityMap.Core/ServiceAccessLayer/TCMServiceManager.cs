using System;
using System.Collections.Generic;
using ServiceStack.ServiceClient.Web;
using TripCityMap.Core.Model;
using System.Threading.Tasks;
using ServiceStack.Text;

namespace TripCityMap.Core.Service
{
	public sealed class TCMServiceManager
	{
		private const string BASE_URL = @"http://service.tripcitymap.com/1.0";
		private static volatile TCMServiceManager instance;
		private static object syncRoot = new Object();
		private static JsonServiceClient _client;

		private TCMServiceManager () {}

		/// <summary>
		/// Get Singleton instance of TCM Service client
		/// </summary>
		/// <value><c>true</c> if this instance istance; otherwise, <c>false</c>.</value>
		public static TCMServiceManager Instance {
			get {
				if (instance == null) {
					lock (syncRoot) {
						if (instance == null) {
							instance = new TCMServiceManager ();
							_client = new JsonServiceClient (BASE_URL);
						}
					}
				}
				return instance;
			}
		}
		/// <summary>
		/// Gets the poi categories.
		/// </summary>
		/// <returns>The poi categories.</returns>
		/// <param name="queryParams">Query String parameters.</param>
		public IEnumerable<PoiCategory> GetPoiCategories(string queryParams)
		{
			_client.Headers.Add ("Accept-Language", "it");
			string responseJson = _client.Get<string>("/poicategory/?" + queryParams);
			return responseJson.FromJson<IEnumerable<PoiCategory>>();
		}
	}
}

