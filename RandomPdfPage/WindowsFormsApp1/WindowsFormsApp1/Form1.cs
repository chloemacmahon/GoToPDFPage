using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            numericUpDown1.Visible = false;
            button2.Visible = false;
        }
        private bool alreadyopen = false;
        private void button1_Click(object sender, EventArgs e)
        {
            Random rand = new Random();
            openFileDialog1.Filter = "PDF|* .pdf";
            
            if (!alreadyopen)
            {
                if (openFileDialog1.ShowDialog() == DialogResult.OK)
                {
                    axAcroPDF1.src = openFileDialog1.FileName;
                    alreadyopen = true;
                    button2.Visible = true;
                }
            }
            axAcroPDF1.setCurrentPage(rand.Next(150));
            axAcroPDF1.setZoom(50);
        }

        private void axAcroPDF1_Enter(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            
            if(numericUpDown1.Visible)
            {
                axAcroPDF1.setCurrentPage(Convert.ToInt32(numericUpDown1.Value));
                numericUpDown1.Visible = false;
            }
            else
            {
                numericUpDown1.Visible = true;
                MessageBox.Show("Please choose a page to go to in the document then press the specific page button again");
            }
        }
    }
}
