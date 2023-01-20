using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CrudMySql.Models
{
	//Criação da Tabela
    [Table("Produto")]

    public class Produto
    {
		//Criação das colunas
        [Display(Name = "Código")]
        [Column("Id")]
        public int Id { get; set; }


        [Display(Name = "Nome")]
        [Column("Nome")]

        public string Nome { get; set; }


   






    }
}
