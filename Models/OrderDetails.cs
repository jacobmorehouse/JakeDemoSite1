using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace JakeDemoSite1.Models
{

	[PrimaryKey(nameof(OrderID), nameof(ProductID))]
	public class OrderDetails
	{
		[ForeignKey("Orders")]
		public int OrderID { get; set; }
		[ForeignKey("Products")]
		public int ProductID { get; set; }
		public decimal UnitPrice { get; set; }
		public int Quantity { get; set; }
		public float Discount { get; set; }



	}
}
