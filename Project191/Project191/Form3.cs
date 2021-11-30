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

namespace Project191
{
    public partial class Form3 : Form
    {
        public List<Player> players = new List<Player>();
        public PictureBox[] pictures1 = new PictureBox[6];
        public PictureBox[] pictures2 = new PictureBox[6];
        Random r = new Random(DateTime.UtcNow.Millisecond);
        bool flagSum = false, flagMul = false;
        bool flagAddScore = true, flagTurn = false;
        int mbank = 0, mbank1 = 0;
        public int score;
        public Form3()
        {
            InitializeComponent();
            createPic(pictures1);
            createPic(pictures2);
        }
        public void createPic(params PictureBox[] pic)
        {
            for (int i = 0; i < pic.Length; i++)
            {
                pic[i] = new PictureBox();
                pic[i].Visible = false;
                this.Controls.Add(pic[i]);
            }
        }


        public PictureBox randomPicture1(params PictureBox[] pictures)
        {
            int n = r.Next(0, 6);
            pictures[n].Visible = true;
            pictures[n].Refresh();
            return pictures[n];
        }


        private int randomLocVer1()
        {
            int n = r.Next(15, 221);
            return n;
        }

        private int randomLocHor1()
        {
            int n = r.Next(170, 330);
            return n;
        }
        private int randomLocHor2()
        {
            int n = r.Next(450, 611);
            return n;
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            button1.Enabled = false; button1.Visible = false;
            button3.Enabled = false; button3.Visible = false;
            button4.Enabled = false; button4.Visible = false;
            button5.Enabled = false; button5.Visible = false;
            panel7.Enabled = false; panel7.Visible = false;
            Panel[] panels = new Panel[] { panel1, panel2, panel3, panel4, panel5, panel6 };
            Label[] names = new Label[] { lName1, lName2, lName3, lName4, lName5, lName6 };
            for (int i = 0; i < players.Count; i++)
            {
                panels[i].Visible = true;
                panels[i].Enabled = true;
                names[i].Text = players[i].name;
                panels[i].BackColor = players[i].color;
            }
        }

        private void Button3_Click(object sender, EventArgs e)
        {
            pictures1[0].Image = Properties.Resources._1;
            pictures1[1].Image = Properties.Resources._2;
            pictures1[2].Image = Properties.Resources._3;
            pictures1[3].Image = Properties.Resources._4;
            pictures1[4].Image = Properties.Resources._5;
            pictures1[5].Image = Properties.Resources._6;

            pictures2[0].Image = Properties.Resources._1;
            pictures2[1].Image = Properties.Resources._2;
            pictures2[2].Image = Properties.Resources._3;
            pictures2[3].Image = Properties.Resources._4;
            pictures2[4].Image = Properties.Resources._5;
            pictures2[5].Image = Properties.Resources._6;
            flagMul = true;
            if (flagMul && flagSum)
            {
                button1.Enabled = true;
            }
        }

        private void Button4_Click(object sender, EventArgs e)
        {
            pictures1[0].Image = Properties.Resources.red1;
            pictures1[1].Image = Properties.Resources.red2;
            pictures1[2].Image = Properties.Resources.red3;
            pictures1[3].Image = Properties.Resources.red4;
            pictures1[4].Image = Properties.Resources.red5;
            pictures1[5].Image = Properties.Resources.red6;

            pictures2[0].Image = Properties.Resources.red1;
            pictures2[1].Image = Properties.Resources.red2;
            pictures2[2].Image = Properties.Resources.red3;
            pictures2[3].Image = Properties.Resources.red4;
            pictures2[4].Image = Properties.Resources.red5;
            pictures2[5].Image = Properties.Resources.red6;
            flagMul = true;
            if (flagMul && flagSum)
            {
                button1.Enabled = true;
            }
        }

        private void Button5_Click(object sender, EventArgs e)
        {
            pictures1[0].Image = Properties.Resources.o1;
            pictures1[1].Image = Properties.Resources.o2;
            pictures1[2].Image = Properties.Resources.o3;
            pictures1[3].Image = Properties.Resources.o4;
            pictures1[4].Image = Properties.Resources.o5;
            pictures1[5].Image = Properties.Resources.o6;

            pictures2[0].Image = Properties.Resources.o1;
            pictures2[1].Image = Properties.Resources.o2;
            pictures2[2].Image = Properties.Resources.o3;
            pictures2[3].Image = Properties.Resources.o4;
            pictures2[4].Image = Properties.Resources.o5;
            pictures2[5].Image = Properties.Resources.o6;
            flagMul = true;
            if (flagMul && flagSum)
            {
                button1.Enabled = true;
            }
        }

