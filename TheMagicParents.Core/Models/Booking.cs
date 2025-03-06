using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using TheMagicParents.Enums;

namespace TheMagicParents.Models
{
	public class Booking
	{
		[Key]
		public int BookingID { get; set; }
		public int ClientID { get; set; }
		public int ServiceProviderID { get; set; }
		[Required]
		public DateTime BookingTime { get; set; }
		[Required]
		public decimal TotalPrice { get; set; }
		public BookingStatus Status { get; set; } = BookingStatus.pending;
		public string Location { get; set; }
		public int CityID { get; set; }

		// Navigation properties
		[ForeignKey("ClientID")]
		public virtual Client Client { get; set; }
		[ForeignKey("ServiceProviderID")]
		public virtual ServiceProvider ServiceProvider { get; set; }
		[ForeignKey("CityID")]
		public virtual City City { get; set; }

		//1:1 relations
		public virtual Payment Payment { get; set; }
		public virtual Review Review { get; set; }




	}
}
