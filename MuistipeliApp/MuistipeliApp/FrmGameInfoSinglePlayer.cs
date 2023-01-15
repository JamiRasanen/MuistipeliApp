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

namespace MuistipeliApp
{
    public partial class FrmGameInfoSP : Form
    {
        public List<Player> playerList = new List<Player>();

        public Player player1;
        public bool sfxOnOff = true;

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

        public void PlaySFX(UnmanagedMemoryStream file)
        {
            //Soittaa ääneiefektin
            if (sfxOnOff)
            {
                SoundPlayer soundPlayer = new SoundPlayer(file);
                soundPlayer.Play();
            }
        }

        public void AddPlayersToList()
        {
            //Lisää player 1 
            bool playerExists = false;
            foreach (Player pl in playerList)
            {
                if (cmbPlayer1Name.Text == pl.Name)
                {
                    playerExists = true;
                    player1 = pl;
                    player1.Index = playerList.IndexOf(pl);
                    break;
                }
            }
            if (!playerExists)
            {
                player1 = new Player();
                player1.Name = cmbPlayer1Name.Text;
                playerList.Add(player1);
                player1.Index = playerList.IndexOf(player1);
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

                List<string> playerNames = new List<string>();

                foreach (Player pl in playerList)
                {
                    playerNames.Add(pl.Name);
                }

                cmbPlayer1Name.DataSource = playerNames;
            }
        }

        public FrmGameInfoSP(bool sfx)
        {
            InitializeComponent();
            LoadPlayerList();
            sfxOnOff = sfx;
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            //Tarkistaa että pelaajalla on nimi
            if (cmbPlayer1Name.Text.Trim() == "")
            {
                MessageBox.Show("Player must have a name!", "Error");
                cmbPlayer1Name.Focus();
            }
            else //Avaa pelin
            {
                PlaySFX(Properties.Resources.click);
                AddPlayersToList();
                FrmCardsSinglePlayer frmCardsSP = new FrmCardsSinglePlayer(this);
                this.Close();
                frmCardsSP.Show();
            }
        }

        private void nudCardCount_ValueChanged(object sender, EventArgs e)
        {
            //Rivejä voi olla maks puolet korteista
            nudRows.Maximum = nudCardCount.Value/2;

            //Korttien määrän pitää olla jaollinen rivien määrällä
            while (nudCardCount.Value % nudRows.Value != 0)
            {
                nudRows.Value--;
            }
        }

        private void nudRows_Leave(object sender, EventArgs e)
        {
            //Korttien määrän pitää olla jaollinen rivien määrällä
            while (nudCardCount.Value % nudRows.Value != 0)
            {
                nudRows.Value--;
            }
        }

        private void cmbPlayer1Name_KeyPress(object sender, KeyPressEventArgs e)
        {
            //Nimen pituus max 20 merkkiä
            if (cmbPlayer1Name.Text.Length >= 20 && e.KeyChar != '\b')
            {
                e.Handled = true;
            }
        }

        private void nudCardCount_Leave(object sender, EventArgs e)
        {
            //Korttien määrän on pakko olla parillinen
            if (nudCardCount.Value % 2 != 0)
            {
                nudCardCount.Value++;
            }
        }  
    }
}
