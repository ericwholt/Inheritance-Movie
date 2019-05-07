using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance_Movie
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("MOVIE TEST");
            //List<string> Scenes = new List<string> { "Capture Leia", "Blow up deathstar", "Pizza the Hut" };
            //Movie m = new Movie("Space Balls", "Comedy", 120, Scenes);

            //Console.WriteLine("PRINT INFO");
            //m.PrintInfo();
            //Console.WriteLine("PLAY");
            //m.Play();
            //Console.WriteLine("PRINT SCENES");
            //m.PrintScenes();

            //Console.WriteLine("DVD TEST");
            //List<string> Scenes2 = new List<string> { "Cantina Scene", "Jeffereson Starship", "Bobba fett" };
            //DVD d = new DVD("Star Wars Holiday Special", "Hot Mess", 80, Scenes2);
            //Console.WriteLine("PLAY");
            //d.Play();
            //Console.WriteLine("PLAY WHOLE MOVIE");
            //d.PlayWholeMovie();
            //Console.WriteLine("PRINT SCENES");
            //d.PrintScenes();
            //Console.WriteLine("PRINT INFO");
            //d.PrintInfo();

            //Console.WriteLine("VHS TEST");
            //List<string> Scenes3 = new List<string> { "Cantina Scene", "Jeffereson Starship", "Bobba fett" };
            //VHS v = new VHS("Star Wars Holiday Special", "Hot Mess", 80, Scenes3);
            //Console.WriteLine("PLAY");
            //v.Play();
            //Console.WriteLine("PLAY AGAIN");
            //v.Play();
            //Console.WriteLine("REWIND");
            //v.Rewind();
            //Console.WriteLine("PLAY 3RD TIME");
            //v.Play();
            //Console.WriteLine("PLAY WHOLE MOVIE");
            //v.PlayWholeMovie();
            //Console.WriteLine("PRINT SCENES");
            //v.PrintScenes();
            //Console.WriteLine("PRINT INFO");
            //v.PrintInfo();

            Blockbuster b = new Blockbuster();
            b.CheckOut();
        }
    }
}
