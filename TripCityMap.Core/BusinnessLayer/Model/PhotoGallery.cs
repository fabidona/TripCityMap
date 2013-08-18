using System;
using System.Collections.Generic;

namespace TripCityMap.Core.Model
{
	public class PhotoGallery
	{
		public int Id { get; set; }
		public string Name { get; set; }
		public bool IsPrincipal { get; set; }

		public IEnumerable<Photo> Photos { get; set; }

		public PhotoGallery ()
		{
		}
	}
}

