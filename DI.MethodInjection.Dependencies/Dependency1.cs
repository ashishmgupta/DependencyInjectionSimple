//-----------------------------------------------------------------------
// <copyright file="Dependency1.cs" company="R. R. Donnelley &amp; Sons Company">
//     Copyright (c) R. R. Donnelley &amp; Sons Company. All rights reserved.
// </copyright>
//-----------------------------------------------------------------------
namespace DI.MethodInjection.Dependencies
{
    using DI.MethodInjection.Interfaces;

    /// <summary>
    /// Dependent class 1
    /// </summary>
    public class Dependency1 : IDependency1
    {
        #region IBTest Members

        /// <summary>
        /// Method of dependent class
        /// </summary>
        /// <returns>Type of the class</returns>
        public string Dependency1Method()
        {
            return this.GetType().ToString();
        }

        #endregion
    }
}
