﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio
{
    public abstract class Auto:Vehiculo
    {
        protected string _patente;

        public Auto(double precio, string patente)
            : base(precio)
        {
            this._patente = patente;
        }

        public void MostrarPatente()
        {
            Console.WriteLine("Patente: " + this._patente);
        }
    }
}
