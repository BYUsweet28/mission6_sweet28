﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Movies.Models
{
    public class MovieResponse
    {

        // Movie Response Model
        [Key]
        [Required]
        public int MovieId { get; set; }
        [Required]
        //Build Foreign Key Relationship
        public int CategoryID { get; set; }
        public Category Category { get; set; }
        [Required]
        public string Title { get; set; }
        [Required]
        public int Year { get; set; }
        [Required]
        public string Director { get; set; }
        [Required]
        public string Rating { get; set; }
        public bool Edited { get; set; }
        public string LentTo { get; set; }
        [MaxLength(25, ErrorMessage = "25 Characters Max")]
        public string Notes { get; set; }
    }
}
