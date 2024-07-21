using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace esolution.data.Enitity
{
	public class Product
	{
		public int Id					{ get; set; }
		public decimal Price				{ get; set; }
		public decimal OriginalPrice		{ get; set; }
		public decimal Stock				{ get; set; }
		public decimal ViewCount			{ get; set; }
		public DateTime DataCreated			{ get; set; }
		public String SeoAlias				{ get; set; }

	}
}
