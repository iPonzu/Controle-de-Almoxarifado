using Models;
using Controllers;

namespace Views{

    public class AlmoxarifadoUpdate : Form{

        public Label lblnome;
        public TextBox txtnome;
        public Button btUpdate;

        public AlmoxarifadoModels almoxarifado;

        private void btUpdate_Click(object sender, EventArgs e)
        {
            AlmoxarifadoModels almoxarifadoToUpdate = this.almoxarifado;
            almoxarifadoToUpdate.nome = this.txtnome.Text;

            if
            (
                almoxarifadoToUpdate.nome == ""
            ){

                MessageBox.Show("Preencha o campo corretamente");
                return;
            }
            else
            {
                AlmoxarifadoController.Update(almoxarifadoToUpdate);
                MessageBox.Show("Almoxarifado foi editado com sucesso");
            }

            ListAlmoxarifado AlmoxarifadoList = Application.OpenForms.OfType<ListAlmoxarifado>().FirstOrDefault();
            if (AlmoxarifadoList != null)
            {
                AlmoxarifadoList.RefreshList();
            }
            this.Close();
        }

        public AlmoxarifadoUpdate(AlmoxarifadoModels almoxarifado)
        {
            this.almoxarifado = almoxarifado;

            this.Text = "Editar Almoxarifado";
            this.Size = new System.Drawing.Size(280, 360);
            this.StartPosition = FormStartPosition.CenterScreen;
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.ShowIcon = false;

            this.lblnome = new Label();
            this.lblnome.Text = "Nome";
            this.lblnome.Location = new Point(10, 40);
            this.lblnome.Size = new Size(50, 20);
            this.Controls.Add(this.lblnome);

            this.txtnome = new TextBox();
            this.txtnome.Text = almoxarifado.nome;
            this.txtnome.Location = new System.Drawing.Point(80, 40);
            this.txtnome.Size = new System.Drawing.Size(150, 20);
            this.Controls.Add(this.txtnome);

            this.btUpdate = new Button();
            this.btUpdate.Text = "Editar";
            this.btUpdate.Location = new System.Drawing.Point(80, 260);
            this.btUpdate.Size = new System.Drawing.Size(150, 35);
            this.btUpdate.Click += new EventHandler(btUpdate_Click);
            this.Controls.Add(this.btUpdate);
        }
    }
}