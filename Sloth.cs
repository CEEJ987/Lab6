using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab06
{
    internal class Sloth : Reptile
    {
        public override void Breathe()
        {
            Console.WriteLine("I breathe to relax");
        }
        public override void Sound()
        {
            Console.WriteLine("I scream ");
        }

        public override void Move()
        {
            Console.WriteLine("Moving forward slowly but steady.");
        }


    }
}
