using Models;
using Controllers;
using static Views.AlmoxarifadoView;

namespace Views{

    public class AlmoxarifadoCreate : Form{
       public Label lblnome;
       public TextBox txtnome;
       public Button btcd;

        public void btcd_Click(object sender, EventArgs e){
        if(
            txtnome.Text == "" 
        ){
            MessageBox.Show("Preencha corretamente os campos");
            return;
        }else{

            Models.AlmoxarifadoModels almoxarifado = new AlmoxarifadoModels(
                txtnome.Text
            );

            AlmoxarifadoController almoxarifadoController = new AlmoxarifadoController();
            almoxarifadoController.Create(almoxarifado);

            MessageBox.Show("Almoxarifado cadastrado com sucesso");
            ClearForm();
        }

        ListAlmoxarifado listAlmoxarifado = Application.OpenForms.OfType<ListAlmoxarifado>().FirstOrDefault();
        if(listAlmoxarifado!= null){
            listAlmoxarifado.RefreshList();
        }
            this.Close();
        }

        private void ClearForm(){
            txtnome.Clear();
        }

        public AlmoxarifadoCreate(){
            this.lblnome = new Label();
            this.lblnome.Text = "Nome";
            this.lblnome.Location = new System.Drawing.Point(10, 70);
            this.lblnome.Size = new System.Drawing.Size(50, 20);

            this.txtnome = new TextBox();
            this.txtnome.Location = new System.Drawing.Point(80, 70);
            this.txtnome.Size = new System.Drawing.Size(150, 20);

            this.btcd = new Button();
            this.btcd.Text = "Cadastrar";
            this.btcd.Location = new System.Drawing.Point(80, 360);
            this.btcd.Size = new System.Drawing.Size(150, 35);
            this.btcd.Click += new EventHandler(this.btcd_Click);

            this.Controls.Add(this.lblnome);
            this.Controls.Add(this.txtnome);
            this.Controls.Add(this.btcd);
            
        }
    }

}
