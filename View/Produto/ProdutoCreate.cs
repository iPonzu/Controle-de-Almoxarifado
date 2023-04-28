using Controllers;
using Models;

namespace Views{

    public class ProdutoCreate : Form
    {
        public Label lblnome;
        public TextBox txtnome;
        public Label lblpreco;
        public TextBox txtpreco;
        public Button btCadt;

        public void btCadt_Click(object sender, EventArgs e)
        {
            if(
                txtnome.Text == "" ||
                txtpreco.Text == ""
            ){
                MessageBox.Show("Preencha corretamente os campos");
                return;
            }else
            {
                Models.ProdutoModels produto = new ProdutoModels(
                    txtnome.Text,
                    txtpreco.Text
                );

                ProdutoController produtoController = new ProdutoController();

                MessageBox.Show("Produto cadastrado com sucesso");
                ClearForm();
            }

            ListProduto ProdutoList = Application.OpenForms.OfType<ListProduto>().FirstOrDefault();
            if(ProdutoList!= null)
            {
                ProdutoList.RefreshList();
            }
            this.Close();
        }

        private void ClearForm()
        {
            txtnome.Clear();
            txtpreco.Clear();
        }

        public ProdutoCreate()
        {
            this.Text = "Registrar Produto";
            this.StartPosition = FormStartPosition.CenterScreen;
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.Size = new System.Drawing.Size(280, 360);

            this.lblnome = new Label();
            this.lblnome.Text = "Nome";
            this.lblnome.Location = new Point(10, 40);
            this.lblnome.Size = new Size(50, 20);

            this.txtnome = new TextBox();
            this.txtnome.Location = new Point(80, 40);
            this.txtnome.Size = new Size(150, 20);

            this.lblpreco = new Label();
            this.lblpreco.Text = "Preço";
            this.lblpreco.Location = new Point(10, 70);
            this.lblpreco.Size = new Size(50, 20);

            this.txtpreco = new TextBox();
            this.txtpreco.Location = new Point(80, 70);
            this.txtpreco.Size = new Size(150, 20);

            this.btCadt = new Button();
            this.btCadt.Text = "Cadastrar";
            this.btCadt.Location = new Point(10, 130);
            this.btCadt.Size = new Size(50, 20);

            this.Controls.Add(this.lblnome);
            this.Controls.Add(this.txtnome);
            this.Controls.Add(this.lblpreco);
            this.Controls.Add(this.txtpreco);
            this.Controls.Add(this.btCadt);
        }
    }
}