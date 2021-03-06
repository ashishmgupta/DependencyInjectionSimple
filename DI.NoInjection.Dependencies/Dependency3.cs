﻿//-----------------------------------------------------------------------
// <copyright file="Dependency3.cs" company="R. R. Donnelley &amp; Sons Company">
//     Copyright (c) R. R. Donnelley &amp; Sons Company. All rights reserved.
// </copyright>
//-----------------------------------------------------------------------
namespace DI.NoInjection.Dependencies
{
    /// <summary>
    /// Dependency class 3
    /// </summary>
    public class Dependency3
    {
        #region IBTest Members

        /// <summary>
        /// Method of dependency class
        /// </summary>
        /// <returns>Type of the class</returns>
        public string Dependency3Method()
        {
            return "Object Type :- " + this.GetType().ToString();
        }

        #endregion
    }
}
