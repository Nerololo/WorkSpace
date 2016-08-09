using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MapaArcgics
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

            this.dataGridView1.DataSource = Proceso.BaseDB.Tables[0];

            listView1.View = View.Details;
            listView1.LabelEdit = true;
            listView1.AllowColumnReorder = true;
            listView1.FullRowSelect = true;
            listView1.GridLines = true;

            listView1.BackColor = Color.Azure;
            listView1.ForeColor = Color.Black;
            listView1.Dock = DockStyle.Fill;
            listView1.View = View.Details;
            listView1.FullRowSelect = true;

            listView1.Columns.Add("Nombre", 230, HorizontalAlignment.Left);
            listView1.Columns.Add("Valor", 140, HorizontalAlignment.Left);

            ListViewItem li;
            int j = 0;
            for (int i = 0; i < dataGridView1.Rows.Count; i++)
            {
                foreach (DataGridViewCell dgvc in dataGridView1.Rows[i].Cells)
                {
                    li = listView1.Items.Add(dgvc.DataGridView.Columns[j].Name);
                    li.SubItems.Add(dgvc.Value.ToString());
                    j += 1;
                }
            }



         


    }

}
}
