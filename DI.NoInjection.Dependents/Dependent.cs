//-----------------------------------------------------------------------
// <copyright file="Dependent.cs" company="R. R. Donnelley &amp; Sons Company">
//     Copyright (c) R. R. Donnelley &amp; Sons Company. All rights reserved.
// </copyright>
//-----------------------------------------------------------------------
namespace DI.NoInjection.Dependents
{
    using DI.NoInjection.Dependencies;

    /// <summary>
    /// The dependent class
    /// </summary>
    public class Dependent
    {
        #region No Dependency injection

        /// <summary>
        /// The method which uses all the dependencies
        /// </summary>
        /// <returns>String output from all the dependency methods</returns>
        public string DoSomeATestWork()
        {
            Dependency1 test1 = new Dependency1();
            Dependency2 test2 = new Dependency2();
            Dependency3 test3 = new Dependency3();
            return string.Format("{0} - {1} - {2}", test1.Dependency1Method(), test2.Dependency2Method(), test3.Dependency3Method());
        }
        
        #endregion
    }
}
