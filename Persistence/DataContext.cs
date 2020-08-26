using Domain;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace Persistence {
    public class DataContext : IdentityDbContext<AppUser> {
        public DataContext (DbContextOptions options) : base (options) { }

        public DbSet<Book> Books { get; set; }
        public DbSet<UserBook> UserBooks { get; set; }

        // protected override void OnModelCreating (ModelBuilder builder) {
        //     base.OnModelCreating (builder);

        //     builder.Entity<UserBook> (x => x.HasKey (ua =>
        //         new { ua.AppUserId, ua.BookId }));

        //     builder.Entity<UserBook> ()
        //         .HasOne (u => u.AppUser)
        //         .WithMany (a => a.UserActivities)
        //         .HasForeignKey (u => u.AppUserId);

        //     builder.Entity<UserBook> ()
        //         .HasOne (a => a.Book)
        //         .WithMany (u => u.UserActivities)
        //         .HasForeignKey (a => a.BookId);
        // }
    }
}