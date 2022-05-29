using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;
namespace deeplay
{
    public partial class Form1 : Form
    {
        OleDbConnection connection;
        OleDbCommand command;
        string dbconnect = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=deeplayworker1.mdb";
        public Form1()
        {
            InitializeComponent();
            connection = new OleDbConnection(dbconnect);
            connection.Open();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string postworker = workerpost.Text;
            string nameworker = workerfullname.Text;
            if (actionbox.SelectedIndex == 1 &&  nameworker.Length>0)
            {
                string query = $"update workers set post=@post where fullname=@name ";
                command = new OleDbCommand(query, connection);
                command.Parameters.AddWithValue("post", postworker);
                command.Parameters.AddWithValue("name", nameworker);
                command.ExecuteNonQuery();
            }
            else if(actionbox.SelectedIndex==0 && workerpost.SelectedIndex>-1)
            {
                
                string query = $"select * from workers where post='{postworker}'"; 
                DataTable dataTable = new DataTable();
                OleDbDataAdapter dataAdapter = new OleDbDataAdapter(query,connection);
                dataAdapter.Fill(dataTable);
                dataGridView1.DataSource = dataTable;
            }
            this.workersTableAdapter.Fill(this.deeplayworker1DataSet.workers);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "deeplayworker1DataSet.workers". При необходимости она может быть перемещена или удалена.
            this.workersTableAdapter.Fill(this.deeplayworker1DataSet.workers);

        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            connection.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string addfulname = addfullname.Text;
            string addbirth = adddob.Text;
            string addpostname = addpost.Text;
            string addsexname = addsex.Text;
            string strquery = $"insert into [workers](fullname,Date_Of_Birth,post,sex) values('{addfulname}','{addbirth}','{addpostname}','{addsexname}')";
            command = new OleDbCommand(strquery,connection); 
            command.ExecuteNonQuery();
            this.workersTableAdapter.Fill(this.deeplayworker1DataSet.workers);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            string fullname = changefullname.Text;
            string birth = changebirth.Text;
            string sex = changesex.Text;
            string post = changepost.Text;
            string id = changeId.Text;
            string query = $"update workers set fullname=@fullname, Date_Of_Birth=@Date_Of_Birth, post=@post ,sex=@sex  where id=@id";

            command = new OleDbCommand(query, connection);
            command.Parameters.AddWithValue("fullname", fullname);
            command.Parameters.AddWithValue("Date_Of_Birth", birth);
            command.Parameters.AddWithValue("post", post);
            command.Parameters.AddWithValue("sex", sex);
            command.Parameters.AddWithValue("id", id);

            command.ExecuteNonQuery();
            this.workersTableAdapter.Fill(this.deeplayworker1DataSet.workers);
        }

        private void dataGridView1_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            string fulname = dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();
            string birth = dataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString();
            string postname = dataGridView1.Rows[e.RowIndex].Cells[3].Value.ToString();
            string sexname = dataGridView1.Rows[e.RowIndex].Cells[4].Value.ToString();
            changefullname.Text = fulname;
            changebirth.Text = birth;
            changepost.Text = postname;
            changesex.Text = sexname;
            delfullname.Text = fulname;
            delid.Text = dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString();
            changeId.Text = dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString();
            workerpost.Text = postname;
            workerfullname.Text = fulname;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            string fullname = delfullname.Text;
            string id = delid.Text;

            string querybyid = "delete from workers where id=@id";
            string querybyname = "delete from workers where fullname=@fullname";
            if (fullname == "")
            {
                command = new OleDbCommand(querybyid, connection);
                command.Parameters.AddWithValue("id", id); 
                command.ExecuteNonQuery();
            }
            else if (id == "")
            {
                command = new OleDbCommand(querybyname, connection);
                command.Parameters.AddWithValue("fullname", fullname);
                command.ExecuteNonQuery();
            }
            else
            {
                command = new OleDbCommand(querybyid, connection);
                command.Parameters.AddWithValue("id", id); 
                command.ExecuteNonQuery();
            }
            this.workersTableAdapter.Fill(this.deeplayworker1DataSet.workers);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.workersTableAdapter.Fill(this.deeplayworker1DataSet.workers);
        }
    }
}
