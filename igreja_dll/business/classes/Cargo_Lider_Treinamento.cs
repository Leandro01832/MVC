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

    [Table("Lider_treinamento")]    
    public class Cargo_Lider_Treinamento 
    {
        [Key, ForeignKey("Pessoa")]
        public int Lidertreinamentoid { get; set; }

        public virtual Pessoa Pessoa { get; set; }        

        public Cargo_Lider_Treinamento()
        {
           // bd = new BDcomum();
        }

        /// <summary>
        /// contrutor para buscar lider por treinamento atraves do id
        /// </summary>
        /// <param name="id"></param>
        public Cargo_Lider_Treinamento(int id)
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
