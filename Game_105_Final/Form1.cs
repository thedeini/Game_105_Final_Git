using System;
using System.Drawing;
using System.Windows.Forms;

namespace Game_105_Final
{
    public partial class loginScreen : Form
    {
        //defining variables
        UserData userData = new UserData();

        public loginScreen()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            openFileDialog1.Filter = "Choose Avatar | *.JPG; *.PNG;";
            DialogResult result = openFileDialog1.ShowDialog();
            if (result == DialogResult.OK)
            {
                pictureBox1.Image = Bitmap.FromFile(openFileDialog1.FileName);
                userData.avatarFile = openFileDialog1.FileName;
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "")
            {
                MessageBox.Show("Please enter a valid name!");
            }
            else
            {
                userData.name = textBox1.Text;
                MessageBox.Show("Press Space to jump!");
                Game gameForm = new Game(userData);//sending the user data to next form
                gameForm.ShowDialog();
            }

        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Do you want to exit the game?", "Confirmation", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                Application.Exit();
            }
        }


    }

    public class UserData
    {
        public string name = "";
        public string avatarFile = "";
    }
}
