﻿//-----------------------------------------------------------------------
// <copyright file="Dependency2.cs" company="R. R. Donnelley &amp; Sons Company">
//     Copyright (c) R. R. Donnelley &amp; Sons Company. All rights reserved.
// </copyright>
//-----------------------------------------------------------------------
namespace DI.ConstructorInjection.Dependencies
{
    using System;
    using System.Linq;
    using DI.ConstructorInjection.Interfaces;

    /// <summary>
    /// Dependency class 2
    /// </summary>
    public class Dependency2 : IDependency2
    {
        #region IDependency2 Members
        /// <summary>
        /// Dependency 2 method
        /// </summary>
        /// <returns>Returns the type of the class</returns>
        public string Dependency2Method()
        {
            return this.GetType().ToString();
        }

        #endregion
    }
}
