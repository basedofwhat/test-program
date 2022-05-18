using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace Database;

internal static class Misc
{
    internal static SqlCommand GetSqlCommand(in string procedureName, params SqlParameter[] sqlParameters)
    {
        SqlCommand MainCommand = new()
        {
            CommandText = procedureName,
            CommandType = System.Data.CommandType.StoredProcedure
        };

        foreach (SqlParameter SqlParameter in sqlParameters)
        {
            MainCommand.Parameters.Add(SqlParameter);
        }

        return MainCommand;
    }
}
