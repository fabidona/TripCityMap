using System;
using System.Collections.Generic;

namespace TripCityMap.Core.Model
{
	public class Photo
	{
		public int Id { get; set; }
		public string BigPictureUrl { get; set; }
		public string MidPictureUrl { get; set; }
		public string IcoPictureUrl { get; set; }
		public int Ordinal { get; set; }

		public Photo ()
		{
		}
	}
}

