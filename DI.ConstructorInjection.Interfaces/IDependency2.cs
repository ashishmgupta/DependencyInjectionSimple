﻿//-----------------------------------------------------------------------
// <copyright file="IDependency2.cs" company="R. R. Donnelley &amp; Sons Company">
//     Copyright (c) R. R. Donnelley &amp; Sons Company. All rights reserved.
// </copyright>
//-----------------------------------------------------------------------
namespace DI.ConstructorInjection.Interfaces
{
    using System;
    using System.Linq;

    /// <summary>
    /// An interface for BTest type of classes
    /// </summary>
    public interface IDependency2
    {
        /// <summary>
        /// Common interface method to be implemented by all the dependency classes
        /// </summary>
        /// <returns>Type of the object as string</returns>
        string Dependency2Method();
    }
}
