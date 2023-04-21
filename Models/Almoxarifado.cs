using System.ComponentModel.DataAnnotations.Schema;

namespace Models{
    public class Almoxarifado{

        [Column("ID Almoxarifado")]
        [System.ComponentModel.DataAnnotations.Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int id_almoxarifado {get;set;}

        [Column("Nome")]
        public string nome_produto {get;set;}
        

        public Almoxarifado(int id_almoxarifado, string nome_produto){
            this.id_almoxarifado = id_almoxarifado;
            this.nome_produto = nome_produto;
        }
    }
}