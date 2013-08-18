using System;
using System.Collections.Generic;

namespace TripCityMap.Core.Model
{
	public class Address
	{
		public int Id { get; set; }
		public string CountryName { get; set; }
		public string CityName { get; set; }
		public string ProvinceName { get; set; }
		public string RegionName { get; set; }
		public string AddressName { get; set; }
		public string CivicNumber { get; set; }
		public string Zip { get; set; }
		public string ProvinceAbbreviation { get; set; }

		public int CountryId { get; set; }
		public int RegionId { get; set; }
		public int ProvinceId { get; set; }
		public int CityId { get; set; }

		public double Latitude { get; set; }
		public double Longitude { get; set; }

		public Address ()
		{

		}
	}
}

