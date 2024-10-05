using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace JakeDemoSite1.Models
{
	public class Regions
	{
		[Key]
		public int RegionID { get; set; }
		[Required]
		[DisplayName("Region Description")]
		public string? RegionDescription { get; set; }
	}
}
