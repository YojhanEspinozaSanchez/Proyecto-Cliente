using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer
{
    public class Movie
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public Category Category { get; set; }
        public int ReleaseYear { get; set; }
        public string Language { get; set; }

        public Movie() { }

        public Movie(int id, string name, Category category, int releaseYear, string language)
        {
            Id = id;
            Name = name;
            Category = category;
            ReleaseYear = releaseYear;
            Language = language;
        }

    }
}
