//-----------------------------------------------------------------------
// <copyright file="TestDependency1.cs" company="R. R. Donnelley &amp; Sons Company">
//     Copyright (c) R. R. Donnelley &amp; Sons Company. All rights reserved.
// </copyright>
//-----------------------------------------------------------------------
namespace DI.ConstructorInjection.Tests.Test_Doubles
{
    using System;
    using System.Linq;
    using DI.ConstructorInjection.Interfaces;

    /// <summary>
    /// TODO: Provide summary section in the documentation header.
    /// </summary>
    public class TestDependency2 : IDependency2
    {
        #region IDependency2 Members

        public string Dependency2Method()
        {
            return "is";
        }

        #endregion
    }
}
