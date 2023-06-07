using System.ComponentModel.DataAnnotations.Schema;

namespace Models{
    public class SaldoModels{


        [Column("ID Saldo")]
        [System.ComponentModel.DataAnnotations.Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int id_saldo {get;set;}

        [Column("ID do Produto: ")]
        public int id_Produto {get;set;}

        [Column("Almoxarifado")]
        public int almoxarifado {get;set;}

        [Column("Quantidade: ")]
        public int quant {get;set;}

        public SaldoModels(int id_Produto, int almoxarifado, int quant){
            this.id_saldo = id_saldo;
            this.id_Produto = id_Produto;
            this.almoxarifado = almoxarifado;
            this.quant = quant;

        }
    }
}