//-----------------------------------------------------------------------
// <copyright file="Dependent.cs" company="R. R. Donnelley &amp; Sons Company">
//     Copyright (c) R. R. Donnelley &amp; Sons Company. All rights reserved.
// </copyright>
//-----------------------------------------------------------------------
namespace DI.PropertyInjection.Dependents
{
    using DI.PropertyInjection.Interfaces;

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

        #region Property Injection

        /// <summary>
        /// The method which uses all the dependencies with their common interface
        /// </summary>
        /// <returns>String output from all the dependency methods</returns>
        public string DoSomeATestWorkWithPropertyInjection()
        {           
            return string.Format("{0} - {1} - {2}", this.IDependency1.Dependency1Method(), this.IDependency2.Dependency2Method(), this.IDependency3.Dependency3Method());
        }

        #endregion
    }
}
