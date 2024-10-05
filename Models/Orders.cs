using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace JakeDemoSite1.Models
{
	public class Orders
	{
		[Key]
		public int OrderID { get; set; }
		public string? CustomerID { get; set; }
		public int EmployeeID { get; set; }
		[DisplayName("Order Date")]
		public DateTime OrderDate { get; set; }
		[DisplayName("Required Date")]
		public DateTime RequiredDate { get; set; }
		[DisplayName("Shipped Date")]
		public DateTime ShippedDate { get; set; }
		public int ShipVia { get; set; }
		public decimal Freight { get; set; }
		[DisplayName("Ship Name")]
		public string? ShipName { get; set; }
		[DisplayName("Ship Address")]
		public string? ShipAddress { get; set; }
		[DisplayName("Ship City")]
		public string? ShipCity { get; set; }
		[DisplayName("Ship Region")]
		public string? ShipRegion { get; set; }
		[DisplayName("Ship Postal Code")]
		public string? ShipPostalCode { get; set;}
		[DisplayName("Ship Country")]
		public string? ShipCountry { get; set; }
	}
}
