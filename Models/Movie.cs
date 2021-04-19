using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Kinobar.Models
{
    public class Movie
    {

        public long Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public int Year { get; set; }
        public string Image { get; set; }
        public string Сollection { get; set; }
        public string Spent { get; set; }
        public double Rating { get; set; }

        public Country Country { get; set; }
        public List<Comment> Comments { get; set; }
    }
}
