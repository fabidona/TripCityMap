using System;
using System.Collections.Generic;

namespace TripCityMap.Core.Model
{
	public class Poi
	{
		public long Id { get; set; }
		public string Name { get; set; }
		public string Descrption { get; set; }
		public string Notes { get; set; }
		public string BigPictureUrl { get; set; }
		public string MidPictureUrl { get; set; }
		public string IcoPictureUrl { get; set; }
		public string PhoneNumber { get; set; }
		public string Email { get; set; }
		public string WebSite { get; set; }
	
		public bool IsPremium  { get; set; }
		public float DistanceToMe { get; set; }

		public Address Address { get; set;}
		public PoiCategory Category { get; set;}
		public IEnumerable<PhotoGallery> PhotoGalleries { get; set; }
		//public IEnumerable<ExtraFields> EctraFields { get; set; }

		public Poi ()
		{

		}
	}
}

