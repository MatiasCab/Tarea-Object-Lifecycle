//--------------------------------------------------------------------------------
// <copyright file="Program.cs" company="Universidad Católica del Uruguay">
//     Copyright (c) Programación II. Derechos reservados.
// </copyright>
//--------------------------------------------------------------------------------

using System;
using ClassLibrary;

namespace ConsoleApplication
{
    /// <summary>
    /// Programa de consola de demostración.
    /// </summary>
    public static class Program
    {
        /// <summary>
        /// Punto de entrada al programa principal.
        /// </summary>
        public static void Main()
        {
            Train train = new Train("0");
            for (var instancias=1; instancias<100; instancias++)
            {
            train = new Train(Convert.ToString(instancias));
            }
            Console.WriteLine(Train.Count);
            Train t1=new Train("Last Train London");
            Train t2=new Train("Last Train London");
            Train t3=new Train("Runaway Train");
            Console.WriteLine(Convert.ToString(t1==t2));
            Console.WriteLine(Convert.ToString(t2==t3) );
        }

    }
}