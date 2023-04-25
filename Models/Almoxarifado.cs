using System.ComponentModel.DataAnnotations.Schema;

namespace Models
{
    public class AlmoxarifadoModels
    {

        [Column("ID Almoxarifado")]
        [System.ComponentModel.DataAnnotations.Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int id_almoxarifado {get; set;}

        [Column("Nome")]
        public string nome{get; set;}   

        public AlmoxarifadoModels(int id_almoxarifado, string nome)
        {
            this.id_almoxarifado = id_almoxarifado;
            this.nome = nome;
        }
    }
}
