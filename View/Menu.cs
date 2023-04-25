namespace Views{
    public class Menu{
        public static void index(){
            Form menu = new Form();

            menu.Text = "Menu";
            menu.Size = new Size(300,300);
            menu.StartPosition = FormStartPosition.CenterScreen;
            menu.FormBorderStyle = FormBorderStyle.FixedSingle;
            menu.MaximizeBox = false;
            menu.MinimizeBox = false;
            menu.ShowIcon = false;
            menu.ShowInTaskbar = false;

            Button btPt = new Button();
            btPt.Text = "Produto";
            btPt.Size = new Size(100,30);
            btPt.Location = new Point(100,100);
            btPt.Click += (sender, e) =>{
                menu.Hide();
                var listProduto = new ListProduto();
                menu.Show();
            };

            Button btalx = new Button();
            btalx.Text = "Almoxarifado";
            btalx.Size = new Size(100,30);
            btalx.Location = new Point (100,150);
            btalx.Click += (sender, e) =>{
                menu.Hide();
                var listAlmoxarifado = new ListAlmoxarifado();
                listAlmoxarifado.ShowDialog();
                menu.Show();
            };

            Button btsd = new Button();
            btsd.Text = "Saldo";
            btsd.Size = new Size(100,30);
            btsd.Location = new Point(100,200);
            btsd.Click += (sender, e) =>{
                menu.Hide();
                var listsaldo = new Listsaldo();
                listsaldo.ShowDialog();
                menu.Show();
            };
            
            Button sair = new Button();
            sair.Text = "Sair";
            sair.Size = new Size(100,30);
            sair.Location = new Point(100,250);
            sair.Click += (sender, e) =>{
                menu.Close();
            };
            
            menu.Controls.Add(btPt);
            menu.Controls.Add(btalx);
            menu.Controls.Add(btsd);
            menu.Controls.Add(sair);
            menu.ShowDialog();
        }
    }
}