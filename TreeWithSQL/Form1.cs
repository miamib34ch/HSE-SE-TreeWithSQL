using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace TreeWithSQL
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "treeWithSQLLabDataSet.Group". При необходимости она может быть перемещена или удалена.
            this.groupTableAdapter.Fill(this.treeWithSQLLabDataSet.Group);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "treeWithSQLLabDataSet.Faculty". При необходимости она может быть перемещена или удалена.
            this.facultyTableAdapter.Fill(this.treeWithSQLLabDataSet.Faculty);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "treeWithSQLLabDataSet.Course". При необходимости она может быть перемещена или удалена.
            this.courseTableAdapter.Fill(this.treeWithSQLLabDataSet.Course);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "treeWithSQLLabDataSet.Faculty". При необходимости она может быть перемещена или удалена.
            this.facultyTableAdapter.Update(this.treeWithSQLLabDataSet.Faculty);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "treeWithSQLLabDataSet.Course". При необходимости она может быть перемещена или удалена.
            this.courseTableAdapter.Update(this.treeWithSQLLabDataSet.Course);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "treeWithSQLLabDataSet.Group". При необходимости она может быть перемещена или удалена.
            this.groupTableAdapter.Update(this.treeWithSQLLabDataSet.Group);
         
        }

        private void button2_Click(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;Initial Catalog=TreeWithSQLLab;Integrated Security=True;");
            conn.Open();
            var sqlq = "SELECT * FROM(Faculty INNER JOIN Course ON Faculty.[Id] = Course.[FacultyId]) INNER JOIN[Group] ON Course.[Id] = [Group].[CourseId]; ";
            var cmd = new SqlCommand(sqlq,conn);
            using (var dr = cmd.ExecuteReader())
            {
                while (dr.Read())
                {
                    var node = treeView1.Nodes.Add(dr["Name"].ToString());
                }
            }
        }

        void Load1(int groupId, TreeNode parent)
        {

        }
    }
}
