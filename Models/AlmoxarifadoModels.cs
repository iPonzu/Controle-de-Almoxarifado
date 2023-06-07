using System.ComponentModel.DataAnnotations.Schema;
using MyData;

namespace Models
{
    public class AlmoxarifadoModels
    {

        [Column("ID Almoxarifado")]
        [System.ComponentModel.DataAnnotations.Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id {get; set;}

        [Column("Nome")]
        public string Nome{get; set;}   

        public AlmoxarifadoModels(string nome)
        {
            this.Nome = nome;

            this.Create(this);
        }
        public AlmoxarifadoModels(){}

        public void Create(AlmoxarifadoModels almoxarifado){
            using(var context = new Context()){
                context.Almoxarifados.Add(almoxarifado);
                context.SaveChanges();
            }
        }
        public static List<AlmoxarifadoModels> Read(){
            using(var context = new Context()){
                return context.Almoxarifados.ToList();
            }
        }
        public static AlmoxarifadoModels ReadById(int id){
            using(var context = new Context()){
                var almoxarifado = context.Almoxarifados.Find(id);
                return almoxarifado;
            }
        }
        public static AlmoxarifadoModels Update(AlmoxarifadoModels almoxarifado){
            using(var context = new Context()){
                context.Almoxarifados.Update(almoxarifado);
                context.SaveChanges();

                return almoxarifado;
            }
        }
    }
}