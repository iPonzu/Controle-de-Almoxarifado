using Models;
using Controllers;
using System;

namespace Views{

    public class UpdateProduto : Form{

        public Label labelnome;
        public TextBox txtnome;
        public Label lblpreco;
        public TextBox txtpreco;
        public Button btadd;

        public ProdutoModels produto;

        private void btAdd_Click(object sender, EventArgs e){
            ProdutoModels produtoToEdit = this.produto;
            
        }
    }
}