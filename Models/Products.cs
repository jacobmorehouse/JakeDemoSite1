using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace JakeDemoSite1.Models
{
	public class Products
	{
		[Key]
		public int ProductID { get; set; }
		[Required]
		[DisplayName("Product Name")]
		public string ProductName { get; set; } = string.Empty;
		[ForeignKey("Supplier")]
		[DisplayName("Supplier")]
		public int SupplierID { get; set; }
		public Suppliers? Supplier { get; set; } 
		[ForeignKey("Category")]
		[DisplayName("Category")]
		public int CategoryID { get; set; }
		public Categories? Category { get; set; }
		[DisplayName("Quantity per Unit")]
		public string? QuantityPerUnit { get; set; }
		[DisplayName("Unit Price")]
		public decimal UnitPrice { get; set; }
		[DisplayName("Units in Stock")]
		public int UnitsInStock { get; set; }
		[DisplayName("Units on Order")]
		public int UnitsOnOrder { get; set; }
		[DisplayName("Reorder Level")]
		public int ReorderLevel { get; set; }
		public string? Discontinued { get; set; }
		public bool DiscontinuedBool {
			get {
				if (this.Discontinued == "1") { 
					return true;
				} else {
					return false;
				} ;
			}
		}
	}
}
