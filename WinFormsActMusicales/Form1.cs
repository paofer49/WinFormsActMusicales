using WinFormsActMusicales.Model;
using WinFormsActMusicales.Service;
namespace WinFormsActMusicales
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private async void btnMostrar_Click(object sender, EventArgs e)
        {
            var api = new ApiService();
            var succes = await api.LoginAsync("admin", "123");

            if (succes)
            {
                MessageBox.Show("Inicio de sesión exitoso");
                var actis = await api.GetActAsync();
                dataGridView1.DataSource = actis;
            }
            else
            {
                MessageBox.Show("Credenciales incorrectas");
            }
        }
    }
}
