﻿//-----------------------------------------------------------------------
// <copyright file="IDependency1.cs" company="R. R. Donnelley &amp; Sons Company">
//     Copyright (c) R. R. Donnelley &amp; Sons Company. All rights reserved.
// </copyright>
//-----------------------------------------------------------------------
namespace DI.MethodInjection.Interfaces
{
    using System;
    using System.Linq;

    /// <summary>
    /// An interface for BTest type of classes
    /// </summary>
    public interface IDependency1
    {
        /// <summary>
        /// Common interface method to be implemented by all the dependency classes
        /// </summary>
        /// <returns>Type of the object as string</returns>
        string Dependency1Method();
    }
}
