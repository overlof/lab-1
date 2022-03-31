using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FormNew
{
    public partial class Form1: Form
    {
        String[] imglist = new String[]
            {"1.jpg","2.jpg","3.jpg","4.jpg","5.jpg","6.jpg","7.jpg","8.jpg","9.jpg","10.jpg"};
        int index = 0;

        Country[] countries = new Country[5];
        Player[] playerS = new Player[5];
        Teams[] teams = new TeamsMain[5];
        positionNames[] 



    public Form1()
        {
            InitializeComponent();

            Country country = new Country();   
            country.set("ARG", "Argentina");
            countries[0] = country;

            country.set("AT", "Austria");
            countries[1] = country;

            country.set("AUS", "Australia");
            countries[2] = country;

            country.set("BI", "Bosnia");
            countries[3] = country;

            country.set("BIH", "Bosnia Herzegovina");
            countries[4] = country;

            Player player = new Player();
            player.set("1", "MO", "Williams", "1,85", "89,8", "US");
            playerS[0] = player;

            player.set("2", "Alonzo", "Edward Gee", "1,98", "99", "US");
            playerS[1] = player;

            player.set("3", "Johnny", "O'Bryant", "2,05", "116,5", "US");
            playerS[2] = player;

            player.set("4", "Danilo", "Gallinari", "2,08", "102", "US");
            playerS[3] = player;

            player.set("5", "Darrell", "Arthur", "2,06", "107", "US");
            playerS[4] = player;

            TeamsMain team = new Team();
            team.Set("1", "Miami Heat", "MIA", "1.jpg");
            Teams[0] = team;

            team.Set("2", "Orlando Magic", "ORL", "2.jpg");
            Teams[1] = team;

            team.Set("3", "Atlanta Hawks", "ATL", "3.jpg");
            Teams[2] = team;

            team.Set("4", "Washington Wizards", "WSH", "4.jpg");
            Teams[3] = team;

            team.Set("5", "Charlotte Hornets", "CHA", "5.jpg");
            Teams[4] = team;

            PositionName positionName = new PositionName();
            positionName.Set("1","SmallForward");
            positionNames[0] = positionName;

            positionName.Set("2", "PowerForward");
            positionNames[1] = positionName;

            positionName.Set("3", "Center");
            positionNames[2] = positionName;

            positionName.Set("4", "ShootingGuard");
            positionNames[3] = positionName;

            positionName.Set("5", "PointGuard");
            positionNames[4] = positionName;

            PositionOfPlayer positionofplayer = new PositionOfPlayer();
            positionofplayer.Set("1", "1");
            positionofplayers[0] = positionofplayer;

            positionofplayer.Set("2", "2");
            positionofplayers[1] = positionofplayer;

            positionofplayer.Set("3", "3");
            positionofplayers[2] = positionofplayer;

            positionofplayer.Set("4", "4");
            positionofplayers[3] = positionofplayer;

            positionofplayer.Set("5", "5");
            positionofplayers[4] = positionofplayer;



            pictureBox3.Load("../../../Pictures/" + imglist[0]);
            pictureBox2.Load("../../../Pictures/" + imglist[1]);
            pictureBox4.Load("../../../Pictures/" + imglist[2]);
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form2 form = new Form2();
            form.ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            index = index + 1;
            if (index + 3 > imglist.Length) index = 0;
            pictureBox3.Load("../../../Pictures/" + imglist[index + 0]);
            pictureBox2.Load("../../../Pictures/" + imglist[index + 1]);
            pictureBox4.Load("../../../Pictures/" + imglist[index + 2]);
        }

        private void button4_Click(object sender, EventArgs e)
        {
           
            index = index - 1;
            if (index < 0) index = imglist.Length - 3;
            pictureBox3.Load("../../../Pictures/" + imglist[index + 0]);
            pictureBox2.Load("../../../Pictures/" + imglist[index + 1]);
            pictureBox4.Load("../../../Pictures/" + imglist[index + 2]);
        }
    }
}
