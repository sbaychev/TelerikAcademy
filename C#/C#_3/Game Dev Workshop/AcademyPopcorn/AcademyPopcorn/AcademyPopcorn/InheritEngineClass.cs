using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AcademyPopcorn
{
    // Task 4 Inherit the Engine class. Create a method ShootPlayerRacket. Leave it empty for now.
    public class InheritEngineClass : Engine
    {
        public InheritEngineClass(IRenderer renderer, IUserInterface userInterface)
        : base(renderer, userInterface)
        {
        }
        public void ShootPlayerRacket()
        {
        }
    }
}