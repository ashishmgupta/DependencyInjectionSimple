//-----------------------------------------------------------------------
// <copyright file="Dependent.cs" company="R. R. Donnelley &amp; Sons Company">
//     Copyright (c) R. R. Donnelley &amp; Sons Company. All rights reserved.
// </copyright>
//-----------------------------------------------------------------------
namespace _0___Common_Objects.Types
{
    using System;
    using System.Linq;
    using _0___Common_Objects;
    using _1___Interfaces;

    /// <summary>
    /// The dependent class
    /// </summary>
    public class Dependent
    {
        #region Constructors

        /// <summary>
        /// Initializes a new instance of the <see cref="T:Dependent"/> class.
        /// </summary>
        public Dependent()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="T:Dependent"/> class.
        /// An overloaded constructor which takes interfaces of all the dependencies 
        /// </summary>
        /// <param name="dependency1">Interface of dependency1</param>
        /// <param name="dependency2">Interface of dependency2</param>
        /// <param name="dependency3">Interface of dependency3</param>
        public Dependent(IDependency1 dependency1, IDependency2 dependency2, IDependency3 dependency3)
        {
            this.IDependency1 = dependency1;
            this.IDependency2 = dependency2;
            this.IDependency3 = dependency3;
        } 

        #endregion

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

        #region Constructor Injection

        /// <summary>
        /// The method which uses all the dependencies with their common interface
        /// </summary>
        /// <returns>String output from all the dependency methods</returns>
        public string DoSomeATestWorkWithConstructorInjection()
        {           
            return string.Format("{0} - {1} - {2}", this.IDependency1.Dependency1Method(), this.IDependency2.Dependency2Method(), this.IDependency3.Dependency3Method());
        }

        #endregion
    }
}
