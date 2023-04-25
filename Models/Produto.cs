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
        public float Preço {get;set;}

        public ProdutoModels(int id, string Nome, float Preço){
            this.id = id;
            this.Nome = Nome;
            this.Preço = Preço;
        }
    }
}