        public int num(PictureBox pic)
        {
            int n = 0;
            if (pic == pictures1[0] || pic == pictures2[0])
            {
                n = 1;
            }
            else if (pic == pictures1[1] || pic == pictures2[1])
            {
                n = 2;
            }
            else if (pic == pictures1[2] || pic == pictures2[2])
            {
                n = 3;
            }
            else if (pic == pictures1[3] || pic == pictures2[3])
            {
                n = 4;
            }
            else if (pic == pictures1[4] || pic == pictures2[4])
            {
                n = 5;
            }
            else if (pic == pictures1[5] || pic == pictures2[5])
            {
                n = 6;
            }
            return n;
        }

        private void Add_Score(int NumButton)
        {
            if (flagTurn)
            {
                if (radioButton1.Checked)
                {
                    if (flagAddScore)
                    {
                        players[NumButton - 1].score = players[NumButton - 1].score + mbank;
                    }
                    else
                    {
                        players[NumButton - 1].score = 0;
                    }
                    switch (NumButton)
                    {
                        case 1:
                            lScore1.Text = "Score " + players[NumButton - 1].score.ToString();
                            lBank1.Text = "Bank " + mbank.ToString();
                            break;
                        case 2:
                            lScore2.Text = "Score " + players[NumButton - 1].score.ToString();
                            lBank2.Text = "Bank " + mbank.ToString();
                            break;
                        case 3:
                            lScore3.Text = "Score " + players[NumButton - 1].score.ToString();
                            lBank3.Text = "Bank " + mbank.ToString();
                            break;
                        case 4:
                            lScore4.Text = "Score " + players[NumButton - 1].score.ToString();
                            lBank4.Text = "Bank " + mbank.ToString();
                            break;
                        case 5:
                            lScore5.Text = "Score " + players[NumButton - 1].score.ToString();
                            lBank5.Text = "Bank " + mbank.ToString();
                            break;
                        case 6:
                            lScore6.Text = "Score " + players[NumButton - 1].score.ToString();
                            lBank6.Text = "Bank " + mbank.ToString();
                            break;
                        default:
                            break;
                    }
                }
                else
                {
                    if (flagAddScore)
                    {
                        players[NumButton - 1].score = players[NumButton - 1].score + mbank1;
                    }
                    else
                    {
                        players[NumButton - 1].score = 0;
                    }
                    switch (NumButton)
                    {
                        case 1:
                            lScore1.Text = "Score " + players[NumButton - 1].score.ToString();
                            lBank1.Text = "Bank " + mbank1.ToString();
                            break;
                        case 2:
                            lScore2.Text = "Score " + players[NumButton - 1].score.ToString();
                            lBank2.Text = "Bank " + mbank1.ToString();
                            break;
                        case 3:
                            lScore3.Text = "Score " + players[NumButton - 1].score.ToString();
                            lBank3.Text = "Bank " + mbank1.ToString();
                            break;
                        case 4:
                            lScore4.Text = "Score " + players[NumButton - 1].score.ToString();
                            lBank4.Text = "Bank " + mbank1.ToString();
                            break;
                        case 5:
                            lScore5.Text = "Score " + players[NumButton - 1].score.ToString();
                            lBank5.Text = "Bank " + mbank1.ToString();
                            break;
                        case 6:
                            lScore6.Text = "Score " + players[NumButton - 1].score.ToString();
                            lBank6.Text = "Bank " + mbank1.ToString();
                            break;
                        default:
                            break;
                    }
                }
            }
        }

        private void RefreshVisButton(int numButton)
        {
            if (flagTurn)
            {
                bRoll1.Enabled = false;
                bRoll2.Enabled = false;
                bRoll3.Enabled = false;
                bRoll4.Enabled = false;
                bRoll5.Enabled = false;
                bRoll6.Enabled = false;
                bank1.Enabled = false;
                bank2.Enabled = false;
                bank3.Enabled = false;
                bank4.Enabled = false;
                bank5.Enabled = false;
                bank6.Enabled = false;
                if (numButton == players.Count)
                {
                    bRoll1.Enabled = true;
                    bank1.Enabled = true;
                }
                else
                {
                    switch (numButton)
                    {
                        case 1:
                            bRoll2.Enabled = true;
                            bank2.Enabled = true;
                            break;
                        case 2:
                            bRoll3.Enabled = true;
                            bank3.Enabled = true;
                            break;
                        case 3:
                            bRoll4.Enabled = true;
                            bank4.Enabled = true;
                            break;
                        case 4:
                            bRoll5.Enabled = true;
                            bank5.Enabled = true;
                            break;
                        case 5:
                            bRoll6.Enabled = true;
                            bank6.Enabled = true;
                            break;
                        case 6:
                            bRoll1.Enabled = true;
                            bank1.Enabled = true;
                            break;
                        default:
                            break;
                    }
                }
            }
        }

