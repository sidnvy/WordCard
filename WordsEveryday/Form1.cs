using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WordsEveryday
{
    public partial class Form1 : Form
    {
        private string[] answers = new string[4];
        private string[] definition;
        // batch is how many words per group
        // pass_answer used when user make wrong choice and what get next word
        private int requiredbatch = 10, pass_answer = -2;
        private int pointer, right_answer, mastered, batch;
        private bool hide = true, show = false, review_mode = false;
        //private Word[] words;
        private List<Word> words;
        private Random rnd = new Random();
        // Hint Color change
        private int _iDeltaR;
        private int _iDeltaG;
        private int _iDeltaB;
        private int _iColorLevel;
        private Point m_MousePoint;
        private Point m_LastPoint;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            words = Kernel.WordsController.GetBatchofWords(requiredbatch, 0, review_mode, out batch);
            newViewInit();
        }

        /// <summary>
        /// Hide others only show a new round view
        /// </summary>
        public void newViewInit()
        {
            pointer = batch - 1;
            mastered = batch;
            setCurrentWordLabel(pointer);
            if (review_mode)
            {
                toogleButtonTo(hide);
                definition = words[pointer].chinese.Split('；');
                definition_label.Text = string.Join("\n", definition);
            }
            else
            {
                right_answer = setAnswers(pointer);
                toogleButtonTo(show);
            }
            //hint_label.Visible = false;
        }

        /// <summary>
        /// Gets random Answers
        /// </summary>
        /// <param name="pointer">Index of word</param>
        /// <returns>Right answer's index</returns>
        private int setAnswers(int pointer)
        {
            int length = 4, right_index = -1, index = -1;
            // Random sort of answers
            Word[] newWd = new Word[length];
            for (int i = 0; i < length; i++)
            {
                newWd[i] = words[(pointer + i * (batch / 4)) % batch];
            }
            for (int i = 0; i < length; i++)
            {
                index = rnd.Next(length - i);
                answers[i] = newWd[index].chinese;
                newWd[index] = newWd[length - 1 - i];
                if (answers[i] == words[pointer].chinese)
                {
                    right_index = i;
                }
            }
            return right_index;
        }

        /// <summary>
        /// Judge the choice and refresh Controls
        /// </summary>
        /// <param name="choice">User's choice</param>
        private void refreshUI(int choice)
        {
            if (choice == right_answer || choice == pass_answer)
            {
                // Right answer & show hint
                if (choice == right_answer)
                {
                    //Result.Text = "Bingo!";
                    //hint_label.Visible = true;
                    setHint("Bingo!", Color.Aquamarine);
                    words[pointer].learnTime += 1;
                    words[pointer].wordStatus = 2;
                }
                // Goto next word
                if (pointer > 0)
                {
                    pointer -= 1;
                    right_answer = setAnswers(pointer);
                    if (!review_mode)
                    {
                        toogleButtonTo(show);
                    }
                    definition = words[pointer].chinese.Split('；');
                    definition_label.Text = string.Join("\n", definition);
                    setCurrentWordLabel(pointer);
                    return;
                }
                // reach the last word
                toogleButtonTo(hide);
                //Definition.Visible = false;
                panel_definition.Visible = false;
                // Save words to DB
                int affectedRow = Kernel.WordsController.SaveBatchofWords(words, batch);

                DialogResult result = MessageBox.Show("All done,do you wanna start a new round?",
                    string.Format("{0} words saved", affectedRow), MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {
                    // Get a new batch & start a new round
                    review_mode = false;
                    words = Kernel.WordsController.GetBatchofWords(requiredbatch, 0, review_mode, out batch);
                    newViewInit();
                    return;
                }
                else
                {
                    // Show the statistics
                    if (!review_mode)
                    {
                        Result_label.Text = String.Format("You have mastered:\n {0} words", mastered);
                        Result_label.Visible = true;
                    }
                    ReviewLabel.Visible = true;
                    return;
                }
            }
            else
            {
                // Wrong answers show definition & jump to next
                //hint_label.Visible = true;
                setHint("Sorry man :(", Color.LightPink);
                definition = words[pointer].chinese.Split('；');
                definition_label.Text = string.Join("\n", definition);
                toogleButtonTo(hide);
                GotItLabel.Visible = true;
                mastered -= 1;
                words[pointer].wordStatus = 1;
                words[pointer].learnTime += 1;
            }
        }

        /// <summary>
        /// Change button's visibility
        /// </summary>
        /// <param name="status">hide or show</param>
        private void toogleButtonTo(bool status)
        {
            if (status)
            {
                button1.Visible = false;
                button2.Visible = false;
                button3.Visible = false;
                button4.Visible = false;
                //Result.Visible = true;
                GotItLabel.Visible = true;
                //ReviewLabel.Visible = true;
                //Definition.Visible = true;
                panel_definition.Visible = true;
            }
            else
            {
                button1.Text = answers[0];
                button2.Text = answers[1];
                button3.Text = answers[2];
                button4.Text = answers[3];
                button1.Visible = true;
                button2.Visible = true;
                button3.Visible = true;
                button4.Visible = true;
                //Result.Visible = false;
                GotItLabel.Visible = false;
                ReviewLabel.Visible = false;
                Result_label.Visible = false;
                //Definition.Visible = false;
                panel_definition.Visible = false;
            }
        }

        /// <summary>
        /// Set current word's to view
        /// </summary>
        /// <param name="pointer">Index of word</param>
        private void setCurrentWordLabel(int pointer)
        {
            WordLabel.Text = words[pointer].english;
            Counter_label.Text = string.Format("{0} Left", pointer);
        }

        private void GotItLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            refreshUI(pass_answer);
            //hint_label.Visible = false;
        }

        private void ReviewLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            words = Kernel.WordsController.GetBatchofWords(requiredbatch, 1, review_mode, out batch);
            if (batch < 1)
            {
                MessageBox.Show("Sorry,there are no words to review", "Warning");
                return;
            }
            review_mode = true;
            Result_label.Visible = false;
            ReviewLabel.Visible = false;
            newViewInit();
        }

        private void CloseButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            refreshUI(3);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            refreshUI(2);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            refreshUI(1);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            refreshUI(0);
        }

        private void timerColor_Tick(object sender, EventArgs e)
        {
            // Hint label is disabled in this version 
            // Replaced with hint color of form's backcolor
            //if (0 <= this._iColorLevel && this._iColorLevel <= 17)
            //{
            //    this.hint_label.ForeColor = Color.FromArgb(
            //        this.hint_label.ForeColor.A,
            //        this.hint_label.ForeColor.R + this._iDeltaR,
            //        this.hint_label.ForeColor.G + this._iDeltaG,
            //        this.hint_label.ForeColor.B + this._iDeltaB);
            //}

            //if (18 == this._iColorLevel)
            //{
            //    this.hint_label.ForeColor = Color.White;
            //    this.timerColor.Enabled = false;
            //}

            //this._iColorLevel++;
            if (0 <= this._iColorLevel && this._iColorLevel <= 17)
            {
                this.BackColor = Color.FromArgb(
                    this.BackColor.A,
                    this.BackColor.R + this._iDeltaR,
                    this.BackColor.G + this._iDeltaG,
                    this.BackColor.B + this._iDeltaB);
            }

            if (18 == this._iColorLevel)
            {
                this.BackColor = Color.White;
                this.timerColor.Enabled = false;
            }

            this._iColorLevel++;
        }

        /// <summary>
        /// Set hint color
        /// </summary>
        /// <param name="hint">Hint info</param>
        /// <param name="color">Color name</param>
        private void setHint(string hint, Color color)
        {
            // The comment show the previous version which set hint label
            //this.hint_label.ForeColor = color;
            //this._iColorLevel = 0;
            //this._iDeltaR = (255 - this.hint_label.ForeColor.R) / 18;
            //this._iDeltaG = (255 - this.hint_label.ForeColor.G) / 18;
            //this._iDeltaB = (255 - this.hint_label.ForeColor.B) / 18;
            //this.hint_label.Text = hint;
            //this.timerColor.Enabled = true;
            this.BackColor = color;
            this._iColorLevel = 0;
            this._iDeltaR = (255 - this.BackColor.R) / 18;
            this._iDeltaG = (255 - this.BackColor.G) / 18;
            this._iDeltaB = (255 - this.BackColor.B) / 18;
            //this.hint_label.Text = hint;
            this.timerColor.Enabled = true;
        }

        // The 2 methods down below
        // Make windows dragable when set FormBorderStyle = none
        protected override void OnMouseDown(MouseEventArgs e)
        {
            base.OnMouseDown(e);
            this.m_LastPoint = this.Location;
            this.m_MousePoint = this.PointToScreen(e.Location);
        }

        protected override void OnMouseMove(MouseEventArgs e)
        {
            base.OnMouseMove(e);
            if (e.Button == MouseButtons.Left)
            {
                Point t = this.PointToScreen(e.Location);
                Point l = this.m_LastPoint;

                l.Offset(t.X - this.m_MousePoint.X, t.Y - this.m_MousePoint.Y);
                this.Location = l;
            }
        }
    }
}
