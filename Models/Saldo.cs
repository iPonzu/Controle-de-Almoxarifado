using System.ComponentModel.DataAnnotations.Schema;

namespace Models{
    public class SaldoModels{
        [Column("ID Saldo")]
        [System.ComponentModel.DataAnnotations.Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int id_saldo {get;set;}

        [Column("Nome: ")]
        public string nome {get;set;}

        [Column("Almoxarifado")]
        public string almoxarifado {get;set;}

        [Column("Quantidade: ")]
        public string quant {get;set;}

        public SaldoModels(int id_saldo, string nome, string almoxarifado, string quant){
            this.id_saldo = id_saldo;
            this.nome = nome;
            this.almoxarifado = almoxarifado;
            this.quant = quant;

        }
    }
}