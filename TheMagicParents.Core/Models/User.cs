using Microsoft.AspNetCore.Identity;
using TheMagicParents.Enums;

namespace TheMagicParents.Models
{
    public class User:IdentityUser
    {
        public string PersonalPhoto { get; set; }
        public string IdCardFrontPhoto { get; set; }
        public string IdCardBackPhoto { get;set; }
        public StateType AccountState { get; set; }
        public int CityId { get; set; }
        public City City { get; set; }
    }
}
