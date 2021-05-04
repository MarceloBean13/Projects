using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.Data;

namespace FRONT_END
{
    public partial class ReceitasSopas : System.Web.UI.Page
    {
        SqlConnection Connection = new SqlConnection(Properties.Settings.Default.Connection);

        protected void Page_Load(object sender, EventArgs e)
        {
            SqlCommand Command = new SqlCommand();
            Command.Connection = Connection;
            Command.CommandType = CommandType.StoredProcedure;
            Command.CommandText = "SeleccionarReceitasSopa";
            SqlDataReader Reader;
            DataTable Table = new DataTable();
            Connection.Open();
            Reader = Command.ExecuteReader();
            Table.Load(Reader);
            Connection.Close();
            dgvSopa.DataSource = Table;
        }
    }
}