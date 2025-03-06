using System.ComponentModel.DataAnnotations.Schema;

namespace TheMagicParents.Models
{
    public class City
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int GovermentId { get; set; }
        [ForeignKey(nameof(GovermentId))]
        public virtual Goverment Goverment { get; set; }
        public virtual ICollection<User> Users { get; set; }
    }
}
