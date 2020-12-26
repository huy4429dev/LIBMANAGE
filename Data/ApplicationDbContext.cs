using System;
using LibManage.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Logging.Console;

namespace LibManage.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {

        }


        public static readonly ILoggerFactory _loggerFactory = LoggerFactory.Create(builder =>
          {
              builder.AddConsole();
          });

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);

            // ================ user - role  | n - n 

            builder.Entity<UserRole>()
          .HasKey(e => new { e.UserId, e.RoleId });  // add primary key for table UserRoles

            builder.Entity<UserRole>()
                .HasOne(ta => ta.User)
                .WithMany(t => t.UserRoles)
                .OnDelete(DeleteBehavior.Cascade);


            builder.Entity<UserRole>()              // add relation  
                .HasOne(ta => ta.Role)
                .WithMany(t => t.UserRoles)
                .OnDelete(DeleteBehavior.Cascade);

            // ================ role - claim  | n - n 


            builder.Entity<RoleClaim>()
          .HasKey(e => new { e.RoleId, e.ClaimId });


            builder.Entity<RoleClaim>()
                .HasOne(ta => ta.Claim)
                .WithMany(t => t.RoleClaims)
                .OnDelete(DeleteBehavior.Cascade);


            builder.Entity<RoleClaim>()
                .HasOne(ta => ta.Role)
                .WithMany(t => t.RoleClaims)
                .OnDelete(DeleteBehavior.Cascade);

            // book tag 

            builder.Entity<BookTag>()
          .HasKey(e => new { e.BookId, e.TagId });  // add primary key for table UserRoles

            builder.Entity<BookTag>()
                .HasOne(ta => ta.Book)
                .WithMany(t => t.BookTags)
                .OnDelete(DeleteBehavior.Cascade);


            builder.Entity<BookTag>()              // add relation  
                .HasOne(ta => ta.Tag)
                .WithMany(t => t.BookTags)
                .OnDelete(DeleteBehavior.Cascade);

        }


        // User 

        public DbSet<User> Users { get; set; }
        public DbSet<Role> Roles { get; set; }
        public DbSet<UserRole> UserRoles { get; set; }
        public DbSet<Claim> Claims { get; set; }
        public DbSet<RoleClaim> RoleClaim { get; set; }
        public DbSet<Book> Books { get; set; }
        public DbSet<BookType> BookTypes { get; set; }
        public DbSet<Author> Authors { get; set; }
        public DbSet<Publisher> Publishers { get; set; }
        public DbSet<Order> Orders { get; set; }
        public DbSet<OrderDetail> OrderDetails { get; set; }
        public DbSet<Contact> Contacts { get; set; }
        public DbSet<Post> Posts { get; set; }
        public DbSet<Tag> Tags { get; set; }
        public DbSet<BookTag> BookTags { get; set; }
    }
}
