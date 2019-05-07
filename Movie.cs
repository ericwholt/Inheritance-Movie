using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance_Movie
{
    class Movie
    {

        //A property for Title that’s a string
        public string Title { get; set; }
        //A property for Category that’s a string
        public string Category { get; set; }
        //An int property for RunTime(in minutes)
        public int RunTime { get; set; }
        //A list of strings called Scenes
        public List<string> Scenes { get; set; }
        //A virtual method called PrintInfo that prints all properties in the class to the console.

        public Movie(string Title, string Category, int RunTime, List<string> Scenes)
        {
            this.Title = Title;
            this.Category = Category;
            this.RunTime = RunTime;
            this.Scenes = Scenes;
        }

        public virtual void PrintInfo()
        {
            Console.WriteLine("Movie info: ");
            Console.WriteLine(Title);
            Console.WriteLine(Category);
            Console.WriteLine(RunTime);
            PrintScenes();
        }
        //A method called PrintScenes() that prints all the scenes in the list along with their index
        public void PrintScenes()
        {
            for (int i = 0; i < Scenes.Count; i++)
            {
                Console.WriteLine($"Scene {i}: {Scenes[i]}");
            }
        }

        public virtual void Play()
        {
            Console.WriteLine("The play method onlny works on physical media");
        }

        public virtual void PlayWholeMovie()
        {
            PrintScenes();
        }

        public override string ToString()
        {
            return Title;
        }
    }
}
