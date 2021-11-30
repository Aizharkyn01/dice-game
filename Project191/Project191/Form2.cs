using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project191
{
    public partial class Form2 : Form
    {
        public List<Player> players = new List<Player>();

        public Form2()
        {
            InitializeComponent();
        }
        public Label[] lPlayers = new Label[6];
        public TextBox[] tPlayers = new TextBox[6];
        public Button[] bColors = new Button[6];

        int numOfPlay = 0;
        int numOfBot = 0;
        int score = 0;
        private void Button1_Click(object sender, EventArgs e)
        {
            lPlayers[0] = lPlayer1; lPlayers[1] = lPlayer2; lPlayers[2] = lPlayer3; lPlayers[3] = lPlayer4; lPlayers[4] = lPlayer5; lPlayers[5] = lPlayer6;
            tPlayers[0] = textPlayer1; tPlayers[1] = textPlayer2; tPlayers[2] = textPlayer3; tPlayers[3] = textPlayer4; tPlayers[4] = textPlayer5; tPlayers[5] = textPlayer6;
            bColors[0] = butColor1; bColors[1] = butColor2; bColors[2] = butColor3; bColors[3] = butColor4; bColors[4] = butColor5; bColors[5] = butColor6;

            for (int i = 0; i < 6; i++)
            {
                lPlayers[i].Visible = false; lPlayers[i].Enabled = false;
                tPlayers[i].Visible = false; tPlayers[i].Enabled = false;
                bColors[i].Visible = false; bColors[i].Enabled = false;
            }
            button2.Enabled = false;

            players.Clear();

            try
            {
                numOfPlay = Convert.ToInt32(textBox1.Text);
                numOfBot = Convert.ToInt32(textBox2.Text);
                score = Convert.ToInt32(textBox3.Text);
                if (score <= 0)
                {
                    MessageBox.Show("Score cannot be 0 and negative value!!!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    textBox3.Clear();
                    score = 1;
                    textBox3.Text = "1";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);

            }

            switch (numOfBot + numOfPlay)
            {
                case (1):
                    {
                        for (int i = 0; i < 1; i++)
                        {
                            lPlayers[i].Visible = true; lPlayers[i].Enabled = true;
                            tPlayers[i].Visible = true; tPlayers[i].Enabled = true;
                            bColors[i].Visible = true; bColors[i].Enabled = true;
                            players.Add(new Player());
                        }
                        button2.Enabled = true;
                        break;
                    }
                case (2):
                    {
                        for (int i = 0; i < 2; i++)
                        {
                            lPlayers[i].Visible = true; lPlayers[i].Enabled = true;
                            tPlayers[i].Visible = true; tPlayers[i].Enabled = true;
                            bColors[i].Visible = true; bColors[i].Enabled = true;
                            players.Add(new Player());
                        }
                        button2.Enabled = true;
                        break;
                    }
                case (3):
                    {
                        for (int i = 0; i < 3; i++)
                        {
                            lPlayers[i].Visible = true; lPlayers[i].Enabled = true;
                            tPlayers[i].Visible = true; tPlayers[i].Enabled = true;
                            bColors[i].Visible = true; bColors[i].Enabled = true;
                            players.Add(new Player());
                        }
                        button2.Enabled = true;
                        break;
                    }
                case (4):
                    {
                        for (int i = 0; i < 4; i++)
                        {
                            lPlayers[i].Visible = true; lPlayers[i].Enabled = true;
                            tPlayers[i].Visible = true; tPlayers[i].Enabled = true;
                            bColors[i].Visible = true; bColors[i].Enabled = true;
                            players.Add(new Player());
                        }
                        button2.Enabled = true;
                        break;
                    }
                case (5):
                    {
                        for (int i = 0; i < 5; i++)
                        {
                            lPlayers[i].Visible = true; lPlayers[i].Enabled = true;
                            tPlayers[i].Visible = true; tPlayers[i].Enabled = true;
                            bColors[i].Visible = true; bColors[i].Enabled = true;
                            players.Add(new Player());
                        }
                        button2.Enabled = true;
                        break;
                    }
                case (6):
                    {
                        for (int i = 0; i < 6; i++)
                        {
                            lPlayers[i].Visible = true; lPlayers[i].Enabled = true;
                            tPlayers[i].Visible = true; tPlayers[i].Enabled = true;
                            bColors[i].Visible = true; bColors[i].Enabled = true;
                            players.Add(new Player());
                        }
                        button2.Enabled = true;
                        break;
                    }
                default:
                    {
                        players.Clear();
                        MessageBox.Show("Max number of players is 6!!!Min number of players is 1!!!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        break;
                    }
            }
        }

        private void butColor1_Click(object sender, EventArgs e)
        {
            ColorDialog color = new ColorDialog();
            if (color.ShowDialog() == DialogResult.OK)
            {
                butColor1.ForeColor = color.Color;
                players[0].color = color.Color;
            }
        }
        private void butColor2_Click(object sender, EventArgs e)
        {
            ColorDialog color = new ColorDialog();
            if (color.ShowDialog() == DialogResult.OK)
            {
                butColor2.ForeColor = color.Color;
                players[1].color = color.Color;
            }
        }
        private void butColor3_Click(object sender, EventArgs e)
        {
            ColorDialog color = new ColorDialog();
            if (color.ShowDialog() == DialogResult.OK)
            {
                butColor3.ForeColor = color.Color;
                players[2].color = color.Color;
            }
        }
        private void butColor4_Click(object sender, EventArgs e)
        {
            ColorDialog color = new ColorDialog();
            if (color.ShowDialog() == DialogResult.OK)
            {
                butColor4.ForeColor = color.Color;
                players[3].color = color.Color;
            }
        }
        private void butColor5_Click(object sender, EventArgs e)
        {
            ColorDialog color = new ColorDialog();
            if (color.ShowDialog() == DialogResult.OK)
            {
                butColor5.ForeColor = color.Color;
                players[4].color = color.Color;
            }
        }
        private void butColor6_Click(object sender, EventArgs e)
        {
            ColorDialog color = new ColorDialog();
            if (color.ShowDialog() == DialogResult.OK)
            {
                butColor6.ForeColor = color.Color;
                players[5].color = color.Color;
            }
        }

        public bool nameCheck(TextBox textBox)
        {
            if (textBox.Text.Length < 1)
            {
                textBox.Text = "Name";
                return false;
            }
            else if (textBox.Text.Length > 10)
            {
                textBox.Text = textBox.Text.Substring(0, 10);
                return false;
            }
            else
            {
                return true;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            bool check = true;
            for (int i = 0; i < numOfBot + numOfPlay; i++)
            {
                check = nameCheck(tPlayers[i]);
                if(check == false)
                {
                    break;
                }               
            }
            if (check == true)
            {
                this.Hide();
                Form3 form3 = new Form3();
                switch (numOfPlay)
                {
                    case (1):
                        {
                            for (int i = 0; i < 1; i++)
                            {
                                players[i].name = tPlayers[i].Text;
                            }

                            break;
                        }
                    case (2):
                        {
                            for (int i = 0; i < 2; i++)
                            {
                                players[i].name = tPlayers[i].Text;
                            }

                            break;
                        }
                    case (3):
                        {
                            for (int i = 0; i < 3; i++)
                            {
                                players[i].name = tPlayers[i].Text;
                            }

                            break;
                        }
                    case (4):
                        {
                            for (int i = 0; i < 4; i++)
                            {
                                players[i].name = tPlayers[i].Text;
                            }
                            break;
                        }
                    case (5):
                        {
                            for (int i = 0; i < 5; i++)
                            {
                                players[i].name = tPlayers[i].Text;
                            }
                            break;
                        }
                    case (6):
                        {
                            for (int i = 0; i < 6; i++)
                            {
                                players[i].name = tPlayers[i].Text;
                            }
                            break;
                        }
                    default:
                        break;
                }
                switch (numOfBot)
                {
                    case (1):
                        {
                            for (int i = numOfPlay; i < numOfPlay + 1; i++)
                            {
                                players[i].name = tPlayers[i].Text + "_BOT";
                            }
                            break;
                        }
                    case (2):
                        {
                            for (int i = numOfPlay; i < numOfPlay + 2; i++)
                            {
                                players[i].name = tPlayers[i].Text + "_BOT";
                            }
                            break;
                        }
                    case (3):
                        {
                            for (int i = numOfPlay; i < numOfPlay + 3; i++)
                            {
                                players[i].name = tPlayers[i].Text + "_BOT";
                            }
                            break;
                        }
                    case (4):
                        {
                            for (int i = numOfPlay; i < numOfPlay + 4; i++)
                            {
                                players[i].name = tPlayers[i].Text + "_BOT";
                            }
                            break;
                        }
                    case (5):
                        {
                            for (int i = numOfPlay; i < numOfPlay + 5; i++)
                            {
                                players[i].name = tPlayers[i].Text + "_BOT";
                            }
                            break;
                        }
                    case (6):
                        {
                            for (int i = numOfPlay; i < numOfPlay + 6; i++)
                            {
                                players[i].name = tPlayers[i].Text + "_BOT";
                            }
                            break;
                        }
                    default:
                        break;
                }
                form3.score = score;
                form3.players = players;
                form3.ShowDialog();
                this.Close();
            }
            else
            {
                MessageBox.Show("Change the name of player \n Minimum number of names characters is 1 \n Maximum number of names characters is 10", "error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

    }
}
