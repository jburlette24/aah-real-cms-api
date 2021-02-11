using System;
using System.Collections.Generic;
using aah_real_cms_api.Domain.Models;
using Microsoft.AspNetCore.Builder;
using Microsoft.EntityFrameworkCore;
using Microsoft.JSInterop;

namespace aah_real_cms_api.Persistence.Contexts
{
    public class AppDbContext : DbContext
    {
        public DbSet<Author> Authors { get; set; }
        public DbSet<Post> Posts { get; set; }

        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);

            builder.Entity<Author>().ToTable("Authors");
            builder.Entity<Author>().HasKey(p => p.Id);
            builder.Entity<Author>().Property(p => p.Name).IsRequired();
            builder.Entity<Author>().Property(p => p.Surname).IsRequired();
            builder.Entity<Author>().Property(p => p.BioBlurb);

            builder.Entity<Author>().HasData
            (
                new Author { Id = 100, Name = "Jim", Surname = "Burlette", BioBlurb = "He was born upon the shores of the Connecticut..." }
            );

            builder.Entity<Post>().ToTable("Posts");
            builder.Entity<Post>().HasKey(p => p.Id);
            builder.Entity<Post>().Property(p => p.PublicationDate);
            builder.Entity<Post>().Property(p => p.Title).IsRequired().HasMaxLength(50);
            builder.Entity<Post>().Property(p => p.Text);

            builder.Entity<Post>().HasData
            (
                new Post {Id = 100, PublicationDate = DateTime.Parse("05/22/1987"), AuthorId = 100, Title = "First Post", Text = "This post is the real deal."}
            );
        }
    }
}

