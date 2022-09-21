//---------------------------------------------------------------------------------
// <copyright file="AllInOnePrinter.cs" company="Universidad Católica del Uruguay">
// Copyright (c) Programación II. Derechos reservados.
// </copyright>
//---------------------------------------------------------------------------------
using System;
using System.IO;

/*
Aqui creo una clase FilePrinter que implementa la interfaz IPrinter y su metodo respectivo PrintTicket
de esta manera eliminamos la clase AllInOnePrinter, deshaciendonos de la necesidad de preguntar la destinacion
que le queremos otorgar a Recipe, esta clase FilePrinter va escribir el ticket de recipe en el archivo recipe.txt
*/

namespace Full_GRASP_And_SOLID.Library
{
    public class FilePrinter : IPrinter
    {
        public void PrintTicket(Recipe recipe)
        {
            File.WriteAllText("Recipe.txt", recipe.GetTextToPrint());
        }
    }
}