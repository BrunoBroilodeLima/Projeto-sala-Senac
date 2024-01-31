using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SQLite;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AgendaSalaSenac
{
    public class DALAgenda
    {
        //endereco do banco de dados, o path se refere ao caminho aonde o banco esta
        public static string path = Directory.GetCurrentDirectory() + "\\banco.sqlite";
        private static SQLiteConnection sqliteConnection;


        //metodo conectar com o banco de dados
        private static SQLiteConnection DbConnection()
        {
            //procura o endereco
            sqliteConnection = new SQLiteConnection("Data Source =" + path);
            //abre o banco de dados
            sqliteConnection.Open();
            //retorna o endereco encontrado
            return sqliteConnection;
        }

        // criar banco dados
        public static void CriarBancoSQLite()
        {
            //try tratamento de execao 
            try
            {
                // se for falso q existe esse banco de dados  
                if (File.Exists(path) == false)
                {
                    //cria o banco
                    SQLiteConnection.CreateFile(path);
                }

            }
            //se nao nao faz nada
            catch
            {
                throw;
            }
        }

        //criat tabelas
        public static void CriarTabelaSQLite()
        {
            try
            {
                using (var cmd = DbConnection().CreateCommand())
                {
                    
                    
                    
                    
                    //Sab BOOLEAN NOT NULL CHECK (Sab IN (0, 1))
                    cmd.CommandText = @$"CREATE TABLE IF NOT EXISTS Reservas         (Id INTEGER PRIMARY KEY AUTOINCREMENT,                    Sala VARCHAR(10), Turno VARCHAR(30), DataInicioAgendamento DATETIME, DataFinalAgendamento DATETIME, Responsavel VARCHAR(80), Finalidade VARCHAR(80), Conteudo VARCHAR(80) , Encerrado BOOLEAN NOT NULL CHECK (Encerrado IN (0, 1)),Seg BOOLEAN NOT NULL CHECK (Seg IN (0, 1)),Ter BOOLEAN NOT NULL CHECK (Ter IN (0, 1)),Qua BOOLEAN NOT NULL CHECK (Qua IN (0, 1)),Qui BOOLEAN NOT NULL CHECK (Qui IN (0, 1)),Sex BOOLEAN NOT NULL CHECK (Sex IN (0, 1)),Sab BOOLEAN NOT NULL CHECK (Sab IN (0, 1)) ); 
                                         CREATE TABLE IF NOT EXISTS ReservasHistorico(Id INTEGER PRIMARY KEY AUTOINCREMENT, IdReserva INTEGER, Sala VARCHAR(10), Turno VARCHAR(30), DataInicioAgendamento DATETIME, DataFinalAgendamento DATETIME, Responsavel VARCHAR(80), Finalidade VARCHAR(80), Conteudo VARCHAR(80) , Encerrado BOOLEAN NOT NULL CHECK (Encerrado IN (0, 1)),Seg BOOLEAN NOT NULL CHECK (Seg IN (0, 1)),Ter BOOLEAN NOT NULL CHECK (Ter IN (0, 1)),Qua BOOLEAN NOT NULL CHECK (Qua IN (0, 1)),Qui BOOLEAN NOT NULL CHECK (Qui IN (0, 1)),Sex BOOLEAN NOT NULL CHECK (Sex IN (0, 1)),Sab BOOLEAN NOT NULL CHECK (Sab IN (0, 1)) );
                                         ";
                    cmd.ExecuteNonQuery();

                }
            }
            catch (Exception ex)
            {
                throw ex;
            }

        }

        //pegar todas reservas
        public static DataTable GetReservas()
        {
            SQLiteDataAdapter da = null;
            DataTable dt = new DataTable();
            try
            {
                //ussing serve para criar uma variavel e guarda em memoria os dados, assim so usara memoria enquanto esse bloco for usado
                using (var cmd = DbConnection().CreateCommand())
                {
                    cmd.CommandText = "SELECT * FROM Reservas WHERE Encerrado = 0";
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
        // copiei o mesmo mettodo, so passei como parametrro SALA
        public static DataTable GetReservas(string sala)
        {
            SQLiteDataAdapter da = null;
            DataTable dt = new DataTable();
            try
            {
                using (var cmd = DbConnection().CreateCommand())
                {
                    // seleciona tudo na tabela reservas aonde tiver usuario em qualquer parte 3
                    cmd.CommandText = "SELECT * FROM Reservas WHERE sala like '%" + sala + "%' AND Encerrado = 0";
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

        // copiei o mesmo mettodo, so passei como parametrro SALA
        public static DataTable GetHistorico()
        {
            SQLiteDataAdapter da = null;
            DataTable dt = new DataTable();
            try
            {
                using (var cmd = DbConnection().CreateCommand())
                {
                    // seleciona tudo na tabela reservas aonde tiver usuario em qualquer parte 3
                    cmd.CommandText = "SELECT * FROM ReservasHistorico";
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

        //pegar apenas uma reserva
        public static DataTable GetReseva(int id)
        {
            SQLiteDataAdapter da = null;
            DataTable dt = new DataTable();
            try
            {
                using (var cmd = DbConnection().CreateCommand())
                {
                    cmd.CommandText = "SELECT * FROM Reservas where Id=" + id;
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
        public static Reserva GetReserva(int id)
        {
            SQLiteDataAdapter da = null;
            DataTable dt = new DataTable();
            try
            {
                using (var cmd = DbConnection().CreateCommand())
                {
                    cmd.CommandText = "SELECT * FROM Reservas where Id=" + id;
                    da = new SQLiteDataAdapter(cmd.CommandText, DbConnection());
                    da.Fill(dt);
                    foreach( DataRow dataRow in dt.Rows)
                    {
                        var reserva = new Reserva();
                        reserva.Id = Convert.ToInt32( dataRow["id"]);
                        reserva.Sala = dataRow["sala"].ToString();
                        reserva.Turno = dataRow["turno"].ToString();
                        reserva.DataInicioAgendamento = Convert.ToDateTime (dataRow["dataInicioAgendamento"]);
                        reserva.DataFinalAgendamento = Convert.ToDateTime(dataRow["dataFinalAgendamento"]);
                        reserva.Responsavel = dataRow["responsavel"].ToString();
                        reserva.Finalidade = dataRow["finalidade"].ToString();
                        reserva.Conteudo = dataRow["conteudo"].ToString();

                        return reserva;
                    }
                    return new Reserva();
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        //adicinar reserva
        public static void Add(Reserva reserva)
        {

            try
            {
                // usamos o ussing pra liberar a memoria
                using (var cmd = DbConnection().CreateCommand())
                {
                   
                    cmd.CommandText = "INSERT INTO Reservas( sala, turno, dataInicioAgendamento, dataFinalAgendamento, responsavel, finalidade, conteudo , Encerrado, Seg, Ter, Qua, Qui, Sex, Sab) values ( @sala, @turno, @dataInicioAgendamento, @dataFinalAgendamento, @responsavel, @finalidade, @conteudo, 0, @ckSeg, @ckTer, @ckQua, @ckQui, @ckSex, @ckSab)";
                    
                    cmd.Parameters.AddWithValue("@sala", reserva.Sala);
                    cmd.Parameters.AddWithValue("@turno", reserva.Turno);
                    cmd.Parameters.AddWithValue("@dataInicioAgendamento", reserva.DataInicioAgendamento);
                    cmd.Parameters.AddWithValue("@dataFinalAgendamento", reserva.DataFinalAgendamento);
                    cmd.Parameters.AddWithValue("@responsavel", reserva.Responsavel);
                    cmd.Parameters.AddWithValue("@finalidade", reserva.Finalidade);
                    cmd.Parameters.AddWithValue("@conteudo", reserva.Conteudo);
                    cmd.Parameters.AddWithValue("@ckSeg", reserva.ckSeg);
                    cmd.Parameters.AddWithValue("@ckTer", reserva.ckTer);
                    cmd.Parameters.AddWithValue("@ckQua", reserva.ckQua);
                    cmd.Parameters.AddWithValue("@ckQui", reserva.ckQui);
                    cmd.Parameters.AddWithValue("@ckSex", reserva.ckSex);
                    cmd.Parameters.AddWithValue("@ckSab", reserva.ckSab);
                    cmd.ExecuteNonQuery();


                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        //altera reserva
        public static void Update(Reserva reserva)
        {
            try
            {
                // usamos o ussing pra liberar a memoria
                using (var cmd = DbConnection().CreateCommand())
                {
                    cmd.CommandText = "UPDATE Reservas SET Sala=@sala, Turno=@turno, DataInicioAgendamento=@dataInicioAgendamento, DataFinalAgendamento=@dataFinalAgendamento, Responsavel=@responsavel, Finalidade=@finalidade, Conteudo=@conteudo, Seg=@ckSeg, Ter=@ckTer, Qua=@ckQua, Qui=@ckQui, Sex=@ckSex, Sab=@ckSab WHERE Id=@id";
                    cmd.Parameters.AddWithValue("@id", reserva.Id);
                    cmd.Parameters.AddWithValue("@sala", reserva.Sala);
                    cmd.Parameters.AddWithValue("@turno", reserva.Turno);
                    cmd.Parameters.AddWithValue("@dataInicioAgendamento", reserva.DataInicioAgendamento);
                    cmd.Parameters.AddWithValue("@dataFinalAgendamento", reserva.DataFinalAgendamento);
                    cmd.Parameters.AddWithValue("@responsavel", reserva.Responsavel);
                    cmd.Parameters.AddWithValue("@finalidade", reserva.Finalidade);
                    cmd.Parameters.AddWithValue("@conteudo", reserva.Conteudo);
                    cmd.Parameters.AddWithValue("@ckSeg", reserva.ckSeg);
                    cmd.Parameters.AddWithValue("@ckTer", reserva.ckTer);
                    cmd.Parameters.AddWithValue("@ckQua", reserva.ckQua);
                    cmd.Parameters.AddWithValue("@ckQui", reserva.ckQui);
                    cmd.Parameters.AddWithValue("@ckSex", reserva.ckSex);
                    cmd.Parameters.AddWithValue("@ckSab", reserva.ckSab);
                    cmd.ExecuteNonQuery();


                }
            }
            catch (Exception ex)
            {
                throw ex;
            }

        }

        //exclui reserva
        public static void Encerrar(int id)
        {
            try
            {
                // usamos o ussing pra liberar a memoria
                using (var cmd = DbConnection().CreateCommand())
                {
                    cmd.CommandText = "UPDATE Reservas SET Encerrado = true WHERE Id=@id";
                    cmd.Parameters.AddWithValue("@id", id);
                    cmd.ExecuteNonQuery();

                    var reserva = GetReserva(id);
                    cmd.CommandText = "INSERT INTO ReservasHistorico(IdReserva, sala, turno, dataInicioAgendamento, dataFinalAgendamento, responsavel, finalidade, conteudo , Encerrado, Seg, Ter, Qua, Qui, Sex, Sab) values (@id, @sala, @turno, @dataInicioAgendamento, @dataFinalAgendamento, @responsavel, @finalidade, @conteudo, 0, @ckSeg, @ckTer, @ckQua, @ckQui, @ckSex, @ckSab)";
                                      
                    cmd.Parameters.AddWithValue("@id", id);
                    cmd.Parameters.AddWithValue("@sala", reserva.Sala);
                    cmd.Parameters.AddWithValue("@turno", reserva.Turno);
                    cmd.Parameters.AddWithValue("@dataInicioAgendamento", reserva.DataInicioAgendamento);
                    cmd.Parameters.AddWithValue("@dataFinalAgendamento", reserva.DataFinalAgendamento);
                    cmd.Parameters.AddWithValue("@responsavel", reserva.Responsavel);
                    cmd.Parameters.AddWithValue("@finalidade", reserva.Finalidade);
                    cmd.Parameters.AddWithValue("@conteudo", reserva.Conteudo);
                    cmd.Parameters.AddWithValue("@ckSeg", reserva.ckSeg);
                    cmd.Parameters.AddWithValue("@ckTer", reserva.ckTer);
                    cmd.Parameters.AddWithValue("@ckQua", reserva.ckQua);
                    cmd.Parameters.AddWithValue("@ckQui", reserva.ckQui);
                    cmd.Parameters.AddWithValue("@ckSex", reserva.ckSex);
                    cmd.Parameters.AddWithValue("@ckSab", reserva.ckSab);

                    cmd.ExecuteNonQuery();

                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        internal static bool ConsultarDisponibilidade(Reserva reserva)
        {
            SQLiteDataAdapter da = null;
            DataTable dt = new DataTable();
            try
            {
                //ussing serve para criar uma variavel e guarda em memoria os dados, assim so usara memoria enquanto esse bloco for usado
                using (var cmd = DbConnection().CreateCommand())
                {
                    cmd.CommandText = "SELECT * FROM Reservas WHERE Sala =  @sala AND Turno = @turno AND date(dataInicioAgendamento) >= @dataInicioAgendamento AND date(dataFinalAgendamento) <= @dataFinalAgendamento AND Seg = @seg AND Ter = @ter AND Qua = @qua AND Qui = @qui AND Sex = @sex AND Sab = @sab";

                    da = new SQLiteDataAdapter(cmd.CommandText, DbConnection());
                    da.SelectCommand.Parameters.AddWithValue("@sala", reserva.Sala);
                    da.SelectCommand.Parameters.AddWithValue("@turno", reserva.Turno);
                    da.SelectCommand.Parameters.AddWithValue("@dataInicioAgendamento", reserva.DataInicioAgendamento.ToString("yyyy-MM-dd"));
                    da.SelectCommand.Parameters.AddWithValue("@dataFinalAgendamento", reserva.DataFinalAgendamento.ToString("yyyy-MM-dd"));
                    da.SelectCommand.Parameters.AddWithValue("@seg", reserva.ckSeg);
                    da.SelectCommand.Parameters.AddWithValue("@ter", reserva.ckTer);
                    da.SelectCommand.Parameters.AddWithValue("@qua", reserva.ckQua);
                    da.SelectCommand.Parameters.AddWithValue("@qui", reserva.ckQui);
                    da.SelectCommand.Parameters.AddWithValue("@sex", reserva.ckSex);
                    da.SelectCommand.Parameters.AddWithValue("@sab", reserva.ckSab);

                    da.Fill(dt);
                    if (dt.Select().Length == 0)
                        return true;
                }

                return false;
            }
            catch (Exception ex)
            {
                throw ex;
            }

        }
    }
}
