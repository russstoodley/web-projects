using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Trading_Cards_App
{
    internal class HockeyPlayerData
    {
        public static List<HockeyPlayer> GetPlayers()
        {
            return new List<HockeyPlayer>

        {
            new HockeyPlayer
            { Name = "Wayne Gretzky",
              PhotoPath = "C:\\Rapid application development fall 2025\\Trading Cards App\\Images\\Wayne Gretzky.jpg",
              Team = "Edmonton Oilers",
              Age = 30,
              Position = "Forward",
              GamesPlayed = 81,
              GoalsScored = 144 },

             new HockeyPlayer
            { Name = "Erik Desjardins",
              PhotoPath = "C:\\Rapid application development fall 2025\\Trading Cards App\\Images\\Erik Desjardins.jpg",
              Team = "Colorado Avalanche",
              Age = 28,
              Position = "Forward",
              GamesPlayed = 82,
              GoalsScored = 35 },

               new HockeyPlayer
            { Name = "Jari kurri",
              PhotoPath = "C:\\Rapid application development fall 2025\\Trading Cards App\\Images\\Jari kurri.jpg",
              Team = "Edmonton Oilers",
              Age = 26,
              Position = "Forward",
              GamesPlayed = 76,
              GoalsScored = 92 },

                  new HockeyPlayer
            { Name = "Sydney Crosby",
              PhotoPath = "C:\\Rapid application development fall 2025\\Trading Cards App\\Images\\Sydney Crosby.jpg",
              Team = "New York Rangers",
              Age = 32,
              Position = "Forward",
              GamesPlayed = 82,
              GoalsScored = 89 },

                  new HockeyPlayer
            { Name = "Roman Turek",
              PhotoPath = "C:\\Rapid application development fall 2025\\Trading Cards App\\Images\\Roman Turek.jpg",
              Team = "Boston Bruins",
              Age = 27,
              Position = "Forward",
              GamesPlayed = 82,
              GoalsScored = 47 },

                   new HockeyPlayer
            { Name = "Patrick Burglund",
              PhotoPath = "C:\\Rapid application development fall 2025\\Trading Cards App\\Images\\Patrick Burglund.jpg",
              Team = "Toronto Maple Leafs",
              Age = 26,
              Position = "Forward",
              GamesPlayed = 81,
              GoalsScored = 69 },

                   new HockeyPlayer
            { Name = "Mikko Turvall",
              PhotoPath = "C:\\Rapid application development fall 2025\\Trading Cards App\\Images\\Mikko Turvall.jpg",
              Team = "Edmonton Oilers",
              Age = 28,
              Position = "Forward",
              GamesPlayed = 31,
              GoalsScored = 41 },

                   new HockeyPlayer
            { Name = "Mikko Makela",
              PhotoPath = "C:\\Rapid application development fall 2025\\Trading Cards App\\Images\\Mikko Makela.jpg",
              Team = "Colorado Avalanche",
              Age = 27,
              Position = "Forward",
              GamesPlayed = 40,
              GoalsScored = 82 },

                   new HockeyPlayer
            { Name = "Mikko Helisten",
              PhotoPath = "C:\\Rapid application development fall 2025\\Trading Cards App\\Images\\Mikko Helisten.jpg",
              Team = "Vancouver Canucks",
              Age = 30,
              Position = "Forward",
              GamesPlayed = 81,
              GoalsScored = 37 },

                          new HockeyPlayer
            { Name = "Mikko Koivu",
              PhotoPath = "C:\\Rapid application development fall 2025\\Trading Cards App\\Images\\Mikko Koivu.jpg",
              Team = "Toronto Maple Leafs",
              Age = 27,
              Position = "Forward",
              GamesPlayed = 82,
              GoalsScored = 40 },          
            
             };
        }
    }
}
