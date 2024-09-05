using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Numerics;
using System.Reflection.Metadata;

namespace JakeDemoSite1.Models
{
	public class Categories
	{
		[Key]
		public int CategoryID { get; set; }
		[Required]
		public string CategoryName { get; set; }
		public string? Description { get; set; }
		[NotMapped]
		public Blob? Picture { get; set; }
	}
}
