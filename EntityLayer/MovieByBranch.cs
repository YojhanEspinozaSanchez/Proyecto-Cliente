using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer
{
    public class MovieByBranch
    {
        public Branch Branch { get; set; }
        public Movie Movie { get; set; }
        public int Quantity { get; set; }

        public MovieByBranch() { }

        public MovieByBranch(Branch branch, Movie movie, int quantity)
        {
            Branch = branch;
            Movie = movie;
            Quantity = quantity;
        }
    }
}
