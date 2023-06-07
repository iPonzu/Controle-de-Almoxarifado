using System.ComponentModel.DataAnnotations.Schema;

namespace Models{
    public class ProdutoModels{
        [Column("ID do Produto")]
        [System.ComponentModel.DataAnnotations.Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int id { get; set; }

        [Column("Nome: ")]
        public string nome {get;set;}

        [Column("Preço: ")]
        public string preco {get;set;}

        public ProdutoModels(string nome, string preco){
            this.nome = nome;
            this.preco = preco;
        }
    }
}