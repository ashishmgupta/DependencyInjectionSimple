//-----------------------------------------------------------------------
// <copyright file="IDataAccessWrapper.cs" company="R. R. Donnelley &amp; Sons Company">
//     Copyright (c) R. R. Donnelley &amp; Sons Company. All rights reserved.
// </copyright>
//-----------------------------------------------------------------------
namespace DI.UsingMocks.Moq.Interfaces
{
    using System;
    using System.Linq;

    /// <summary>
    /// Interface to wrap 
    /// </summary>
    public interface IDataAccessWrapper
    {
        /// <summary>
        /// Called when [static factory method].
        /// </summary>
        /// <param name="id">The value for the id parameter.</param>
        /// <param name="name">The value for the name parameter.</param>
        void OneStaticFactoryMethod(Guid id, string name);
    }
}