        private void BRoll1_Click(object sender, EventArgs e)
        {
            roll();
            Add_Score(1);
            RefreshVisButton(1);
            flagTurn = false;
            listScore();
            checkWin();
        }
        private void bRoll2_Click(object sender, EventArgs e)
        {
            roll();
            Add_Score(2);
            RefreshVisButton(2);
            flagTurn = false;
            listScore();
            checkWin();
        }

        private void bRoll3_Click(object sender, EventArgs e)
        {
            roll();
            Add_Score(3);
            RefreshVisButton(3);
            flagTurn = false;
            listScore();
            checkWin();
        }

        private void bRoll4_Click(object sender, EventArgs e)
        {
            roll();
            Add_Score(4);
            RefreshVisButton(4);
            flagTurn = false;
            listScore();
            checkWin();
        }

        private void bRoll5_Click(object sender, EventArgs e)
        {
            roll();
            Add_Score(5);
            RefreshVisButton(5);
            flagTurn = false;
            listScore();
            checkWin();
        }

        private void bRoll6_Click(object sender, EventArgs e)
        {
            roll();
            Add_Score(6);
            RefreshVisButton(6);
            flagTurn = false;
            listScore();
            checkWin();
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            flagSum = true;
            if (flagMul || flagSum)
            {
                button1.Enabled = true;
            }
        }

        private void bank5_Click(object sender, EventArgs e)
        {
            flagTurn = true;
            Add_Score(5);
            RefreshVisButton(5);
            flagTurn = false;
            listScore();
            checkWin();
        }

        private void bank2_Click(object sender, EventArgs e)
        {
            flagTurn = true;
            Add_Score(2);
            RefreshVisButton(2);
            flagTurn = false;
            listScore();
            checkWin();
        }

        private void bank3_Click(object sender, EventArgs e)
        {
            flagTurn = true;
            Add_Score(3);
            RefreshVisButton(3);
            flagTurn = false;
            listScore();
            checkWin();
        }

        private void bank6_Click(object sender, EventArgs e)
        {
            flagTurn = true;
            Add_Score(6);
            RefreshVisButton(6);
            flagTurn = false;
            listScore();
            checkWin();
        }

        private void bank4_Click(object sender, EventArgs e)
        {
            flagTurn = true;
            Add_Score(4);
            RefreshVisButton(4);
            flagTurn = false;
            listScore();
            checkWin();
        }

        private void bank1_Click(object sender, EventArgs e)
        {
            flagTurn = true;
            Add_Score(1);
            RefreshVisButton(1);
            flagTurn = false;
            listScore();
            checkWin();
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            flagMul = true;
            if (flagMul || flagSum)
            {
                button1.Enabled = true;
            }
        }

        public void roll()
        {
            PictureBox PB1, PB2;

            int h1 = randomLocHor1();
            int v1 = randomLocVer1();
            int h2 = randomLocHor2();
            int v2 = randomLocVer1();
            for (int i = 0; i < 6; i++)
            {
                pictures1[i].Visible = false;
                pictures1[i].Refresh();
                pictures2[i].Visible = false;
                pictures1[i].Refresh();
            }
            PB1 = randomPicture1(pictures1);
            PB1.Location = new System.Drawing.Point(h1, v1);
            PB1.Size = new System.Drawing.Size(115, 115);

            PB2 = randomPicture1(pictures2);
            PB2.Location = new System.Drawing.Point(h2, v2);
            PB2.Size = new System.Drawing.Size(115, 115);

            mbank = num(PB1) + num(PB2);
            mbank1 = num(PB1) * num(PB2);
            if (num(PB1) == 1 && num(PB2) == 1)
            {
                mbank = 0;
                mbank1 = 0;
                flagAddScore = false;
                flagTurn = true;
            }
            else if (num(PB1) == 1 || num(PB2) == 1)
            {
                flagAddScore = true;
                flagTurn = true;
            }
            return;
        }

        public void listScore()
        {
            List<Player> playersSort = new List<Player>();
            for (int i = 0; i < players.Count; i++)
            {
                playersSort.Add(players[i]);
            }
            playersSort.Sort((a, b) => b.score.CompareTo(a.score));
            listScores.Items.Clear();
            for (int i = 0; i < players.Count; i++)
            {
                listScores.Items.Add(playersSort[i].name + " :" + playersSort[i].score);
            }
        }
        public void checkWin()
        {
            for (int i = 0; i < players.Count; i++)
            {
                if (players[i].score >= score)
                {
                    FileStream records = new FileStream("records.txt", FileMode.OpenOrCreate, FileAccess.Write);
                    StreamWriter sw = new StreamWriter(records);
                    sw.WriteLine(players[i].name + "       " + players[i].score);
                    sw.Close();
                    records.Close();

                    DialogResult d = new DialogResult();
                    d = MessageBox.Show("Winner is " + players[i].name, "WINNER!!!", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                    if (d == DialogResult.OK)
                    {
                        Application.Exit();
                    }

                }
            }
        }
    }
}
