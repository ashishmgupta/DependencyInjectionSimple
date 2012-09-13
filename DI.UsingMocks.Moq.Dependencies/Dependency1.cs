//-----------------------------------------------------------------------
// <copyright file="Dependency1.cs" company="R. R. Donnelley &amp; Sons Company">
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
    public class Dependency1 : IDependency1
    {
        #region IDependency1 Members

        /// <summary>
        /// Dependency 1 method
        /// </summary>
        /// <returns>Returns the type of the class</returns>
        public string Dependency1Method()
        {
            return this.GetType().ToString();
        }

        /// <summary>
        /// Dependency 2 method
        /// </summary>
        /// <param name="param1">The prefix for the type of the class</param>
        /// <param name="param2">The suffix for the type of the class</param>
        /// <returns>Type of the class with prefix and suffix</returns>
        public string Dependency1Method(string param1, string param2)
        {
            return param1 + this.GetType().ToString() + param2;
        }

        #endregion
    }
}
