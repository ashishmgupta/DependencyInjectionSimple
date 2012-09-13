//-----------------------------------------------------------------------
// <copyright file="Dependency3.cs" company="R. R. Donnelley &amp; Sons Company">
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
    public class Dependency3 : IDependency3
    {
        #region IDependency3 Members

        /// <summary>
        /// Dependecy method 3
        /// </summary>
        /// <returns>Returns the type of the class</returns>
        public string Dependency3Method()
        {
            return this.GetType().ToString();
        }

        #endregion
    }
}
