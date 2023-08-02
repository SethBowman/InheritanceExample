using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritanceExample
{
    public class Coder : Person
    {
        public string ProgrammingLanguage { get; set; }

        public void Code()
        {
            Console.WriteLine("I can code!");
        }
    }
}
