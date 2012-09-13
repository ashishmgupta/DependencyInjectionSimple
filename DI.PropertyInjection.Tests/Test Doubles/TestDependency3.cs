//-----------------------------------------------------------------------
// <copyright file="TestDependency1.cs" company="R. R. Donnelley &amp; Sons Company">
//     Copyright (c) R. R. Donnelley &amp; Sons Company. All rights reserved.
// </copyright>
//-----------------------------------------------------------------------
namespace DI.PropertyInjection.Tests.Test_Doubles
{
    using DI.PropertyInjection.Interfaces;
    
    /// <summary>
    /// TODO: Provide summary section in the documentation header.
    /// </summary>
    public class TestDependency3 : IDependency3
    {
        #region IDependency3 Members

        public string Dependency3Method()
        {
            return "you.";
        }

        #endregion
    }
}
