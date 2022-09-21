//---------------------------------------------------------------------------------
// <copyright file="AllInOnePrinter.cs" company="Universidad Católica del Uruguay">
// Copyright (c) Programación II. Derechos reservados.
// </copyright>
//---------------------------------------------------------------------------------
using System;
using System.IO;

/*
Aqui creo una clase ConsolePrinter que implementa la interfaz IPrinter y su metodo respectivo PrintTicket
de esta manera eliminamos la clase AllInOnePrinter, deshaciendonos de la necesidad de preguntar la destinacion
que le queremos otorgar a Recipe, esta clase escribira el ticket de recipe directamente en la consola.
*/

namespace Full_GRASP_And_SOLID.Library
{
    public class ConsolePrinter : IPrinter
    {
        public void PrintTicket(Recipe recipe)
        {
            Console.WriteLine($"{recipe.GetTextToPrint()}");
        }
    }
}