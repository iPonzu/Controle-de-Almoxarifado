using System;
using Models;

namespace Controllers{
    public class Almoxarifado{
        public void Create(Almoxarifado almoxarifado){
            using (var context = new AlmoxarifadoContext()){
                context.Almoxarifado.add(almoxarifado);
                context.SaveChanges();
            }
        }
        public static List<Almoxarifado> Read(){
            using (var context = new Almoxarifado()){
                return context.Almoxarifado.ToList();
            }
        }
        public static Almoxarifado ReadById(int id){
            using (var context = new AlmoxarifadoContext()){
                var almoxarifado = context.Almoxarifado.Find(id);
                if (almoxarifado == null){
                    throw new ArgumentException ("Almoxarifado não encontrado");
                } else{
                    return almoxarifado;
                }
            }
        }

        public static void Delete(Almoxarifado almoxarifado){
            using (var context = new AlmoxarifadoContext()){
                context.Almoxarifado.Remove(almoxarifado);
                context.SaveChanges();
            }
        }
        public static void Update(Almoxarifado almoxarifado){
            using (var context = new AlmoxarifadoContext()){
                context.Almoxarifado.Update(almoxarifado);
                context.SaveChanges();
            }
        }
    }
}

