﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using Dapper;

namespace PPE___Gestion_de_formations
{
    public class Formation
    {
        public int ID { get; set; }
        public string Nom { get; set; }
        public List<Participant> Interesses { get; set;}

        public Formation(string nom)
        {
            Nom = nom;
        }
       
        public Formation(int id, string nom)
        {
            ID = id;
            Nom = nom;
        }
        

    }
}
