using Newtonsoft.Json;
using Newtonsoft.Json.Bson;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Media;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MuistipeliApp
{
    public partial class FrmCardsSinglePlayer : Form
    {
        //Images
        public Image back = MuistipeliApp.Properties.Resources.back1;
        public Image picture1 = MuistipeliApp.Properties.Resources.picture1;
        public Image picture2 = MuistipeliApp.Properties.Resources.picture2;
        public Image picture3 = MuistipeliApp.Properties.Resources.picture3;
        public Image picture4 = MuistipeliApp.Properties.Resources.picture4;
        public Image picture5 = MuistipeliApp.Properties.Resources.picture5;
        public Image picture6 = MuistipeliApp.Properties.Resources.picture6;
        public Image picture7 = MuistipeliApp.Properties.Resources.picture7;
        public Image picture8 = MuistipeliApp.Properties.Resources.picture8;
        public Image picture9 = MuistipeliApp.Properties.Resources.picture9;
        public Image picture10 = MuistipeliApp.Properties.Resources.picture10;
        public Image picture11 = MuistipeliApp.Properties.Resources.picture11;
        public Image picture12 = MuistipeliApp.Properties.Resources.picture12;
        public Image picture13 = MuistipeliApp.Properties.Resources.picture13;
        public Image picture14 = MuistipeliApp.Properties.Resources.picture14;
        public Image picture15 = MuistipeliApp.Properties.Resources.picture15;
        public Image picture16 = MuistipeliApp.Properties.Resources.picture16;
        //

        //Lists
        public Image[] kuvat = new Image[32];
        public PictureBox[] cards = new PictureBox[32];
        public int[] cardPositions = new int[32];
        List<Player> playerList;
        //

        //Card amount
        public int cardCount;
        public int rows;
        //

        //File path to folder 2 steps above where the .exe is located
        public string gameFilePath = Directory.GetCurrentDirectory().Substring(0, Directory.GetCurrentDirectory().Length - 10);
        //

        //Selections
        public int cardSelected = -1;
        public int firstClicked = -1;
        public int secondClicked = -1;
        public bool canSelect = true;
        //

        //Game info
        public int gameTime = 0;
        public Player player1;
        public bool musicOnOff = true;
        public bool sfxOnOff = true;
        //


        public void SerializeJSON(List<Player> input, string file)
        {
            string json = JsonConvert.SerializeObject(input);
            //write string to file
            System.IO.File.WriteAllText(file, json);
        }

        public void PlaySFX(UnmanagedMemoryStream file)
        {
            //Soittaa ääniefektin

            if (sfxOnOff)
            {
                SoundPlayer soundPlayer = new SoundPlayer(file);
                soundPlayer.Play();
            }
        }

        public void LoadImages()
        {
            //Lisätään kuvat listaan
            kuvat[0] = picture1;
            kuvat[1] = picture1;
            kuvat[2] = picture2;
            kuvat[3] = picture2;
            kuvat[4] = picture3;
            kuvat[5] = picture3;
            kuvat[6] = picture4;
            kuvat[7] = picture4;
            kuvat[8] = picture5;
            kuvat[9] = picture5;
            kuvat[10] = picture6;
            kuvat[11] = picture6;
            kuvat[12] = picture7;
            kuvat[13] = picture7;
            kuvat[14] = picture8;
            kuvat[15] = picture8;
            kuvat[16] = picture9;
            kuvat[17] = picture9;
            kuvat[18] = picture10;
            kuvat[19] = picture10;
            kuvat[20] = picture11;
            kuvat[21] = picture11;
            kuvat[22] = picture12;
            kuvat[23] = picture12;
            kuvat[24] = picture13;
            kuvat[25] = picture13;
            kuvat[26] = picture14;
            kuvat[27] = picture14;
            kuvat[28] = picture15;
            kuvat[29] = picture15;
            kuvat[30] = picture16;
            kuvat[31] = picture16;

        }
        public void ShuffleCards()
        {
            //Arvotaan korteille numerot
            Random r = new Random();

            for (int i = 0; i < cardCount; i++)
            {
                do
                {
                    int x = r.Next(0, cardCount);
                    bool loytyi = false;
                    for (int j = 0; j < i; j++)
                    {
                        if (cardPositions[j] == x)
                        {
                            loytyi = true;
                            break;
                        }
                    }
                    if (!loytyi)
                    {
                        cardPositions[i] = x;
                        break;
                    }
                } while (true);

            }
        }

        public void CreateCards()
        {
            //Luodaan kortit dynaamisesti perustuen niiden ja rivien määrään
            int width = pnlCards.Width / (cardCount/rows);
            int height = pnlCards.Height / rows;
            int row = -1;
            for (int i = 0, j = 0 ; i < cardCount; i++, j++)
            {
                row = (i%(cardCount/rows) == 0) ? ++row : row;
                j = (i%(cardCount/rows) == 0) ? 0 : j;
                
                PictureBox pb = new PictureBox();
                pb.Location = new System.Drawing.Point(4 + width * j, 4 + row * height);
                pb.Name = i.ToString();
                pb.Size = new System.Drawing.Size(width - 8, height - 8);
                pb.TabIndex = 0;
                pb.TabStop = false;
                pb.Image = back;
                pb.SizeMode = PictureBoxSizeMode.StretchImage;
                cards[i] = pb;
                pb.Click += new System.EventHandler(this.pictureBox_Click);
                pnlCards.Controls.Add(cards[i]);
            }
        }

        public void CheckForMatch()
        {            
            //Aktivoi ajastimen joka tarkistaa oliko pari, jos kaksi korttia on valittu
            if (firstClicked != -1 && secondClicked != -1)
            {
                tmrCheckMatch.Enabled = true;
                canSelect = false;
            }
        }
        private void tmrCheckMatch_Tick(object sender, EventArgs e)
        {
            //Tarkistaa onko pari
            tmrCheckMatch.Enabled = false;
            if (cards[firstClicked].Image == cards[secondClicked].Image) //Match
            {
                PlaySFX(Properties.Resources.match);

                pnlCards.Controls.Remove(cards[firstClicked]);
                pnlCards.Controls.Remove(cards[secondClicked]);

                firstClicked = -1;
                secondClicked = -1;

                UpdateScore();

                IsGameOver();
            }
            else //No Match
            {
                PlaySFX(Properties.Resources.noMatch);

                cards[firstClicked].Image = back;
                cards[secondClicked].Image = back;

                firstClicked = -1;
                secondClicked = -1;

            }

            canSelect = true;
        }

        public void UpdateScore()
        {
            //Tulosten päivitys
            player1.Score++;
            player1.TotalMatches++;
            lblPlayer1Score.Text = "Score: " + player1.Score.ToString();

        }

        public void IsGameOver()
        {
            //Jos peli on ohi, kysytään pelataanko uudestaan vai palataanko valikkoon, tallennetaan joka tapauksessa
            if (pnlCards.Controls.Count == 0)
            {
                DialogResult dr = DialogResult.No;

                myMessageBox mb = new myMessageBox("All pairs found!\rWould you like to play again, or return to menu?", "Game Over!");
                dr = mb.ShowDialog();

                SavePlayerStats();

                if (dr == DialogResult.Yes)
                {
                    NewGame();
                }
                else
                {
                    this.Close();
                }
            }
        }

        public void NewGame()
        {
            LoadImages();
            ShuffleCards();
            CreateCards();


            //Reset scores
            player1.Score = 0;
            lblPlayer1Score.Text = "Score: 0";
            gameTime = 0;
        }
        public void SavePlayerStats()
        {
            //Tallennetaan tiedot
            playerList[player1.Index] = player1;

            //Luodaan GameData kansio jos sitä ei ole
            string gameDataFilePath = gameFilePath + "\\GameData";

            DirectoryInfo drInfoGameData = new DirectoryInfo(gameDataFilePath);

            if (drInfoGameData.Exists != true)
            {
                drInfoGameData.Create();
            }

            //Luodaan GameData tiedosto
            SerializeJSON(playerList, gameDataFilePath + "\\GameData.json");
        }
        public void LoadSettings()
        {
            //Ladataan edelliset asetukset
            string gameSettingsFilePath = gameFilePath + "\\GameData";

            if (File.Exists(gameSettingsFilePath + "\\settings.txt"))
            {
                using (StreamReader sr = new StreamReader(gameSettingsFilePath + "\\settings.txt"))
                {
                    while (!sr.EndOfStream)
                    {
                        string line = sr.ReadLine();

                        switch (line.Substring(0, line.Length - 1))
                        {
                            case "CardBack = ":
                                int cardBack;
                                bool ok = int.TryParse(line.Substring(line.Length - 1, 1), out cardBack);

                                if (!ok)
                                {
                                    cardBack = 1;
                                }

                                switch (cardBack)
                                {
                                    case 1:
                                        back = MuistipeliApp.Properties.Resources.back1;
                                        break;
                                    case 2:
                                        back = MuistipeliApp.Properties.Resources.back2;
                                        break;
                                    case 3:
                                        back = MuistipeliApp.Properties.Resources.back3;
                                        break;
                                }

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
        


        public FrmCardsSinglePlayer(FrmGameInfoSP frmGISP)
        {
            InitializeComponent();
            cardCount = (int)frmGISP.nudCardCount.Value;
            rows = (int)frmGISP.nudRows.Value;
            playerList = frmGISP.playerList;


            player1 = frmGISP.player1;
            lblPlayer1Name.Text = player1.Name;
        }

        private void FrmCards_Load(object sender, EventArgs e)
        {
            LoadSettings();
            NewGame();
        }

        
        private void pictureBox_Click(object sender, EventArgs e)
        {
            //Kortin valinta
            if (canSelect)
            {
                PictureBox pb = (PictureBox)sender;
                cardSelected = int.Parse(pb.Name);

                if (cards[cardSelected].Image == back)
                {
                    //jos korttia ei ole käännetty
                    PlaySFX(Properties.Resources.cardFlip);
                }

                if (firstClicked == -1)
                {
                    firstClicked = cardSelected;
                }
                else if (firstClicked != cardSelected)
                {
                    secondClicked = cardSelected;
                }

                cards[cardSelected].Image = kuvat[cardPositions[cardSelected]];

                CheckForMatch();
            }
        }

        private void tmrGameTime_Tick(object sender, EventArgs e)
        {
            //Kauanko peli on kestänyt
            gameTime++;
            tsslblTime.Text = "Time: " + gameTime.ToString();
        }

        private void Frm8cards_Resize(object sender, EventArgs e)
        {
            //Skaalaa korttien kokoa ikkunan koon mukaan
            pnlCards.Width = this.ClientSize.Width - pnlCards.Location.X * 2;
            pnlCards.Height = this.ClientSize.Height - pnlCards.Location.Y - 71;


            foreach (PictureBox pb in pnlCards.Controls)
            {
                int pos = int.Parse(pb.Name);
                int row = -1;

                int width = pnlCards.Width / (cardCount / rows);
                int height = pnlCards.Height / rows;

                //Laskee millä rivillä kyseisen kortin pitäisi olla
                for (int i = 0; i <= pos; i++)
                {
                    row = (i % (cardCount / rows) == 0) ? ++row : row;
                }

                pb.Location = new Point(4 + width * (pos - cardCount/rows * row), 4 + row * height);
                pb.Size = new Size(width - 8, height - 8);
            }

            //Nimi paneelin skaalaus
            pnlNames.Width = this.ClientSize.Width - pnlNames.Location.X - 45;

        }
    }
}
