﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula_13_Polimorfismo
{
    internal class Mamiferos : Animal
    {
        public Mamiferos(string tipoAnimal) : base(tipoAnimal) { 
            
        }

        public override void caracteristicas()

        {
            Console.WriteLine("Bebe Leite");
        }
    }
}
