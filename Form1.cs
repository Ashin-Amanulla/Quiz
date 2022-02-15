using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Quiz
{
    public partial class Form1 : Form
    {


        //quiz variables

        int correctAnswer;
        int questionNumber = 1;
        int score;
        int percentage;
        int totalQuestions;


        public Form1()
        {
            InitializeComponent();
            askQuestion(questionNumber);
            totalQuestions = 12;
        }

        private void chkevent(object sender, EventArgs e)
        {
            var senderObject = (Button)sender;

            int buttonTag = Convert.ToInt32(senderObject.Tag);

            //Score
            if(buttonTag == correctAnswer)
            {
                score++;
            }

            if (questionNumber== totalQuestions)
            {
                //percentage

                percentage = (int)Math.Round((double)(score*100)/totalQuestions);

                //Message box

                MessageBox.Show(
                    "Quiz Ended !" + Environment.NewLine+ 
                    "You have answered    " + score + "   questions correctly !!" + Environment.NewLine+
                    "Your total percentage is   " + percentage + "%   " + Environment.NewLine+
                    "Click OK to play again"



                    );

                score = 0;
                questionNumber = 0;
                askQuestion(questionNumber);

            }

            questionNumber++;
            askQuestion(questionNumber);
        }



        //Questions 
        private void askQuestion(int qnum)
        {
            switch (qnum)
            {
                case 1:
                    pictureBox1.Image = Properties.Resources._0531_turtle_shell;

                    lblQuestion.Text = "Turtles shells are made of how many bones fused together?";


                    button1.Text = "Over 5";
                    button2.Text = "Over 30";
                    button3.Text = "Over 50";
                    button4.Text = "Over 70";

                    correctAnswer = 3;
                    break;


                case 2:
                    pictureBox1.Image = Properties.Resources.orca_590541;

                    lblQuestion.Text = "..................... the largest species of dolphin?";


                    button1.Text = "Bottlenose Dolphin";
                    button2.Text = "Amazon River Dolphin";
                    button3.Text = "Spinner Dolphin ";
                    button4.Text = "Orca";

                    correctAnswer = 4;
                    break;

                case 3:
                    pictureBox1.Image = Properties.Resources.orange_frogfish;

                    lblQuestion.Text = "Can you name this fish found in the waters off Indonesia?";


                    button1.Text = "Frog Fish";
                    button2.Text = "Tod Fish";
                    button3.Text = "Rabbit Fish ";
                    button4.Text = "Blob Fish";

                    correctAnswer = 1;
                    break;


                case 4:
                    pictureBox1.Image = Properties.Resources.horseshoe_crab_scaled;

                    lblQuestion.Text = "It's not really a crab, but what is it called?";


                    button1.Text = "Horseshoe Crab";
                    button2.Text = "Atlantic blue crab";
                    button3.Text = "Hermit crab";
                    button4.Text = "Red King Crab";

                    correctAnswer = 1;
                    break;

                case 5:
                    pictureBox1.Visible = false;

                    lblQuestion.Text = "A squid has eight tentacles like an octopus.";


                    button1.Text = "True";
                    button2.Text = "False";
                    button3.Hide() ;
                    button4.Hide ();

                    correctAnswer = 2;
                    break;


                case 6:
            

                    lblQuestion.Text = "Dolphins use ........... to breathe";

                    button3.Show();
                    button4.Show();

                    button1.Text = "Gills";
                    button2.Text = "Lungs";
                    button3.Text = "Skin";
                    button4.Text = "Flippers";
                    correctAnswer = 2;
                    break;

                case 7:
                    pictureBox1.Visible = true;
                    pictureBox1.Image = Properties.Resources.Vamp_squid;

                    lblQuestion.Text = "This red-hued sea-animal is the stuff of nightmares. Do you know what it's called?";


                    button1.Text = "Lanternfish";
                    button2.Text = "Eelpout";
                    button3.Text = "Viperfish ";
                    button4.Text = "Vampire squid";

                    correctAnswer = 4;
                    break;


                case 8:
                    pictureBox1.Image = Properties.Resources.angler;

                    lblQuestion.Text = "This frightening fish has a lantern-like appendage that lights its way in the deep, dark sea. What is it?";


                    button1.Text = "Sea robin";
                    button2.Text = "Fangtooth fish";
                    button3.Text = "Viperfish";
                    button4.Text = "Anglerfish";
                    correctAnswer = 4;
                    break;

                case 9:
                    pictureBox1.Image = Properties.Resources.swordfish;

                    lblQuestion.Text = "The swordfish can swim as fast as 62 mph (100 km/h).";


                    button1.Text = "True";
                    button2.Text = "False";
                    button3.Hide();
                    button4.Hide();
                    correctAnswer = 1;
                    break;


                case 10:
                    pictureBox1.Image = Properties.Resources.stargazer;

                    lblQuestion.Text = "This fish has eyes atop its head and loves to bury its body in the deep-sea sand. Do you know what it's called?";

                    button3.Show();
                    button4.Show();

                    button1.Text = "Spottail pinfish";
                    button2.Text = "Scup fish";
                    button3.Text = "Stargazer fish";
                    button4.Text = "Crimson seabream";
                    correctAnswer = 3;
                    break;

                case 11:
                    pictureBox1.Image = Properties.Resources.pelicanEEl;

                    lblQuestion.Text = "This deep-sea fish is rarely seen by humans. What is it?";


                    button1.Text = "Pelican eel";
                    button2.Text = "Conger eel";
                    button3.Text = "European eel";
                    button4.Text = "Moray eel";
                    correctAnswer = 1;
                    break;

            

                case 12:
                    pictureBox1.Image = Properties.Resources.spotted;

                    lblQuestion.Text = "The International Union for the Conservation of Nature (IUCN) has deemed this fish a critically endangered species. Can you guess what it is?";

        

                    button1.Text = "Spotted handfish";
                    button2.Text = "Lizard fish";
                    button3.Text = "Specklefish";
                    button4.Text = "Red porgy";
                    correctAnswer = 1;
                    break;
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
