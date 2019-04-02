using System;
using System.Data;
using System.Data.SQLite;
/*
 * 
BEGIN TRANSACTION;
DROP TABLE IF EXISTS "OutrosContatos";
CREATE TABLE IF NOT EXISTS "OutrosContatos" (
	"IdOutroContato"	INTEGER NOT NULL,
	"IdCrianca"	INTEGER NOT NULL,
	"Nome"	VARCHAR(100) NOT NULL,
	"CPF"	VARCHAR(15) NOT NULL,
	"RG"	VARCHAR(20) NOT NULL,
	"Telefone"	VARCHAR(15) NOT NULL,
	"Parentesco"	VARCHAR(50) NOT NULL,
	PRIMARY KEY("IdOutroContato","IdCrianca")
);
DROP TABLE IF EXISTS "Pai";
CREATE TABLE IF NOT EXISTS "Pai" (
	"IdPai"	INTEGER NOT NULL,
	"IdCrianca"	INTEGER NOT NULL,
	"CPF"	VARCHAR(15) NOT NULL,
	"RG"	VARCHAR(20) NOT NULL,
	"Nome"	VARCHAR(100) NOT NULL,
	"Telefone"	VARCHAR(15) NOT NULL,
	"Endereco"	VARCHAR(100) NOT NULL,
	PRIMARY KEY("IdPai","IdCrianca")
);
DROP TABLE IF EXISTS "Crianca";
CREATE TABLE IF NOT EXISTS "Crianca" (
	"IdCrianca"	INTEGER NOT NULL,
	"Nome"	VARCHAR(100) NOT NULL,
	"DataNascimento"	DATE NOT NULL,
	"Sexo"	VARCHAR(5) NOT NULL,
    "TipoSanguineo" VARCHAR(5),
	PRIMARY KEY("IdCrianca")
);
DROP TABLE IF EXISTS "Mae";
CREATE TABLE IF NOT EXISTS "Mae" (
	"IdMae"	INTEGER NOT NULL,
	"IdCrianca"	INTEGER NOT NULL,
	"CPF"	VARCHAR(15) NOT NULL,
	"RG"	VARCHAR(20) NOT NULL,
	"Nome"	VARCHAR(100) NOT NULL,
	"Telefone"	VARCHAR(15) NOT NULL,
	"Endereco"	VARCHAR(100) NOT NULL,
	PRIMARY KEY("IdMae","IdCrianca")
);
COMMIT;
 * 
 */
namespace DengoDeCrianca
{
    public class DAOHelper
    {
        private static SQLiteConnection sqliteConnection;

        public DAOHelper()
        { }

        private static SQLiteConnection DbConnection()
        {
            sqliteConnection = new SQLiteConnection("Data Source=c:\\dadosDengoDeCrianca\\DengoDeCrianca.sqlite; Version=3;");
            sqliteConnection.Open();
            return sqliteConnection;
        }

        //public static void CriarBancoSQLite()
        //{
        //    try
        //    {
        //        SQLiteConnection.CreateFile(@"c:\dadosDengoDeCrianca\DengoDeCrianca.sqlite");
        //    }
        //    catch
        //    {
        //        throw;
        //    }
        //}

        //public static void CriarTabelaSQlite()
        //{
        //    try
        //    {
        //        using (var cmd = DbConnection().CreateCommand())
        //        {
        //            cmd.CommandText = "CREATE TABLE IF NOT EXISTS Clientes(id int, Nome Varchar(50), email VarChar(80))";
        //            cmd.ExecuteNonQuery();
        //        }
        //    }
        //    catch (Exception ex)
        //    {
        //        throw ex;
        //    }
        //}

