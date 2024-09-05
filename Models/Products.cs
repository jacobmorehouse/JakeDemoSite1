using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace JakeDemoSite1.Models
{
	public class Products
	{
		[Key]
		public int ProductID { get; set; }
		[Required]
		public string ProductName { get; set; } = string.Empty;
		[ForeignKey("Supplier")]
		public int SupplierID { get; set; }
		public Suppliers? Supplier { get; set; } 
		[ForeignKey("Category")]
		public int CategoryID { get; set; }
		public Categories? Category { get; set; }
		public string? QuantityPerUnit { get; set; }
		public decimal UnitPrice { get; set; }
		public int UnitsInStock { get; set; }
		public int UnitsOnOrder { get; set; }
		public int ReorderLevel { get; set; }
		public string? Discontinued { get; set; }
	}
}
