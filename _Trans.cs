﻿using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;

namespace Bot.Translations
{
    /// <summary>
    /// Do not edit this file!
    /// </summary>
    public enum _Language
    {
        English, French, Spanish, Russian, Portuguese, German, Dutch, Italian, Hungarian, Polish, Indonesian
    }
    public class _Trans
    {
        public TError Error;
        public class TError
        {
            public string NoEmbedPerms;
            public string AdminOnly;
            public string PlayerNotFound;
            public string ApiError;
            public string EnterIP;
            public string InvalidIP;
            public string Cooldown;
            public string EnableQuery;
            public string ListNoServers;
            public string UnknownArg;
            public string TextLimit;
            public string RequireAttachFiles;
            public string UnknownWiki;
        }

        public TMain Main;
        public class TMain
        {
            public List<string> Commands;
            public string HelpFooter;
            public string MultiMC;
            public string PleaseWait;
            public string ServerAdminUse;
            public string StoleSkin;
            public string NameOnlyOne;
            public string PlayingMinecraft;
            public string Hi;
            public string BotDesc;
            public string First;
        }

        public THidden Hidden;
        public class THidden
        {
            public string FoundHiddenCommand;
            public string Herobrine;
            public string Notch;
        }

        public TWiki Wiki;
        public class TWiki
        {
            public string Blocks;
            public string Unknown;
            public string Player;
            public string Players;
            public string Attack;
            public string Easy;
            public string Hard;
            public string Health;
            public string Height;
            public string Width;
        }

        public TProfile Profile;
        public class TProfile
        {
            public string Badges;
            public string BadgeInfo;
            public string SetMCName;
            public string InvalidUserID;
            public string UnknownUser;
            public string NotInServer;
        }

        public TAdmin Admin;
        public class TAdmin
        {
            public List<string> Commands;
            public string WantTranslation;
            public string ChangeLang;
            public string UseList;
            public string AddServer;
            public string AddServerAdded;
            public string AddServerAlready;
            public string DelServerEnter;
            public string DelServerNone;
            public string DelServerDeleted;
            public string PrefixReset;
            public string LanguageSet;
        }

        /// <summary>
        /// Check for missing translations
        /// </summary>
        public void Check(_Language _Language)
        {
            foreach (JProperty property in JObject.FromObject(this).Properties())
            {
                if (string.IsNullOrEmpty(property.Value.ToString()))
                    Console.WriteLine($"NULL {_Language.ToString()}.{property.Name}");
                else if (property.HasValues)
                {
                    foreach (JProperty p in property.Value)
                    {
                        if (string.IsNullOrEmpty(p.Value.ToString()))
                            Console.WriteLine($"NULL {_Language.ToString()}.{property.Name}.{p.Name}");
                    }
                }
            }
            _Config.Translate.Add(_Language, this);
        }
    }
}
