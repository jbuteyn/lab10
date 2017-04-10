using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab10
{
    class Movie
    {
        private string genre;
        private string title;

        public Movie(string title, string genre)
        {
            this.genre = genre;
            this.title = title;
        }
        
        public string getTitle()
        {

            return title;

        }
        public string getGenre()
        {

            return genre;

        }
        public void printTitle()
        {
            Console.WriteLine(title);

        }
    }
}
