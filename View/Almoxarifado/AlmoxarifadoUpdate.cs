using Models;
using Controllers;
using static Views.AlmoxarifadoView;

namespace Views{

    public class AlmoxarifadoUpdate : Form{

        public Label lblnome;
        public TextBox txtnome;
        public Button btcd;

        public AlmoxarifadoModels almoxarifado;
        
                
        private void btEdit_Click(object sender, EventArgs e){

            AlmoxarifadoModels almoxarifadoToEdit = this.almoxarifado;
            almoxarifadoToEdit.nome = this.txtnome.Text;
            
            AlmoxarifadoController.Update(almoxarifadoToEdit);
            MessageBox.Show("Almoxarifado foi modificado com sucesso!");

            ListAlmoxarifado listAlmoxarifado = Application.OpenForms.OfType<ListAlmoxarifado>().FirstOrDefault();
            if (almoxarifado != null)
            {
                almoxarifado.RefreshList();
            }
            this.Close();            
        }

        public AlmoxarifadoUpdate(AlmoxarifadoModels almoxarifado){

            this.lblnome = new Label();
            this.lblnome.Text = "Nome";
            this.lblnome.Location = new System.Drawing.Point(10, 40);
            this.lblnome.Size = new System.Drawing.Size(50, 20);

            this.txtnome = new TextBox();
            this.txtnome.Location = new System.Drawing.Point(80, 40);
            this.txtnome.Size = new System.Drawing.Size(150, 20);

            this.btcd = new Button();
            this.btcd.Text = "Cadastrar";
            this.btcd.Location = new System.Drawing.Point(80, 360);
            this.btcd.Size = new System.Drawing.Size(150, 35);
            this.btcd.Click += new EventHandler(this.btEdit_Click);

            this.Controls.Add(this.lblnome);
            this.Controls.Add(this.txtnome);
            this.Controls.Add(this.btcd);
        }
    }
}