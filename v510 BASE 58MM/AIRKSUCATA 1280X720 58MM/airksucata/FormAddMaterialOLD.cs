using MySql.Data.MySqlClient;

namespace airksucata
{
    public class CustomComboBox : ComboBox
    {
        protected override void OnDrawItem(DrawItemEventArgs e)
        {
            base.OnDrawItem(e);

            if (e.Index >= 0 && e.Index < Items.Count)
            {
                e.DrawBackground();
                e.DrawFocusRectangle();

                string itemText = GetItemText(Items[e.Index]);

                // Separe o nome e o valor do item
                string[] parts = itemText.Split('-');
                string nome = parts[0].Trim();
                string valor = parts[1].Trim();

                // Desenhe o nome à esquerda
                e.Graphics.DrawString(nome, e.Font, Brushes.Black, e.Bounds.Left, e.Bounds.Top);

                // Desenhe o valor à direita
                SizeF valueSize = e.Graphics.MeasureString(valor, e.Font);
                float valueX = e.Bounds.Right - valueSize.Width;
                e.Graphics.DrawString(valor, e.Font, Brushes.Gray, valueX, e.Bounds.Top);
            }
        }
    }
    public partial class Form2 : Form
    {
        private string connectionString = "Server=localhost;Database=xlata_db;Uid=root;Pwd=;";

        public Form2()
        {
            InitializeComponent();
            PreencherComboBoxRegistros();
        }

        private void PreencherComboBoxRegistros()
        {
            string query = "SELECT nome, valorporkg FROM materiais";

            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                try
                {
                    connection.Open();

                    MySqlCommand command = new MySqlCommand(query, connection);

                    using (MySqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            string nome = reader["nome"].ToString();
                            double valorPorKg = Convert.ToDouble(reader["valorporkg"]);

                            string itemDisplay = $"{nome} - {valorPorKg:C}";

                            cmbRegistros.Items.Add(itemDisplay);
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Erro ao carregar registros: " + ex.Message);
                }
            }
        }
    }
}