using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Kinobar.Models
{
    public class Comment
    {
        public long Id { get; set; }
        public string Text { get; set; }

        public DateTime CreatingDate { get; set; }
        public int MovieId { get; set; }
        public Movie Movie { get; set; }

    }
}
