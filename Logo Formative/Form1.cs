//Created by Doyle Blacklock on September 19, 2016
//Created to make a Logo for Central Rams Arcade and to play pacman

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;
using System.Media;
namespace Logo_Formative
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            pacmanButton.Visible = false;
        }

        private void ClearColor(PaintEventArgs e)

        {
            e.Graphics.Clear(Color.Teal);
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void playButton_Click(object sender, EventArgs e)
        {
            SoundPlayer One = new SoundPlayer(Properties.Resources._71548__lindsayanng__1); //Setting up the "one" sound
            SoundPlayer Two = new SoundPlayer(Properties.Resources._71549__lindsayanng__2); //Setting up the "two Sound
            SoundPlayer Three = new SoundPlayer(Properties.Resources._71550__lindsayanng__3__1_); //Setting up the "three" sound
            SoundPlayer Go = new SoundPlayer(Properties.Resources._132685__ashjenx__lets_go); //Setting up the "go" sound

            Graphics formGraphics = this.CreateGraphics();//Allows for graphics to be created
            SolidBrush WhiteBrush = new SolidBrush(Color.White);//Creates a white brush
            SolidBrush RedBrush = new SolidBrush(Color.Red);//Creates a red brush
            Font BigFont = new Font("Times New Roman", 80, FontStyle.Bold);//Creates a New font colour and size
            Font MediumFont = new Font("Deja Vu Serif", 30, FontStyle.Bold);//Creates a New font colour and size
            Font LittleFont = new Font("Deja Vu Serif", 7, FontStyle.Bold);//Creates a New font colour and size

            playButton.Visible = false; //Making the button invisible


            countdownLabel.ForeColor = Color.White; //Making the label visible
            countdownLabel.Text = "Game will start in: 3"; //Changing the text of the label
            Three.Play(); //Playing sound for three

            Refresh(); //Putting the computer to sleep
            Thread.Sleep(1000);  //Putting the computer to sleep

            countdownLabel.Text = "Game will start in: 2"; //Changing the text of the label
            Two.Play(); //Playing sound for two

            Refresh();//Putting the computer to sleep
            Thread.Sleep(1000); //Putting the computer to sleep

            countdownLabel.Text = "Game will start in: 1"; //Changing the text of the label
            One.Play(); //Playing sound for one

            Refresh(); //Putting the computer to sleep
            Thread.Sleep(1000);//Putting the computer to sleep 

            countdownLabel.Visible = false;//Makes the label invisible

            BackColor = Color.Green; //Changing the color of the entire design to green

            Refresh();//Refreshs the screen and allows the images to be stacked

            formGraphics.FillEllipse(RedBrush, 65, 90, 160, 110);//Draws the Ellispe
            formGraphics.DrawString("C", BigFont, WhiteBrush, 70, 85);//Writes the C for the logo
            formGraphics.DrawString("Rams", MediumFont, WhiteBrush, 110, 120);//Writes Rams for the logo

            formGraphics.TranslateTransform(225, 200);//Moves the rotated text
            formGraphics.RotateTransform(270);//Rotates the text 270 degrees
            formGraphics.DrawString("Central Rams Arcade", LittleFont, WhiteBrush, new Rectangle());//Writes the side text
            formGraphics.ResetTransform();//Resets the rotation of the screen


            Thread.Sleep(2000);

            BackColor = Color.Black;

            pacmanButton.Visible = true;
        }

        private void playButton_MouseHover(object sender, EventArgs e)
        {
            playButton.BackColor = Color.Green; //Changing the color of the button to black when the button leaves it
        }



        private void playButton_MouseLeave(object sender, EventArgs e)
        {
            playButton.BackColor = Color.Black;

        }

        private void countdownLabel_Click(object sender, EventArgs e)
        {

        }

        private void pacmanButton_Click(object sender, EventArgs e)
        {
            Graphics formGraphics = this.CreateGraphics(); //Creates graphics variable
            Pen bluePen = new Pen(Color.Blue, 7); //Createsnpen
            SolidBrush yellowBrush = new SolidBrush(Color.Yellow); //Creates brush
            Font drawFont = new Font("Arial", 10, FontStyle.Bold); //Creates font variable

            formGraphics.TranslateTransform(175, 7); //Draws rotated line
            formGraphics.RotateTransform(45);
            formGraphics.DrawLine(bluePen, 0, 0, 100, 100);
            formGraphics.ResetTransform();

            formGraphics.TranslateTransform(178, 10);//Draws rotated line
            formGraphics.RotateTransform(135);
            formGraphics.DrawLine(bluePen, 0, 0, 120, 120);
            formGraphics.ResetTransform();

            formGraphics.TranslateTransform(100, 80);//Draws rotated line
            formGraphics.RotateTransform(135);
            formGraphics.DrawLine(bluePen, 0, 0, 65, 65);
            formGraphics.ResetTransform();

            formGraphics.TranslateTransform(100, 77);//Draws rotated line
            formGraphics.RotateTransform(45);
            formGraphics.DrawLine(bluePen, 0, 0, 50, 50);
            formGraphics.ResetTransform();

            formGraphics.FillPie(yellowBrush, 5, 20, 50, 50, 30, 300); //Draws Pacman

            Thread.Sleep(200); //Delays for 200 milliseconds


            formGraphics.Clear(Color.Black); //Clears screen


            formGraphics.FillEllipse(yellowBrush, 10, 20, 50, 50); //Draws pacman with mouth closed

            formGraphics.TranslateTransform(175, 7);//Draws rotated line
            formGraphics.RotateTransform(45);
            formGraphics.DrawLine(bluePen, 0, 0, 100, 100);
            formGraphics.ResetTransform();

            formGraphics.TranslateTransform(178, 10);//Draws rotated line
            formGraphics.RotateTransform(135);
            formGraphics.DrawLine(bluePen, 0, 0, 120, 120);
            formGraphics.ResetTransform();

            formGraphics.TranslateTransform(100, 80);//Draws rotated line
            formGraphics.RotateTransform(135);
            formGraphics.DrawLine(bluePen, 0, 0, 65, 65);
            formGraphics.ResetTransform();

            formGraphics.TranslateTransform(100, 77);//Draws rotated line
            formGraphics.RotateTransform(45);
            formGraphics.DrawLine(bluePen, 0, 0, 50, 50);
            formGraphics.ResetTransform();

            Thread.Sleep(200);//Delays for 200 milliseconds

            formGraphics.Clear(Color.Black); //Clears screen

            formGraphics.FillPie(yellowBrush, 15, 20, 50, 50, 30, 300);//Draws pacman

            formGraphics.TranslateTransform(175, 7);//Draws rotated line
            formGraphics.RotateTransform(45);
            formGraphics.DrawLine(bluePen, 0, 0, 100, 100);
            formGraphics.ResetTransform();

            formGraphics.TranslateTransform(178, 10);//Draws rotated line
            formGraphics.RotateTransform(135);
            formGraphics.DrawLine(bluePen, 0, 0, 120, 120);
            formGraphics.ResetTransform();

            formGraphics.TranslateTransform(100, 80);//Draws rotated line
            formGraphics.RotateTransform(135);
            formGraphics.DrawLine(bluePen, 0, 0, 65, 65);
            formGraphics.ResetTransform();

            formGraphics.TranslateTransform(100, 77);//Draws rotated line
            formGraphics.RotateTransform(45);
            formGraphics.DrawLine(bluePen, 0, 0, 50, 50);
            formGraphics.ResetTransform();

            Thread.Sleep(200);//Delays for 200 milliseconds

            formGraphics.Clear(Color.Black);//Clears screen

            formGraphics.FillEllipse(yellowBrush, 20, 20, 50, 50); //Draws pacman with mouth closed

            formGraphics.TranslateTransform(175, 7);//Draws rotated line
            formGraphics.RotateTransform(45);
            formGraphics.DrawLine(bluePen, 0, 0, 100, 100);
            formGraphics.ResetTransform();

            formGraphics.TranslateTransform(178, 10);//Draws rotated line
            formGraphics.RotateTransform(135);
            formGraphics.DrawLine(bluePen, 0, 0, 120, 120);
            formGraphics.ResetTransform();

            formGraphics.TranslateTransform(100, 80);//Draws rotated line
            formGraphics.RotateTransform(135);
            formGraphics.DrawLine(bluePen, 0, 0, 65, 65);
            formGraphics.ResetTransform();

            formGraphics.TranslateTransform(100, 77);//Draws rotated line
            formGraphics.RotateTransform(45);
            formGraphics.DrawLine(bluePen, 0, 0, 50, 50);
            formGraphics.ResetTransform();

            Thread.Sleep(200);//Delays for 200 milliseconds

            formGraphics.Clear(Color.Black);//Clears screen

            formGraphics.FillPie(yellowBrush, 25, 20, 50, 50, 30, 300); //Draws pacman

            formGraphics.TranslateTransform(175, 7);//Draws rotated line
            formGraphics.RotateTransform(45);
            formGraphics.DrawLine(bluePen, 0, 0, 100, 100);
            formGraphics.ResetTransform();

            formGraphics.TranslateTransform(178, 10);//Draws rotated line
            formGraphics.RotateTransform(135);
            formGraphics.DrawLine(bluePen, 0, 0, 120, 120);
            formGraphics.ResetTransform();

            formGraphics.TranslateTransform(100, 80);//Draws rotated line
            formGraphics.RotateTransform(135);
            formGraphics.DrawLine(bluePen, 0, 0, 65, 65);
            formGraphics.ResetTransform();

            formGraphics.TranslateTransform(100, 77);//Draws rotated line
            formGraphics.RotateTransform(45);
            formGraphics.DrawLine(bluePen, 0, 0, 50, 50);
            formGraphics.ResetTransform();

            Thread.Sleep(200);//Delays for 200 milliseconds

            formGraphics.Clear(Color.Black);//Clears screen

            formGraphics.FillEllipse(yellowBrush, 30, 20, 50, 50); //Draws pacman with mouth closed

            formGraphics.TranslateTransform(175, 7);//Draws rotated line
            formGraphics.RotateTransform(45);
            formGraphics.DrawLine(bluePen, 0, 0, 100, 100);
            formGraphics.ResetTransform();

            formGraphics.TranslateTransform(178, 10);//Draws rotated line
            formGraphics.RotateTransform(135);
            formGraphics.DrawLine(bluePen, 0, 0, 120, 120);
            formGraphics.ResetTransform();

            formGraphics.TranslateTransform(100, 80);//Draws rotated line
            formGraphics.RotateTransform(135);
            formGraphics.DrawLine(bluePen, 0, 0, 65, 65);
            formGraphics.ResetTransform();

            formGraphics.TranslateTransform(100, 77);//Draws rotated line
            formGraphics.RotateTransform(45);
            formGraphics.DrawLine(bluePen, 0, 0, 50, 50);
            formGraphics.ResetTransform();

            Thread.Sleep(200);//Delays for 200 milliseconds

            formGraphics.Clear(Color.Black);//Clears screen

            formGraphics.FillPie(yellowBrush, 35, 20, 50, 50, 30, 300); //Draws pacman

            formGraphics.TranslateTransform(175, 7);//Draws rotated line
            formGraphics.RotateTransform(45);
            formGraphics.DrawLine(bluePen, 0, 0, 100, 100);
            formGraphics.ResetTransform();

            formGraphics.TranslateTransform(178, 10);//Draws rotated line
            formGraphics.RotateTransform(135);
            formGraphics.DrawLine(bluePen, 0, 0, 120, 120);
            formGraphics.ResetTransform();

            formGraphics.TranslateTransform(100, 80);//Draws rotated line
            formGraphics.RotateTransform(135);
            formGraphics.DrawLine(bluePen, 0, 0, 65, 65);
            formGraphics.ResetTransform();

            formGraphics.TranslateTransform(100, 77);//Draws rotated line
            formGraphics.RotateTransform(45);
            formGraphics.DrawLine(bluePen, 0, 0, 50, 50);
            formGraphics.ResetTransform();

            Thread.Sleep(200);//Delays for 200 milliseconds

            formGraphics.Clear(Color.Black);//Clears screen

            formGraphics.FillEllipse(yellowBrush, 40, 20, 50, 50);//Draws pacman with mouth closed

            formGraphics.TranslateTransform(175, 7);//Draws rotated line
            formGraphics.RotateTransform(45);
            formGraphics.DrawLine(bluePen, 0, 0, 100, 100);
            formGraphics.ResetTransform();

            formGraphics.TranslateTransform(178, 10);//Draws rotated line
            formGraphics.RotateTransform(135);
            formGraphics.DrawLine(bluePen, 0, 0, 120, 120);
            formGraphics.ResetTransform();

            formGraphics.TranslateTransform(100, 80);//Draws rotated line
            formGraphics.RotateTransform(135);
            formGraphics.DrawLine(bluePen, 0, 0, 65, 65);
            formGraphics.ResetTransform();

            formGraphics.TranslateTransform(100, 77);//Draws rotated line
            formGraphics.RotateTransform(45);
            formGraphics.DrawLine(bluePen, 0, 0, 50, 50);
            formGraphics.ResetTransform();

            Thread.Sleep(200);//Delays for 200 milliseconds

            formGraphics.Clear(Color.Black);//Clears screen

            formGraphics.FillPie(yellowBrush, 45, 20, 50, 50, 30, 300);//Draws pacman

            formGraphics.TranslateTransform(175, 7);//Draws rotated line
            formGraphics.RotateTransform(45);
            formGraphics.DrawLine(bluePen, 0, 0, 100, 100);
            formGraphics.ResetTransform();

            formGraphics.TranslateTransform(178, 10);//Draws rotated line
            formGraphics.RotateTransform(135);
            formGraphics.DrawLine(bluePen, 0, 0, 120, 120);
            formGraphics.ResetTransform();

            formGraphics.TranslateTransform(100, 80);//Draws rotated line
            formGraphics.RotateTransform(135);
            formGraphics.DrawLine(bluePen, 0, 0, 65, 65);
            formGraphics.ResetTransform();

            formGraphics.TranslateTransform(100, 77);//Draws rotated line
            formGraphics.RotateTransform(45);
            formGraphics.DrawLine(bluePen, 0, 0, 50, 50);
            formGraphics.ResetTransform();

            Thread.Sleep(200);//Delays for 200 milliseconds

            formGraphics.Clear(Color.Black);//Clears screen


            formGraphics.FillEllipse(yellowBrush, 50, 20, 50, 50);//Draws pacman with mouth closed

            formGraphics.TranslateTransform(175, 7);//Draws rotated line
            formGraphics.RotateTransform(45);
            formGraphics.DrawLine(bluePen, 0, 0, 100, 100);
            formGraphics.ResetTransform();

            formGraphics.TranslateTransform(178, 10);//Draws rotated line
            formGraphics.RotateTransform(135);
            formGraphics.DrawLine(bluePen, 0, 0, 120, 120);
            formGraphics.ResetTransform();

            formGraphics.TranslateTransform(100, 80);//Draws rotated line
            formGraphics.RotateTransform(135);
            formGraphics.DrawLine(bluePen, 0, 0, 65, 65);
            formGraphics.ResetTransform();

            formGraphics.TranslateTransform(100, 77);//Draws rotated line
            formGraphics.RotateTransform(45);
            formGraphics.DrawLine(bluePen, 0, 0, 50, 50);
            formGraphics.ResetTransform();

            Thread.Sleep(200);//Delays for 200 milliseconds

            formGraphics.Clear(Color.Black);//Clears screen

            formGraphics.FillPie(yellowBrush, 55, 20, 50, 50, 30, 300);//Draws pacman

            formGraphics.TranslateTransform(175, 7);//Draws rotated line
            formGraphics.RotateTransform(45);
            formGraphics.DrawLine(bluePen, 0, 0, 100, 100);
            formGraphics.ResetTransform();

            formGraphics.TranslateTransform(178, 10);//Draws rotated line
            formGraphics.RotateTransform(135);
            formGraphics.DrawLine(bluePen, 0, 0, 120, 120);
            formGraphics.ResetTransform();

            formGraphics.TranslateTransform(100, 80);//Draws rotated line
            formGraphics.RotateTransform(135);
            formGraphics.DrawLine(bluePen, 0, 0, 65, 65);
            formGraphics.ResetTransform();

            formGraphics.TranslateTransform(100, 77);//Draws rotated line
            formGraphics.RotateTransform(45);
            formGraphics.DrawLine(bluePen, 0, 0, 50, 50);
            formGraphics.ResetTransform();

            Thread.Sleep(200);//Delays for 200 milliseconds

            formGraphics.Clear(Color.Black);//Clears screen

            formGraphics.FillEllipse(yellowBrush, 60, 20, 50, 50);//Draws pacman with mouth closed

            formGraphics.TranslateTransform(175, 7);//Draws rotated line
            formGraphics.RotateTransform(45);
            formGraphics.DrawLine(bluePen, 0, 0, 100, 100);
            formGraphics.ResetTransform();

            formGraphics.TranslateTransform(178, 10);//Draws rotated line
            formGraphics.RotateTransform(135);
            formGraphics.DrawLine(bluePen, 0, 0, 120, 120);
            formGraphics.ResetTransform();

            formGraphics.TranslateTransform(100, 80);//Draws rotated line
            formGraphics.RotateTransform(135);
            formGraphics.DrawLine(bluePen, 0, 0, 65, 65);
            formGraphics.ResetTransform();

            formGraphics.TranslateTransform(100, 77);//Draws rotated line
            formGraphics.RotateTransform(45);
            formGraphics.DrawLine(bluePen, 0, 0, 50, 50);
            formGraphics.ResetTransform();

            Thread.Sleep(200);//Delays for 200 milliseconds

            formGraphics.Clear(Color.Black);//Clears screen


            formGraphics.FillPie(yellowBrush, 65, 20, 50, 50, 30, 300);//Draws pacman

            formGraphics.TranslateTransform(175, 7);//Draws rotated line
            formGraphics.RotateTransform(45);
            formGraphics.DrawLine(bluePen, 0, 0, 100, 100);
            formGraphics.ResetTransform();

            formGraphics.TranslateTransform(178, 10);//Draws rotated line
            formGraphics.RotateTransform(135);
            formGraphics.DrawLine(bluePen, 0, 0, 120, 120);
            formGraphics.ResetTransform();

            formGraphics.TranslateTransform(100, 80);//Draws rotated line
            formGraphics.RotateTransform(135);
            formGraphics.DrawLine(bluePen, 0, 0, 65, 65);
            formGraphics.ResetTransform();

            formGraphics.TranslateTransform(100, 77);//Draws rotated line
            formGraphics.RotateTransform(45);
            formGraphics.DrawLine(bluePen, 0, 0, 50, 50);
            formGraphics.ResetTransform();

            Thread.Sleep(200);//Delays for 200 milliseconds

            formGraphics.Clear(Color.Black);//Clears screen


            formGraphics.FillEllipse(yellowBrush, 70, 20, 50, 50); ;//Draws pacman with mouth closed

            formGraphics.TranslateTransform(175, 7);//Draws rotated line
            formGraphics.RotateTransform(45);
            formGraphics.DrawLine(bluePen, 0, 0, 100, 100);
            formGraphics.ResetTransform();

            formGraphics.TranslateTransform(178, 10);//Draws rotated line
            formGraphics.RotateTransform(135);
            formGraphics.DrawLine(bluePen, 0, 0, 120, 120);
            formGraphics.ResetTransform();

            formGraphics.TranslateTransform(100, 80);//Draws rotated line
            formGraphics.RotateTransform(135);
            formGraphics.DrawLine(bluePen, 0, 0, 65, 65);
            formGraphics.ResetTransform();

            formGraphics.TranslateTransform(100, 77);//Draws rotated line
            formGraphics.RotateTransform(45);
            formGraphics.DrawLine(bluePen, 0, 0, 50, 50);
            formGraphics.ResetTransform();

            Thread.Sleep(200);//Delays for 200 milliseconds

            formGraphics.Clear(Color.Black);//Clears screen


            formGraphics.FillPie(yellowBrush, 75, 20, 50, 50, 30, 300);//Draws pacman

            formGraphics.TranslateTransform(175, 7);//Draws rotated line
            formGraphics.RotateTransform(45);
            formGraphics.DrawLine(bluePen, 0, 0, 100, 100);
            formGraphics.ResetTransform();

            formGraphics.TranslateTransform(178, 10);//Draws rotated line
            formGraphics.RotateTransform(135);
            formGraphics.DrawLine(bluePen, 0, 0, 120, 120);
            formGraphics.ResetTransform();

            formGraphics.TranslateTransform(100, 80);//Draws rotated line
            formGraphics.RotateTransform(135);
            formGraphics.DrawLine(bluePen, 0, 0, 65, 65);
            formGraphics.ResetTransform();

            formGraphics.TranslateTransform(100, 77);//Draws rotated line
            formGraphics.RotateTransform(45);
            formGraphics.DrawLine(bluePen, 0, 0, 50, 50);
            formGraphics.ResetTransform();

            Thread.Sleep(200);//Delays for 200 milliseconds

            formGraphics.Clear(Color.Black);//Clears screen


            formGraphics.FillEllipse(yellowBrush, 80, 20, 50, 50);//Draws pacman with mouth closed

            formGraphics.TranslateTransform(175, 7);//Draws rotated line
            formGraphics.RotateTransform(45);
            formGraphics.DrawLine(bluePen, 0, 0, 100, 100);
            formGraphics.ResetTransform();

            formGraphics.TranslateTransform(178, 10);//Draws rotated line
            formGraphics.RotateTransform(135);
            formGraphics.DrawLine(bluePen, 0, 0, 120, 120);
            formGraphics.ResetTransform();

            formGraphics.TranslateTransform(100, 80);//Draws rotated line
            formGraphics.RotateTransform(135);
            formGraphics.DrawLine(bluePen, 0, 0, 65, 65);
            formGraphics.ResetTransform();

            formGraphics.TranslateTransform(100, 77);//Draws rotated line
            formGraphics.RotateTransform(45);
            formGraphics.DrawLine(bluePen, 0, 0, 50, 50);
            formGraphics.ResetTransform();

            Thread.Sleep(200);//Delays for 200 milliseconds

            formGraphics.Clear(Color.Black);//Clears screen

            formGraphics.FillPie(yellowBrush, 85, 20, 50, 50, 30, 300);//Draws pacman

            formGraphics.TranslateTransform(175, 7);//Draws rotated line
            formGraphics.RotateTransform(45);
            formGraphics.DrawLine(bluePen, 0, 0, 100, 100);
            formGraphics.ResetTransform();

            formGraphics.TranslateTransform(178, 10);//Draws rotated line
            formGraphics.RotateTransform(135);
            formGraphics.DrawLine(bluePen, 0, 0, 120, 120);
            formGraphics.ResetTransform();

            formGraphics.TranslateTransform(100, 80);//Draws rotated line
            formGraphics.RotateTransform(135);
            formGraphics.DrawLine(bluePen, 0, 0, 65, 65);
            formGraphics.ResetTransform();

            formGraphics.TranslateTransform(100, 77);//Draws rotated line
            formGraphics.RotateTransform(45);
            formGraphics.DrawLine(bluePen, 0, 0, 50, 50);
            formGraphics.ResetTransform();

            Thread.Sleep(200);//Delays for 200 milliseconds

            formGraphics.Clear(Color.Black);//Clears screen

            formGraphics.FillEllipse(yellowBrush, 90, 20, 50, 50);//Draws pacman with mouth closed

            formGraphics.TranslateTransform(175, 7);//Draws rotated line
            formGraphics.RotateTransform(45);
            formGraphics.DrawLine(bluePen, 0, 0, 100, 100);
            formGraphics.ResetTransform();

            formGraphics.TranslateTransform(178, 10);//Draws rotated line
            formGraphics.RotateTransform(135);
            formGraphics.DrawLine(bluePen, 0, 0, 120, 120);
            formGraphics.ResetTransform();

            formGraphics.TranslateTransform(100, 80);//Draws rotated line
            formGraphics.RotateTransform(135);
            formGraphics.DrawLine(bluePen, 0, 0, 65, 65);
            formGraphics.ResetTransform();

            formGraphics.TranslateTransform(100, 77);//Draws rotated line
            formGraphics.RotateTransform(45);
            formGraphics.DrawLine(bluePen, 0, 0, 50, 50);
            formGraphics.ResetTransform();

            Thread.Sleep(200);//Delays for 200 milliseconds

            formGraphics.Clear(Color.Black);//Clears screen

            formGraphics.FillPie(yellowBrush, 95, 20, 50, 50, 30, 300);//Draws pacman

            formGraphics.TranslateTransform(175, 7);//Draws rotated line
            formGraphics.RotateTransform(45);
            formGraphics.DrawLine(bluePen, 0, 0, 100, 100);
            formGraphics.ResetTransform();

            formGraphics.TranslateTransform(178, 10);//Draws rotated line
            formGraphics.RotateTransform(135);
            formGraphics.DrawLine(bluePen, 0, 0, 120, 120);
            formGraphics.ResetTransform();

            formGraphics.TranslateTransform(100, 80);//Draws rotated line
            formGraphics.RotateTransform(135);
            formGraphics.DrawLine(bluePen, 0, 0, 65, 65);
            formGraphics.ResetTransform();

            formGraphics.TranslateTransform(100, 77);//Draws rotated line
            formGraphics.RotateTransform(45);
            formGraphics.DrawLine(bluePen, 0, 0, 50, 50);
            formGraphics.ResetTransform();

            Thread.Sleep(200);//Delays for 200 milliseconds

            formGraphics.Clear(Color.Black);//Clears screen

            formGraphics.FillEllipse(yellowBrush, 100, 20, 50, 50);//Draws pacman with mouth closed

            formGraphics.TranslateTransform(175, 7);//Draws rotated line
            formGraphics.RotateTransform(45);
            formGraphics.DrawLine(bluePen, 0, 0, 100, 100);
            formGraphics.ResetTransform();

            formGraphics.TranslateTransform(178, 10);//Draws rotated line
            formGraphics.RotateTransform(135);
            formGraphics.DrawLine(bluePen, 0, 0, 120, 120);
            formGraphics.ResetTransform();

            formGraphics.TranslateTransform(100, 80);//Draws rotated line
            formGraphics.RotateTransform(135);
            formGraphics.DrawLine(bluePen, 0, 0, 65, 65);
            formGraphics.ResetTransform();

            formGraphics.TranslateTransform(100, 77);//Draws rotated line
            formGraphics.RotateTransform(45);
            formGraphics.DrawLine(bluePen, 0, 0, 50, 50);
            formGraphics.ResetTransform();

            Thread.Sleep(200);//Delays for 200 milliseconds

            formGraphics.Clear(Color.Black);//Clears screen

            formGraphics.FillPie(yellowBrush, 105, 20, 50, 50, 30, 300);//Draws pacman

            formGraphics.TranslateTransform(175, 7);//Draws rotated line
            formGraphics.RotateTransform(45);
            formGraphics.DrawLine(bluePen, 0, 0, 100, 100);
            formGraphics.ResetTransform();

            formGraphics.TranslateTransform(178, 10);//Draws rotated line
            formGraphics.RotateTransform(135);
            formGraphics.DrawLine(bluePen, 0, 0, 120, 120);
            formGraphics.ResetTransform();

            formGraphics.TranslateTransform(100, 80);//Draws rotated line
            formGraphics.RotateTransform(135);
            formGraphics.DrawLine(bluePen, 0, 0, 65, 65);
            formGraphics.ResetTransform();

            formGraphics.TranslateTransform(100, 77);//Draws rotated line
            formGraphics.RotateTransform(45);
            formGraphics.DrawLine(bluePen, 0, 0, 50, 50);
            formGraphics.ResetTransform();

            Thread.Sleep(200);//Delays for 200 milliseconds

            formGraphics.Clear(Color.Black);//Clears screen


            formGraphics.FillEllipse(yellowBrush, 110, 20, 50, 50);//Draws pacman with mouth closed

            formGraphics.TranslateTransform(175, 7);//Draws rotated line
            formGraphics.RotateTransform(45);
            formGraphics.DrawLine(bluePen, 0, 0, 100, 100);
            formGraphics.ResetTransform();

            formGraphics.TranslateTransform(178, 10);//Draws rotated line
            formGraphics.RotateTransform(135);
            formGraphics.DrawLine(bluePen, 0, 0, 120, 120);
            formGraphics.ResetTransform();

            formGraphics.TranslateTransform(100, 80);//Draws rotated line
            formGraphics.RotateTransform(135);
            formGraphics.DrawLine(bluePen, 0, 0, 65, 65);
            formGraphics.ResetTransform();

            formGraphics.TranslateTransform(100, 77);//Draws rotated line
            formGraphics.RotateTransform(45);
            formGraphics.DrawLine(bluePen, 0, 0, 50, 50);
            formGraphics.ResetTransform();

            Thread.Sleep(200);//Delays for 200 milliseconds

            formGraphics.Clear(Color.Black);//Clears screen


            formGraphics.FillPie(yellowBrush, 110, 20, 50, 50, 120, 300);//Draws pacman

            formGraphics.TranslateTransform(175, 7);//Draws rotated line
            formGraphics.RotateTransform(45);
            formGraphics.DrawLine(bluePen, 0, 0, 100, 100);
            formGraphics.ResetTransform();

            formGraphics.TranslateTransform(178, 10);//Draws rotated line
            formGraphics.RotateTransform(135);
            formGraphics.DrawLine(bluePen, 0, 0, 120, 120);
            formGraphics.ResetTransform();

            formGraphics.TranslateTransform(100, 80);//Draws rotated line
            formGraphics.RotateTransform(135);
            formGraphics.DrawLine(bluePen, 0, 0, 65, 65);
            formGraphics.ResetTransform();

            formGraphics.TranslateTransform(100, 77);//Draws rotated line
            formGraphics.RotateTransform(45);
            formGraphics.DrawLine(bluePen, 0, 0, 50, 50);
            formGraphics.ResetTransform();

            Thread.Sleep(200);//Delays for 200 milliseconds

            formGraphics.Clear(Color.Black);//Clears screen

            formGraphics.FillEllipse(yellowBrush, 110, 25, 50, 50);//Draws pacman with mouth closed

            formGraphics.TranslateTransform(175, 7);//Draws rotated line
            formGraphics.RotateTransform(45);
            formGraphics.DrawLine(bluePen, 0, 0, 100, 100);
            formGraphics.ResetTransform();

            formGraphics.TranslateTransform(178, 10);//Draws rotated line
            formGraphics.RotateTransform(135);
            formGraphics.DrawLine(bluePen, 0, 0, 120, 120);
            formGraphics.ResetTransform();

            formGraphics.TranslateTransform(100, 80);//Draws rotated line
            formGraphics.RotateTransform(135);
            formGraphics.DrawLine(bluePen, 0, 0, 65, 65);
            formGraphics.ResetTransform();

            formGraphics.TranslateTransform(100, 77);//Draws rotated line
            formGraphics.RotateTransform(45);
            formGraphics.DrawLine(bluePen, 0, 0, 50, 50);
            formGraphics.ResetTransform();

            Thread.Sleep(200);//Delays for 200 milliseconds

            formGraphics.Clear(Color.Black); ;//Clears screen

            formGraphics.FillPie(yellowBrush, 110, 30, 50, 50, 120, 300);//Draws pacman

            formGraphics.TranslateTransform(175, 7);//Draws rotated line
            formGraphics.RotateTransform(45);
            formGraphics.DrawLine(bluePen, 0, 0, 100, 100);
            formGraphics.ResetTransform();

            formGraphics.TranslateTransform(178, 10);//Draws rotated line
            formGraphics.RotateTransform(135);
            formGraphics.DrawLine(bluePen, 0, 0, 120, 120);
            formGraphics.ResetTransform();

            formGraphics.TranslateTransform(100, 80);//Draws rotated line
            formGraphics.RotateTransform(135);
            formGraphics.DrawLine(bluePen, 0, 0, 65, 65);
            formGraphics.ResetTransform();

            formGraphics.TranslateTransform(100, 77);//Draws rotated line
            formGraphics.RotateTransform(45);
            formGraphics.DrawLine(bluePen, 0, 0, 50, 50);
            formGraphics.ResetTransform();

            Thread.Sleep(200);//Delays for 200 milliseconds

            formGraphics.Clear(Color.Black);//Clears screen

            formGraphics.FillEllipse(yellowBrush, 110, 35, 50, 50);//Draws pacman with mouth closed

            formGraphics.TranslateTransform(175, 7);//Draws rotated line
            formGraphics.RotateTransform(45);
            formGraphics.DrawLine(bluePen, 0, 0, 100, 100);
            formGraphics.ResetTransform();

            formGraphics.TranslateTransform(178, 10);//Draws rotated line
            formGraphics.RotateTransform(135);
            formGraphics.DrawLine(bluePen, 0, 0, 120, 120);
            formGraphics.ResetTransform();

            formGraphics.TranslateTransform(100, 80);//Draws rotated line
            formGraphics.RotateTransform(135);
            formGraphics.DrawLine(bluePen, 0, 0, 65, 65);
            formGraphics.ResetTransform();

            formGraphics.TranslateTransform(100, 77);//Draws rotated line
            formGraphics.RotateTransform(45);
            formGraphics.DrawLine(bluePen, 0, 0, 50, 50);
            formGraphics.ResetTransform();

            Thread.Sleep(200);//Delays for 200 milliseconds

            formGraphics.Clear(Color.Black);//Clears screen

            formGraphics.FillPie(yellowBrush, 110, 40, 50, 50, 120, 300);//Draws pacman

            formGraphics.TranslateTransform(175, 7);//Draws rotated line
            formGraphics.RotateTransform(45);
            formGraphics.DrawLine(bluePen, 0, 0, 100, 100);
            formGraphics.ResetTransform();

            formGraphics.TranslateTransform(178, 10);//Draws rotated line
            formGraphics.RotateTransform(135);
            formGraphics.DrawLine(bluePen, 0, 0, 120, 120);
            formGraphics.ResetTransform();

            formGraphics.TranslateTransform(100, 80);//Draws rotated line
            formGraphics.RotateTransform(135);
            formGraphics.DrawLine(bluePen, 0, 0, 65, 65);
            formGraphics.ResetTransform();

            formGraphics.TranslateTransform(100, 77);//Draws rotated line
            formGraphics.RotateTransform(45);
            formGraphics.DrawLine(bluePen, 0, 0, 50, 50);
            formGraphics.ResetTransform();

            Thread.Sleep(200);//Delays for 200 milliseconds

            formGraphics.Clear(Color.Black);//Clears screen

            formGraphics.FillEllipse(yellowBrush, 110, 45, 50, 50);//Draws pacman with mouth closed

            formGraphics.TranslateTransform(175, 7);//Draws rotated line
            formGraphics.RotateTransform(45);
            formGraphics.DrawLine(bluePen, 0, 0, 100, 100);
            formGraphics.ResetTransform();

            formGraphics.TranslateTransform(178, 10);//Draws rotated line
            formGraphics.RotateTransform(135);
            formGraphics.DrawLine(bluePen, 0, 0, 120, 120);
            formGraphics.ResetTransform();

            formGraphics.TranslateTransform(100, 80);//Draws rotated line
            formGraphics.RotateTransform(135);
            formGraphics.DrawLine(bluePen, 0, 0, 65, 65);
            formGraphics.ResetTransform();

            formGraphics.TranslateTransform(100, 77);//Draws rotated line
            formGraphics.RotateTransform(45);
            formGraphics.DrawLine(bluePen, 0, 0, 50, 50);
            formGraphics.ResetTransform();

            Thread.Sleep(200);//Delays for 200 milliseconds

            formGraphics.Clear(Color.Black);//Clears screen


            formGraphics.FillPie(yellowBrush, 110, 50, 50, 50, 120, 300);//Draws pacman

            formGraphics.TranslateTransform(175, 7);//Draws rotated line
            formGraphics.RotateTransform(45);
            formGraphics.DrawLine(bluePen, 0, 0, 100, 100);
            formGraphics.ResetTransform();

            formGraphics.TranslateTransform(178, 10);//Draws rotated line
            formGraphics.RotateTransform(135);
            formGraphics.DrawLine(bluePen, 0, 0, 120, 120);
            formGraphics.ResetTransform();

            formGraphics.TranslateTransform(100, 80);//Draws rotated line
            formGraphics.RotateTransform(135);
            formGraphics.DrawLine(bluePen, 0, 0, 65, 65);
            formGraphics.ResetTransform();

            formGraphics.TranslateTransform(100, 77);//Draws rotated line
            formGraphics.RotateTransform(45);
            formGraphics.DrawLine(bluePen, 0, 0, 50, 50);
            formGraphics.ResetTransform();

            Thread.Sleep(200);//Delays for 200 milliseconds

            formGraphics.Clear(Color.Black);//Clears screen

            formGraphics.FillEllipse(yellowBrush, 110, 55, 50, 50);//Draws pacman with mouth closed

            formGraphics.TranslateTransform(175, 7);//Draws rotated line
            formGraphics.RotateTransform(45);
            formGraphics.DrawLine(bluePen, 0, 0, 100, 100);
            formGraphics.ResetTransform();

            formGraphics.TranslateTransform(178, 10);//Draws rotated line
            formGraphics.RotateTransform(135);
            formGraphics.DrawLine(bluePen, 0, 0, 120, 120);
            formGraphics.ResetTransform();

            formGraphics.TranslateTransform(100, 80);//Draws rotated line
            formGraphics.RotateTransform(135);
            formGraphics.DrawLine(bluePen, 0, 0, 65, 65);
            formGraphics.ResetTransform();

            formGraphics.TranslateTransform(100, 77);//Draws rotated line
            formGraphics.RotateTransform(45);
            formGraphics.DrawLine(bluePen, 0, 0, 50, 50);
            formGraphics.ResetTransform();

            Thread.Sleep(200);//Delays for 200 milliseconds

            formGraphics.Clear(Color.Black);//Clears screen

            formGraphics.FillPie(yellowBrush, 110, 60, 50, 50, 120, 300);//Draws pacman

            formGraphics.TranslateTransform(175, 7);//Draws rotated line
            formGraphics.RotateTransform(45);
            formGraphics.DrawLine(bluePen, 0, 0, 100, 100);
            formGraphics.ResetTransform();

            formGraphics.TranslateTransform(178, 10);//Draws rotated line
            formGraphics.RotateTransform(135);
            formGraphics.DrawLine(bluePen, 0, 0, 120, 120);
            formGraphics.ResetTransform();

            formGraphics.TranslateTransform(100, 80);//Draws rotated line
            formGraphics.RotateTransform(135);
            formGraphics.DrawLine(bluePen, 0, 0, 65, 65);
            formGraphics.ResetTransform();

            formGraphics.TranslateTransform(100, 77);//Draws rotated line
            formGraphics.RotateTransform(45);
            formGraphics.DrawLine(bluePen, 0, 0, 50, 50);
            formGraphics.ResetTransform();

            Thread.Sleep(200);//Delays for 200 milliseconds

            formGraphics.Clear(Color.Black);//Clears screen

            formGraphics.FillEllipse(yellowBrush, 110, 65, 50, 50);//Draws pacman with mouth closed

            formGraphics.TranslateTransform(175, 7);//Draws rotated line
            formGraphics.RotateTransform(45);
            formGraphics.DrawLine(bluePen, 0, 0, 100, 100);
            formGraphics.ResetTransform();

            formGraphics.TranslateTransform(178, 10);//Draws rotated line
            formGraphics.RotateTransform(135);
            formGraphics.DrawLine(bluePen, 0, 0, 120, 120);
            formGraphics.ResetTransform();

            formGraphics.TranslateTransform(100, 80);//Draws rotated line
            formGraphics.RotateTransform(135);
            formGraphics.DrawLine(bluePen, 0, 0, 65, 65);
            formGraphics.ResetTransform();

            formGraphics.TranslateTransform(100, 77);//Draws rotated line
            formGraphics.RotateTransform(45);
            formGraphics.DrawLine(bluePen, 0, 0, 50, 50);
            formGraphics.ResetTransform();

            Thread.Sleep(200);//Delays for 200 milliseconds

            formGraphics.Clear(Color.Black);//Clears screen

            formGraphics.FillPie(yellowBrush, 110, 70, 50, 50, 120, 300);//Draws pacman

            formGraphics.TranslateTransform(175, 7);//Draws rotated line
            formGraphics.RotateTransform(45);
            formGraphics.DrawLine(bluePen, 0, 0, 100, 100);
            formGraphics.ResetTransform();

            formGraphics.TranslateTransform(178, 10);//Draws rotated line
            formGraphics.RotateTransform(135);
            formGraphics.DrawLine(bluePen, 0, 0, 120, 120);
            formGraphics.ResetTransform();

            formGraphics.TranslateTransform(100, 80);//Draws rotated line
            formGraphics.RotateTransform(135);
            formGraphics.DrawLine(bluePen, 0, 0, 65, 65);
            formGraphics.ResetTransform();

            formGraphics.TranslateTransform(100, 77);//Draws rotated line
            formGraphics.RotateTransform(45);
            formGraphics.DrawLine(bluePen, 0, 0, 50, 50);
            formGraphics.ResetTransform();

            Thread.Sleep(200);//Delays for 200 milliseconds

            formGraphics.Clear(Color.Black);//Clears screen

            formGraphics.FillEllipse(yellowBrush, 110, 75, 50, 50);//Draws pacman with mouth closed

            formGraphics.TranslateTransform(175, 7);//Draws rotated line
            formGraphics.RotateTransform(45);
            formGraphics.DrawLine(bluePen, 0, 0, 100, 100);
            formGraphics.ResetTransform();

            formGraphics.TranslateTransform(178, 10);//Draws rotated line
            formGraphics.RotateTransform(135);
            formGraphics.DrawLine(bluePen, 0, 0, 120, 120);
            formGraphics.ResetTransform();

            formGraphics.TranslateTransform(100, 80);//Draws rotated line
            formGraphics.RotateTransform(135);
            formGraphics.DrawLine(bluePen, 0, 0, 65, 65);
            formGraphics.ResetTransform();

            formGraphics.TranslateTransform(100, 77);//Draws rotated line
            formGraphics.RotateTransform(45);
            formGraphics.DrawLine(bluePen, 0, 0, 50, 50);
            formGraphics.ResetTransform();

            Thread.Sleep(200);//Delays for 200 milliseconds

            formGraphics.Clear(Color.Black);//Delays for 200 milliseconds

            formGraphics.FillPie(yellowBrush, 110, 80, 50, 50, 120, 300);//Draws pacman

            formGraphics.TranslateTransform(175, 7);//Draws rotated line
            formGraphics.RotateTransform(45);
            formGraphics.DrawLine(bluePen, 0, 0, 100, 100);
            formGraphics.ResetTransform();

            formGraphics.TranslateTransform(178, 10);//Draws rotated line
            formGraphics.RotateTransform(135);
            formGraphics.DrawLine(bluePen, 0, 0, 120, 120);
            formGraphics.ResetTransform();

            formGraphics.TranslateTransform(100, 80);//Draws rotated line
            formGraphics.RotateTransform(135);
            formGraphics.DrawLine(bluePen, 0, 0, 65, 65);
            formGraphics.ResetTransform();

            formGraphics.TranslateTransform(100, 77);//Draws rotated line
            formGraphics.RotateTransform(45);
            formGraphics.DrawLine(bluePen, 0, 0, 50, 50);
            formGraphics.ResetTransform();

            Thread.Sleep(200);//Delays for 200 milliseconds

            formGraphics.Clear(Color.Black);//Clears screen

            formGraphics.FillEllipse(yellowBrush, 110, 85, 50, 50);//Draws pacman with mouth closed

            formGraphics.TranslateTransform(175, 7);//Draws rotated line
            formGraphics.RotateTransform(45);
            formGraphics.DrawLine(bluePen, 0, 0, 100, 100);
            formGraphics.ResetTransform();

            formGraphics.TranslateTransform(178, 10);//Draws rotated line
            formGraphics.RotateTransform(135);
            formGraphics.DrawLine(bluePen, 0, 0, 120, 120);
            formGraphics.ResetTransform();

            formGraphics.TranslateTransform(100, 80);//Draws rotated line
            formGraphics.RotateTransform(135);
            formGraphics.DrawLine(bluePen, 0, 0, 65, 65);
            formGraphics.ResetTransform();

            formGraphics.TranslateTransform(100, 77);//Draws rotated line
            formGraphics.RotateTransform(45);
            formGraphics.DrawLine(bluePen, 0, 0, 50, 50);
            formGraphics.ResetTransform();

            Thread.Sleep(200);//Delays for 200 milliseconds

            formGraphics.Clear(Color.Black);//Clears screen

            formGraphics.FillPie(yellowBrush, 110, 90, 50, 50, 120, 300);//Draws pacman

            formGraphics.TranslateTransform(175, 7);//Draws rotated line
            formGraphics.RotateTransform(45);
            formGraphics.DrawLine(bluePen, 0, 0, 100, 100);
            formGraphics.ResetTransform();

            formGraphics.TranslateTransform(178, 10);//Draws rotated line
            formGraphics.RotateTransform(135);
            formGraphics.DrawLine(bluePen, 0, 0, 120, 120);
            formGraphics.ResetTransform();

            formGraphics.TranslateTransform(100, 80);//Draws rotated line
            formGraphics.RotateTransform(135);
            formGraphics.DrawLine(bluePen, 0, 0, 65, 65);
            formGraphics.ResetTransform();

            formGraphics.TranslateTransform(100, 77);//Draws rotated line
            formGraphics.RotateTransform(45);
            formGraphics.DrawLine(bluePen, 0, 0, 50, 50);
            formGraphics.ResetTransform();

            Thread.Sleep(200);//Delays for 200 milliseconds

            formGraphics.Clear(Color.Black);//Clears screen

            formGraphics.FillEllipse(yellowBrush, 110, 95, 50, 50);//Draws pacman with mouth closed

            formGraphics.TranslateTransform(175, 7);//Draws rotated line
            formGraphics.RotateTransform(45);
            formGraphics.DrawLine(bluePen, 0, 0, 100, 100);
            formGraphics.ResetTransform();

            formGraphics.TranslateTransform(178, 10);//Draws rotated line
            formGraphics.RotateTransform(135);
            formGraphics.DrawLine(bluePen, 0, 0, 120, 120);
            formGraphics.ResetTransform();

            formGraphics.TranslateTransform(100, 80);//Draws rotated line
            formGraphics.RotateTransform(135);
            formGraphics.DrawLine(bluePen, 0, 0, 65, 65);
            formGraphics.ResetTransform();

            formGraphics.TranslateTransform(100, 77);//Draws rotated line
            formGraphics.RotateTransform(45);
            formGraphics.DrawLine(bluePen, 0, 0, 50, 50);
            formGraphics.ResetTransform();

            Thread.Sleep(200);//Delays for 200 milliseconds

            formGraphics.Clear(Color.Black);//Clears screen

            formGraphics.FillPie(yellowBrush, 110, 100, 50, 50, 120, 300);//Draws pacman

            formGraphics.TranslateTransform(175, 7);//Draws rotated line
            formGraphics.RotateTransform(45);
            formGraphics.DrawLine(bluePen, 0, 0, 100, 100);
            formGraphics.ResetTransform();

            formGraphics.TranslateTransform(178, 10);//Draws rotated line
            formGraphics.RotateTransform(135);
            formGraphics.DrawLine(bluePen, 0, 0, 120, 120);
            formGraphics.ResetTransform();

            formGraphics.TranslateTransform(100, 80);//Draws rotated line
            formGraphics.RotateTransform(135);
            formGraphics.DrawLine(bluePen, 0, 0, 65, 65);
            formGraphics.ResetTransform();

            formGraphics.TranslateTransform(100, 77);//Draws rotated line
            formGraphics.RotateTransform(45);
            formGraphics.DrawLine(bluePen, 0, 0, 50, 50);
            formGraphics.ResetTransform();

            Thread.Sleep(200);//Delays for 200 milliseconds

            formGraphics.Clear(Color.Black);//Clears screen

            formGraphics.FillEllipse(yellowBrush, 110, 105, 50, 50);//Draws pacman with mouth closed

            formGraphics.TranslateTransform(175, 7);//Draws rotated line
            formGraphics.RotateTransform(45);
            formGraphics.DrawLine(bluePen, 0, 0, 100, 100);
            formGraphics.ResetTransform();

            formGraphics.TranslateTransform(178, 10);//Draws rotated line
            formGraphics.RotateTransform(135);
            formGraphics.DrawLine(bluePen, 0, 0, 120, 120);
            formGraphics.ResetTransform();

            formGraphics.TranslateTransform(100, 80);//Draws rotated line
            formGraphics.RotateTransform(135);
            formGraphics.DrawLine(bluePen, 0, 0, 65, 65);
            formGraphics.ResetTransform();

            formGraphics.TranslateTransform(100, 77);//Draws rotated line
            formGraphics.RotateTransform(45);
            formGraphics.DrawLine(bluePen, 0, 0, 50, 50);
            formGraphics.ResetTransform();

            Thread.Sleep(200);//Delays for 200 milliseconds

            formGraphics.Clear(Color.Black);//Clears screen

            formGraphics.FillPie(yellowBrush, 110, 110, 50, 50, 120, 300);//Draws pacman

            formGraphics.TranslateTransform(175, 7);//Draws rotated line
            formGraphics.RotateTransform(45);
            formGraphics.DrawLine(bluePen, 0, 0, 100, 100);
            formGraphics.ResetTransform();

            formGraphics.TranslateTransform(178, 10);//Draws rotated line
            formGraphics.RotateTransform(135);
            formGraphics.DrawLine(bluePen, 0, 0, 120, 120);
            formGraphics.ResetTransform();

            formGraphics.TranslateTransform(100, 80);//Draws rotated line
            formGraphics.RotateTransform(135);
            formGraphics.DrawLine(bluePen, 0, 0, 65, 65);
            formGraphics.ResetTransform();

            formGraphics.TranslateTransform(100, 77);//Draws rotated line
            formGraphics.RotateTransform(45);
            formGraphics.DrawLine(bluePen, 0, 0, 50, 50);
            formGraphics.ResetTransform();

            Thread.Sleep(200);//Delays for 200 milliseconds

            formGraphics.Clear(Color.Black);//Clears screen

            formGraphics.FillEllipse(yellowBrush, 110, 115, 50, 50);//Draws pacman with mouth closed

            formGraphics.TranslateTransform(175, 7);//Draws rotated line
            formGraphics.RotateTransform(45);
            formGraphics.DrawLine(bluePen, 0, 0, 100, 100);
            formGraphics.ResetTransform();

            formGraphics.TranslateTransform(178, 10);//Draws rotated line
            formGraphics.RotateTransform(135);
            formGraphics.DrawLine(bluePen, 0, 0, 120, 120);
            formGraphics.ResetTransform();

            formGraphics.TranslateTransform(100, 80);//Draws rotated line
            formGraphics.RotateTransform(135);
            formGraphics.DrawLine(bluePen, 0, 0, 65, 65);
            formGraphics.ResetTransform();

            formGraphics.TranslateTransform(100, 77);//Draws rotated line
            formGraphics.RotateTransform(45);
            formGraphics.DrawLine(bluePen, 0, 0, 50, 50);
            formGraphics.ResetTransform();

            Thread.Sleep(200);//Delays for 200 milliseconds

            formGraphics.Clear(Color.Black);//Clears screen

            formGraphics.FillPie(yellowBrush, 110, 120, 50, 50, 120, 300);//Draws pacman

            formGraphics.TranslateTransform(175, 7);//Draws rotated line
            formGraphics.RotateTransform(45);
            formGraphics.DrawLine(bluePen, 0, 0, 100, 100);
            formGraphics.ResetTransform();

            formGraphics.TranslateTransform(178, 10);//Draws rotated line
            formGraphics.RotateTransform(135);
            formGraphics.DrawLine(bluePen, 0, 0, 120, 120);
            formGraphics.ResetTransform();

            formGraphics.TranslateTransform(100, 80);//Draws rotated line
            formGraphics.RotateTransform(135);
            formGraphics.DrawLine(bluePen, 0, 0, 65, 65);
            formGraphics.ResetTransform();

            formGraphics.TranslateTransform(100, 77);//Draws rotated line
            formGraphics.RotateTransform(45);
            formGraphics.DrawLine(bluePen, 0, 0, 50, 50);
            formGraphics.ResetTransform();

            formGraphics.DrawString("Congratulations", drawFont, yellowBrush, 180, 40);//Writes congratulations



        }
    }
}


