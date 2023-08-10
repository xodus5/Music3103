using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Music3103
{
    public partial class Form1 : Form
    {

        static private List<Music> Musiclist = new List<Music>()
        {
            new Music() {artist = "TXT", title = "Devil by the Window", album = "TEMPTATION", like = 64418},
            new Music() {artist = "TXT", title = "Sugar Rush Ride", album = "TEMPTATION", like = 106019},
            new Music() {artist = "TXT", title = "Tinnitus(돌멩이가 되고 싶어)", album = "TEMPTATION", like = 55281},
            new Music() {artist = "TXT", title = "Good Boy Gone Bad", album = "Thursday's Child", like = 81098},
            new Music() {artist = "TXT", title = "Thursday's child Has Far To Go", album = "Thursday's Child", like = 48579},
            new Music() {artist = "TXT", title = "디어 스푸트니크", album = "혼돈의 장 : FIGHT OR ESCAPE", like = 17783},

            new Music() {artist = "SEVENTEEN", title = "손오공", album = "FML", like = 81037},
            new Music() {artist = "SEVENTEEN", title = "Left & Right", album = "헹가래", like = 113251},
            new Music() {artist = "SEVENTEEN", title = "어쩌나", album = "YOU MAKE MY DAY", like = 148585},
            new Music() {artist = "SEVENTEEN", title = "예쁘다", album = "Love&Letter Repackage Album", like = 40466},
            new Music() {artist = "SEVENTEEN", title = "아주 NICE", album = "Love&Letter Repackage Album", like = 193103},

            new Music() {artist = "IVE", title = "I AM", album = "I've IVE", like = 191117},
            new Music() {artist = "IVE", title = "Kitsch", album = "I've IVE", like = 146965},
            new Music() {artist = "IVE", title = "After Like", album = "After LIKE", like = 234653},
            new Music() {artist = "IVE", title = "LOVE DIVE", album = "LOVE DIVE", like = 241160},
            new Music() {artist = "IVE", title = "Cherish", album = "I've IVE", like = 15168},

            new Music() {artist = "STRAY KIDS", title = "특", album = "5-STAR", like = 47448},
            new Music() {artist = "STRAY KIDS", title = "충돌", album = "5-STAR", like = 16545},
            new Music() {artist = "STRAY KIDS", title = "Lost me", album = "THE SOUND", like = 2769},
            new Music() {artist = "STRAY KIDS", title = "CASE 143", album = "MAXIDENT", like = 47923},
            new Music() {artist = "STRAY KIDS", title = "Back Door", album = "IN生", like = 56214},

            new Music() {artist = "IU", title = "라일락", album = "LILAC", like = 255001},
            new Music() {artist = "IU", title = "Coin", album = "LILAC", like = 119917},
            new Music() {artist = "IU", title = "팔레트", album = "Palette", like = 285979},
            new Music() {artist = "IU", title = "Blueming", album = "Love poem", like = 356353},
            new Music() {artist = "IU", title = "Love poem", album = "Love poem", like = 344562},

            new Music() {artist = "BTS", title = "Take Two", album = "Take Two", like = 65089},
            new Music() {artist = "BTS", title = "Permission to Dance", album = "Permission to Dance", like = 18112},
            new Music() {artist = "BTS", title = "잠시", album = "BE", like = 111304},
            new Music() {artist = "BTS", title = "Love maze", album = "LOVE YOURSELF 轉 'Tear'", like = 186064},
            new Music() {artist = "BTS", title = "Pied Piper", album = "LOVE YOURSELF 承 'Her'", like = 169024},


        };

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button8_Click(object sender, EventArgs e)
        {
            musicBindingSource.DataSource = Musiclist;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            musicBindingSource.DataSource = from item in Musiclist
                                            where item.artist == "TXT"
                                            orderby item.title descending
                                            select item;
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            musicBindingSource.DataSource = from item in Musiclist
                                            where item.artist == "SEVENTEEN"
                                            orderby item.title descending
                                            select item;

        }

        private void button3_Click(object sender, EventArgs e)
        {
            musicBindingSource.DataSource = from item in Musiclist
                                            where item.artist == "IVE"
                                            orderby item.title descending
                                            select item;

        }

        private void button4_Click(object sender, EventArgs e)
        {
            musicBindingSource.DataSource = from item in Musiclist
                                            where item.artist == "STRAY KIDS"
                                            orderby item.title descending
                                            select item;

        }

        private void button5_Click(object sender, EventArgs e)
        {
            musicBindingSource.DataSource = from item in Musiclist
                                            where item.artist == "IU"
                                            orderby item.title descending
                                            select item;

        }

        private void button6_Click(object sender, EventArgs e)
        {
            musicBindingSource.DataSource = from item in Musiclist
                                            where item.artist == "BTS"
                                            orderby item.title descending
                                            select item;

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
    }
}
