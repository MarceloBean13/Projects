using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace ClassLibraryPROJECTO
{
    public static class SeleccionarUnidade
    {
        private static SqlConnection Connection = new SqlConnection(
            @"data source = .\sqlexpress; initial catalog = Receitas2020;
            integrated security = true;");
        
        public static DataTable SeleccionarIngrediente()
        {
            SqlCommand Command = new SqlCommand();
            Command.Connection = Connection;
            Command.CommandType = CommandType.StoredProcedure;
            Command.CommandText = "IngredienteEUnidade";
            SqlDataReader Reader;
            Connection.Open();
            Reader = Command.ExecuteReader();
            DataTable Table = new DataTable();
            Table.Load(Reader);
            Connection.Close();
            return Table;

        }
        public static DataTable InserirIngredientes()
        {
            SqlCommand Command = new SqlCommand();
            Command.Connection = Connection;
            Command.CommandType = CommandType.StoredProcedure;
            Command.CommandText = "";
            DataTable Table = new DataTable();
            return Table;
        }
    }
}
        
    
