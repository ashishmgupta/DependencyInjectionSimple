//-----------------------------------------------------------------------
// <copyright file="RandomRepository.cs" company="R. R. Donnelley &amp; Sons Company">
//     Copyright (c) R. R. Donnelley &amp; Sons Company. All rights reserved.
// </copyright>
//-----------------------------------------------------------------------
namespace DI.UsingMocks.Moq.Dependents
{
    using System;
    using System.Data;
    using DI.UsingMocks.Moq.Dependencies;
    using DI.UsingMocks.Moq.Interfaces;

    /// <summary>
    /// Repository for some random data access
    /// </summary>
    public class RandomRepository
    {
        /// <summary>
        /// Name of the stored procedure to insert data in a table
        /// </summary>
        private const string SomeRandomTableInsertSP = "SomeRandomTable_Insert";

        /// <summary>
        /// The connection string
        /// </summary>
        private const string ConnectionString = "Random connection string";

        /// <summary>
        /// Gets or sets the IDataAccess.
        /// </summary>
        /// <value>The IDataAccess.</value>
        public static IDataAccess DataAccessObject
        {
            get;
            set;
        } 

        #region Static method
        
        /// <summary>
        /// A random static "Factory" method
        /// </summary>
        /// <param name="id">The value for the Id parameter.</param>
        /// <param name="name">The value for the Name parameter.</param>
        public static void RandomRepositoryMethod(Guid id, string name)
        {
            DataAccessObject.ExecuteNonQuery(
                ConnectionString,
                SomeRandomTableInsertSP,
                DataAccess.CreateParameter("@Id", SqlDbType.UniqueIdentifier, id),
                DataAccess.CreateParameter("@Name", SqlDbType.NVarChar, name));
        }

        /// <summary>
        /// A random static "Factory" method
        /// </summary>
        /// <param name="id">The value for the Id parameter.</param>
        /// <param name="name">The value for the Name parameter.</param>
        /// <param name="dataAccess">The data access.</param>
        public static void RandomRepositoryMethod(Guid id, string name, IDataAccess dataAccess)
        {
            dataAccess.ExecuteNonQuery(
                ConnectionString,
                SomeRandomTableInsertSP,
                DataAccess.CreateParameter("@Id", SqlDbType.UniqueIdentifier, id),
                DataAccess.CreateParameter("@Name", SqlDbType.NVarChar, name));
        }
        #endregion
    }
}
