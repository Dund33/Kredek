using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using LukaszDrozdzLab7.Models.DTO;

namespace LukaszDrozdzLab7.Models
{
    public class SkiJumpingContest : DbContext
    {
        public SkiJumpingContest(DbContextOptions<SkiJumpingContest> options):base(options)
        {

        }

        public DbSet<Jumper> Jumpers { get; set; }
        public DbSet<Country> Countries { get; set; }
        public DbSet<GetStatisticJumperDTO> GetStatisticJumperDTO { get; set; }
    }
}
