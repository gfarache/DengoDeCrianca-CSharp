using System;
using System.Data;
using System.Data.SQLite;
/*
 * 
BEGIN TRANSACTION;
CREATE TABLE "OutrosContatos" (
	"IdOutroContato"	INTEGER NOT NULL PRIMARY KEY AUTOINCREMENT,
	"IdCrianca"	INTEGER NOT NULL,
	"Nome"	VARCHAR(100) NOT NULL,
	"CPF"	VARCHAR(15) NOT NULL,
	"RG"	VARCHAR(20) NOT NULL,
	"Telefone"	VARCHAR(15) NOT NULL,
	"Parentesco"	VARCHAR(50) NOT NULL
);
CREATE TABLE "Pai" (
	"IdPai"	INTEGER NOT NULL PRIMARY KEY AUTOINCREMENT,
	"IdCrianca"	INTEGER NOT NULL,
	"CPF"	VARCHAR(15) NOT NULL,
	"RG"	VARCHAR(20) NOT NULL,
	"Nome"	VARCHAR(100) NOT NULL,
	"Telefone"	VARCHAR(15) NOT NULL,
	"Endereco"	VARCHAR(100) NOT NULL
);
CREATE TABLE "Crianca" (
	"IdCrianca"	INTEGER NOT NULL PRIMARY KEY AUTOINCREMENT,
	"Nome"	VARCHAR(100) NOT NULL,
	"DataNascimento"	DATE NOT NULL,
	"Sexo"	VARCHAR(5) NOT NULL,
	"TipoSanguineo"	VARCHAR(5)
);
CREATE TABLE "Mae" (
	"IdMae"	INTEGER NOT NULL PRIMARY KEY AUTOINCREMENT,
	"IdCrianca"	INTEGER NOT NULL,
	"CPF"	VARCHAR(15) NOT NULL,
	"RG"	VARCHAR(20) NOT NULL,
	"Nome"	VARCHAR(100) NOT NULL,
	"Telefone"	VARCHAR(15) NOT NULL,
	"Endereco"	VARCHAR(100) NOT NULL
);
CREATE TABLE "Foto" (
	"IdFotoCrianca"	INTEGER NOT NULL,
	"Descricao"	TEXT NOT NULL,
	"Foto"	TEXT,
	PRIMARY KEY("IdFotoCrianca")
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

        public static int AddCrianca(CadastroCrianca crianca)
        {
            try
            {
                //using (var cmd = DbConnection().CreateCommand())
                //{
                //    cmd.CommandText = "SELECT MAX(IdCrianca) FROM Crianca";
                //    SQLiteDataAdapter da = new SQLiteDataAdapter(cmd.CommandText, DbConnection());
                //    da.ToString();
                //}

                SQLiteConnection connect = new SQLiteConnection("Data Source=c:\\dadosDengoDeCrianca\\DengoDeCrianca.sqlite; Version=3;");
                connect.Open();
                SQLiteCommand cmdSelect = connect.CreateCommand();
                cmdSelect.CommandText = @"SELECT MAX(IdCrianca) FROM Crianca";
                cmdSelect.CommandType = CommandType.Text;
                //cmdSelect.Connection = sqliteConnection;
                //sqliteConnection.Open();
                SQLiteDataReader dataReader = cmdSelect.ExecuteReader();
                dataReader.Read();
                int idCrianca = dataReader.GetInt32(0)+1;
                //sqliteConnection.Close();
                dataReader.Close();

                int i = 0;
                using (var cmd = DbConnection().CreateCommand())
                {
                    //https://stackoverflow.com/questions/10853301/save-and-load-image-sqlite-c-sharp
                    cmd.CommandText = "INSERT INTO Crianca(Nome, DataNascimento, Sexo, TipoSanguineo) values (@Nome, @DataNasc, @Sexo, @TipoSanguineo)";
                    cmd.Parameters.AddWithValue("@Nome", crianca.nomeCrianca);
                    cmd.Parameters.AddWithValue("@DataNasc", crianca.dataNasc);
                    cmd.Parameters.AddWithValue("@Sexo", crianca.sexo);
                    cmd.Parameters.AddWithValue("@TipoSanguineo", crianca.tipoSanguineo);
                    cmd.ExecuteNonQuery();
                    i++;
                }
                using (var cmd = DbConnection().CreateCommand())
                {
                    cmd.CommandText = "INSERT INTO Pai(IdCrianca, Nome, CPF, RG, Telefone, Endereco) values (@IdCrianca, @NomePai, @CPFPai, @RGPai, @TelefonePai, @Endereco)";
                    cmd.Parameters.AddWithValue("@IdCrianca", idCrianca);
                    cmd.Parameters.AddWithValue("@NomePai", crianca.nomePai);
                    cmd.Parameters.AddWithValue("@CPFPai", crianca.cpfPai);
                    cmd.Parameters.AddWithValue("@RGPai", crianca.rgPai);
                    cmd.Parameters.AddWithValue("@TelefonePai", crianca.telefonePai);
                    cmd.Parameters.AddWithValue("@Endereco", crianca.enderecoPais + " - " + crianca.noEnderecoPais+ " - " + crianca.bairroPais+ " - " + crianca.cepPais);
                    cmd.ExecuteNonQuery();
                    i++;
                }
                using (var cmd = DbConnection().CreateCommand())
                {
                    cmd.CommandText = "INSERT INTO Mae(IdCrianca, Nome, CPF, RG, Telefone, Endereco) values (@IdCrianca, @NomeMae, @CPFMae, @RGMae, @TelefoneMae, @Endereco)";
                    cmd.Parameters.AddWithValue("@IdCrianca", idCrianca);
                    cmd.Parameters.AddWithValue("@NomeMae", crianca.nomeMae);
                    cmd.Parameters.AddWithValue("@CPFMae", crianca.cpfMae);
                    cmd.Parameters.AddWithValue("@RGMae", crianca.rgMae);
                    cmd.Parameters.AddWithValue("@TelefoneMae", crianca.telefoneMae);
                    cmd.Parameters.AddWithValue("@Endereco", crianca.enderecoPais + " - " + crianca.noEnderecoPais + " - " + crianca.bairroPais + " - " + crianca.cepPais);
                    cmd.ExecuteNonQuery();
                    i++;
                }
                Imagem imagem = new Imagem();
                //imagem.Descricao = "Foto 2";
                imagem.Descricao = crianca.nomeCrianca;
                //imagem.Foto = ConvertImage.ImageToBase64("2.jpg");
                imagem.Foto = ConvertImage.ImageToBase64(crianca.fotoCrianca);
                //SQLiteConnection connection = new SQLiteConnection(@"Data Source=c:\Temp\base.db;");
                SQLiteConnection connection = new SQLiteConnection("Data Source=c:\\dadosDengoDeCrianca\\DengoDeCrianca.sqlite; Version=3;");
                connection.Open();
                SQLiteCommand command = connection.CreateCommand();
                command.CommandText = "INSERT INTO Imagem(Descricao, Foto) VALUES(@Descricao, @Foto);";
                command.Parameters.Add("@Descricao", System.Data.DbType.String).Value = imagem.Descricao;
                command.Parameters.Add("@Foto", System.Data.DbType.String).Value = imagem.Foto;
                command.ExecuteNonQuery();
                //connection.Dispose();
                if (i == 3)
                    return i;
                else
                    return 0;
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