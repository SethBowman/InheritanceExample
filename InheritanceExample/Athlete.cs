using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritanceExample
{
    public class Athlete : Coder
    {
        public string Sport { get; set; }

        public void PlayGame()
        {
            Console.WriteLine("I play sport ball");
        }
    }
}
