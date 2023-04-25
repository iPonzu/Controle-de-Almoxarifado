using System.ComponentModel.DataAnnotations.Schema;

namespace Models{
    public class Saldo{
        [Column("idSaldo")]
        [System.ComponentModel.DataAnnotations.Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int idSaldo {get;set;}

        [Column("Nome: ")]
        public string nome {get;set;}

        [Column("Almoxarifado")]
        public string almoxarifado {get;set;}

        [Column("Quantidade: ")]
        public string quant {get;set;}

        public Saldo(int idSaldo, string nome, string almoxarifado, string quant){
            this.idSaldo = idSaldo;
            this.nome = nome;
            this.almoxarifado = almoxarifado;
            this.quant = quant;

        }
    }
}