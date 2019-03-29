using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DengoDeCrianca
{
    class BDConexao
    {
        SqlConnection con;
        public SqlConnection abrir_conexao()
        {
            con = new SqlConnection();
            con.ConnectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=
                C:\Users\Administrador\source\repos\DengoDeCrianca\DengoDeCrianca\DengoMainDB.mdf;Integrated Security=True";
            con.Open();
            return con;
        }

        public void fechar_conexao(SqlConnection con)
        {
            con.Close();
        }
    }
}
