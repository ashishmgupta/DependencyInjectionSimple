//-----------------------------------------------------------------------
// <copyright file="Program.cs" company="R. R. Donnelley &amp; Sons Company">
//     Copyright (c) R. R. Donnelley &amp; Sons Company. All rights reserved.
// </copyright>
//-----------------------------------------------------------------------
namespace DI.UsingMocks.Moq.ClientApp
{
    using System;
    using DI.UsingMocks.Moq.Dependencies;
    using DI.UsingMocks.Moq.Dependents;

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
            Dependent dependent = new Dependent(new Dependency1(), new Dependency2(), new Dependency3());
            Console.WriteLine(dependent.DoSomeATestWorkWithMoq("<", ">"));
            Console.ReadLine();
        }
    }
}
