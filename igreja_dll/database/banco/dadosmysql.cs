using MySql.Data.MySqlClient;
using System.Collections;
using System.Data;

namespace database.banco
{
   public class dadosmysql
    {
        public MySqlConnection conectar()
        {
            MySqlConnection conexao = new MySqlConnection(@"Server=MYSQL5015.site4now.net;Database =db_a44135_biblia;Uid =a44135_biblia;Pwd=Manequim1991");

            return conexao;
        }

        public DataTable listar(string comand, bool semsupervisor, bool semcelula, bool listarpessoas, string id)
        {
            if (semsupervisor)
            {
                comand = "select * from celula left join supervisor_celula on id_celula=super_celula " +
                    " where super_celula is null";
            }

            if (listarpessoas)
            {
                comand = "select * from pessoa left join celula_pessoa on pes_id=cel_pessoa " +
                    " inner join celula on id_celula=pes_celula where cel_pessoa is not null and id_celula='@id'";
                comand = comand.Replace("@id", id);
            }

            if (semcelula)
            {
                comand = "select * from pessoa left join celula_pessoa on pes_id=cel_pessoa where cel_pessoa is  null";
            }

            DataTable dtable = new DataTable();
            MySqlCommand comando = new MySqlCommand(comand, conectar());
            MySqlDataAdapter objadp = new MySqlDataAdapter(comando);
            objadp.Fill(dtable);

            foreach (DataRow dtrow in dtable.Rows)
            {
                ArrayList lista = new ArrayList();
                lista.Add(dtrow);
                //exibe os registros no listbox
                //  list.Items.Add(dtrow.ItemArray[0]);
            }

            return dtable;
        }
    }
}
