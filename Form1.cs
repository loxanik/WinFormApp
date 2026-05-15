using Microsoft.Data.SqlClient;
using System.Data;

namespace WinFormsAppBooks
{
    public partial class Form1 : Form
    {
        public string connectionString = "Data Source=DESKTOP-J7SGTAS\\SQLEXPRESS;Initial Catalog=Books;Integrated Security=True;Trust Server Certificate=True";
        SqlConnection conn;
        SqlDataAdapter adapter;
        DataTable dataTable;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            LoadData();
        }

        private void LoadData()
        {
            conn = new SqlConnection(connectionString);
            adapter = new SqlDataAdapter("SELECT * FROM [Весь ассортимент]", conn);

            dataTable = new DataTable();
            adapter.Fill(dataTable);
            dataGridViewStaff.DataSource = dataTable;

            comboBoxStaffSeacch.Items.Clear();
            foreach (DataColumn column in dataTable.Columns)
            {
                comboBoxStaffSeacch.Items.Add(column.ColumnName);
            }

            comboBoxStaffTypeDelete.Items.Clear();
            foreach (DataColumn column in dataTable.Columns)
            {
                comboBoxStaffTypeDelete.Items.Add(column.ColumnName);
            }
        }

        private void comboBoxStaffSeacch_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBoxStaffSeacch.SelectedIndex == -1)
            {
                buttonStaffResetSearch.Enabled = false;
                buttonStaffSearch.Enabled = false;
            }
            else
            {
                buttonStaffResetSearch.Enabled = true;
                buttonStaffSearch.Enabled = true;
            }

        }

        private void buttonStaffResetSearch_Click(object sender, EventArgs e)
        {
            comboBoxStaffSeacch.SelectedIndex = -1;
            textBoxStaffSearch.Text = string.Empty;
            dataTable.DefaultView.RowFilter = "";
        }

        private void buttonStaffSearch_Click(object sender, EventArgs e)
        {
            string columnName = comboBoxStaffSeacch.SelectedItem.ToString();
            string filterText = textBoxStaffSearch.Text;

            dataTable.DefaultView.RowFilter = string.Format("[{0}] LIKE '%{1}%'", columnName, filterText);
        }

        private void buttonStaffEdit_Click(object sender, EventArgs e)
        {
            conn.Open();

            string query = "UPDATE [Весь ассортимент] " +
                "SET [Тип] = @type, [Количество в наличии] = @count, [Цена за штуку/упаковку] = @price " +
                "WHERE [Наименование] = @name;";

            SqlCommand cmd = new SqlCommand(query, conn);

            cmd.Parameters.AddWithValue("@type", comboBoxStaffEditType.SelectedItem.ToString());
            cmd.Parameters.AddWithValue("@count", Convert.ToInt32(textBoxStaffEditCount.Text));
            cmd.Parameters.AddWithValue("@price", Convert.ToInt32(textBoxStaffEditPrice.Text));
            cmd.Parameters.AddWithValue("@name", textBoxStaffNameEdit.Text);

            cmd.ExecuteNonQuery();

            conn.Close();

            LoadData();
        }

        private void textBoxStaffNameEdit_TextChanged(object sender, EventArgs e)
        {
            if (textBoxStaffNameEdit.Text.Trim() != string.Empty)
            {
                buttonStaffEdit.Enabled = true;
            }
            else
            {
                buttonStaffEdit.Enabled = false;
            }
        }

        private void buttonStaffDelete_Click(object sender, EventArgs e)
        {
            conn.Open();

            string column = comboBoxStaffTypeDelete.SelectedItem.ToString();

            string query = "DELETE FROM [Весь ассортимент] " +
                $"WHERE {column} = @name;";

            SqlCommand cmd = new SqlCommand(query, conn);

            cmd.Parameters.AddWithValue("@name", textBoxStaffValueDelete.Text);

            cmd.ExecuteNonQuery();

            conn.Close();

            LoadData();
        }

        private void comboBoxStaffTypeDelete_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBoxStaffTypeDelete.SelectedIndex == -1)
            {
                buttonStaffDelete.Enabled = false;
            }
            else
            {
                buttonStaffDelete.Enabled = true;
            }
        }
    }
}
