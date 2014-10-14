﻿using System;

namespace Final_Year_Project.GameData
    {
        [Serializable()]
        public class SystemOptions
        {
            #region Variables
            public Boolean fullScreen { get; set; }
            public Difficulty difficultyLevel { get; set; }
            public Sound soundLevel { get; set; }
            public Music musicLevel { get; set; }
            public int resolutionWidth { get; set; }
            public int resolutionHeight { get; set; }
	        #endregion

            #region Constructor(s)
            public SystemOptions()
            {
                fullScreen = true;
                difficultyLevel = Difficulty.MEDIUM;
                soundLevel = Sound.ON;
                musicLevel = Music.ON;
                resolutionWidth = (int)ResolutionWidth.WIDESCREEN;
                resolutionHeight = (int)ResolutionHeight.WIDESCREEN;
            }
	        #endregion
        }

        public enum Difficulty
        {
            EASY = 0,
            MEDIUM = 1,
            HARD = 2
        }

        public enum Sound
        {
            ON = 0,
            QUIET = 1,
            OFF = 2
        }

        public enum Music
        {
            ON = 0,
            QUIET = 1,
            OFF = 2
        }

        public enum ResolutionWidth
        {
            SMALL = 1280,
            MEDIUM = 1366,
            LARGE = 1920,
            WIDESCREEN = 2560
        }

        public enum ResolutionHeight
        {
            SMALL = 900,
            MEDIUM = 876,
            LARGE = 1080,
            WIDESCREEN = 1080
        }
    }
