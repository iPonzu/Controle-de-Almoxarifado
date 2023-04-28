using Models;
using Controllers;

namespace Views{

    public class SaldoUpdate : Form{

        public Label lblid_Produto;
        public TextBox txtid_Produto;
        public Label lblalmoxarifado;
        public TextBox txtalmoxarifado;
        public Label lblquant;
        public TextBox txtquant;
        public Button btUpdate;


        public SaldoModels saldo;

        private void btUpdate_Click(object sender, EventArgs e)
        {
            SaldoModels saldoToUpdate = this.saldo;
            saldoToUpdate.id_Produto = Convert.ToInt32(this.txtid_Produto.Text);
            saldoToUpdate.almoxarifado = Convert.ToInt32(this.txtalmoxarifado.Text);
            saldoToUpdate.quant = Convert.ToInt32(this.txtquant.Text);

            if
            (
                saldoToUpdate.id_Produto.ToString() == "" ||
                saldoToUpdate.almoxarifado.ToString() == "" ||
                saldoToUpdate.quant.ToString() == ""
            )
                {
                    MessageBox.Show("Preencha corretamente os campos");
                    return;
                }
                else
                {
                    SaldoController.Update(saldoToUpdate);
                    MessageBox.Show("Saldo foi editado com sucesso");
                }

                ListSaldo SaldoList = Application.OpenForms.OfType<ListSaldo>().FirstOrDefault();
                if (SaldoList != null)
                {
                    SaldoList.RefreshList();
                }
                this.Close();
        }

        public SaldoUpdate(SaldoModels saldo)
        {
            this.saldo = saldo;

            this.Text = "Editar Saldo";
            this.Size = new System.Drawing.Size(280, 360);
            this.StartPosition = FormStartPosition.CenterScreen;
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.ShowIcon = false;

            this.lblid_Produto = new Label();
            this.lblid_Produto.Text = "Id do Produto";
            this.lblid_Produto.Location = new Point(10, 40);
            this.lblid_Produto.Size = new Size(50, 20);
            this.Controls.Add(this.lblid_Produto);

            this.txtid_Produto = new TextBox();
            this.txtid_Produto.Text = saldo.id_Produto.ToString();
            this.txtid_Produto.Location = new System.Drawing.Point(80, 40);
            this.txtid_Produto.Size = new System.Drawing.Size(150, 20);
            this.Controls.Add(this.txtid_Produto);

            this.lblalmoxarifado = new Label();
            this.lblalmoxarifado.Text = "Almoxarifado";
            this.lblalmoxarifado.Location = new Point(10, 70);
            this.lblalmoxarifado.Size = new Size(50, 20);
            this.Controls.Add(this.lblalmoxarifado);

            this.txtalmoxarifado = new TextBox();
            this.txtalmoxarifado.Text = saldo.almoxarifado.ToString();
            this.txtalmoxarifado.Location = new System.Drawing.Point(80, 70);
            this.txtalmoxarifado.Size = new System.Drawing.Size(150, 20);
            this.Controls.Add(this.txtalmoxarifado);

            this.lblquant = new Label();
            this.lblquant.Text = "Quantidade";
            this.lblquant.Location = new Point(10, 100);
            this.lblquant.Size = new Size(50, 20);
            this.Controls.Add(this.lblquant);

            this.txtquant = new TextBox();
            this.txtquant.Text = saldo.quant.ToString();
            this.txtquant.Location = new System.Drawing.Point(80, 100);
            this.txtquant.Size = new System.Drawing.Size(150, 20);
            this.Controls.Add(this.txtquant);

            this.btUpdate = new Button();
            this.btUpdate.Text = "Editar";
            this.btUpdate.Location = new System.Drawing.Point(80, 260);
            this.btUpdate.Size = new System.Drawing.Size(150, 35);
            this.btUpdate.Click += new EventHandler(btUpdate_Click);
            this.Controls.Add(this.btUpdate);
        }
    }
}