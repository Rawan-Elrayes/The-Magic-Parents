using System.ComponentModel.DataAnnotations.Schema;

namespace TheMagicParents.Models
{
	public class transaction
	{
		public int ClientId { get; set; }
		public int ServiceProviderId { get; set; }
		public int NumberOfSuccessfulServices { get; set; }
		public int NumberOfCanceledServices { get; set; }
		public int NumberOfSupports { get; set; }

		[ForeignKey(nameof(ClientId))]
		public virtual Client Client { get; set; }

		[ForeignKey(nameof(ServiceProviderId))]
		public virtual ServiceProvider ServiceProvider { get; set; }	

	}
}
