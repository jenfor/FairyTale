﻿using System;
using System.Collections.Generic;
using System.Text;

namespace App1.Languages
{
    public class ShortEnglish : Language
    {
        public string BackToStart => "Back to start";
        public string ShareFairyTale => "Share the fairy tale";
        public string BackFairyTale => "Back";
        public string ContinueFairyTale => "Continue";
        public string ViewFairyTale => "View/Share";
        public string NewImage => "Change";

        public string VersionOption => "What kind of fairy tale do you want to write?";

        public string BackToStartPageWarning => "Are you sure you want to go back to start?" + NewLine + NewLine + " This story will be deleted!";
        public string Warning => "Warning";
        public string Question => "Question";
        public string Information => "It is your turn";

        public string Deletion => "Are you sure you want to delete this fairy tale and create a new one?";
        public string Short => "A short fairy tale";
        public string Long => "A long fairy tale";
        public string Yes => "Yes";
        public string No => "No";

        public string TapHere => "Tap here to write!";

        public string InformationExchangeString => "Now it's your turn to write about "
            + StringReplacer.Character1_Name + " and "
            + StringReplacer.Character2_Name + "." + NewLine + NewLine
                    + "Tap the fairy tale text you see in this page and start writing!";

        public string ExchangeString => "Tap here to write about " +
                         StringReplacer.Character1_Name + " and " +
                         StringReplacer.Character2_Name + Dot;

        public string WasNamed => "called ";
        public string HadA => " has a ";
        public string A => "a ";
        public string WhoWasCalled => " called ";
        public string And => " and ";
        public string ThatEverything => " that everything ";
        public string Was => " is ";
        public string Dots => "...";
        public String Dot => ". ";
        public String Space => " ";
        public String Comma => ", ";
        public String NewLine => "\n";

        public Dictionary<string, string> Animals => new Dictionary<string, string>()
        {
            { "squirrel", "\U0001F43F" },
            {"hedgehog", "\U0001F994"},
            {"bat", "\U0001F987"},
            //{"skunk", "\U0001F9A8"}, // Todo: find better emoji
            //{"badger", "\U0001F9A1"}, // Todo: find better emoji
            {"dove", "\U0001F54A"},
            //{"eagle", "\U0001F985"},// Todo: needs an instead of a
            {"duck", "\U0001F986"},
            //{"swan", "\U0001F9A2"}, // Todo: find better emoji
            //{"peacock", "\U0001F99A"}, // Todo: find better emoji
            //{"parrot", "\U0001F99C"}, // Todo: find better emoji
            //{"owl", "\U0001F989"}, // Todo: needs an instead of a
            {"spider", "\U0001F577"},
            {"skorpion", "\U0001F982"},
            {"larva", "\U0001F41B"},
            {"snake", "\U0001F40D"},
            {"hamster", "\U0001F439"},
            {"turtle", "\U0001F422"},
            {"cat", "\U0001F431"},
            {"snail", "\U0001F40C"},
            {"frog", "\U0001F438"},
            {"ladybug", "\U0001F41E"},
            {"bird", "\U0001F426"},
            //{"ant", "\U0001F41C"}, // Todo: needs an instead of a
            {"shrew", "\U0001F42D"},
            {"chicken", "\U0001F425"},
            {"penguin", "\U0001F427"},
            {"koala", "\U0001F428"},
            //{"hen", "\U0001F414"}, // Todo: find better emoji
            {"monkey", "\U0001F412"},
            {"dog", "\U0001F436"},
            {"panda", "\U0001F43C"},
            {"rabbit", "\U0001F407"},
            {"rat", "\U0001F401"},
            {"goat", "\U0001F410"},
            {"honeybee", "\U0001F41D"},
            {"cricket", "\U0001F997"},
            {"butterfly", "\U0001F98B"},
        };

        public Dictionary<string, string> Places => new Dictionary<string, string>()
        {
            {"on their planet", "\U0001FA90" + ",their planet"}, // ToDo: Fix this emoji
            {"in their city", "\U0001F306" + ",the city"},
            {"in their country", "\U0001F304" + ",mountains from their country"},
            {"in their forest", "\U0001F333" + ",a tree in their forest"}
        };

        public Dictionary<string, string> Events => new Dictionary<string, string>()
        {
            {"wants to see a big party", "\U0001F382" + ",a cake"},
            {"wants to see a space ship", "\U0001F6F8" + ",a space ship"},
            {"wants to see a new car", "\U0001F698" + ",a car"},
            {"wants to see more candy", "\U0001F36C" + "\U0001F36D" + ",the candy"},
            {"wants to see a new school", "\U0001F3EB" + ",a school"},
            {"wants to see a castle", "\U0001F3F0" + ",a castle"},
            {"wants to see a dragon", "\U0001F409" + ",a dragon"},
            {"wants to see the rainbow", "\U0001F308" + ",a rainbow"}
        };

        public List<string> FairyTaleStarts => new List<string>()
        {
            "This is a",
        };

        public List<string> Relationships => new List<string>()
        {
            "friend",
        };

        public List<string> BadRelationships => new List<string>()
        {
            "enemy",
        };

        public List<string> CharacterAdjectives => new List<string>()
        {
            "happy",
            "nice",
            "funny",
            "smart",
            "popular",
        };

        public List<string> BadRelationshipsAdjectives => new List<string>()
        {
            "stupid",
        };

        public List<string> Verb1 => new List<string>()
        {
            "play",
        };

        public List<string> PlaceAdjectives => new List<string>()
        {
            "lovely",
            "good",
            "bad",
            "nice"
        };

        public List<string> Verb2 => new List<string>()
        {
            "like to",
        };

        public List<string> Circumstances => new List<string>()
        {
            "It can be " + StringReplacer.Place_Condition + " " + StringReplacer.Place + " in many different ways",
            "But it isn't " + StringReplacer.Place_Condition + " " + StringReplacer.Place + " today",
        };

        public List<string> Gender => new List<string>()
        {
            "He",
            "She"
        };

        public List<string> Actions => new List<string>()
        {
            StringReplacer.Character1_Name + " wants to see something new",
        };

        public List<string> Continuations => new List<string>()
        {
            "But",
        };
    }
}

