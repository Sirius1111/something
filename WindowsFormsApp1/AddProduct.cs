using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lesson9_2
{
    public partial class TovarList : Form
    {
        public TovarList()
        {
            InitializeComponent();
        }

        private void nameTovar_TextChanged(object sender, EventArgs e)
        {
            if (nameTovar.Text == "товар")
            {
                nameTovar.Text = "";
            }
            else if (nameTovar.Text.Length == 0)
            {
                nameTovar.Text = "Имя товара";
            }
        }

        private void TovarList_Load(object sender, EventArgs e)
        {

        }
        private void button1_Click(object sender, EventArgs e)
        {
            if (changeImg.ShowDialog() == DialogResult.OK)
            {
                pictureBox.ImageLocation = changeImg.FileName;
                MessageBox.Show("Картинка загружена");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void TovarList_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}
