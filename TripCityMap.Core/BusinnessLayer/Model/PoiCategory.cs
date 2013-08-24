using System;
using System.Collections.Generic;

namespace TripCityMap.Core.Model
{
	public class PoiCategory
	{
		public int Id { get; set; }
		public string Name { get; set; }
		public string Description { get; set; }
		public string IconUrl { get; set; }
		public string IconMarkerUrl { get; set; }
		public string IconRoundUrl { get; set; }
		public string Color { get; set; }
		public int TotalSubCategories  { get; set; }
		public int TotalPoi { get; set; }
		public int ParentCategoryId { get; set;}
		public PoiCategory ParentCategory { get; set;}
		public IEnumerable<PoiCategory> ChildrenCategories { get; set;}


		public PoiCategory ()
		{

		}
	}
}

