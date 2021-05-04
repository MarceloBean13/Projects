using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace ClassLibraryPROJECTO
{
    public class GERAL
    {
         SqlConnection Connection = new SqlConnection(@"data source = .\sqlexpress; initial catalog = Receitas2020; integrated security=true;");

    }
}
