using Newtonsoft.Json;
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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace MuistipeliApp
{
    public partial class FrmPlayerStats : Form
    {
        
        public List<Player> playerList = new List<Player>();
        public bool sfxOnOff = true;


        public void SerializeJSON(List<Player> input, string file)
        {
            string json = JsonConvert.SerializeObject(input);
            //write string to file
            System.IO.File.WriteAllText(file, json);
        }

        public List<Player> DeserializeJSON(string file)
        {
            if (File.Exists(file))
            {
                using (StreamReader r = new StreamReader(file))
                {
                    string json = r.ReadToEnd();
                    return JsonConvert.DeserializeObject<List<Player>>(json);
                }
            }
            else
                return null;
        }

        public void LoadSettings()
        {
            //Lataa asetukset
            string gameSettingsFilePath = Directory.GetCurrentDirectory();
            gameSettingsFilePath = gameSettingsFilePath.Substring(0, gameSettingsFilePath.Length - 10);
            gameSettingsFilePath += "\\GameData";

            if (File.Exists(gameSettingsFilePath + "\\settings.txt"))
            {
                using (StreamReader sr = new StreamReader(gameSettingsFilePath + "\\settings.txt"))
                {
                    while (!sr.EndOfStream)
                    {
                        string line = sr.ReadLine();

                        switch (line.Substring(0, line.Length - 1))
                        {
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
                SoundPlayer soundPlayer = new SoundPlayer(file);
                soundPlayer.Play();
            }
        }

        public void UpdateListBox()
        {
            //Päivittää ListBoxin tiedot
            lbPlayerStats.Items.Clear();

            foreach (Player pl in playerList)
            {
                lbPlayerStats.Items.Add("Wins: " + pl.Wins + "   Losses: " + pl.Losses + 
                    "   Draws: " + pl.Draws +  "   Pairs: " + pl.TotalMatches + "   " + pl.Name);
            }
        }

        public void LoadPlayerList()
        {
            //Lataa tiedot
            string gameDataFilePath = Directory.GetCurrentDirectory();
            gameDataFilePath = gameDataFilePath.Substring(0, gameDataFilePath.Length - 10);
            gameDataFilePath += "\\GameData";

            if (File.Exists(gameDataFilePath + "\\GameData.json"))
            {
                playerList = DeserializeJSON(gameDataFilePath + "\\GameData.json");

                UpdateListBox();
            }
        }

        public FrmPlayerStats()
        {
            InitializeComponent();
            LoadPlayerList();
            LoadSettings();
        }

        private void FrmPlayerStats_Resize(object sender, EventArgs e)
        {
            //Skaalaa ListBoxia

            lbPlayerStats.Width = this.ClientSize.Width - lbPlayerStats.Location.X * 2;
            lbPlayerStats.Height = this.ClientSize.Height - lbPlayerStats.Location.Y -100;
        }

        private void deletePlayerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Poistaa pelaajan ListBoxista ja pelaaja listasta
            int index = lbPlayerStats.SelectedIndex;

            if (index != -1)
            {
                playerList.RemoveAt(index);

                foreach (Player pl in playerList)
                {   //Päivitetään pelaajien indexit
                    pl.Index = playerList.IndexOf(pl);
                }

                UpdateListBox();
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            //Sulkee ikkunan, ei tallenna
            PlaySFX(Properties.Resources.click);
            this.Close();
        }

        private void btnSaveExit_Click(object sender, EventArgs e)
        {
            //Sulkee ikkunna, tallentaa
            PlaySFX(Properties.Resources.click);

            //Otetaan .exe tiedoston sijainti, mennään taakse päin ja lisätään GameData kansio
            string gameDataFilePath = Directory.GetCurrentDirectory();
            gameDataFilePath = gameDataFilePath.Substring(0, gameDataFilePath.Length - 10);
            gameDataFilePath += "\\GameData";

            DirectoryInfo drInfoGameData = new DirectoryInfo(gameDataFilePath);

            if (drInfoGameData.Exists != true)
            {
                drInfoGameData.Create();
            }

            SerializeJSON(playerList, gameDataFilePath + "\\GameData.json");

            this.Close();
        }
    }
}
