﻿using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace BloodBowl_Library
{
    [Serializable]
    public abstract class Invitation
    {
        private DateTime _date;
        private League _league;
        private Coach _invitor;
        private Guid _idLeague;
        private Guid _idInvitor;



        // CONSTRUCTORS

        /// <summary>
        /// Creates a default instance of an Invitation
        /// </summary>
        public Invitation()
        {
            date = DateTime.MinValue;
            league = new League();
            invitor = new Coach();
            idLeague = Guid.Empty;
            idInvitor = Guid.Empty;
        }


        /// <summary>
        /// Creates a new instance of an Invitation with according parameters
        /// </summary>
        /// <param name="league">League of the Invitation</param>
        /// <param name="invitor">Invitor of the Invitation</param>
        public Invitation(League league, Coach invitor)
        {
            date = DateTime.Now;
            this.league = league;
            this.invitor = invitor;
            idLeague = league.id;
            idInvitor = invitor.id;
        }


        /// <summary>
        /// Creates a complete instance of a JobAttribution with according parameters
        /// </summary>
        /// <param name="date">Date of the Invitation</param>
        /// <param name="league">League of the Invitation</param>
        /// <param name="invitor">Invitor of the Invitation</param>
        public Invitation(DateTime date, League league, Coach invitor)
        {
            this.date = date;
            this.league = league;
            this.invitor = invitor;
            idLeague = league.id;
            idInvitor = invitor.id;
        }




        // GETTER - SETTER
        public DateTime date { get => _date; set => _date = value; }
        [JsonIgnore]
        public League league {
            get => _league;
            set
            {
                _league = value;
                _idLeague = _league.id;
            }
        }
        [JsonIgnore]
        public Coach invitor
        {
            get => _invitor;
            set
            {
                _invitor = value;
                _idInvitor = _invitor.id;
            }
        }
        public Guid idLeague { get => _idLeague; set => _idLeague = value; }
        public Guid idInvitor { get => _idInvitor; set => _idInvitor = value; }
    }
}