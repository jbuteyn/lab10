using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab10
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Movie> movieList = new List<Movie>();
            Console.WriteLine("enter a movie genre to see titles");
            Console.WriteLine("enter 1 for Scifi. enter 2 for Comedy. enter 3 for fantasy. enter 4 for childrens. enter 5 to see all movies");
            


            movieList.Add(new Movie("Star Wars", "Scifi"));
            movieList.Add(new Movie("The Hobbit", "Fantasy"));
            movieList.Add(new Movie("The Hangover", "Comedy"));
            movieList.Add(new Movie("Finding Nemo", "Childrens"));
            movieList.Add(new Movie("Star Trek", "Scifi"));
            movieList.Add(new Movie("Superbad", "Comedy"));
            movieList.Add(new Movie("Toy Story", "Childrens"));
            movieList.Add(new Movie("Lord of the Rings", "Fantasy"));
            movieList.Add(new Movie("The Martian", "Scifi"));
            movieList.Add(new Movie("Aladin", "Childrens"));
            

            string input =Console.ReadLine();
            
            foreach (Movie movie in movieList)
            {
                
                if (input == "1" && movie.getGenre() == "Scifi")
                {
                    movie.printTitle();
                }
                if (input == "2" && movie.getGenre() == "Comedy")
                {
                    movie.printTitle();
                }
               if (input == "3" && movie.getGenre() == "Fantasy")
                {
                    movie.printTitle();
                }
               if(input =="4" && movie.getGenre() == "Childrens")
                {
                    movie.printTitle();
                }
               if(input == "5")
                {
                    movie.printTitle();
                }
            }
            

            
            
            


        }

        
    }
}
