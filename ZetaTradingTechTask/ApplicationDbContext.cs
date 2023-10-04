using System;
using Microsoft.EntityFrameworkCore;
using ZetaTradingTechTask.Models;

namespace ZetaTradingTechTask
{
	public class ApplicationDbContext : DbContext
	{
		public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
        : base(options)
        {
		}

		public DbSet<JournalRecord> JournalRecords { get; set; }

		public DbSet<Node> Nodes { get; set; }


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<JournalRecord>().
                Ignore(h => h.Data)
                .HasKey(j => j.Id);

            modelBuilder.Entity<Node>()
                .HasKey(j => j.NodeId);

        }
    }
}

