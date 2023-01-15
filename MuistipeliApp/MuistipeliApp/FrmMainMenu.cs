using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Net.WebRequestMethods;

namespace MuistipeliApp
{
    public partial class FrmMainMenu : Form
    {
        public bool musicOnOff = true;
        public bool sfxOnOff = true;

        public void LoadSettings()
        {
            //Ladataan edelliset asetukset
            string gameDataFilePath = Directory.GetCurrentDirectory();
            gameDataFilePath = gameDataFilePath.Substring(0, gameDataFilePath.Length - 10);
            gameDataFilePath += "\\GameData";

            if (System.IO.File.Exists(gameDataFilePath + "\\settings.txt"))
            {
                using (StreamReader sr = new StreamReader(gameDataFilePath + "\\settings.txt"))
                {
                    while (!sr.EndOfStream)
                    {
                        string line = sr.ReadLine();

                        switch (line.Substring(0, line.Length - 1))
                        {
                            case "Music = ":
                                if (line.Substring(line.Length - 1, 1) == "0")
                                {
                                    musicOnOff = false;
                                }
                                else
                                {
                                    musicOnOff = true;
                                }

                                break;
                            case "SFX = ":
                                if (line.Substring(line.Length - 1, 1) == "0")
                                {
                                    sfxOnOff = false;
                                }
                                else
                                {
                                    sfxOnOff = true;
                                }

                                break;
                        }
                    }
                }
            }
        }
        public void PlaySFX(UnmanagedMemoryStream file)
        {
            //Soittaa ääniefektin
            if (sfxOnOff)
            {
                SoundPlayer click = new SoundPlayer(file);
                click.Play();
            }
        }

        public void InitializeMediaPLayer()
        {
            //Alustetaan MediaPlayer

            string gameResourceFilePath = Directory.GetCurrentDirectory();
            gameResourceFilePath = gameResourceFilePath.Substring(0, gameResourceFilePath.Length - 10);
            gameResourceFilePath += "\\Resources";

            WMPmusic.URL = gameResourceFilePath + "\\background.wav"; //mitä soitetaan
            WMPmusic.settings.playCount = 9999; // toistaa 9999 kertaa
            WMPmusic.settings.volume = 10;
            WMPmusic.Ctlcontrols.stop();
            WMPmusic.Visible = false;
        }

        public void PlayMusic()
        {
            //Soiko musiikki vai ei
            if (musicOnOff)
            {
                WMPmusic.Ctlcontrols.play();
            }
            else if (!musicOnOff)
            {
                WMPmusic.Ctlcontrols.stop();
            }
        }

        public FrmMainMenu()
        {
            InitializeComponent();
            LoadSettings();
            InitializeMediaPLayer();
            PlayMusic();
        }

        private void btn1Player_Click(object sender, EventArgs e)
        {
            //Käynnistää yksinpelin
            PlaySFX(Properties.Resources.click);
            FrmGameInfoSP frmGISP = new FrmGameInfoSP(sfxOnOff);
            frmGISP.ShowDialog();
        }

        private void btn2Players_Click(object sender, EventArgs e)
        {
            //Käynnistää kaksinpelin
            PlaySFX(Properties.Resources.click);
            FrmGameInfoMultiPlayer frmGIMP = new FrmGameInfoMultiPlayer(sfxOnOff);
            frmGIMP.ShowDialog();
        }

        private void btnQuit_Click(object sender, EventArgs e)
        {
            //Sulkee sovelluksen
            PlaySFX(Properties.Resources.click);
            Application.Exit();
        }

        private void btnPlayerStats_Click(object sender, EventArgs e)
        {
            //Avaa statistiikka ikkunan
            PlaySFX(Properties.Resources.click);
            FrmPlayerStats frmPS = new FrmPlayerStats();
            frmPS.ShowDialog();
        }

        private void btnSettings_Click(object sender, EventArgs e)
        {
            //Avaa asetus ikkunan
            PlaySFX(Properties.Resources.click);
            FrmSettings FrmSettigns = new FrmSettings(WMPmusic);
            FrmSettigns.ShowDialog();
            LoadSettings();
            PlayMusic();
        }
    }
}
