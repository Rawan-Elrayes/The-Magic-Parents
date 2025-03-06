namespace TheMagicParents.Models
{
    public class Goverment
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public virtual ICollection<City> Cities { get; set; }
    }
}
