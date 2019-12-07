using MaterialSkin;
using MaterialSkin.Controls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Lesson9_2
{
    public partial class waiterForm : MaterialForm
    {
        Render Ren = new Render();

        public waiterForm()
        {
            InitializeComponent();
            var materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkinManager.Themes.DARK;
            materialSkinManager.ColorScheme = new ColorScheme(Primary.Indigo500, Primary.Grey400, Primary.Indigo100, Accent.Pink200, TextShade.WHITE);
        }

        private void waiterForm_Load(object sender, EventArgs e)
        {
            RenderComponent();
        }

        public void RenderComponent()
        {
            Bd bd = new Bd();
            Coffee coffee = new Coffee();
            StreamReader sr = new StreamReader("E:/programming/c#/git/WindowsFormsApp1/data/data.txt");
            using (sr)
            {
                int i = 0;
                while (!sr.EndOfStream)
                {
                    string[] masData = sr.ReadLine().Split('|');
                    coffee.name = masData[0];
                    coffee.category = masData[1];
                    coffee.description = masData[2];
                    coffee.urlImg = masData[3];
                    Rendering(coffee.name, coffee.category, coffee.description, coffee.urlImg,i);
                    i++;
                }
            }
        }

        private void Rendering(string name, string category, string description, string urlImg, int i)
        {
            var pn = Ren.GetPanel(i);
            panel1.Controls.Add(pn);
            pn.Controls.AddRange(Ren.GetInformation(name, category, description));
            pn.Controls.Add(Ren.GetImage(urlImg));
        }
        private void waiterForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Hide();
            StartPage startPage = new StartPage();
            startPage.Show();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Hide();
            AddTovar addTovar = new AddTovar();
            addTovar.Show();

        }
    }

    class Render
    {
        readonly Color colorFirsst = Color.FromArgb(0, 121, 107); // 1 color
        readonly Color colorSecond = Color.FromArgb(233, 30, 99); // 2 color

        //
        // Panel
        //

        public Panel GetPanel(int i)
        {
            Panel pnl = new Panel();
            // Panel 
            int start = 20;
            pnl.Size = new System.Drawing.Size(200, 320);
            pnl.Location = new System.Drawing.Point(start + (230 * i), 0);
            pnl.BorderStyle = BorderStyle.FixedSingle;
            return pnl;
        }

        //
        // Labels
        //

        public Control[] GetInformation(string name, string type, string text)
        {
            Label LbName = new Label(); // name
            Label LbType = new Label(); // type
            Label LbText = new Label(); // description

            //
            // name
            //

            LbName.AutoSize = false;
            LbName.Text = name.ToUpper();
            LbName.Size = new System.Drawing.Size(200, 30);
            LbName.Location = new System.Drawing.Point(0, 170);
            LbName.Margin = new Padding(20, 0, 20, 10);
            LbName.Font = new System.Drawing.Font("Roboto", 8F);
            LbName.TextAlign = ContentAlignment.MiddleCenter;
            LbName.ForeColor = Color.White;
            LbName.BackColor = colorFirsst;
            LbName.Padding = new System.Windows.Forms.Padding(0, 5, 0, 5);

            //
            // type
            //

            LbType.AutoSize = true;
            LbType.Text = type;
            LbType.Padding = new System.Windows.Forms.Padding(5);
            LbType.Size = new System.Drawing.Size(180, 20);
            LbType.Location = new System.Drawing.Point(0, 200);
            LbType.TextAlign = ContentAlignment.MiddleRight;
            LbType.ForeColor = Color.White;
            LbType.BackColor = colorSecond;
            //
            // description
            //

            LbText.AutoSize = false;
            LbText.Text = text;
            LbText.Location = new System.Drawing.Point(0, 230);
            LbText.Size = new System.Drawing.Size(200, 100);
            LbText.Margin = new Padding(20, 0, 20, 10);
            LbText.TextAlign = ContentAlignment.TopLeft;
            LbText.ForeColor = Color.White;

            return new Control[] { LbName, LbType, LbText };
        }
        //
        // PictureBox
        //
        public PictureBox GetImage(string loc)
        {
            PictureBox img = new PictureBox
            {
                Location = new System.Drawing.Point(0, 0),
                Size = new System.Drawing.Size(200, 170),
                ImageLocation = loc,
                BackColor = Color.White,
                SizeMode = PictureBoxSizeMode.Zoom
            };
            return img;
        }
    }

}
