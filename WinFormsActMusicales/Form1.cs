using WinFormsActMusicales.Model;
using WinFormsActMusicales.Service;
namespace WinFormsActMusicales
{
    public partial class Form1 : Form
    {
        private ApiService api;
        public Form1()
        {
            InitializeComponent();
            api = new ApiService();
        }

        private async void btnMostrar_Click(object sender, EventArgs e)
        {
            try
            {
                var actis = await api.GetActAsync();
                dataGridView1.DataSource = actis;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al obtener actividades: " + ex.Message);
            }
        }

        private async void Form1_Load(object sender, EventArgs e)
        {
            var success = await api.LoginAsync("admin", "123");

            if (success)
            {
                MessageBox.Show("Inicio de sesión exitoso");
            }
            else
            {
                MessageBox.Show("Credenciales incorrectas");
                this.Close();
            }

            Dictionary<int, string> tipos = new Dictionary<int, string>()
            {
                { 1, "Concierto" },
                { 2, "Ensayo" },
                { 3, "Clase Especial" }
            };

            comboBox1.DataSource = new BindingSource(tipos, null);
            comboBox1.DisplayMember = "Value";
            comboBox1.ValueMember = "Key";
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                var row = dataGridView1.Rows[e.RowIndex];
                txtNombre.Text = row.Cells["Nombre"].Value?.ToString();
                txtDesc.Text = row.Cells["Descripcion"].Value?.ToString();
                dateTimePicker1.Value = Convert.ToDateTime(row.Cells["Fecha"].Value);
                txtLugar.Text = row.Cells["Lugar"].Value?.ToString();

                int tipoId = Convert.ToInt32(row.Cells["TipoActividadId"].Value);
                comboBox1.SelectedValue = tipoId;
            }
        }

        private void btnInsertar_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {

        }
    }
}
