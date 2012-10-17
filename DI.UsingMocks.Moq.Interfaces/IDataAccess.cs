//-----------------------------------------------------------------------
// <copyright file="IDataAccess.cs" company="R. R. Donnelley &amp; Sons Company">
//     Copyright (c) R. R. Donnelley &amp; Sons Company. All rights reserved.
// </copyright>
//-----------------------------------------------------------------------
namespace DI.UsingMocks.Moq.Interfaces
{
    using System.Collections.Generic;
    using System.Data;
    using System.Data.Common;
    using System.Data.SqlClient;

    /// <summary>
    /// An interface for DataAccess
    /// </summary>
    public interface IDataAccess
    {
        /// <summary>
        /// Creates a SqlParameter with the given name, type, and value.
        /// </summary>
        /// <param name="name">The name of the parameter.</param>
        /// <param name="type">The type of the parameter.</param>
        /// <param name="value">The value of the parameter.</param>
        /// <returns>Returns a SqlParameter created with the given arguments.</returns>
        SqlParameter CreateParameter(string name, SqlDbType type, object value);

        /// <summary>
        /// Executes the given stored procedure.
        /// </summary>
        /// <param name="connectionString">The connection string.</param>
        /// <param name="storedProcedure">The stored procedure.</param>
        /// <param name="inParameters">The parameters to pass into the stored procedure.</param>
        void ExecuteNonQuery(string connectionString, string storedProcedure, params DbParameter[] inParameters);
    }
}
