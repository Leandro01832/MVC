using business.classes;
using database.banco;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace business.classes
{

    [Table("Lider")]    
    public class Cargo_Lider 
    {
        [Key, ForeignKey("Pessoa")]
        public int Liderid { get; set; }

        public virtual Pessoa Pessoa { get; set; }        

        public Cargo_Lider()
        {
           // bd = new BDcomum();
        }
        
        /// <summary>
        /// contrutor para buscar lider atraves do id
        /// </summary>
        /// <param name="id"></param>
        public Cargo_Lider(int id)
        {
           // bd = new BDcomum();
           // recuperar(id);
        }

        //public override string salvar()
        //{
        //    return base.salvar();
        //}

        //public override bool recuperar(int id)
        //{
        //    return base.recuperar(id);
        //}

        //public override string excluir()
        //{
        //    return base.excluir();
        //}

        //public override string alterar()
        //{
        //    return base.alterar();
        //}

        //public override IEnumerable<Pessoa> recuperartodos()
        //{
        //    return base.recuperartodos();
        //}
    }
}
