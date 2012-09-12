//-----------------------------------------------------------------------
// <copyright file="Dependent.cs" company="R. R. Donnelley &amp; Sons Company">
//     Copyright (c) R. R. Donnelley &amp; Sons Company. All rights reserved.
// </copyright>
//-----------------------------------------------------------------------
namespace DI.NoInjectionWithInterfaces.Dependents
{
    using System;
    using System.Linq;
    using DI.NoInjectionWithInterfaces.Dependencies;
    using DI.NoInjectionWithInterfaces.Interfaces;

    /// <summary>
    /// The dependent class
    /// </summary>
    public class Dependent
    {  
        #region Still No Dependency Injection - With Interfaces

        /// <summary>
        /// The method which uses all the dependencies with their common interface
        /// </summary>
        /// <returns>String output from all the dependency methods</returns>
        public string DoSomeATestWorkWithInterface()
        {
            IDependency1 test1 = new Dependency1();
            IDependency2 test2 = new Dependency2();
            IDependency3 test3 = new Dependency3();
            return string.Format("{0} - {1} - {2}", test1.Dependency1Method(), test2.Dependency2Method(), test3.Dependency3Method());
        } 

        #endregion
    }
}
