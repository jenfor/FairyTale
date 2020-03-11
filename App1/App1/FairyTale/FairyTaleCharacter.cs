﻿using System;
using System.Collections.Generic;
using System.Text;

namespace App1.FairyTale
{
    public class FairyTaleCharacter
    {
        public String Animal = String.Empty;
        public String Adjective = String.Empty;
        public String Name = String.Empty;
        public String Gender = String.Empty;
        public String RelationShip = String.Empty;
        public String Emoji = String.Empty;

        private List<char> uppercaseConsonants = new List<char>(){'B', 'C', 'D', 'F', 'G', 'H', 'J', 'K', 'L', 'M', 'N', 'P', 'R', 'S', 'T', 'V'};
        private List<char> lowercaseConsonants = new List<char>() { 'b', 'c', 'd', 'f', 'g', 'h', 'j', 'k', 'l', 'm', 'n', 'p', 'r', 's', 't', 'v' };
        private List<char> vowels = new List<char>() { 'a', 'e', 'i', 'o', 'u', 'y' };

        public FairyTaleCharacter(String animal, String adjective,  String gender, String relationShip, string emoji)
        {
            Animal = animal;
            Adjective = adjective;
            Name = GetFairyTaleName();
            Gender = gender;
            RelationShip = relationShip;
            Emoji = emoji;
        }

        public String GetPronoun()
        {
            if (Gender != String.Empty && Gender.Equals("Hon"))
            {
                return "Hennes";
            }
            else if (Gender != String.Empty && Gender.Equals("Han"))
            {
                return "Hans";
            }

            return String.Empty;
        }

        public String GetFairyTaleName()
        {
            var random = new Random();
            var sb = new StringBuilder();

            var consonant1 = uppercaseConsonants[random.Next(uppercaseConsonants.Count)];
            var vowel = vowels[random.Next(vowels.Count)];
            sb.Append(consonant1).Append(vowel);
            for (int i = 0; i <= random.Next(1); i++)
            {
                var consonant2 = lowercaseConsonants[random.Next(lowercaseConsonants.Count)];
                var vowel2 = vowels[random.Next(vowels.Count)];
                sb.Append(consonant2).Append(vowel2);
            }

            var name = sb.ToString();
            return name;
        }
    }
}


