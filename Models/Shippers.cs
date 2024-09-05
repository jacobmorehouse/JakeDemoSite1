using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace JakeDemoSite1.Models
{
	public class Shippers
	{
		[Key]
		public int ShipperID { get; set; }
		[Required]
		public string CompanyName { get; set; } = string.Empty;
		public string? Phone { get; set; }
	}
}
