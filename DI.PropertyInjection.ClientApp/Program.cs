//-----------------------------------------------------------------------
// <copyright file="Program.cs" company="R. R. Donnelley &amp; Sons Company">
//     Copyright (c) R. R. Donnelley &amp; Sons Company. All rights reserved.
// </copyright>
//-----------------------------------------------------------------------
namespace DI.PropertyInjection.ClientApp
{
    using DI.PropertyInjection.Dependencies;
    using DI.PropertyInjection.Dependents;

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
            test.IDependency1 = new Dependency1();
            test.IDependency2 = new Dependency2();
            test.IDependency3 = new Dependency3();
            test.DoSomeATestWorkWithPropertyInjection();
        }
    }
}
