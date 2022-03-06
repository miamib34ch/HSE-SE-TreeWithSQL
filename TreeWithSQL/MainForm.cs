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
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        public static int facultyCount = 0;
        public static int courseCount = 0;
        public static int groupCount = 0;

        private void Form1_Load(object sender, EventArgs e)
        {
            обновитьДеревоToolStripMenuItem.Enabled = false;
            удалитьДеревоToolStripMenuItem.Enabled = false;
            добавитьФакультетToolStripMenuItem.Enabled = false;

        }

        private void вывестиToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;Initial Catalog=TreeWithSQLLab;Integrated Security=True;");
            conn.Open();
            var sqlq = "SELECT * FROM [Faculty]";
            var cmd = new SqlCommand(sqlq, conn);
            using (var dr = cmd.ExecuteReader())
            {
                while (dr.Read())
                {
                    var node = treeView.Nodes.Add(dr["Name"].ToString());
                    node.Tag = dr["Id"].ToString();
                    facultyCount = int.Parse(dr["Id"].ToString());
                    node.ContextMenuStrip = contextMenuStripNodeFaculty;
                }
            }
            conn.Close();
            вывестиToolStripMenuItem.Enabled = false;
            обновитьДеревоToolStripMenuItem.Enabled = true;
            удалитьДеревоToolStripMenuItem.Enabled = true;
            добавитьФакультетToolStripMenuItem.Enabled = true;
        }

        void LoadCourse(TreeNode parent, string FacultyId)
        {
            SqlConnection conn = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;Initial Catalog=TreeWithSQLLab;Integrated Security=True;");
            conn.Open();
            var sqlq = $"SELECT * FROM [Course] WHERE [FacultyId] = {FacultyId}";
            var cmd = new SqlCommand(sqlq, conn);
            TreeNode node = new TreeNode();
            using (var dr = cmd.ExecuteReader())
            {
                while (dr.Read())
                {
                    node = parent.Nodes.Add(dr["CourseNumber"].ToString());
                    node.Tag = dr["Id"].ToString();
                    courseCount = int.Parse(dr["Id"].ToString());
                    node.ContextMenuStrip = contextMenuStripNodeCourse;
                }
            }
            conn.Close();
        }

        void LoadGroup(TreeNode parent, string CourseId)
        {
            SqlConnection conn = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;Initial Catalog=TreeWithSQLLab;Integrated Security=True;");
            conn.Open();
            var sqlq = $"SELECT * FROM [Group] WHERE [CourseId] = {CourseId}";
            var cmd = new SqlCommand(sqlq, conn);
            TreeNode node = new TreeNode();
            using (var dr = cmd.ExecuteReader())
            {
                while (dr.Read())
                {
                    node = parent.Nodes.Add(dr["GroupNumber"].ToString());
                    node.Tag=dr["Id"].ToString();
                    groupCount = int.Parse(dr["Id"].ToString());
                    node.ContextMenuStrip = contextMenuStripNodeGroup;
                }
            }
            conn.Close();
        }

        private void удалитьДеревоToolStripMenuItem_Click(object sender, EventArgs e)
        {
            treeView.Nodes.Clear();
            вывестиToolStripMenuItem.Enabled = true;
            обновитьДеревоToolStripMenuItem.Enabled = false;
            удалитьДеревоToolStripMenuItem.Enabled = false;
            добавитьФакультетToolStripMenuItem.Enabled = false;
        }

        private void обновитьДеревоToolStripMenuItem_Click(object sender, EventArgs e)
        {
            удалитьДеревоToolStripMenuItem_Click(sender, e);
            вывестиToolStripMenuItem_Click(sender, e);
        }

        private void treeView_AfterSelect(object sender, TreeViewEventArgs e)
        {
            if (e.Node.Checked == false)
            {
                if (e.Node.Parent == null)
                {
                    LoadCourse(e.Node, e.Node.Tag.ToString());
                    e.Node.Checked = true;
                }
                else
                {
                    if (e.Node.ContextMenuStrip == contextMenuStripNodeCourse)
                    {
                        LoadGroup(e.Node, e.Node.Tag.ToString());
                        e.Node.Checked = true;
                    }
                }
            }
        }

        private void удалитьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;Initial Catalog=TreeWithSQLLab;Integrated Security=True;");
            conn.Open();
            var sqlq = $"DELETE FROM [dbo].[Faculty] WHERE [Name] = '{treeView.SelectedNode.Text}' AND [Id] = {treeView.SelectedNode.Tag}";
            var cmd = new SqlCommand(sqlq, conn);
            cmd.ExecuteNonQuery();
            conn.Close();
            treeView.SelectedNode.Remove();
        }

        private void удалитьToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;Initial Catalog=TreeWithSQLLab;Integrated Security=True;");
            conn.Open();
            var sqlq = $"DELETE FROM [dbo].[Course] WHERE [CourseNumber] = '{treeView.SelectedNode.Text}' AND [Id] = {treeView.SelectedNode.Tag}";
            var cmd = new SqlCommand(sqlq, conn);
            cmd.ExecuteNonQuery();
            conn.Close();
            treeView.SelectedNode.Remove();
        }

        private void удалитьToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;Initial Catalog=TreeWithSQLLab;Integrated Security=True;");
            conn.Open();
            var sqlq = $"DELETE FROM [dbo].[Group] WHERE [GroupNumber] = '{treeView.SelectedNode.Text}' AND [Id] = {treeView.SelectedNode.Tag}";
            var cmd = new SqlCommand(sqlq, conn);
            cmd.ExecuteNonQuery();
            conn.Close();
            treeView.SelectedNode.Remove();
        }

        private void добавитьФакультетToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddFaculty frm = new AddFaculty();
            frm.ShowDialog();
            обновитьДеревоToolStripMenuItem_Click(sender, e);
        }

        private void добавитьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddCourse frm = new AddCourse(treeView.SelectedNode.Tag.ToString());
            frm.ShowDialog();
            UpdateNode();
        }

        private void добавитьToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            AddGroup frm = new AddGroup(treeView.SelectedNode.Tag.ToString());
            frm.ShowDialog();
            UpdateNode();
        }

        void UpdateNode()
        {
            treeView.SelectedNode.Nodes.Clear();
            if (treeView.SelectedNode.ContextMenuStrip == contextMenuStripNodeFaculty)
                LoadCourse(treeView.SelectedNode, treeView.SelectedNode.Tag.ToString());
            else
                LoadGroup(treeView.SelectedNode, treeView.SelectedNode.Tag.ToString());
        }

        private void contextMenuStripNodeFaculty_Opening(object sender, CancelEventArgs e)
        {
            if (treeView.SelectedNode != null)
            {
                if (treeView.SelectedNode.ContextMenuStrip != contextMenuStripNodeFaculty)
                {
                    удалитьToolStripMenuItem.Enabled = false;
                    изменитьToolStripMenuItem.Enabled = false;
                    добавитьToolStripMenuItem.Enabled = false;
                }
                else
                {
                    удалитьToolStripMenuItem.Enabled = true;
                    изменитьToolStripMenuItem.Enabled = true;
                    добавитьToolStripMenuItem.Enabled = true;
                }
            }
            else
            {
                удалитьToolStripMenuItem.Enabled = false;
                изменитьToolStripMenuItem.Enabled = false;
                добавитьToolStripMenuItem.Enabled = false;
            }
        }

        private void contextMenuStripNodeCourse_Opening(object sender, CancelEventArgs e)
        {
            if (treeView.SelectedNode != null)
            {
                if (treeView.SelectedNode.ContextMenuStrip != contextMenuStripNodeCourse)
                {
                    удалитьToolStripMenuItem2.Enabled = false;
                    изменитьToolStripMenuItem2.Enabled = false;
                    добавитьToolStripMenuItem1.Enabled = false;
                }
                else
                {
                    удалитьToolStripMenuItem2.Enabled = true;
                    изменитьToolStripMenuItem2.Enabled = true;
                    добавитьToolStripMenuItem1.Enabled = true;
                }
            }
            else
            {
                удалитьToolStripMenuItem2.Enabled = false;
                изменитьToolStripMenuItem2.Enabled = false;
                добавитьToolStripMenuItem1.Enabled = false;
            }
        }

        private void contextMenuStripNodeGroup_Opening(object sender, CancelEventArgs e)
        {
            if (treeView.SelectedNode != null)
            {
                if (treeView.SelectedNode.ContextMenuStrip != contextMenuStripNodeGroup)
                {
                    удалитьToolStripMenuItem1.Enabled = false;
                    изменитьToolStripMenuItem1.Enabled = false;
                }
                else
                {
                    удалитьToolStripMenuItem1.Enabled = true;
                    изменитьToolStripMenuItem1.Enabled = true;
                }
            }
            else
            {
                удалитьToolStripMenuItem1.Enabled = false;
                изменитьToolStripMenuItem1.Enabled = false;
            }
        }

        private void изменитьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            UpdateFaculty frm = new UpdateFaculty(treeView.SelectedNode.Tag.ToString());
            frm.ShowDialog();
            обновитьДеревоToolStripMenuItem_Click(sender, e);
        }

        private void изменитьToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            UpdateCourse frm = new UpdateCourse(treeView.SelectedNode.Tag.ToString(),treeView.SelectedNode.Parent.Tag.ToString());
            frm.ShowDialog();
            обновитьДеревоToolStripMenuItem_Click(sender, e);
        }

        private void изменитьToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            UpdateGroup frm = new UpdateGroup(treeView.SelectedNode.Tag.ToString(), treeView.SelectedNode.Parent.Tag.ToString());
            frm.ShowDialog();
            обновитьДеревоToolStripMenuItem_Click(sender, e);
        }

    }
}
