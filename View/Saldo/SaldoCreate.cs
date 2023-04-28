using Controllers;
using Models;

namespace Views{

    public class SaldoCreate : Form
    {
        public Label lblid_Produto;
        public TextBox txtid_Produto;
        public Label lblalmoxarifado;
        public TextBox txtalmoxarifado;
        public Label lblquant;
        public TextBox txtquant;
        public Button btCadt;

        public void btCadt_Click(object sender, EventArgs e)
        {
            if(
                txtid_Produto.Text == "" ||
                txtalmoxarifado.Text == "" ||
                txtquant.Text == "" 
            ){
                MessageBox.Show("Preencha corretamente os campos");
                return;
            }else
            {
                Models.SaldoModels saldo = new SaldoModels(
                    Convert.ToInt32(txtid_Produto.Text),
                    Convert.ToInt32(txtalmoxarifado.Text),
                    Convert.ToInt32(txtquant.Text)
                );

                SaldoController saldoController = new SaldoController();
                MessageBox.Show("Saldo cadastrado com sucesso");
                ClearForm();
            }

            ListSaldo SaldoList = Application.OpenForms.OfType<ListSaldo>().FirstOrDefault();
            if(SaldoList!= null)
            {
                SaldoList.RefreshList();
            }
            this.Close();
        }

        private void ClearForm()
        {
            txtid_Produto.Clear();
            txtalmoxarifado.Clear();
            txtquant.Clear();
        }

        public SaldoCreate()
        {
            this.Text = "Registrar Saldo";
            this.StartPosition = FormStartPosition.CenterScreen;
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.Size = new System.Drawing.Size(280, 360);

            this.lblid_Produto = new Label();
            this.lblid_Produto.Text = "Nome";
            this.lblid_Produto.Location = new Point(10, 40);
            this.lblid_Produto.Size = new Size(50, 20);

            this.txtid_Produto = new TextBox();
            this.txtid_Produto.Location = new Point(80, 40);
            this.txtid_Produto.Size = new Size(150, 20);

            this.lblalmoxarifado = new Label();
            this.lblalmoxarifado.Text = "Almoxarifado";
            this.lblalmoxarifado.Location = new Point(10, 70);
            this.lblalmoxarifado.Size = new Size(50, 20);

            this.txtalmoxarifado = new TextBox();
            this.txtalmoxarifado.Location = new Point(80, 70);
            this.txtalmoxarifado.Size = new Size(150, 20);

            this.lblquant = new Label();
            this.lblquant.Text = "Quantidade";
            this.lblquant.Location = new Point(10, 100);
            this.lblquant.Size = new Size(50, 20);

            this.txtquant = new TextBox();
            this.txtquant.Location = new Point(80, 100);
            this.txtquant.Size = new Size(70, 20);

            this.btCadt = new Button();
            this.btCadt.Text = "Cadastrar";
            this.btCadt.Location = new Point(10, 130);
            this.btCadt.Size = new Size(50, 20);

            this.Controls.Add(this.lblid_Produto);
            this.Controls.Add(this.txtid_Produto);
            this.Controls.Add(this.lblalmoxarifado);
            this.Controls.Add(this.txtalmoxarifado);
            this.Controls.Add(this.lblquant);
            this.Controls.Add(this.txtquant);
            this.Controls.Add(this.btCadt);
        }
    }
}