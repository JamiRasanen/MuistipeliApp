using AxWMPLib;
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

namespace MuistipeliApp
{
    public partial class FrmSettings : Form
    {
        public int cardBack = 1;
        public bool musicOnOff = true;
        public bool sfxOnOff = true;

        public AxWindowsMediaPlayer WMPmusic;

        public void LoadSettins()
        {
            //Ladataan edelliset asetukset
            string gameDataFilePath = Directory.GetCurrentDirectory();
            gameDataFilePath = gameDataFilePath.Substring(0, gameDataFilePath.Length - 10);
            gameDataFilePath += "\\GameData";

            if (File.Exists(gameDataFilePath + "\\settings.txt"))
            {
                using (StreamReader sr = new StreamReader(gameDataFilePath + "\\settings.txt"))
                {
                    while (!sr.EndOfStream)
                    {
                        string line = sr.ReadLine();
                       
                        switch (line.Substring(0, line.Length - 1))
                        {
                            case "CardBack = ":
                                bool ok = int.TryParse(line.Substring(line.Length - 1, 1), out cardBack);

                                if (!ok)
                                {
                                    cardBack = 1;
                                }

                                PositionPointerArrow();
                                break;
                            case "Music = ":
                                if (line.Substring(line.Length - 1, 1) == "0")
                                {
                                    musicOnOff = false;
                                }
                                else
                                {
                                    musicOnOff = true;
                                }
                                UpdateBtnMusic();
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
                                UpdateBtnSFX();
                                break;
                        }
                    }
                }
            }
        }
        public void SaveSettings()
        {
            //Tallentaa asetukset
            string gameDataFilePath = Directory.GetCurrentDirectory();
            gameDataFilePath = gameDataFilePath.Substring(0, gameDataFilePath.Length - 10);
            gameDataFilePath += "\\GameData";

            DirectoryInfo dri = new DirectoryInfo(gameDataFilePath);

            if (!dri.Exists)
            {
                dri.Create();
            }

            using (StreamWriter sw = new StreamWriter(gameDataFilePath + "\\settings.txt"))
            {
                sw.WriteLine("CardBack = " + cardBack);
                if (musicOnOff)
                {
                    sw.WriteLine("Music = " + 1);
                }
                else
                {
                    sw.WriteLine("Music = " + 0);
                }

                if (sfxOnOff)
                {
                    sw.WriteLine("SFX = " + 1);
                }
                else
                {
                    sw.WriteLine("SFX = " + 0);
                }
            }
        }

        public void UpdateBtnMusic()
        {
            //Päivittää napin tekstin
            if (musicOnOff)
            {
                btnMusic.Text = "ON";
            }
            else
            {
                btnMusic.Text = "OFF";
            }
        }

        public void UpdateMusic()
        {
            //Soiko musiikki
            if (musicOnOff)
            {
                WMPmusic.Ctlcontrols.play();
            }
            else
            {
                WMPmusic.Ctlcontrols.stop();
            }
        }

        public void UpdateBtnSFX()
        {
            //Päivittää napin tekstin
            if (sfxOnOff)
            {
                btnSFX.Text = "ON";
            }
            else
            {
                btnSFX.Text = "OFF";
            }
        }

        public void PositionPointerArrow()
        {
            //Laitetaan PointerArrow osoittamaan oikeaan kuvaan
            switch (cardBack)
            {
                case 1:
                    pbPointerArrow.Left = (pbCardBack1.Left + pbCardBack1.Width/2) - pbPointerArrow.Width/2;
                    break;
                case 2:
                    pbPointerArrow.Left = (pbCardBack2.Left + pbCardBack1.Width / 2) - pbPointerArrow.Width / 2;
                    break;
                case 3:
                    pbPointerArrow.Left = (pbCardBack3.Left + pbCardBack1.Width / 2) - pbPointerArrow.Width / 2;
                    break;
            }
        }
        public void PlaySFX(UnmanagedMemoryStream file)
        {
            //Soittaa ääneiefektin
            if (sfxOnOff)
            {
                SoundPlayer soundPlayer = new SoundPlayer(file);
                soundPlayer.Play();
            }
        }

        public FrmSettings(AxWindowsMediaPlayer WMP)
        {
            WMPmusic = WMP; //tuo MediaPlayerin main menusta
            InitializeComponent();
            LoadSettins();
            PositionPointerArrow();
        }

        private void pbCardBack1_Click(object sender, EventArgs e)
        {
            //Valitsee kortin takakuvan
            PlaySFX(Properties.Resources.click);
            cardBack = 1;
            PositionPointerArrow();
        }

        private void pbCardBack2_Click(object sender, EventArgs e)
        {
            //Valitsee kortin takakuvan
            PlaySFX(Properties.Resources.click);
            cardBack = 2;
            PositionPointerArrow();
        }

        private void pbCardBack3_Click(object sender, EventArgs e)
        {
            //Valitsee kortin takakuvan
            PlaySFX(Properties.Resources.click);
            cardBack = 3;
            PositionPointerArrow();
        }

        private void btnMusic_Click(object sender, EventArgs e)
        {
            //Musiikki päälle/pois
            PlaySFX(Properties.Resources.click);
            musicOnOff = !musicOnOff;
            UpdateBtnMusic();
            UpdateMusic();
        }

        private void btnSFX_Click(object sender, EventArgs e)
        {
            //Äänet päälle/pois
            PlaySFX(Properties.Resources.click);
            sfxOnOff = !sfxOnOff;
            UpdateBtnSFX();
        }

        private void btnSaveExit_Click(object sender, EventArgs e)
        {
            //Sulkee ikkunan, tallentaa
            PlaySFX(Properties.Resources.click);
            SaveSettings();
            this.Close();
        }
        private void btnExit_Click(object sender, EventArgs e)
        {
            //Sulkee ikkunan, ei tallenna
            PlaySFX(Properties.Resources.click);
            this.Close();
        }
    }
}
