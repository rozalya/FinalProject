﻿using GetFit.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace GetFit.Models
{
    public class Post
    {
        public Post()
        {
            this.Date = DateTime.Now;
        }
        [Key]
        public int Id { get; set; }

        [Required]
        [StringLenght(250)]
        public string Title { get; set; }

        [Required]
        [DataType(DataType.MultilineText)]
        public string Body { get; set; }

        [Required]
        public DateTime Date { get; set; }

        public string Author_Id { get; set; }

        [ForeignKey("Author_Id")]
        public ApplicationUser Author { get; set; }

        public int? Comments { get; set; }


    }
}