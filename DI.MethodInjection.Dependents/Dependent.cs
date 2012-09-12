//-----------------------------------------------------------------------
// <copyright file="Dependent.cs" company="R. R. Donnelley &amp; Sons Company">
//     Copyright (c) R. R. Donnelley &amp; Sons Company. All rights reserved.
// </copyright>
//-----------------------------------------------------------------------
namespace DI.MethodInjection.Dependents
{
    using System;
    using DI.MethodInjection.Interfaces;
    
    /// <summary>
    /// The dependent class
    /// </summary>
    public class Dependent
    {
        #region Properties

        /// <summary>
        /// Gets or sets the IDependency1.
        /// </summary>
        /// <value>The IDependency1.</value>
        public IDependency1 IDependency1
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or sets the IDependency2.
        /// </summary>
        /// <value>The IDependency2.</value>
        public IDependency2 IDependency2
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or sets the IDependency3.
        /// </summary>
        /// <value>The IDependency3.</value>
        public IDependency3 IDependency3
        {
            get;
            set;
        }

        #endregion

        #region Method Injection
        /// <summary>
        /// The method which uses all the dependencies with their common interface
        /// </summary>
        /// <param name="test1">Object of type IDependency1</param>
        /// <param name="test2">Object of type IDependency2</param>
        /// <param name="test3">Object of type IDependency3</param>
        /// <returns>String output from all the dependency methods</returns>
        public string DoSomeATestWorkWithMethodInjection(IDependency1 test1, IDependency2 test2, IDependency3 test3)
        {           
            return string.Format("{0} - {1} - {2}", test1.Dependency1Method(), test2.Dependency2Method(), test3.Dependency3Method());
        }

        #endregion
    }
}
