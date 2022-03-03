using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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
    }
}
