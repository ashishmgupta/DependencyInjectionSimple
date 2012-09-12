//-----------------------------------------------------------------------
// <copyright file="Dependency2.cs" company="R. R. Donnelley &amp; Sons Company">
//     Copyright (c) R. R. Donnelley &amp; Sons Company. All rights reserved.
// </copyright>
//-----------------------------------------------------------------------
namespace DI.NoInjection.Dependencies
{
    /// <summary>
    /// Dependency class 2
    /// </summary>
    public class Dependency2 
    {
        #region IBTest Members
        /// <summary>
        /// Method of the dependency class
        /// </summary>
        /// <returns>Type of the class</returns>
        public string Dependency2Method()
        {
            return this.GetType().ToString();
        }

        #endregion
    }
}
