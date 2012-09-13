//-----------------------------------------------------------------------
// <copyright file="Dependency2.cs" company="R. R. Donnelley &amp; Sons Company">
//     Copyright (c) R. R. Donnelley &amp; Sons Company. All rights reserved.
// </copyright>
//-----------------------------------------------------------------------
namespace DI.UsingMocks.Moq.Dependencies
{
    using System;
    using System.Linq;
    using DI.UsingMocks.Moq.Interfaces;

    /// <summary>
    /// TODO: Provide summary section in the documentation header.
    /// </summary>
    public class Dependency2 : IDependency2
    {
        #region IDependency2 Members

        /// <summary>
        /// Dependency 2 method which returns the type of the object
        /// </summary>
        /// <returns>Returns the type of the class</returns>
        public string Dependency2Method()
        {
            return this.GetType().ToString();
        }

        #endregion
    }
}
