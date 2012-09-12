//-----------------------------------------------------------------------
// <copyright file="Program.cs" company="R. R. Donnelley &amp; Sons Company">
//     Copyright (c) R. R. Donnelley &amp; Sons Company. All rights reserved.
// </copyright>
//-----------------------------------------------------------------------
namespace DI.NoInjectionWithInterfaces.ClientApp
{
    using System;
    using System.Linq;
    using DI.NoInjectionWithInterfaces.Dependents;

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
            Console.WriteLine(test.DoSomeATestWorkWithInterface());
            Console.ReadLine();
        }
    }
}
