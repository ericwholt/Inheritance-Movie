using System;
using System.Collections.Generic;

namespace Inheritance_Movie
{
    class VHS : Movie
    {
        public int CurrentTime { get; set; }

        public VHS(string Title, string Category, int RunTime, List<string> Scenes)
            : base(Title, Category, RunTime, Scenes)
        {
            CurrentTime = 0;
        }

        public override void Play()
        {
            if (CurrentTime < Scenes.Count)
            {
                Console.WriteLine(Scenes[CurrentTime]);
                CurrentTime++;
            }
            else
            {
                Rewind();
            }
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
