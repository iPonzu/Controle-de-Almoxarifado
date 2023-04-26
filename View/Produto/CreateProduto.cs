using Models;
using Controllers;
using static Views.ProdutoView;

namespace Views{

    public class ProdutoCreate : Form{

        public Label lblnome;
        public TextBox txtnome;
        public Label lblpreco;
        public TextBox txtpreco;
        public Button btadd;

        public void btadd_Click(object sender, EventArgs e){
            if(
                txtnome.Text == "" ||
                txtpreco.Text == ""
            ){
                MessageBox.Show("Preencha o nome deve ser informado");
                return;
            }else{
                Models.ProdutoModels produto = new ProdutoModels(
                    txtnome.Text,
                    txtpreco.Text
                );

                ProdutoController produtoController = new ProdutoController();
                ProdutoController.Create(produto);

                MessageBox.Show("Produto criado com sucesso");
                ClearForm();
            }

            ListProduto listProduto = Application.OpenForms.OfType<ListProduto>().FirstOrDefault();
            if(listProduto!= null)
            {
                listProduto.RefreshList();
            }

            this.Close();
        }

        private void ClearForm(){
            txtnome.Clear();
            txtpreco.Clear();
        }

        public ProdutoCreate(){
            this.lblnome = new Label();
            this.lblnome.Text = "Nome";
            this.lblnome.Location = new System.Drawing.Point(10, 40);
            this.lblnome.Size = new System.Drawing.Size(50, 20);

            this.txtnome = new TextBox();
            this.txtnome.Location = new System.Drawing.Point(80, 40);
            this.txtnome.Size = new System.Drawing.Size(150, 20);

            this.lblpreco = new Label();
            this.lblpreco.Text = "Preco";
            this.lblpreco.Location = new System.Drawing.Point(10, 70);
            this.lblpreco.Size = new System.Drawing.Size(50, 20);

            this.txtpreco = new TextBox();
            this.txtpreco.Location = new System.Drawing.Point(80, 70);
            this.txtpreco.Size = new System.Drawing.Size(150, 20);
 
            this.btadd = new Button();
            this.btadd.Text = "Adicionar";
            this.btadd.Location = new System.Drawing.Point(80, 260);
            this.btadd.Size = new System.Drawing.Size(150, 35);
            this.btadd.Click += new EventHandler(this.btadd_Click);
        }
    }
}