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

namespace LostAdventure
{
    public partial class Form1 : Form
    {
        // Tracks what page of the story the user is at
        int page = 1;
        SoundPlayer sp;
        public Form1()
        {
            InitializeComponent();

            // Display initial message and options

            
        }

        private void option1Button_Click(object sender, EventArgs e)
        {
            /// Check what page we are currently on, and then flip
            /// to the page you need to go to if you selected option 1

            if (page == 1)
            {

                page = 2;

            }
            else if (page == 2)
            {
                page = 3;
            }
            else if (page == 3)
            {
                page = 99;
            }
            else if (page == 4)
            {
                page = 99;
            }
            else if (page == 5)
            {
                page = 10;
            }
            else if (page == 6)
            {
                page = 7;
            }
            else if (page == 7)
            {
                page = 8;
            }
            else if (page == 8)
            {
              page = 99;
            }

            else if (page == 9)
            {
                page = 99;
            }
            else if (page == 10)
            {
                page = 11;
            }
            else if (page == 11)
            {
                page = 12;
            }
            else if (page == 12)
            {
                page = 99;
            }
            else if (page == 13)
            {

            } 
          


            /// Display text and game options to screen based on the 
            /// current page

            switch (page)
            {

                case 1:
                    break;
                case 2:
                    sp = new SoundPlayer(Properties.Resources.no_evidence_of_disease_144022);
                    sp.Play();
                    imageBox.Image = Properties.Resources.deepBrush;
                    option1Label.Text = "North";
                    option2Label.Text = "South";
                    break;
                case 3:
                    feddy.Text = "there are two paths but take the wrong one and HE will send you to rohde island";
                    imageBox.Image = Properties.Resources.deepBrush;
                    option1Label.Text = "north";
                    option2Label.Text = "left";
                    sp = new SoundPlayer(Properties.Resources.jungle);
                    break;
                case 4:
                    sp = new SoundPlayer(Properties.Resources.calm_river_ambience_loop_125071);
                    sp.Play();
                    imageBox.Image = Properties.Resources.forestLake;
                    feddy.Text = "hes coming keep going";
                    option1Label.Text = " go north";
                    option2Label.Text = "keep going left";
                    break;
                case 5:
                    sp = new SoundPlayer(Properties.Resources.vine_boom_162668);
                    sp.Play();
                    imageBox.Image = Properties.Resources.Capture;
                    option1Label.Text = "pick up lighter";
                    option2Label.Text = "NUH UH";

                    break;
                case 6:
                    sp = new SoundPlayer(Properties.Resources.nuclear_alarm_nuke_siren__nuke__nuclear__alarm_made_with_Voicemod_technology);
                    sp.Play();
                    imageBox.Image = Properties.Resources.NIGHTMARE;

                    option1Label.Text = "keep running";
                    option2Label.Text = "keep running";

                    break;
                case 7:

                    option1Label.Text = "hes getting closer";
                    option2Label.Text = "hes getting closer";
                    break;
                case 8:
                    sp = new SoundPlayer(Properties.Resources.heheheha_made_with_Voicemod_technology);
                    sp.Play();
                    imageBox.Image = Properties.Resources.AAAAAAAAAAAAAAAAA1;
                    option1Label.Text = "HES HERE";
                    option2Label.Text = "HES HERE";
                    break;
                case 9:
                    option1Label.Text = "HES HERE";
                    option2Label.Text = "HES HERE";
                   
                    break;
                case 10:
                    sp = new SoundPlayer(Properties.Resources.nuclear_alarm_nuke_siren__nuke__nuclear__alarm_made_with_Voicemod_technology);
                    sp.Play();
                    imageBox.Image = Properties.Resources.AAAAAAAAAAAAAAAAA1;

                    feddy.Text = "DO IT NOW";
                    option1Label.Text = "HES HERE";
                    option2Label.Text = "HES HERE";
                    lighterbutton.Text = "SET HIM ON FIRE";
                    break;
                case 11:
                    option1Label.Text = "HES HERE";
                    option2Label.Text = "HES HERE";
                    lighterbutton.Text = "SET HIM ON FIRE";
                    break;
                case 12:
                    option1Label.Text = "HES HERE";
                    option2Label.Text = "HES HERE";
                    lighterbutton.Text = "SET HIM ON FIRE";
                    break;
                case 13:
                    sp = new SoundPlayer(Properties.Resources.horror_background_atmosphere_156462);
                    sp.Play();
                    lighterbutton.Text = "...";
                    imageBox.Image = Properties.Resources.har_har_harr_harr_harr;
                    feddy.Text = "even though his body is burned he is still there mocking you laughing at you this creature this THING everywhere you look it is there and it shall be there to mock you not even death can free you from this monstrosity that has chosen to haunt you. also your a wizard idk";
                    break;
                case 99:
                    sp = new SoundPlayer(Properties.Resources.horror_background_atmosphere_156462);
                    sp.Play();
                    imageBox.Image = Properties.Resources.AAAAAAAAAAAAAAAAA;
                    feddy.Text = "i have no mouth and I must scream.";
                    break;
                default:
                    break;
            }
        }

