using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace Trading_Cards_App
{
    public partial class Form1 : Form
    {
        // Holds the list of players
        private List<HockeyPlayer> players;

        // Data source for retrieving player information
        private HockeyPlayerData PlayerData { get; set; }

        // Dictionary to hold team colors
        public Dictionary<string, Color> teamColors = new Dictionary<string, Color>()
        {
            { "Edmonton Oilers", Color.Blue }, // Example team color
            { "Colorado Avalanche", Color.Red },  // Example team color
            { "New York Rangers", Color.Black },
             { "Boston Bruins", Color.Orange },
             { "Toronto Maple Leafs", Color.LightBlue},
             { "Colorado Avalanches", Color.Yellow },
             { "Vancouver Canucks", Color.DarkBlue },/// Example team color            
        };

        public Form1()
        {
            InitializeComponent();
            LoadData(); // Load player data into the application
            BindData(); // Bind player data to the UI components

            // Subscribe to the event for handling selection changes in the ListBox
            listBoxPlayers.SelectedIndexChanged += ListBoxPlayers_SelectedIndexChanged;
        }

        // Loads player data from the data source.
        public void LoadData()
        {
            PlayerData = new HockeyPlayerData(); // Initialize PlayerData object
            players = HockeyPlayerData.GetPlayers(); // Fetch the list of hockey players
        }

        // Binds the player list to the ListBox for display.

        public void BindData()
        {
            if (players == null || !players.Any())
            {
                MessageBox.Show("No player data available.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Bind the player list to the ListBox
            listBoxPlayers.DataSource = players;
            listBoxPlayers.DisplayMember = "Name"; // Display only the player's name in the ListBox
        }

        // Handles selection changes in the ListBox and updates the card view.

        private void ListBoxPlayers_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listBoxPlayers.SelectedItem is HockeyPlayer selectedPlayer)
            {
                UpdateCardView(selectedPlayer); // Update the UI to show the selected player's details
            }
        }

        // Updates the player card view with the selected player's information.

        private void UpdateCardView(HockeyPlayer player)
        {
            if (player == null) return;

            // Update the PictureBox to show the player's image
            try
            {
                if (!string.IsNullOrWhiteSpace(player.PhotoPath) && System.IO.File.Exists(player.PhotoPath))
                {
                    pictureBoxPlayer.Image = Image.FromFile(player.PhotoPath);
                }
                else
                {
                    pictureBoxPlayer.Image = null;
                    MessageBox.Show("Invalid or missing image path.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch (Exception ex)
            {
                // Handle exceptions related to invalid image paths
                MessageBox.Show($"Error loading image: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                pictureBoxPlayer.Image = null; // Clear the PictureBox if the image fails to load
            }

            // Update labels with the player's details
            labelPlayerName.Text = player.Name;
            labelTeamName.Text = $"Team: {player.Team}";

            UpdateStatsDisplay(player);
            UpdatePictureBoxPlayerBorderColor(player.Team);
        }
        private void UpdateStatsDisplay(HockeyPlayer player)
        {
            // Example logic to color stats based on values
            int goals = player.GoalsScored;
            int games = player.GamesPlayed;

            labelStats.Text = $"Age: {player.Age}\n" +
                              $"Position: {player.Position}\n" +
                              $"Games Played: {games}\n" +
                              $"Goals Scored: {goals}";

            // Color coding based on performance
            labelStats.ForeColor = goals > 50 ? Color.Green : Color.Red;
            
        }

        private void UpdatePictureBoxPlayerBorderColor(string team)
        {
            // Assuming playerPanel is the name of the Panel surrounding the PictureBox
            if (teamColors.TryGetValue(team, out Color borderColor))
            {
                pictureBoxPlayer.BorderStyle = BorderStyle.FixedSingle; // Ensure the border is visible
                pictureBoxPlayer.BackColor = borderColor; // Change the panel's background color
            }
            else
            {
                pictureBoxPlayer.BackColor = SystemColors.Control; // Reset to default if team not found
            }
        }
    }
}









