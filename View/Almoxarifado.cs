using Models;
using Controllers;
using System;

namespace Views{
    public class Almoxarifado : Form{
        ListView list;
        public static void almoxarifado(){
        }
        void RefreshList(){
            list.Items.Clear();
            foreach (Models.AlmoxarifadoModels a in Controllers.AlmoxarifadoController()){
                ListViewItem item = new ListViewItem(a.nome);
                list.Items.Add(item);
            }
        }

        public Almoxarifado(){
            Form Almoxarifado = new Form();

            this.Text = "Almoxarifado";
            this.Size = new Size(500, 400);
            this.StartPosition = FormStartPosition.CenterScreen;
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.ShowIcon = false;
            this.ShowInTaskbar = false;

            list = new ListView();
            list.Size = new Size(400, 250);
            list.Location = new Point(50, 50);
            list.View = View.Details;
            list.Columns.Add("Id");
            list.Columns.Add("Nome");

            this.RefreshList();

            Button btCad = new Button();
            btCad.Text = "Cadastrar";
            btCad.Size = new Size(100, 50);
            btCad.Location = new Point(50, 300);
            btCad.Click += (sender, e) => {
                new Cadastrar();
                this.RefreshList();
                this.Show();
                Produto.Almoxarifado();
            };

            Button btEdit = new Button();
            btEdit.Text = "Editar";
            btEdit.Size = new Size(100, 50);
            btEdit.Location = new Point(170, 300);
            btEdit.Click += (sender, e) => {
                new Editar();
                this.Show();
            };

            Button btExcluir = new Button();
            btExcluir.Text = "Excluir";
            btExcluir.Size = new Size(100, 50);
            btExcluir.Location = new Point(350, 300);
            btExcluir.Click += (sender, e) => {
                Excluir.index();
                this.Show();
            }; 

            Button btSair = new Button();
            btSair.Text = "Sair";
            btSair.Size = new Size(100, 30);
            btSair.Location = new Point(530, 300);
            btSair.Click += (sender, e) => {
                this.Close();
            };

            this.Controls.Add(list);
            this.Controls.Add(btCad);
            this.Controls.Add(btEdit);
            this.Controls.Add(btExcluir);
            this.Controls.Add(btSair);
            
            this.ShowDialog();
        }   
    }
}