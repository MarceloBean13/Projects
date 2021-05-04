using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace ClassLibraryPROJECTO
{
    public static class SeleccionarIngrediente
    {
        private static SqlConnection Connection = new SqlConnection(@"data source = .\sqlexpress;
        initial catalog = Receitas2020; integrated security = true;");

        public static DataTable SeleccionarIngredienteReceita()
        {
            SqlCommand Command = new SqlCommand();
            Command.Connection = Connection;
            Command.CommandType = CommandType.StoredProcedure;
            Command.CommandText = "ReceitaIngredientePasso";
            SqlDataReader Reader;
            Connection.Open();
            Reader = Command.ExecuteReader();
            DataTable Table = new DataTable();
            Table.Load(Reader);
            Connection.Close();
            return Table;

        }
    }
}
