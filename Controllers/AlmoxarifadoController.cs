using Models;
using MyData;

namespace Controllers{
    public class AlmoxarifadoController{
        public void Create(string nome){
            if(nome == null || nome.Length == 0){
                throw new Exception("Nome inválido");
            }
            new AlmoxarifadoModels(nome);
        }
        public void Update(string idRef, string nome){
            int id = 0;
            try{
                id = int.Parse(idRef);
            }catch(Exception e){
                throw new Exception ("ID Inválido");
            }
            AlmoxarifadoModels almoxarifado = AlmoxarifadoModels.ReadById(id);
            if(nome == null || nome.Length == 0){
                throw new Exception("Nome inválido");
            }
            if(id != null && id > 0 || nome == null || nome.Length > 0){
                almoxarifado.Nome = nome;
                almoxarifado.Id = id;
            }
            AlmoxarifadoModels.Update(almoxarifado);
        }
        public static List<AlmoxarifadoModels> Read(){
            return AlmoxarifadoModels.Read();
        }
        public static AlmoxarifadoModels ReadById(int id){
            return AlmoxarifadoModels.ReadById(id);
        }
    }
}