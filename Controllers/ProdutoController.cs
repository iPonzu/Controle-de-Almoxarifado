using Models;
using MyData;

namespace Controllers{

    public class ProdutoController{

        public static void Create(ProdutoModels produto){
            using (var context = new Context()){
                context.Produtos.Add(produto);
                context.SaveChanges();
            }
        }

        public static List<ProdutoModels> Read(){
            using (var context = new Context()){
                return context.Produtos.ToList();
            }
        }

        public static ProdutoModels ReadById(int id){
            using (var context = new Context()){
                var produto = context.Produtos.Find(id);
                if (produto == null){
                    throw new ArgumentException("Produto não encontrado");
                }
                else{
                    return produto;
                }
            }
        }

        public static void Update(ProdutoModels produto){
            using (var context = new Context()){
                context.Produtos.Update(produto);
                context.SaveChanges();
            }
        }

        public static void Delete(ProdutoModels produto){
            using (var context = new Context()){
                context.Produtos.Remove(produto);
                context.SaveChanges();
            }
        }
    }
}