using EasyTickets.Data;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace EasyTickets.Models
{
    public class Movie
    {

        [Key]

        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }

        public double Price { get; set; }

        public string ImageURL { get; set; }

        public string StartDate { get; set; }

        public string EndDate { get; set; }

        public MovieCatagory MovieCatagory { get; set; }
    }   
}
