using Controllers;
using Models;

namespace Views{

    public class AlmoxarifadoCreate : Form
    {
        public Label lblnome;
        public TextBox txtnome;
        public Button btcadt;

        public void btcadt_Click(object sender, EventArgs e)
        {
            if(

                txtnome.Text == ""
            ){
                MessageBox.Show("Preencha o campo corretamente");
                return;
            }else
            {
                Models.AlmoxarifadoModels almoxarifado = new AlmoxarifadoModels(
                    txtnome.Text
                );

                AlmoxarifadoController almoxarifadoController = new AlmoxarifadoController();
                almoxarifadoController.Create(almoxarifado);

                MessageBox.Show("Almoxarifado cadastrado com sucesso");
            }
            
            ListAlmoxarifado AlmoxarifadoList = Application.OpenForms.OfType<ListAlmoxarifado>().FirstOrDefault();
            if(AlmoxarifadoList != null)
            {
                AlmoxarifadoList.RefreshList();
            }
            this.Close();
        }

        private void ClearForm()
        {
            txtnome.Clear();
        }

        public AlmoxarifadoCreate()
        {
            this.Text = "Registrar Almoxarifado";
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

            this.btcadt = new Button();
            this.btcadt.Text = "Cadastrar";
            this.btcadt.Location = new Point(10, 130);
            this.btcadt.Size = new Size(50, 20);

            this.Controls.Add(this.lblnome);
            this.Controls.Add(this.txtnome);
            this.Controls.Add(this.btcadt);
        }
    }
}