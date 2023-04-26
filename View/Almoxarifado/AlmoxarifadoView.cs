using Models;
using Controllers;

namespace Views{
    public class AlmoxarifadoView{
        public enum Option {Update, Delete}

        public class ListAlmoxarifado : Form{
            ListView listAlmoxarifado;

            private void AddToListView(Models.AlmoxarifadoModels a almoxarifado){
                string[] row = {
                    almoxarifado.id_almoxarifado.ToString(),
                    almoxarifado.nome
                };

                ListViewItem item = new ListViewItem(row);
                listAlmoxarifado.Items.Add(item);
            }

            public void RefreshList(){
                listAlmoxarifado.Items.Clear();
                List<Models.AlmoxarifadoModels> almoxarifados = Controllers.AlmoxarifadoController.Read();

                foreach(Models.AlmoxarifadoModels almoxarifado in almoxarifados){
                    AddToListView(almoxarifado);
                }
            }
            private void btcad_Click(object sender, EventArgs e){
                var almoxarifadoCreate = new Views.AlmoxarifadoCreate();
                almoxarifadoCreate.Show();
            }
        }
    }
}