using database.banco;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Data;
using System.Collections;

namespace business.classes
{
    [Table("Historico")]
   public class Historico : modelocrud<Historico>
    {
        
        private int id;
        private DateTime data_inicio;        
        private int falta;
        

        [Key]
        public int historicoid
        {
            get
            {
                return id;
            }

            set
            {
                id = value;
            }
        }

        public DateTime Data_inicio
        {
            get
            {
                return data_inicio;
            }

            set
            {
                data_inicio = value;
            }
        }

        public int pessoaid { get; set; }

        [ForeignKey("pessoaid")]
        public virtual Pessoa Pessoa { get; set; }

        public int Falta
        {
            get
            {
                return falta;
            }

            set
            {
                falta = value;
            }
        }               

        public Historico()
        {
            bd = new BDcomum();
        }

        public override string alterar()
        {
            throw new NotImplementedException();
        }

        public override string excluir()
        {
            throw new NotImplementedException();
        }

        public override Historico recuperar(int id)
        {
            throw new NotImplementedException();
        }

        public override string salvar()
        {
            
            insert_padrao = "insert into historico (Data_inicio, Data_fim, Falta, IDENT_CURRENT('Pessoa'))" +
            " values (@data_inicio, @data_fim, @falta)";
            Insert = insert_padrao.Replace("@data_inicio", Data_inicio.ToString());           
            Insert = Insert.Replace("@falta", falta.ToString());
            return bd.montar_sql(Insert, null, null);
        }     

        public override IEnumerable<Historico> recuperartodos()
        {
            throw new NotImplementedException();
        }
    }
}