        private void option2Button_Click(object sender, EventArgs e)
        {
            ///check what page we are currently on, and then flip
            ///to the page you need to go to if you selected option 2
            if (page == 1)
            {
                Random ranum = new Random();
                int chance;
                chance = ranum.Next(0, 100);
               
                if (chance < 50)
                {
                    page = 99;
                }
                else
                {
                    page = 2;
                }

            }
            else if (page == 2)
            {
                page = 99;
            }
            else if (page == 3)
            {
                page = 4;
            }
            else if (page == 4)
            {
                page = 5;
            }
            else if (page == 5)
            {
                page = 6;
            }
            else if (page == 6)
            {
                page = 7;
            }
            else if (page == 7)
            {
                page = 8;
            }
            else if (page == 8)
            {
                page = 99;
            }

            else if (page == 9)
            {

            }
            else if (page == 10)
            {
                page = 11;
            }
            else if (page == 11)
            {
                page = 12;
            }
            else if (page == 12)
            {
                page = 99;
            }
            else if (page == 13)
            {

            }

            /// Display text and game options to screen based on the 
            /// current page

            switch (page)
            {


                case 1:
                    break;
                case 2:
                    sp = new SoundPlayer(Properties.Resources.no_evidence_of_disease_144022);
                    sp.Play();
                    imageBox.Image = Properties.Resources.deepBrush;
                    option1Label.Text = "North";
                    option2Label.Text = "South";
                    break;
                case 3:
                    feddy.Text = "there are two paths but take the wrong one and HE will send you to rohde island";
                    imageBox.Image = Properties.Resources.deepBrush;
                    option1Label.Text = "north";
                    option2Label.Text = "left";
                    sp = new SoundPlayer(Properties.Resources.jungle);
                    break;
                case 4:
                    sp = new SoundPlayer(Properties.Resources.calm_river_ambience_loop_125071);
                    sp.Play();
                    imageBox.Image = Properties.Resources.forestLake;
                    feddy.Text = "hes coming keep going";
                    option1Label.Text = " go north";
                    option2Label.Text = "keep going left";
                    break;
                case 5:
                    sp = new SoundPlayer(Properties.Resources.vine_boom_162668);
                    sp.Play();
                    imageBox.Image = Properties.Resources.Capture;
                    option1Label.Text = "pick up lighter";
                    option2Label.Text = "NUH UH";

                    break;
                case 6:
                    sp = new SoundPlayer(Properties.Resources.nuclear_alarm_nuke_siren__nuke__nuclear__alarm_made_with_Voicemod_technology);
                    sp.Play();
                    imageBox.Image = Properties.Resources.NIGHTMARE;

                    option1Label.Text = "keep running";
                    option2Label.Text = "keep running";

                    break;
                case 7:

                    option1Label.Text = "hes getting closer";
                    option2Label.Text = "hes getting closer";
                    break;
                case 8:
                    sp = new SoundPlayer(Properties.Resources.heheheha_made_with_Voicemod_technology);
                    sp.Play();
                    imageBox.Image = Properties.Resources.AAAAAAAAAAAAAAAAA1;
                    option1Label.Text = "HES HERE";
                    option2Label.Text = "HES HERE";
                    break;
                case 9:
                    option1Label.Text = "HES HERE";
                    option2Label.Text = "HES HERE";

                    break;
                case 10:
                    sp = new SoundPlayer(Properties.Resources.nuclear_alarm_nuke_siren__nuke__nuclear__alarm_made_with_Voicemod_technology);
                    sp.Play();
                    imageBox.Image = Properties.Resources.AAAAAAAAAAAAAAAAA1;

                    feddy.Text = "DO IT NOW";
                    option1Label.Text = "HES HERE";
                    option2Label.Text = "HES HERE";
                    lighterbutton.Text = "SET HIM ON FIRE";
                    break;
                case 11:
                    option1Label.Text = "HES HERE";
                    option2Label.Text = "HES HERE";
                    lighterbutton.Text = "SET HIM ON FIRE";
                    break;
                case 12:
                    option1Label.Text = "HES HERE";
                    option2Label.Text = "HES HERE";
                    lighterbutton.Text = "SET HIM ON FIRE";
                    break;
                case 13:
                    sp = new SoundPlayer(Properties.Resources.horror_background_atmosphere_156462);
                    sp.Play();
                    lighterbutton.Text = "...";
                    imageBox.Image = Properties.Resources.har_har_harr_harr_harr;
                    feddy.Text = "even though his body is burned he is still there mocking you laughing at you this creature this THING everywhere you look it is there and it shall be there to mock you not even death can free you from this monstrosity that has chosen to haunt you. also your a wizard idk";
                    break;
                case 99:
                    sp = new SoundPlayer(Properties.Resources.horror_background_atmosphere_156462);
                    sp.Play();
                    imageBox.Image = Properties.Resources.AAAAAAAAAAAAAAAAA;
                    feddy.Text = "i have no mouth and I must scream.";
                    break;
                default:
                    break;
            }
        }

