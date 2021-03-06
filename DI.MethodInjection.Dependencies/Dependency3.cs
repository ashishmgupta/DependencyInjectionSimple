﻿//-----------------------------------------------------------------------
// <copyright file="Dependency3.cs" company="R. R. Donnelley &amp; Sons Company">
//     Copyright (c) R. R. Donnelley &amp; Sons Company. All rights reserved.
// </copyright>
//-----------------------------------------------------------------------
namespace DI.MethodInjection.Dependencies
{
    using DI.MethodInjection.Interfaces;

    /// <summary>
    /// Dependency class 3
    /// </summary>
    public class Dependency3 : IDependency3
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
