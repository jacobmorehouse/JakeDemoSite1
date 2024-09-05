using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace JakeDemoSite1.Models
{
	public class Territories
	{
	[Key]
	public string TerritoryID { get; set; } = string.Empty;
	[Required]
	public string TerritoryDescription { get; set; } = string.Empty;
	[Required]
	public int RegionID { get; set; }
	}
}
