using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPExercise
{
    internal class clsInsan
    {
        public clsInsan(string name, string surname)
        {
            Name = name;
            Surname = surname;

        }

        public string Name { get; set; }
        public string Surname { get; set; } 
        public int Boy { get; set; } = 165;
        public int Kilo { get; set; } = 55;
        public int Yas { get; set; } = 27;


        public void Tanis()=>Console.WriteLine("Ben {0} {1} ... Boyum {2} cm, Kilom {3} kg, Yaşım {4} 'dir", Name, Surname, Boy, Kilo, Yas);

    }
}
