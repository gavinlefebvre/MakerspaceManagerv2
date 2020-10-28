using System;
using System.Collections.Generic;
using System.Text;

using Microsoft.EntityFrameworkCore;

namespace mysqlefcore
{
  public class ApplicationContext : DbContext
  {
      public DbSet<User> Users { get; set; }

      public DbSet<PrintTracker> PrintTrackers { get; set; }

      //public DbSet<MachineTask> MachineTasks { get; set; }

      //public DbSet<TaskDoc> TaskDocs { get; set; }

      protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
      {
        //Make safer on 'real' app
        //e.g.: https://docs.microsoft.com/en-us/aspnet/core/security/app-secrets?view=aspnetcore-3.1&tabs=windows#secret-manager
        optionsBuilder.UseMySQL("server=localhost;database=MakerspaceDB;user=mkadmin;password=ThisMakerPassword.2020");
      }
    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
      base.OnModelCreating(modelBuilder);


      modelBuilder.Entity<User>()
        .HasMany<PrintTracker>(e => e.PrintTrackers);
        
      modelBuilder.Entity<PrintTracker>()
        .HasOne(p => p.JobOwner)
        .WithMany(u => u.PrintTrackers);

      modelBuilder.Entity<MachineTask>()
        .HasOne(m => m.TrackerOwner)
        .WithMany(p => p.MachineTasks);

      modelBuilder.Entity<TaskDoc>()
        .HasOne(t => t.MachineTaskOwner)
        .WithOne(m => m.OwnedTaskDoc);

      modelBuilder.Entity<CompletionDoc>()
        .HasOne(c => c.CompletionDocOwner)
        .WithOne(t => t.TaskCompletionDoc);
        //.HasForeignKey(c => c.TaskDocId);

      modelBuilder.Entity<RequestGroup>()
        .HasMany(e => e.RequestUsers)
        .WithOne(r => r.UserRequestGroup);

      modelBuilder.Entity<Machine>()
        .HasMany(m => m.AssignedTasks)
        .WithOne(t => t.AssignedMachine);

      //modelBuilder.Entity<PrintMaterial>()
      //  .Ignore();
        //.HasMany(p => p.TrackerUsedMaterials);
        //.WithOne(m => m.JobPrintMaterials);
        //.HasMany(p => p.CompatMachines)
        //.WithMany(p => p.TaskUsedMaterials)

      

/*       modelBuilder.Entity<User>(entity =>
      {
        //entity.HasKey(e => e.UserId).HasName("PK_UserId");
        entity.HasKey(e => e.UserId);
        entity.Property(e => e.Username).IsRequired();
        entity.Property(e => e.EmailAddress).IsRequired();
        entity.HasMany<PrintTracker>(d => d.PrintTrackers)
          .WithOne(d => d.UserId);
      }
      ); */




      //modelBuilder.Entity<PrintTracker>()  
      //  .HasKey(u = u.PrintTrackerId);

/*       modelBuilder.Entity<PrintTracker>(entity =>
      {
        entity.HasKey(e => e.JobId);
        //entity.HasOne<User>(e => e.UserId);
        //entity.HasMany<MachineTask>(p => p.MachineTasks);
        //  .HasForeignKey(p => p.TrackerForeignKey);
        //  .WithOne(m => m.TrackerOwner);
      }
      ); */

      /* modelBuilder.Entity<MachineTask>(entity =>
      {
        entity.HasKey(e => e.MachineTaskId);
        entity.HasOne<TaskDoc>(m => m.OwnedTaskDoc);
        //  .WithOne(m => m.TaskOwner);
        entity.HasOne<User>(m => m.SlicedBy);
        entity.HasOne<User>(m => m.LoadedBy);
        entity.HasOne<User>(m => m.RemovedBy);
      }
      );

      modelBuilder.Entity<TaskDoc>(entity =>
      {
        entity.HasKey(e => e.TaskDocId);
        entity.HasOne(e => e.TaskOwner)
          .WithOne(t => t.OwnedTaskDoc);
          //.HasForeignKey<MachineTask>(); //Need to define one-to-one with dependent
        entity.HasOne<CompletionDoc>(t => t.TaskCompletionDoc);
      }
      );

      modelBuilder.Entity<CompletionDoc>(entity =>
      {
        entity.HasKey(e => e.CompletionDocId);
      }
      ); */
    }

  }


}