using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using database.banco;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data;
using System.Collections;

namespace business.classes
{
    [Table("Telefone")]   
    public class Telefone : modelocrud<Telefone>
    {
        
        private int    id;
        private string fone;
        private string celular;
        private string whatsapp;
        
        

        public string Fone
        {
            get
            {
                return fone;
            }

            set
            {
                fone = value;
            }
        }

        public string Celular
        {
            get
            {
                return celular;
            }

            set
            {
                celular = value;
            }
        }

        public string Whatsapp
        {
            get
            {
                return whatsapp;
            }

            set
            {
                whatsapp = value;
            }
        }

        [Key, ForeignKey("Pessoa")]
        public int telefoneid
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

        public virtual Pessoa Pessoa { get; set; }

        

        public Telefone()
        {
            bd = new BDcomum();
        }

        public override string alterar(int id)
        {
            throw new NotImplementedException();            
        }

        public override string excluir(int id)
        {
            throw new NotImplementedException();
        }

        public override Telefone recuperar(int id)
        {
            throw new NotImplementedException();
        }

        public override string salvar()
        {
            insert_padrao =
        "insert into telefone (Fone, Celular, Whatsapp, telefoneid) values ('@telefone', '@celular', '@whatsapp', IDENT_CURRENT('Pessoa')) ";           
           
            Insert = insert_padrao.Replace("@telefone", Fone);
            Insert = Insert.Replace("@celular", Celular);
            Insert = Insert.Replace("@whatsapp", Whatsapp);

            return Insert;
        }

      

        public override IEnumerable<Telefone> recuperartodos()
        {
            throw new NotImplementedException();
        }
    }
}
