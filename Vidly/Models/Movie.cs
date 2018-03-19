﻿using System;
using System.ComponentModel.DataAnnotations;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Vidly.Models
{
    public class Movie
    {
        public int Id { get; set; }
        [Required]
        [MaxLength(255)]
        public string Name { get; set; }
        
        public Genre Genre { get; set; }
        [Required]
        public byte GenreId { get; set; }
        public DateTime AddDate { get; set; }
        public DateTime ReleaseDate { get; set; }
        public byte NumberInStock { get; set; }

    }
}