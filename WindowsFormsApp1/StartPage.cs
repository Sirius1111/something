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
    public partial class StartPage : Form
    {

        TovarList tovarList = new TovarList();


        public StartPage()
        {
            InitializeComponent();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            Hide();
            TovarList tovarList = new TovarList();
            tovarList.Show();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

            Hide();
            waiterForm waiter = new waiterForm();
            waiter.RenderComponent();
            waiter.Show();
        }
    }
}
