using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance_Movie
{
    class VHS : Movie
    {
        public int CurrentTime { get; set; }

        public VHS(string Title, string Category, int RunTime, List<string> Scenes) : base(Title, Category, RunTime, Scenes)
        {

        }

        public override void Play()
        {
            Console.WriteLine(Scenes[CurrentTime]);
            CurrentTime++;
        }
        public void Rewind()
        {
            CurrentTime = 0;
        }
        public override void PlayWholeMovie()
        {
            foreach (string scene in Scenes)
            {
                Console.WriteLine(scene);
            }
            Rewind();
        }
    }
}
