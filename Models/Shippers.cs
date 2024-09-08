using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace JakeDemoSite1.Models
{
	public class Shippers
	{
		[Key]
		public int ShipperID { get; set; }
		[Required]
        [DisplayName("Company Name")]
        public string? CompanyName { get; set; }
		public string? Phone { get; set; }
	}
}
