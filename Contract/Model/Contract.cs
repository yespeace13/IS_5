﻿using IS_5.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IS_5
{
    public class Contract
    {
        public int Id { get; set; }
        public string Number { get; set; }
        public DateTime DateOfConclusion { get; set; }
        public DateTime DateValidation { get; set; }
        public Organization Executor { get; set; }
        public Organization Client { get; set; }
        public List<Localityprice> Localitysprices { get; set; }
        public List<Scan> Scans { get; set; } 
        public List<Act> Acts { get; set; }
        public Contract(int id, string number, DateTime dateOfCon, DateTime dateValid, 
            Organization executor, Organization client, List<Localityprice> localityprices, List<Scan> scans)
        {
            Id = id;
            Number = number;
            DateOfConclusion = dateOfCon;
            DateValidation = dateValid;
            Executor = executor;
            Client = client;
            Localitysprices = localityprices;
            Scans = scans;
            Acts = new List<Act>();
        }
    }
}
