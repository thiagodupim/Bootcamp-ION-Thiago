using Dapper;
using System;
using System.Data.SQLite;
using System.IO;
using System.Linq;


namespace Tarefas.DAO
{
    public class TarefaDAO
    {
        public string DataSourceFile => Environment.CurrentDirectory + "TarefasDB.sqlite";
        public SQLiteConnection Connection => new SQLiteConnection("DataSource=" + DataSourceFile);

        public TarefaDAO()
        {
            if (!File.Exists(DataSourceFile))
            {
                CreateDatabase();
            }
        }

        public void CreateDatabase() 
            {
                using (var con = Connection)
                {
                con.Open();
                con.Execute(
                    @"CREATE TABLE Tarefa
                    (
                        id integer primary key autoincrement,
                        Titulo varchar(100) not null,
                        Descricao varchar(100) not null
                    )"
                );
            }
        }
    }
}