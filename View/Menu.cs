namespace View
{
    public class Menu{
        
        public static void index(){
            Form menu = new Form();
            
            menu.Text = "Menu";
            menu.Size = new Size(300, 300);
            menu.StartPosition = FormStartPosition.CenterScreen;
            menu.FormBorderStyle = FormBorderStyle.FixedSingle;
            menu.MaximizeBox = false;
            menu.MinimizeBox = false;
            menu.ShowIcon = false;
            menu.ShowInTaskbar = false;

            Button btPt = new Button();
            btPt.Text = "Produto";
            btPt.Size = new Size(100, 30);
            btPt.Location = new Point(100, 100);
            btPt.Click += (sender, e) => {
                menu.Hide();
                menu.Show();
            };

            Button btAmx = new Button();
            btAmx.Text = "Almoxarifado";
            btAmx.Size = new Size(100, 30);
            btAmx.Location = new Point(100, 150);
            btAmx.Click += (sender, e) => {
                menu.Hide();
            //    new Almoxarifado();
                menu.Show();
            };

            Button btSd = new Button();
            btSd.Text = "Saldo";
            btSd.Size = new Size(100, 30);
            btSd.Location = new Point(100, 200);

            Button sair = new Button();
            sair.Text = "Sair";
            sair.Size = new Size(100, 30);
            sair.Location = new Point(100, 250);
            sair.Click += (sender, e) => {
                menu.Close();
            };

            menu.Controls.Add(btPt);
            menu.Controls.Add(sair);
            menu.ShowDialog();
        }
    }
}