        public static DataTable GetCriancas()
        {
            SQLiteDataAdapter da = null;
            DataTable dt = new DataTable();
            try
            {
                using (var cmd = DbConnection().CreateCommand())
                {
                    cmd.CommandText = "SELECT * FROM Crianca";
                    da = new SQLiteDataAdapter(cmd.CommandText, DbConnection());
                    da.Fill(dt);
                    return dt;
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public static DataTable GetCrianca(int idCrianca)
        {
            SQLiteDataAdapter da = null;
            DataTable dt = new DataTable();
            try
            {
                using (var cmd = DbConnection().CreateCommand())
                {
                    cmd.CommandText = "SELECT * FROM Clientes Where IdCrianca=" + idCrianca;
                    da = new SQLiteDataAdapter(cmd.CommandText, DbConnection());
                    da.Fill(dt);
                    return dt;
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public static void AddCrianca(string nome, string dataNasc, char sexo, string tipoSanguineo)
        {
            try
            {
                using (var cmd = DbConnection().CreateCommand())
                {
                    cmd.CommandText = "INSERT INTO Crianca(Nome, DataNascimento, Sexo, TipoSanguineo) values (@Nome, @DataNasc, @Sexo, @TipoSanguineo)";
                    cmd.Parameters.AddWithValue("@Nome", nome);
                    cmd.Parameters.AddWithValue("@DataNasc", dataNasc);
                    cmd.Parameters.AddWithValue("@Sexo", sexo);
                    cmd.Parameters.AddWithValue("@TipoSanguineo", tipoSanguineo);
                    cmd.ExecuteNonQuery();
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public static void AddMae(CadastroCrianca mae)
        {
            try
            {
                using (var cmd = DbConnection().CreateCommand())
                {
                    cmd.CommandText = "INSERT INTO Mae(Nome, CPF, RG, Telefone, Endereco) values (@Nome, @CPF, @RG, @Telefone, @Endereco)";
                    cmd.Parameters.AddWithValue("@Nome", mae.nomeMae);
                    cmd.Parameters.AddWithValue("@CPF", mae.cpfMae);
                    cmd.Parameters.AddWithValue("@RG", mae.rgMae);
                    cmd.Parameters.AddWithValue("@Telefone", mae.telefoneMae);
                    cmd.Parameters.AddWithValue("@Endereco", mae.enderecoPais);
                    cmd.ExecuteNonQuery();
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public static void AddPai(CadastroCrianca pai)
        {
            try
            {
                using (var cmd = DbConnection().CreateCommand())
                {
                    cmd.CommandText = "INSERT INTO Pai(Nome, CPF, RG, Telefone, Endereco) values (@Nome, @CPF, @RG, @Telefone, @Endereco)";
                    cmd.Parameters.AddWithValue("@Nome", pai.nomePai);
                    cmd.Parameters.AddWithValue("@CPF", pai.cpfPai);
                    cmd.Parameters.AddWithValue("@RG", pai.rgPai);
                    cmd.Parameters.AddWithValue("@Telefone", pai.telefonePai);
                    cmd.Parameters.AddWithValue("@Endereco", pai.enderecoPais);
                    cmd.ExecuteNonQuery();
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        //public static void UpdateCrianca(CadastroCrianca crianca)
        //{
        //    try
        //    {
        //        using (var cmd = new SQLiteCommand(DbConnection()))
        //        {
        //            if (crianca.idCrianca != 0)
        //            {
        //                cmd.CommandText = "UPDATE Crianca SET Nome=@Nome, DataNascimento=@DataNasc, Sexo=@Sexo WHERE Id=@IdCrianca";
        //                cmd.Parameters.AddWithValue("@IdCrianca", crianca.idCrianca);
        //                cmd.Parameters.AddWithValue("@Nome", crianca.nomeCrianca);
        //                cmd.Parameters.AddWithValue("@DataNasc", crianca.dataNasc);
        //                cmd.Parameters.AddWithValue("@Sexo", crianca.sexo);
        //                cmd.ExecuteNonQuery();
        //            }
        //        };
        //    }
        //    catch (Exception ex)
        //    {
        //        throw ex;
        //    }
        //}

        public static void DeleteCrianca(int IdCrianca)
        {
            try
            {
                using (var cmd = new SQLiteCommand(DbConnection()))
                {
                    cmd.CommandText = "DELETE FROM Crianca Where Id=@IdCrianca";
                    cmd.Parameters.AddWithValue("@IdCrianca", IdCrianca);
                    cmd.ExecuteNonQuery();
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}