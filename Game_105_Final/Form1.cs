using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Game_105_Final
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            DialogResult result;
            openFileDialog1.Filter = "Choose Avatar | *.JPG; *.PNG;";
            result = openFileDialog1.ShowDialog();
            if(result == DialogResult.OK)
            {
                pictureBox1.Image = Bitmap.FromFile(openFileDialog1.FileName);
                login.avatarFile = openFileDialog1.FileName;
            }
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(textBox1.Text == "")
            {
                MessageBox.Show("Please enter a valid name!");
            }
            else
            {
                login.name = textBox1.Text;
                Game gameForm = new Game();
                gameForm.ShowDialog();
            }
            
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            DialogResult result;
            result = MessageBox.Show("Do you want to exit the game?", "Confirmation", MessageBoxButtons.YesNo);
            if(result == DialogResult.Yes)
            {
                Application.Exit();
            }
        }
    }

    public static class login
    {
        public static string name = "";
        public static string avatarFile = "";
    }
}
