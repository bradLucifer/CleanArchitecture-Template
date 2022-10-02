﻿using CleanTemplate.Domain.Entities;
using Microsoft.AspNetCore.Identity;
using System;
using System.ComponentModel.DataAnnotations;

namespace CleanTemplate.Domain.Entities.Users
{
    public class User : IdentityUser<int>, IEntity<int>
    {
        public User()
        {
            IsActive = true;
        }

        public string FullName { get; set; }

        public int Age { get; set; }

        public GenderType Gender { get; set; }

        public bool IsActive { get; set; }

        public DateTimeOffset? LastLoginDate { get; set; }
        public string? RefreshToken { get; set; }
        public DateTime? RefreshTokenExpiryTime { get; set; }
    }

    public enum GenderType
    {
        [Display(Name = "مرد")]
        Male = 1,

        [Display(Name = "زن")]
        Female = 2
    }
}
