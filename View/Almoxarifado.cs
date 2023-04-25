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
                ListViewItem item = new ListViewItem(a.Nome);
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

            Button btdCad = new Button();
            btdCad.Text = "Cadastrar";
            btdCad.Size = new Size(100, 50);
            btdCad.Location = new Point(50, 300);
            btdCad.Click += (sender, e) => {
                new Cadastrar();
                this.RefreshList();
                this.Show();
                Produto.Almoxarifado();
            };

            Button btdEdit = new Button();
            btdEdit.Text = "Editar";
            btdEdit.Size = new Size(100, 50);
            btdEdit.Location = new Point(170, 300);
            btdEdit.Click += (sender, e) => {
                new Editar();
                this.Show();
            };

            Button btdExcluir = new Button();
            btdExcluir.Text = "Excluir";
            btdExcluir.Size = new Size(100, 50);
            btdExcluir.Location = new Point(350, 300);
            btdExcluir.Click += (sender, e) => {
                Excluir.index();
                this.Show();
            }; 

            Button btdSair = new Button();
            btdSair.Text = "Sair";
            btdSair.Size = new Size(100, 30);
            btdSair.Location = new Point(530, 300);
            btdSair.Click += (sender, e) => {
                this.Close();
            };

            this.Controls.Add(list);
            this.Controls.Add(btdCad);
            this.Controls.Add(btdEdit);
            this.Controls.Add(btdExcluir);
            this.Controls.Add(btdSair);
            
            this.ShowDialog();
        }   
    }
}