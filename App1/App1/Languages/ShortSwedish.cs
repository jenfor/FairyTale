﻿using System;
using System.Collections.Generic;
using System.Text;

namespace App1.Languages
{
    public class ShortSwedish : Language
    {
        public string BackToStart => "Tillbaka till start";
        public string ShareFairyTale => "Dela sagan";
        public string BackFairyTale => "Tillbaka";
        public string ContinueFairyTale => "Fortsätt";
        public string ViewFairyTale => "Visa/Dela sagan";
        public string NewImage => "Byt bild";

        public string Warning => "Varning";
        public string Question => "Fråga";
        public string Information => "Nu är det din tur";

        public string VersionOption => "Vilken sorts saga vill du skriva?";
        public string BackToStartPageWarning => "Vill du ta bort den här sagan och gå till startmenyn?";
        public string Deletion => "Vill du sagan sagan och skriva en ny?";

        public string Short => "En kort saga";
        public string Long => "En lång saga";

        public string Yes => "Ja";
        public string No => "Nej";

        public string TapHere => "Tryck här och skriv!";

        public string InformationExchangeString => "Nu är det din tur att skriva mer om "
            + StringReplacer.Character1_Name + " och "
            + StringReplacer.Character2_Name + "." + NewLine + NewLine
                    + "Tryck på sagotexten på den här sidan och börja skriv!";

        public string ExchangeString => "Tryck här och skriv om "
            + StringReplacer.Character1_Name + " och "
            + StringReplacer.Character2_Name + Dot;

        public string WasNamed => "som heter ";
        public string HadA => " har en ";
        public string A => "en ";
        public string WhoWasCalled => " som heter ";
        public string And =>  " och " ;
        public string ThatEverything => " att allt ";
        public string Was => " är ";
        public string Dots => "...";
        public String Dot => ". ";
        public String Space => " ";
        public String Comma => ", ";
        public String NewLine => "\n";

        public Dictionary<string, string> Animals => new Dictionary<string, string>()
        {
            { "ekorre", "\U0001F43F" },
            {"igelkott", "\U0001F994"},
            {"fladdermus", "\U0001F987"},
            //{"skunk", "\U0001F9A8"},
            //{"grävling", "\U0001F9A1"},
            {"duva", "\U0001F54A"},
            {"örn", "\U0001F985"},
            {"gräsand", "\U0001F986"},
            //{"svan", "\U0001F9A2"},
            {"påfågel", "\U0001F99A"},
            //{"papegoja", "\U0001F99C"},
            {"uggla", "\U0001F989"},
            {"spindel", "\U0001F577"},
            {"skorpion", "\U0001F982"},
            {"larv", "\U0001F41B"},
            {"orm", "\U0001F40D"},
            {"hamster", "\U0001F439"},
            {"sköldpadda", "\U0001F422"},
            {"katt", "\U0001F431"},
            {"snigel", "\U0001F40C"},
            {"groda", "\U0001F438"},
            {"nyckelpiga", "\U0001F41E"},
            {"fågel", "\U0001F426"},
            {"myra", "\U0001F41C"},
            {"näbbmus", "\U0001F42D"},
            {"kyckling", "\U0001F425"},
            {"pingvin", "\U0001F427"},
            {"koala", "\U0001F428"},
            //{"höna", "\U0001F414"},
            {"apa", "\U0001F412"},
            {"hund", "\U0001F436"},
            {"panda", "\U0001F43C"},
            {"kanin", "\U0001F407"},
            {"råtta", "\U0001F401"},
            {"get", "\U0001F410"},
            {"fjäril", "\U0001F98B"},
        };

        public Dictionary<string, string> Places => new Dictionary<string, string>()
        {
            {"i staden", "\U0001F306" + ",staden"},
            {"på landet", "\U0001F304" + ",en bild från landet"},
            {"i byn", "\U0001F3D8" + ",byn"},
            {"i skogen", "\U0001F333" + ",ett träd från skogen"}
        };

        public Dictionary<string, string> Events => new Dictionary<string, string>()
        {
            {"vill ha en fest", "\U0001F382" + ",en tårta" },
            {"vill ha en bil", "\U0001F698" + ",en bil"},
            {"vill ha ett hav", "\U0001F30A" + ",en våg"},
            {"vill ha godis", "\U0001F36C" + "\U0001F36D" + ",godiset"},
            {"vill ha en ny skola", "\U0001F3EB" + ",skolan"},
            {"vill ha ett slott", "\U0001F3F0" + ",ett slott"},
            {"vill ha en drake", "\U0001F409" + ",en drake"},
            {"vill ha en ny måne", "\U0001F314" + ",månen"},
            {"vill ha en regnbåge", "\U0001F308" + ",regnbågen"}
        };

        public List<string> FairyTaleStarts => new List<string>()
        {
             "Det här är en",
        };

        public List<string> Relationships => new List<string>()
        {
            "vän",
            "kompis"
        };

        public List<string> BadRelationships => new List<string>()
        {
            "ovän",
        };

        public List<string> CharacterAdjectives => new List<string>()
        {
            "glad",
            "fin",
            "bra",
            "söt",
            "smart",
        };

        public List<string> BadRelationshipsAdjectives => new List<string>()
        {
            "arg",
        };

        public List<string> Verb1 => new List<string>()
        {
            "leka",
        };

        public List<string> PlaceAdjectives => new List<string>()
        {
            "bra",
            "roligt",
            "fint",

        };

        public List<string> Verb2 => new List<string>()
        {
            "ska",

        };

        public List<string> Circumstances => new List<string>()
        {
            "Det kan vara " + StringReplacer.Place_Condition + " " + StringReplacer.Place + " på många sätt",
            "Men det är inte så " + StringReplacer.Place_Condition + " " + StringReplacer.Place + " idag",
        };

        public List<string> Gender => new List<string>()
        {
            "Hon",
            "Han"
        };

        public List<string> Actions => new List<string>()
        {
            StringReplacer.Character1_Name + " vill ha en sak",
        };

        public List<string> Continuations => new List<string>()
        {
            "Då vill",
            "Då kommer",
        };
    }
}

