using Models;
using MyData;

namespace Controllers{
    public class Saldo{
        public void Create(Saldo saldo){
            using(var context = new Context()){
                context.Saldos.Add(saldo);
                context.SaveChanges();
            }
        }

        public static List<Saldo> Read(){
            using (var context = new Context()){
                return context.Saldos.ToList();
            }
        }

        public static Saldo ReadById(int id){
            using (var context = new Context()){
                var Saldo = context.Saldos.Find(id);
                if (Saldo == null)
                {
                    throw new ArgumentException("Saldo não encontrado");
                }
                else
                {
                    return Saldo;
                }
            }
        }

        public static void Update(Saldo saldo){
            using (var context = new Context()){
                context.Saldos.Update(saldo);
                context.SaveChanges();
            }
        }

        public static void Delete(Saldo saldo){
            using (var context = new Context()){
                context.Saldos.Remove(saldo);
                context.SaveChanges();
            }
        }
    }
}