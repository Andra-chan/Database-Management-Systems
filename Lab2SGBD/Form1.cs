using System;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Lab2SGBD
{
	public partial class Form1 : Form
	{
        SqlConnection dbConn;
        SqlDataAdapter dataAdapterChild, dataAdapterParent;
        DataSet dataSet;
        BindingSource bindingSourceChild, bindingSourceParent;
        SqlCommandBuilder commandBuilderChild;

        public Form1()
        {
            InitializeComponent();
        }


        private string getConnectionString()
        {
            return ConfigurationManager.ConnectionStrings["connection_string"].ConnectionString.ToString();
        }
        private string getParentPK()
        {
            return ConfigurationManager.AppSettings["parent_table_pk"];
        }

        private string getChildPK()
        {
            return ConfigurationManager.AppSettings["child_table_pk"];
        }

        private string getChildFK()
        {
            return ConfigurationManager.AppSettings["child_table_fk"];
        }
        private string getParentTable()
        {
            return ConfigurationManager.AppSettings["parent_table"];
        }
        private string getChildTable()
        {
            return ConfigurationManager.AppSettings["child_table"];
        }

        private string getSelectParentQuery()
        {
            return ConfigurationManager.AppSettings["select_parent_query"];
        }

        private string getSelectChildQuery()
        {
            return ConfigurationManager.AppSettings["select_child_query"];
        }

        private string getUpdateChildQuery()
        {
            return ConfigurationManager.AppSettings["update_child_query"];
        }

        private string getDeleteChildQuery()
        {
            return ConfigurationManager.AppSettings["delete_from_child_query"];
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            dbConn = new SqlConnection(getConnectionString());
            dataAdapterParent = new SqlDataAdapter(getSelectParentQuery(), dbConn);
            dataAdapterChild = new SqlDataAdapter(getSelectChildQuery(), dbConn);
            commandBuilderChild = new SqlCommandBuilder(dataAdapterChild);

            dataSet = new DataSet();

            dataAdapterParent.Fill(dataSet, getParentTable());
            dataAdapterChild.Fill(dataSet, getChildTable());

            DataRelation dr = new DataRelation("fk_child_parent", dataSet.Tables[getParentTable()].Columns[getParentPK()],
            dataSet.Tables[getChildTable()].Columns[getChildFK()]);

            dataSet.Relations.Add(dr);

            bindingSourceParent = new BindingSource();
            bindingSourceParent.DataSource = dataSet;
            bindingSourceParent.DataMember = getParentTable();

            bindingSourceChild = new BindingSource();
            bindingSourceChild.DataSource = bindingSourceParent;
            bindingSourceChild.DataMember = "fk_child_parent";

            parentView.DataSource = bindingSourceParent;
            childView.DataSource = bindingSourceChild;

            parentLabel.Text = getParentTable();
            childLabel.Text = getChildTable();
        }

        private void Add_Click(object sender, EventArgs e)
        {
            try
            {
                dbConn = new SqlConnection(getConnectionString());
                dbConn.Open();
                if (childView.SelectedCells.Count > 0)
                {
                    dataAdapterChild = new SqlDataAdapter(getSelectChildQuery(), dbConn);
                    commandBuilderChild = new SqlCommandBuilder(dataAdapterChild);
                    commandBuilderChild.GetInsertCommand();

                    dataAdapterChild.Update(dataSet, getChildTable());

                    MessageBox.Show("Adaugare realizata cu succes!");
                }
                else
                {
                    MessageBox.Show("Nicio inregistrare selectata!");
                }
                dbConn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            dataSet.Tables[getChildTable()].Clear();
            dataAdapterChild.Fill(dataSet, getChildTable());
        }

		private void Update_Click(object sender, EventArgs e)
        {
            try
            {
                dbConn = new SqlConnection(getConnectionString());
                dbConn.Open();
                if (childView.SelectedCells.Count > 0)
                {
                    dataAdapterChild = new SqlDataAdapter(getSelectChildQuery(), dbConn);
                    commandBuilderChild = new SqlCommandBuilder(dataAdapterChild);
                    commandBuilderChild.GetUpdateCommand();

                    dataAdapterChild.Update(dataSet, getChildTable());

                    MessageBox.Show("Update realizat cu succes!");
                }
                else
                {
                    MessageBox.Show("Nicio inregistrare selectata!");
                }
                dbConn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            dataSet.Tables[getChildTable()].Clear();
            dataAdapterChild.Fill(dataSet, getChildTable());
        }

        private void Delete_Click(object sender, EventArgs e)
        {
            try
            {
                dbConn = new SqlConnection(getConnectionString());
                dbConn.Open();
                if (childView.SelectedCells.Count > 0)
                {
                    
                    dataAdapterChild = new SqlDataAdapter(getSelectChildQuery(), dbConn);
                    commandBuilderChild = new SqlCommandBuilder(dataAdapterChild);
                    commandBuilderChild.GetDeleteCommand();

                    dataAdapterChild.Update(dataSet, getChildTable());
                    
                    
                    /**
                    int indexOfRow = childView.SelectedCells[0].RowIndex;
                    string idChild = childView.Rows[indexOfRow].Cells[0].Value.ToString();
                    SqlCommand deleteCommand = new SqlCommand(getDeleteChildQuery(), dbConn);

                    deleteCommand.Parameters.AddWithValue("@id_child", idChild);
                    deleteCommand.ExecuteNonQuery();
                    **/
              
                    MessageBox.Show("Stergere realizata cu succes!");
                }
                else
                {
                    MessageBox.Show("Nicio inregistrare selectata!");
                }
                dbConn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            dataSet.Tables[getChildTable()].Clear();
            dataAdapterChild.Fill(dataSet, getChildTable());
        }
    }
}
