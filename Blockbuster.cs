using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance_Movie
{
    class Blockbuster
    {
        public List<Movie> Movies { get; set; }

        public Blockbuster()
        {

        }

        public void BuildRentalList(Movie movie)
        {
            this.Movies.Add(movie);
        }

        public void PrintMovies()
        {
            for (int i = 0; i < Movies.Count; i++)
            {
                Console.WriteLine($"{i}) {Movies[i].Title}");
            }
        }

        public void CheckOut()
        {
            //Print movies
            PrintMovies();
            //Prompt The User to select a movie Get user input
            int userInput = Helper.GetIntFromUser("Which movie would you like to check out: ");
            //Use inputed index to grab a movie from the list.
            Movie selectedMovie = Movies[userInput];
            //Play movie
            selectedMovie.Play();
        }
    }
}
