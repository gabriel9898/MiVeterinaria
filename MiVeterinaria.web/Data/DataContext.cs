using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using MiVeterinaria.web.Data.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MiVeterinaria.web.Data
{
    public class DataContext : IdentityDbContext<User>

    {
        public DataContext(DbContextOptions<DataContext> options) : base(options)
        {
            //DbContextOptions crea una bd q se llamara options
        }

        //MATRICULACION de las tablas
        public DbSet<Owner> Owners { get; set; }

        public DbSet<PetType> PetTypes { get; set; }

        public DbSet<Pet> Pets { get; set; }

        public DbSet<ServiceType> ServiceTypes { get; set; }

        public DbSet<History> Histories { get; set; }

        public DbSet<Agenda> Agendas { get; set; }

        public DbSet<Manager> Managers { get; set; }
    }
}

