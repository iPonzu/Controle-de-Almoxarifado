using System;
using Models;
using Controllers;

namespace Views
{
    public class Produto : Form
    {
        ListView list;
        public int selectedAlmoxarifadoId = -1;

        public Produto()
        {
            Form Produto = new Form();

            this.Text = "Produto";
            this.Size = new Size(500, 400);
            this.StartPosition = FormStartPosition.CenterScreen;
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            this.MinimizeBox = false;
            this.MaximizeBox = false;
            this.ShowIcon = false;
            this.ShowInTaskbar = false;

            list = new ListView();
            list.Size = new Size(400, 250);
            list.Location = new Point(50, 50);
            list.View = Views.Details;
            list.Columns.Add("Id");
            list.Columns.Add("Nome");
            list.Columns.Add("Preço");
            list.Columns[0].Width = 30;
            list.Columns[1].Width = 80;
            list.Columns[2].Width = 100;
            list.FullRowSelect = true;
            list.SelectedIndexChanged += new EventHandler(list_SelectedIndexChanged);
            this.Controls.Add(list);

            this.Refresh();

            Button btdAdd = new Button();
            btdAdd.Text = "Adicionar";
            btdAdd.Size = new Size(100, 30);
            btdAdd.Location = new Point(50, 300);
            btdAdd.Click += new EventHandler(btdAdd_Click);
            this.Controls.Add(btdAdd);

            Button btdEdit = new Button();
            btdEdit.Text = "Editar";
            btdEdit.Size = new Size(100, 30);
            btdEdit.Location = new Point(170, 300);
            btdEdit.Click += new EventHandler(btdEdit_Click);
            this.Controls.Add(btdEdit);

            Button btdDelete = new Button();
            btdDelete.Text = "Excluir";
            btdDelete.Size = new Size(100, 30);
            btdDelete.Location = new Point(350, 300);
            btdDelete.Click += new EventHandler(btdDelete_Click);
            this.Controls.Add(btdDelete);

            Button btdSair = new Button();
            btdSair.Text = "Sair";
            btdSair.Size = new Size(100, 30);
            btdSair.Location = new Point(450, 300);
            btdSair.Click += new EventHandler(btdSair_Click);
            this.Controls.Add(btdSair);

            this.ShowDialog();
        }
    }
}