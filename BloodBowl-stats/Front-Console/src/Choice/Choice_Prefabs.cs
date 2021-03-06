﻿using System.Collections.Generic;


namespace Front_Console
{
    public static class Choice_Prefabs
    {
        public static Choice CHOICE_CONNECTION = new Choice
       (
           "Please choose an action :",
           new List<string>()
           {
                "Log in",
                "Sign in",
                "Leave the Program"
           }
       );


        public static Choice CHOICE_CONNECTED = new Choice
       (
           "Please choose an action :",
           new List<string>()
           {
               "See my Data",
               "Manage my Leagues",
               "Create a new League",
               "Manage my Teams",
               "Create a new Team",
               "Log out"
           }
       );


        public static Choice CHOICE_TEAM = new Choice
       (
           "Please choose an action :",
           new List<string>()
           {
               "See Team's Data",
               "Manage Players",
               "Buy Player",
               "Go Back"
           }
       );

        public static Choice CHOICE_REMOVEPLAYER = new Choice
       (
           "Do you really want to remove this Player ?",
           new List<string>()
           {
               "Yes, remove the Player",
               "No, keep the Player"
           }
       );

        public static string CHOICE_TOPIC_JOIN = "Join the Topic";
        public static string CHOICE_TOPIC_LEAVE = "Leave the Topic";
        public static string CHOICE_TOPIC_GOBACK = "Go Back";
    }
}
