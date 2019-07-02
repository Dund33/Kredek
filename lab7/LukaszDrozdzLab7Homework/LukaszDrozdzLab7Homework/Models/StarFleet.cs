using LukaszDrozdzLab7Homework.Models.DTO;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using LukaszDrozdzLab7Homework.Models;

namespace LukaszDrozdzLab7Homework.Models
{
    public class StarFleet:DbContext
    { 
        public StarFleet(DbContextOptions<StarFleet> options) : base(options)
        {

        }

        /// <summary>
        /// Missons
        /// </summary>
        public DbSet<Mission> Missions { get; set; }

        /// <summary>
        /// Cruisers
        /// </summary>
        public DbSet<Cruiser> Cruisers { get; set; }

        /// <summary>
        /// Destroyers
        /// </summary>
        public DbSet<Destroyer> Destroyers { get; set; }

        /// <summary>
        /// Repairs
        /// </summary>
        public DbSet<CruiserRepair> Repairs { get; set; }

        //DTOS
        public DbSet<GetBasicCruiserDTO> GetBasicCruiserDTO { get; set; }
        public DbSet<GetFullCruiserDTO> GetFullCruiserDTO { get; set; }
        public DbSet<GetBasicDestroyerDTO> GetBasicDestroyerDTO { get; set; }
        public DbSet<GetFullDestroyerDTO> GetFullDestroyerDTO { get; set; }
        public DbSet<GetRepairDTO> GetRepairDTO { get; set; }
        public DbSet<DestroyerRepair> DestroyerRepair { get; set; }
    }
}
