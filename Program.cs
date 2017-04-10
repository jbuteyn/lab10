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
            Console.WriteLine("1 for Scifi. \n2 for Comedy\n3 for fantasy\n4 for childrens\n5 to see all movies");
            


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
            bool test = false;
            int input = 0;
            while(test == false)
            {
                test = int.TryParse(Console.ReadLine(), out input);
                
                if(test == false)
                {
                    Console.WriteLine("\nPlease enter a valid response");

                }

            }
            foreach (Movie movie in movieList)
            {
                
                if (input == 1 && movie.getGenre() == "Scifi")
                {
                    movie.printTitle();
                }
                if (input == 2 && movie.getGenre() == "Comedy")
                {
                    movie.printTitle();
                }
               if (input == 3 && movie.getGenre() == "Fantasy")
                {
                    movie.printTitle();
                }
               if(input == 4 && movie.getGenre() == "Childrens")
                {
                    movie.printTitle();
                }
               if(input == 5)
                {
                    movie.printTitle();
                }
            }
            

            
            
            


        }

        
    }
}
