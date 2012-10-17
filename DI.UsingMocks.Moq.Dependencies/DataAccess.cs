//-----------------------------------------------------------------------
// <copyright file="DataAccess.cs" company="R. R. Donnelley &amp; Sons Company">
//     Copyright (c) R. R. Donnelley &amp; Sons Company. All rights reserved.
// </copyright>
//-----------------------------------------------------------------------
namespace DI.UsingMocks.Moq.Dependencies
{
    using System.Data;
    using System.Data.Common;
    using System.Data.SqlClient;
    using DI.UsingMocks.Moq.Interfaces;

    /// <summary>
    /// Classes for the database operations
    /// </summary>
    public class DataAccess : IDataAccess
    {
        /// <summary>
        /// Creates the parameter.
        /// </summary>
        /// <param name="name">The name of the parameter.</param>
        /// <param name="type">The type of the parameter.</param>
        /// <param name="value">The value of the parameter.</param>
        /// <returns>The SqlParameter</returns>
        public static SqlParameter CreateParameter(string name, SqlDbType type, object value)
        {
            return new SqlParameter { ParameterName = name, SqlDbType = type, Value = value };
        }

        /// <summary>
        /// Executes the query.
        /// </summary>
        /// <param name="connectionString">The connection string.</param>
        /// <param name="storedProcedure">The stored procedure.</param>
        /// <param name="inParameters">The in parameters.</param>
        public static void ExecuteNonQuery(string connectionString, string storedProcedure, params DbParameter[] inParameters)
        {
            // Do some database operation here
        }
      
        /// <summary>
        /// Executes the query.
        /// </summary>
        /// <param name="connectionString">The connection string.</param>
        /// <param name="storedProcedure">The stored procedure.</param>
        /// <param name="inParameters">The in parameters.</param>
        void IDataAccess.ExecuteNonQuery(string connectionString, string storedProcedure, params DbParameter[] inParameters)
        {
            DataAccess.ExecuteNonQuery(connectionString, storedProcedure, inParameters);
        }
        
        /// <summary>
        /// Creates the parameter.
        /// </summary>
        /// <param name="name">The name of the parameter.</param>
        /// <param name="type">The type of the parameter.</param>
        /// <param name="value">The value of the parameter.</param>
        /// <returns>The SqlParameter</returns>
        SqlParameter IDataAccess.CreateParameter(string name, SqlDbType type, object value)
        {
            return DataAccess.CreateParameter(name, type, value);
        }
    }   
}
