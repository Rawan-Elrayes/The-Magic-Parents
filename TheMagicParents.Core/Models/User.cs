﻿using Microsoft.AspNetCore.Identity;
using System.ComponentModel.DataAnnotations.Schema;
using TheMagicParents.Enums;

namespace TheMagicParents.Models
{
    public class User:IdentityUser
    {
        public string PersonalPhoto { get; set; }
        public string IdCardFrontPhoto { get; set; }
        public string IdCardBackPhoto { get;set; }
        public StateType AccountState { get; set; }
        public int NumberOfSuccessfulServices { get; set; } = 0;
        public int NumberOfCanceledServices { get; set; } = 0;
        public int NumberOfSupports { get; set; } = 0;

        public int CityId { get; set; }
		[ForeignKey(nameof(CityId))]
		public virtual City City { get; set; }
    }
}
