using System.ComponentModel.DataAnnotations.Schema;

namespace Models{
    public class ProdutoModels{
        [Column("ID do Produto")]
        [System.ComponentModel.DataAnnotations.Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int id { get; set; }

        [Column("Nome: ")]
        public string Nome {get;set;}

        [Column("Preço: ")]
        public string Preco {get;set;}

        public ProdutoModels(string Nome, string Preco){
            this.Nome = Nome;
            this.Preco = Preco;
        }
    }
}