using System.ComponentModel.DataAnnotations;
using System.Numerics;
using System.Reflection.Metadata;

namespace JakeDemoSite1.Models
{
	
	public class CustomerDemographics
	{
		[Key]
		public string CustomerTypeID { get; set; }
		[Required]
		public string? CustomerDesc { get; set; }
	}
}
