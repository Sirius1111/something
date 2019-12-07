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
    public partial class AddTovar : Form
    {
        Bd bd = new Bd();
        public AddTovar()
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

            Coffee coffee = new Coffee();
            coffee.name = nameTovar.Text;
            coffee.category = categoryValue.SelectedItem.ToString();
            coffee.description = text.Text;
            coffee.urlImg = pictureBox.ImageLocation;
            coffee.info = new string[]{ coffee.name, coffee.category, coffee.description, coffee.urlImg };


            // проверка полей на пустоту 
            //
            // nameTovar.Text;
            // categoryValue.SelectedItem.ToString();
            // text.Text;
            // pictureBox.ImageLocation; 

            string dataProduct = coffee.getInfo(coffee.info);
            bd.WriteBd("data", dataProduct);

            //
            // выполнить сброс всех данных и вывести messageBox
            // 
        }

        private void TovarList_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void left(object sender, EventArgs e)
        {
            Hide();
            StartPage s = new StartPage();
            s.Show();
        }
    }
}
