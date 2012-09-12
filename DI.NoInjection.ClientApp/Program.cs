//-----------------------------------------------------------------------
// <copyright file="Program.cs" company="R. R. Donnelley &amp; Sons Company">
//     Copyright (c) R. R. Donnelley &amp; Sons Company. All rights reserved.
// </copyright>
//-----------------------------------------------------------------------
namespace DI.NoInjection.ClientApp
{
    using System;
    using DI.NoInjection.Dependents;

    /// <summary>
    /// Contains the program entry point.
    /// </summary>
    public static class Program
    {
        /// <summary>
        /// Defines the program entry point. 
        /// </summary>
        /// <param name="args">An array of <see cref="T:System.String"/> containing command line parameters.</param>
        private static void Main(string[] args)
        {
            Dependent test = new Dependent();
            Console.WriteLine(test.DoSomeATestWork());
            Console.ReadLine();
        }
    }
}
