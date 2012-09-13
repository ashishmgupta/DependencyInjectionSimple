//-----------------------------------------------------------------------
// <copyright file="IDependency1.cs" company="R. R. Donnelley &amp; Sons Company">
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
    public interface IDependency1
    {
        /// <summary>
        /// Common interface method to be implemented by all the dependency classes
        /// </summary>
        /// <returns>Type of the object as string</returns>
        string Dependency1Method();

        /// <summary>
        /// An overloaded method which takes value type parameters
        /// </summary>
        /// <param name="param1">Parameter 1</param>
        /// <param name="param2">Parameter 2</param>
        /// <returns>Type of object as string - along with parameter values</returns>
        string Dependency1Method(string param1, string param2);
    }
}
