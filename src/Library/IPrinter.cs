//---------------------------------------------------------------------------------
// <copyright file="AllInOnePrinter.cs" company="Universidad Católica del Uruguay">
// Copyright (c) Programación II. Derechos reservados.
// </copyright>
//---------------------------------------------------------------------------------
using System;
using System.IO;


//Aqui estoy creando una interfaz IPrinter que se encargará de imprimir un ticket de tipo recipe.
namespace Full_GRASP_And_SOLID.Library
{
    public interface IPrinter
    {
        void PrintTicket(Recipe recipe);
    }
}
