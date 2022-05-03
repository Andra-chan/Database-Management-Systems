using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Lab1SGBD
{
    public partial class Form1 : Form
    {
        public string text;
        public Form1()
        {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlConnection cs = new SqlConnection(@"Server=DESKTOP-POGJVCH\SQLEXPRESS; Initial Catalog = Centru_de_Engleza; Integrated Security = True");

            cs.Open();

            SqlCommand selCmd = new SqlCommand("SELECT id_grupa, numar FROM Grupe", cs);

            SqlDataReader reader = selCmd.ExecuteReader();

            dataGridView1.Rows.Clear();
            dataGridView1.Refresh();

            dataGridView1.AutoGenerateColumns = false;
            dataGridView1.ColumnCount = 2;
            dataGridView1.Columns[0].Name = "id_grupa";
            dataGridView1.Columns[1].Name = "numar";


            if (reader.HasRows)
            {
                while (reader.Read())
                {
                    DataGridViewRow tempRow = new DataGridViewRow();

                    DataGridViewCell cellID = new DataGridViewTextBoxCell();
                    cellID.Value = reader.GetInt16(0);
                    tempRow.Cells.Add(cellID);

                    DataGridViewCell cellNumar = new DataGridViewTextBoxCell();
                    cellNumar.Value = reader.GetByte(1);
                    tempRow.Cells.Add(cellNumar);

                    dataGridView1.Rows.Add(tempRow);
                }
            }

            reader.Close();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int id_grupa = 0;

            if (dataGridView1.SelectedCells.Count > 0)
            {
                int selectedrowindex = dataGridView1.SelectedCells[0].RowIndex;

                DataGridViewRow selectedRow = dataGridView1.Rows[selectedrowindex];

                id_grupa = Convert.ToInt16(selectedRow.Cells[0].Value);

            }
            SqlConnection cs = new SqlConnection(@"Server=DESKTOP-POGJVCH\SQLEXPRESS; Initial Catalog = Centru_de_Engleza; Integrated Security = True");
            cs.Open();

            string commandText = "SELECT id, ora, id_grupa FROM Ore WHERE id_grupa = @id_grupa";
            SqlCommand selCmd = new SqlCommand(commandText, cs);
            selCmd.Parameters.Add("@id_grupa", SqlDbType.Int);
            selCmd.Parameters["@id_grupa"].Value = id_grupa;

            SqlDataReader reader = selCmd.ExecuteReader();

            dataGridView2.Rows.Clear();
            dataGridView2.Refresh();

            dataGridView2.AutoGenerateColumns = false;
            dataGridView2.ColumnCount = 3;
            dataGridView2.Columns[0].Name = "id";
            dataGridView2.Columns[1].Name = "ora";
            dataGridView2.Columns[2].Name = "id_gr";


            if (reader.HasRows)
            {
                while (reader.Read())
                {
                    DataGridViewRow tempRow = new DataGridViewRow();

                    DataGridViewCell cellID = new DataGridViewTextBoxCell();
                    cellID.Value = reader.GetInt16(0);
                    tempRow.Cells.Add(cellID);

                    DataGridViewCell cellOra = new DataGridViewTextBoxCell();
                    cellOra.Value = reader.GetInt16(1);
                    tempRow.Cells.Add(cellOra);

                    DataGridViewCell cellGrupa = new DataGridViewTextBoxCell();
                    cellGrupa.Value = reader.GetInt16(2);
                    tempRow.Cells.Add(cellGrupa);

                    dataGridView2.Rows.Add(tempRow);
                }
            }
            reader.Close();

        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
        }

        private void dataGridView2_EditingControlShowing(object sender, DataGridViewEditingControlShowingEventArgs e)
        {
            int id = 0;
            if (dataGridView2.SelectedCells.Count > 0)
            {
                int selectedrowindex = dataGridView2.SelectedCells[0].RowIndex;

                DataGridViewRow selectedRow = dataGridView2.Rows[selectedrowindex];

                id = Convert.ToInt16(selectedRow.Cells[0].Value);
            }
            Console.WriteLine("ID ora: {0}", id);
            if (e.Control is TextBox)
            {
                DataGridViewTextBoxEditingControl cell = (DataGridViewTextBoxEditingControl)e.Control;

                if (cell != null)
                {

                    cell.KeyDown += delegate (object s, KeyEventArgs key)
                    {
                        if (key.KeyData == Keys.Delete)
                        {
                            dataGridView2.Rows.RemoveAt(cell.EditingControlRowIndex);

                            SqlConnection cs = new SqlConnection(@"Server=DESKTOP-POGJVCH\SQLEXPRESS; Initial Catalog = Centru_de_Engleza; Integrated Security = True");
                            cs.Open();

                        string sqlQuery = String.Format("delete from Ore where id = {0}", id);

                        SqlCommand command = new SqlCommand(sqlQuery, cs);

                        int rowsDeletedCount = command.ExecuteNonQuery();
                            if (rowsDeletedCount != 0)
                                Console.WriteLine("A delete has occured...");

                        command.Dispose();
                        }
                    };
                }
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            string ora = "";
            Form2 otherForm = new Form2(this);
            otherForm.ShowDialog();

            int id_grupa = 0;
            if (dataGridView1.SelectedCells.Count > 0)
            {
                int selectedrowindex = dataGridView1.SelectedCells[0].RowIndex;

                DataGridViewRow selectedRow = dataGridView1.Rows[selectedrowindex];

                id_grupa = Convert.ToInt16(selectedRow.Cells[0].Value);

            }
            int id = 0;


            SqlConnection cs = new SqlConnection(@"Server=DESKTOP-POGJVCH\SQLEXPRESS; Initial Catalog = Centru_de_Engleza; Integrated Security = True");
            cs.Open();
            string query = "SELECT MAX(id) FROM Ore";
            SqlCommand comSelect = new SqlCommand(query, cs);
            SqlDataReader reader = comSelect.ExecuteReader();
            while (reader.Read())
                id = Convert.ToInt16(reader[0]);

            id++;
            reader.Close();

            DataGridViewRow row = (DataGridViewRow)dataGridView2.Rows[0].Clone();
            row.Cells[0].Value = id;
            row.Cells[1].Value = otherForm.TextBox1.Text;
            dataGridView2.Rows.Add(row);
            ora = otherForm.TextBox1.Text;
            Console.WriteLine("Ora: {0}", ora);
            otherForm.Close();

            string sqlQuery = String.Format("Insert into Ore (id, ora, id_grupa) Values('{0}', '{1}', {2});", id, ora, id_grupa); 

            SqlConnection cons = new SqlConnection(@"Server=DESKTOP-POGJVCH\SQLEXPRESS; Initial Catalog = Centru_de_Engleza; Integrated Security = True");
            cons.Open();

            SqlCommand command = new SqlCommand(sqlQuery, cons);
            int rowsAddedCount = command.ExecuteNonQuery();
            if (rowsAddedCount != 0)
                Console.WriteLine("An add has occured...");
            command.Dispose();

        }


        private void button2_Click(object sender, EventArgs e)
        {
            SqlConnection cs = new SqlConnection(@"Server=DESKTOP-POGJVCH\SQLEXPRESS; Initial Catalog = Centru_de_Engleza; Integrated Security = True");
            int id = 0;
            int ora = 0;

            if (cs.State != ConnectionState.Open)
            {
                cs.Open();
            }

            if (dataGridView2.SelectedCells.Count > 0)
            {
                int selectedrowindex = dataGridView2.SelectedCells[0].RowIndex;

                DataGridViewRow selectedRow = dataGridView2.Rows[selectedrowindex];

                id = Convert.ToInt16(selectedRow.Cells[0].Value);
                ora = Convert.ToInt16(selectedRow.Cells[1].Value);

                Console.WriteLine("Id = {0}", id);
                Console.WriteLine("Ora = {0}", ora);

            }

            for (int i = 0; i < dataGridView2.SelectedRows.Count; i++)
            {
                DialogResult result = MessageBox.Show("Are you sure want to update?", "Confirmation", MessageBoxButtons.YesNo);
                if (result == System.Windows.Forms.DialogResult.Yes)
                {
                    SqlCommand command = new SqlCommand("UPDATE Ore SET ora = @ora Where id = @id", cs);

                    command.Parameters.AddWithValue("@ora", ora);
                    command.Parameters.AddWithValue("@id", id);
                    Console.WriteLine("An update has occured...");

                    command.ExecuteNonQuery();
                }
            }
        }
	}
}