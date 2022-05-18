using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace Database;

internal static class Methods
{
    /// <summary>
    /// Add row to specific table in database.
    /// </summary>
    /// <param name="Grid">DataGridView which needs to be updated.</param>
    /// <param name="ExecuteCommand">Stored procedure to be performed.</param>
    internal static void AddRow(in DataGridView grid, in SqlCommand executeCommand)
    {
        using SqlConnection Connection = new();

        try
        {
            Connection.Open();
        }
        catch
        {
            MessageBox.Show("Нет соединения с базой данных!");
        }
        
        // I think connection error very rare. No need to checking.
        if (executeCommand.ExecuteNonQuery() > 0)
        {
            // [TODO] Add DataGridView fill method.
            MessageBox.Show("Запись успешно добавлена!");
        }
        else
        {
            MessageBox.Show("Что-то пошло не так.");
        }

        executeCommand.Dispose();
    }

    internal static void UpdateRow()
    {

    }

    internal static void RemoveRow()
    {

    }
}
