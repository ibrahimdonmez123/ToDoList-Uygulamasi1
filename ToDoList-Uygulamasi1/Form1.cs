using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ToDoList_Uygulamasi1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            txt_not.Text= string.Empty;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Liste.Rows.Add(txt_not.Text);

        }

        private void button3_Click(object sender, EventArgs e)
        {
            Liste.Rows.Remove(Liste.CurrentRow);
        }
    }
}
