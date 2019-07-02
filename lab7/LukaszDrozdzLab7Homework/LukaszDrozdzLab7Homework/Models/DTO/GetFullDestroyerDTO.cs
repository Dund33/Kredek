﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LukaszDrozdzLab7Homework.Models.DTO
{
    public class GetFullDestroyerDTO
    {
        public int ID { get; set; }
        public int Lasers { get; set; }
        public int BeamTrackers { get; set; }
        public float TWR { get; set; }
        public float Isp { get; set; }
        public float Thrust { get; set; }
        public float Weight { get; set; }
    }
}
