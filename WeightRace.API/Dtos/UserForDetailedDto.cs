using System;
using System.Collections.Generic;
using WeightRace.API.Models;

namespace WeightRace.API.Dtos
{
    public class UserForDetailedDto
    {
        public int Id { get; set; }
        public string Username { get; set; }
        public string Gender { get; set; }
        public int Age { get; set; }
        public string KnownAs { get; set; }
        public DateTime Created { get; set; }
        public DateTime LastActive { get; set; }
        public string Introduction { get; set; }
        public string LookingFor { get; set; }
        public string Interests { get; set; }
        public String City { get; set; }
        public string Country { get; set; }
        public string PhotoUrl { get; set; }
        public ICollection<PhotosForDetailedDto> Photos  { get; set; }
        public ICollection<WeightForReturnDto> Weights { get; set; }
        public ICollection<UserForDetailedDto> Friends { get; set; }
    }
} 