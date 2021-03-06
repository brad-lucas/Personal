﻿using System;

namespace FHL.Data.Models.NHL
{
    public sealed class PlayerModel
    {
        public static PlayerModel FromPlayerSuggestions(string suggestionStr)
        {
            if (string.IsNullOrEmpty(suggestionStr) || !suggestionStr.Contains("|"))
            {
                return null;
            }

            var info = suggestionStr.Split('|');
            if (info.Length != 15)
            {
                return null;
            }

            var position = info[12].Trim();
            if (position.Length != 1)
            {
                return null;
            }

            var model = new PlayerModel
            {
                IsActive = info[3] == "1",
                Id = int.Parse(info[0]),
                FirstName = info[2],
                LastName = info[1],
                PlayerLink = info[14],
                Position = Convert.ToChar(position),
                TeamAbbreviation = info[11]
            };

            return model;
        }

        public string FirstName { get; set; }

        public int Id { get; set; }

        public bool IsActive { get; set; }

        public string LastName { get; set; }

        public string PlayerLink { get; set; }

        public char Position { get; set; }

        public string TeamAbbreviation { get; set; }
    }
}