using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance_Movie
{
    class Blockbuster
    {
        public List<Movie> Movies = new List<Movie>();

        public Blockbuster()
        {
            List<string> Dvd1_Scenes = new List<string> { "Scene 1", "Scene 2", "Scene 3", "Scene 4", "Scene 5", "Scene 6" };
            DVD dvd1 = new DVD("dvd1", "Action", 80, Dvd1_Scenes);
            List<string> Dvd2_Scenes = new List<string> { "Scene 1", "Scene 2", "Scene 3", "Scene 4", "Scene 5", "Scene 6" };
            DVD dvd2 = new DVD("dvd2", "Drama", 80, Dvd2_Scenes);
            List<string> Dvd3_Scenes = new List<string> { "Scene 1", "Scene 2", "Scene 3", "Scene 4", "Scene 5", "Scene 6" };
            DVD dvd3 = new DVD("dvd3", "Suspense", 80, Dvd3_Scenes);
            List<string> Vhs1_Scenes = new List<string> { "Scene 1", "Scene 2", "Scene 3", "Scene 4", "Scene 5", "Scene 6" };
            VHS Vhs1 = new VHS("vhs1", "Action", 80, Vhs1_Scenes);
            List<string> Vhs2_Scenes = new List<string> { "Scene 1", "Scene 2", "Scene 3", "Scene 4", "Scene 5", "Scene 6" };
            VHS Vhs2 = new VHS("vhs2", "Action", 80, Vhs2_Scenes);
            List<string> Vhs3_Scenes = new List<string> { "Scene 1", "Scene 2", "Scene 3", "Scene 4", "Scene 5", "Scene 6" };
            VHS Vhs3 = new VHS("vhs3", "Action", 80, Vhs3_Scenes);
            BuildRentalList(dvd1);
            BuildRentalList(dvd2);
            BuildRentalList(dvd3);
            BuildRentalList(Vhs1);
            BuildRentalList(Vhs2);
            BuildRentalList(Vhs3);
        }

        public void BuildRentalList(Movie movie)
        {
            Movies.Add(movie);
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
            selectedMovie.PrintInfo();
        }
    }
}