        private void imageBox_Click(object sender, EventArgs e)
        {

        }

        private void lighterpicbox_Click(object sender, EventArgs e)
        {

        }

        private void lighterbutton_Click(object sender, EventArgs e)
        {
            if (page == 1)
            {

                

            }
            else if (page == 2)
            {
                
            }
            else if (page == 3)
            {
            }
            else if (page == 4)
            {
            }
            else if (page == 5)
            {
            }
            else if (page == 6)
            {
               
            }
            else if (page == 7)
            {

            }
            else if (page == 8)
            {
               
            }

            else if (page == 9)
            {
              
            }
            else if (page == 10)
            {
                page = 13;
            }
            else if (page == 11)
            {
                page = 13;
            }
            else if (page == 12)
            {
                page = 13;
            }
            else if (page == 13)
            {
             
            }


                /// Display text and game options to screen based on the 
                /// current page

                switch (page)
                {

                case 1:
                    break;
                case 2:
                    sp = new SoundPlayer(Properties.Resources.no_evidence_of_disease_144022);
                    sp.Play();
                    imageBox.Image = Properties.Resources.deepBrush;
                    option1Label.Text = "North";
                    option2Label.Text = "South";
                    break;
                case 3:
                    feddy.Text = "there are two paths but take the wrong one and HE will send you to rohde island";
                    imageBox.Image = Properties.Resources.deepBrush;
                    option1Label.Text = "north";
                    option2Label.Text = "left";
                    sp = new SoundPlayer(Properties.Resources.jungle);
                    break;
                case 4:
                    sp = new SoundPlayer(Properties.Resources.calm_river_ambience_loop_125071);
                    sp.Play();
                    imageBox.Image = Properties.Resources.forestLake;
                    feddy.Text = "hes coming keep going";
                    option1Label.Text = " go north";
                    option2Label.Text = "keep going left";
                    break;
                case 5:
                    sp = new SoundPlayer(Properties.Resources.vine_boom_162668);
                    sp.Play();
                    imageBox.Image = Properties.Resources.Capture;
                    option1Label.Text = "pick up lighter";
                    option2Label.Text = "NUH UH";

                    break;
                case 6:
                    sp = new SoundPlayer(Properties.Resources.nuclear_alarm_nuke_siren__nuke__nuclear__alarm_made_with_Voicemod_technology);
                    sp.Play();
                    imageBox.Image = Properties.Resources.NIGHTMARE;

                    option1Label.Text = "keep running";
                    option2Label.Text = "keep running";

                    break;
                case 7:

                    option1Label.Text = "hes getting closer";
                    option2Label.Text = "hes getting closer";
                    break;
                case 8:
                    sp = new SoundPlayer(Properties.Resources.heheheha_made_with_Voicemod_technology);
                    sp.Play();
                    imageBox.Image = Properties.Resources.AAAAAAAAAAAAAAAAA1;
                    option1Label.Text = "HES HERE";
                    option2Label.Text = "HES HERE";
                    break;
                case 9:
                    option1Label.Text = "HES HERE";
                    option2Label.Text = "HES HERE";

                    break;
                case 10:
                    sp = new SoundPlayer(Properties.Resources.nuclear_alarm_nuke_siren__nuke__nuclear__alarm_made_with_Voicemod_technology);
                    sp.Play();
                    imageBox.Image = Properties.Resources.AAAAAAAAAAAAAAAAA1;

                    feddy.Text = "DO IT NOW";
                    option1Label.Text = "HES HERE";
                    option2Label.Text = "HES HERE";
                    lighterbutton.Text = "SET HIM ON FIRE";
                    break;
                case 11:
                    option1Label.Text = "HES HERE";
                    option2Label.Text = "HES HERE";
                    lighterbutton.Text = "SET HIM ON FIRE";
                    break;
                case 12:
                    option1Label.Text = "HES HERE";
                    option2Label.Text = "HES HERE";
                    lighterbutton.Text = "SET HIM ON FIRE";
                    break;
                case 13:
                    sp = new SoundPlayer(Properties.Resources.horror_background_atmosphere_156462);
                    sp.Play();
                    lighterbutton.Text = "...";
                    imageBox.Image = Properties.Resources.har_har_harr_harr_harr;
                    feddy.Text = "even though his body is burned he is still there mocking you laughing at you this creature this THING everywhere you look it is there and it shall be there to mock you not even death can free you from this monstrosity that has chosen to haunt you. also your a wizard idk";
                    break;
                case 99:
                    sp = new SoundPlayer(Properties.Resources.horror_background_atmosphere_156462);
                    sp.Play();
                    imageBox.Image = Properties.Resources.AAAAAAAAAAAAAAAAA;
                    feddy.Text = "i have no mouth and I must scream.";
                    break;
                default:
                    break;
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void feddy_Click(object sender, EventArgs e)
        {

        }

        private void option1Label_Click(object sender, EventArgs e)
        {

        }

        private void option2Label_Click(object sender, EventArgs e)
        {

        }
    }
}
