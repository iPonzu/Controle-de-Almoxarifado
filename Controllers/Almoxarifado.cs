using Models;
using MyData;

namespace Controllers{
    public class Almoxarifado{
        public void Create(Almoxarifado almoxarifado){
            using(var context = new Context()){
                context.Almoxarifados.Add(almoxarifado);
                context.SaveChanges();
            }
        }

        public static List<Almoxarifado> Read(){
            using (var context = new Context()){
                return context.Almoxarifados.ToList();
            }
        }

        public static Almoxarifado ReadById(int id){
            using (var context = new Context()){
                var almoxarifado = context.Almoxarifados.Find(id);
                if (almoxarifado == null)
                {
                    throw new ArgumentException("Almoxarifado não encontrado");
                }
                else
                {
                    return almoxarifado;
                }
            }
        }

        public static void Update(Almoxarifado almoxarifado){
            using (var context = new Context()){
                context.Almoxarifados.Update(almoxarifado);
                context.SaveChanges();
            }
        }

        public static void Delete(Almoxarifado almoxarifado){
            using (var context = new Context()){
                context.Almoxarifados.Remove(almoxarifado);
                context.SaveChanges();
            }
        }
    }
}