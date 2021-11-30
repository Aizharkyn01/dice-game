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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
       
        
        private void Button3_Click(object sender, EventArgs e)
        {
        }

        private void Button4_Click(object sender, EventArgs e)
        {
            DialogResult d = new DialogResult();               
            d = MessageBox.Show("Are you sure?", "Exit", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (d == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form2 form2 = new Form2();
            form2.ShowDialog();
            this.Close();
            
        }

        private void Button3_Click_1(object sender, EventArgs e)
        {
            MessageBox.Show("Rules: \n Pigs is a fun and challenging dice game with multiple variations and scoring options.\n How to play Pigs? \n After starting the game, you have to choose: \n     *Number of players; \n     *Number of bots to play with (not necessary); \n     *Goal score; \n     *Names of players and bots; \n     *Colors for players; \n     *Dice; \n     *Game option (Mul for multiplication, Sum for sum); \n Player has to roll two standard dice. If neither shows a 1, their sum is added to the turn total. The player can get the points by adding to their scores or he/she can continue rolling for more points. If a single 1 is rolled, the player scores nothing and the turn ends. If two 1s are rolled, the player’s entire score is lost and their turn ends. The first person who reach to the goal point will win the game. \n So, player can ROLL the dice many times, until he/she decide to end (by clicking BANK), or until any of dices will show 1. \n All scores will be seen in the score section. \n Also, you can see the records in the record area.","Rules",MessageBoxButtons.OK,MessageBoxIcon.Information );
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            FileStream records = new FileStream("records.txt", FileMode.OpenOrCreate, FileAccess.Read);
            StreamReader sr = new StreamReader(records);
            string rec = sr.ReadToEnd();
            MessageBox.Show(rec, "RECORDS", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            sr.Close();
            records.Close();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
