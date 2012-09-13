//-----------------------------------------------------------------------
// <copyright file="IDependency3.cs" company="R. R. Donnelley &amp; Sons Company">
//     Copyright (c) R. R. Donnelley &amp; Sons Company. All rights reserved.
// </copyright>
//-----------------------------------------------------------------------
namespace DI.UsingMocks.Moq.Interfaces
{
    using System;
    using System.Linq;

    /// <summary>
    /// An interface for BTest type of classes
    /// </summary>
    public interface IDependency3
    {
        /// <summary>
        /// Common interface method to be implemented by all the dependency classes
        /// </summary>
        /// <returns>Type of the object as string</returns>
        string Dependency3Method();
    }
}
