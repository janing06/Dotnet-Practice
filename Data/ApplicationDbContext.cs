using Microsoft.EntityFrameworkCore;
using BookList.Model;

namespace BookList.Data;

public class ApplicationDbContext : DbContext{

    public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options): base(options){
        
    }

    public DbSet<Book> Book {get; set;}
}