using Models;
using MyData;

namespace Controllers{
    public class SaldoController{
        public void Create(SaldoModels saldo){
            using(var context = new Context()){
                context.Saldos.Add(saldo);
                context.SaveChanges();
            }
        }

        public static List<SaldoModels> Read(){
            using (var context = new Context()){
                return context.Saldos.ToList();
            }
        }

        public static SaldoModels ReadById(int id){
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

        public static void Update(SaldoModels saldo){
            using (var context = new Context()){
                context.Saldos.Update(saldo);
                context.SaveChanges();
            }
        }

        public static void Delete(SaldoModels saldo){
            using (var context = new Context()){
                context.Saldos.Remove(saldo);
                context.SaveChanges();
            }
        }
    }
}