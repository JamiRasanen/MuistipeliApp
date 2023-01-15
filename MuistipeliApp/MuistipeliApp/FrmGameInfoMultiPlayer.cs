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
    public partial class FrmGameInfoMultiPlayer : Form
    {
        public List<Player> playerList = new List<Player>();

        public Player player1;
        public Player player2;
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

            //Lisää player 2 
            playerExists = false;
            foreach (Player pl in playerList)
            {
                if (cmbPlayer2Name.Text == pl.Name)
                {
                    playerExists = true;
                    player2 = pl;
                    player2.Index = playerList.IndexOf(pl);
                    break;
                }
            }
            if (!playerExists)
            {
                player2 = new Player();
                player2.Name = cmbPlayer2Name.Text;
                playerList.Add(player2);
                player2.Index = playerList.IndexOf(player2);
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

                List<String> playerNames2 = new List<String>(playerNames);

                cmbPlayer1Name.DataSource = playerNames;
                cmbPlayer2Name.DataSource = playerNames2;
                if (playerNames.Count >= 2)
                {
                    cmbPlayer2Name.Text = playerNames2[1];
                }
            }
        }

        public FrmGameInfoMultiPlayer(bool sfx)
        {
            InitializeComponent();
            LoadPlayerList();
            sfxOnOff = sfx;
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            //Tarkistaa että pelaajilla on eri nimet
            if (cmbPlayer1Name.Text == cmbPlayer2Name.Text)
            {
                MessageBox.Show("Players can't have the same name!", "Error");
                cmbPlayer1Name.Focus();
            }
            //Tarkistaa että pelaajilla on nimet
            else if (cmbPlayer1Name.Text.Trim() == "")
            {
                MessageBox.Show("Player 1 must have a name!", "Error");
                cmbPlayer1Name.Focus();
            }
            else if (cmbPlayer2Name.Text.Trim() == "")
            {
                MessageBox.Show("Player 2 must have a name!", "Error");
                cmbPlayer2Name.Focus();
            }
            else //Avaa pelin
            {
                PlaySFX(Properties.Resources.click);
                AddPlayersToList();
                FrmCardsMultiPlayer frmCards = new FrmCardsMultiPlayer(this);
                this.Close();
                frmCards.Show();
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

        private void nudCardCount_Leave(object sender, EventArgs e)
        {
            //Korttien määrän on pakko olla parillinen
            if (nudCardCount.Value % 2 != 0)
            {
                nudCardCount.Value++;
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

        private void cmbPlayer2Name_KeyPress(object sender, KeyPressEventArgs e)
        {
            //Nimen pituus max 20 merkkiä
            if (cmbPlayer2Name.Text.Length >= 20 && e.KeyChar != '\b')
            {
                e.Handled = true;
            }
        }
    }
}
