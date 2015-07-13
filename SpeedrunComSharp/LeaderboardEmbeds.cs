﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SpeedrunComSharp
{
    public struct LeaderboardEmbeds
    {
        private Embeds embeds;

        public bool EmbedGame 
        { 
            get { return embeds["game"]; } 
            set { embeds["game"] = value; } 
        }

        public bool EmbedCategory
        {
            get { return embeds["category"]; }
            set { embeds["category"] = value; }
        }

        public bool EmbedLevel
        {
            get { return embeds["level"]; }
            set { embeds["level"] = value; }
        }

        public bool EmbedPlayers
        {
            get { return embeds["players"]; }
            set { embeds["players"] = value; }
        }

        public bool EmbedRegions
        {
            get { return embeds["regions"]; }
            set { embeds["regions"] = value; }
        }

        public bool EmbedPlatforms
        {
            get { return embeds["platforms"]; }
            set { embeds["platforms"] = value; }
        }

        public bool EmbedVariables
        {
            get { return embeds["variables"]; }
            set { embeds["variables"] = value; }
        }

        public LeaderboardEmbeds(
            bool embedGame = false,
            bool embedCategory = false,
            bool embedLevel = false,
            bool embedPlayers = false,
            bool embedRegions = false,
            bool embedPlatforms = false,
            bool embedVariables = false)
        {
            embeds = new Embeds();
            EmbedGame = embedGame;
            EmbedCategory = embedCategory;
            EmbedLevel = embedLevel;
            EmbedPlayers = embedPlayers;
            EmbedRegions = embedRegions;
            EmbedPlatforms = embedPlatforms;
            EmbedVariables = embedVariables;
        }

        public override string ToString()
        {
            return embeds.ToString();
        }
    }
}
