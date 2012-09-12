//-----------------------------------------------------------------------
// <copyright file="Program.cs" company="R. R. Donnelley &amp; Sons Company">
//     Copyright (c) R. R. Donnelley &amp; Sons Company. All rights reserved.
// </copyright>
//-----------------------------------------------------------------------
namespace DI.MethodInjection.ClientApp
{
    using DI.MethodInjection.Dependencies;
    using DI.MethodInjection.Dependents;
    using DI.MethodInjection.Interfaces;

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
            Dependent dependent = new Dependent();
            IDependency1 test1 = new Dependency1();
            IDependency2 test2 = new Dependency2();
            IDependency3 test3 = new Dependency3();
            dependent.DoSomeATestWorkWithMethodInjection(test1, test2, test3);
        }
    }
}
