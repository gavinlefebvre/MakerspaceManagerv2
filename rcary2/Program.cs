using Microsoft.EntityFrameworkCore;
using System;
using System.Text;

namespace mysqlefcore
{
  class Program
  {
    static void Main(string[] args)
    {
      InsertData();
      PrintData();
    }

    private static void InsertData()
    {
      using(var context = new ApplicationContext())
      {
        // Creates the database if not exists
        context.Database.EnsureCreated();

        // Adds a User
        var user = new User 
        {
          Username = "test_user",
          EmailAddress = "test@localhost"
        };
        context.Users.Add(user);

        // Adds a new PrintTracker
        context.PrintTrackers.Add(new PrintTracker
        {
          UserId = user.UserId,
          Description = "This is a test."
        }   
        );
        /* 

        // Adds a publisher
        var publisher = new Publisher
        {
          Name = "Mariner Books"
        };
        context.Publisher.Add(publisher);

        // Adds some books
        context.Book.Add(new Book
        {
          ISBN = "978-0544003415",
          Title = "The Lord of the Rings",
          Author = "J.R.R. Tolkien",
          Language = "English",
          Pages = 1216,
          Publisher = publisher
        });
        context.Book.Add(new Book
        {
          ISBN = "978-0547247762",
          Title = "The Sealed Letter",
          Author = "Emma Donoghue",
          Language = "English",
          Pages = 416,
          Publisher = publisher
        }); */

        // Saves changes
        context.SaveChanges();
      }
    }

    private static void PrintData()
    {
      // Gets and prints all books in database
      /*   using (var context = new LibraryContext())
      {
        var books = context.Book
          .Include(p => p.Publisher);
        foreach(var book in books)
        {
          var data = new StringBuilder();
          data.AppendLine($"ISBN: {book.ISBN}");
          data.AppendLine($"Title: {book.Title}");
          data.AppendLine($"Publisher: {book.Publisher.Name}");
          Console.WriteLine(data.ToString());
        }
      } */
      
      using (var context2 = new ApplicationContext())
      {
        var users = context2.Users
          .Include(u => u.PrintTrackers);
        foreach(var user in users)
        {
          var out_data = new StringBuilder();
          out_data.AppendLine($"Owner: {user.Username}");
          out_data.AppendLine($"OwnerId: {user.UserId.ToString()}");
          Console.WriteLine(out_data.ToString());
        }
        /* var trackers = context2.PrintTrackers
          .Include(p => p.UserId);
        foreach(var tracker in trackers)
        {
          var out_data = new StringBuilder();
          out_data.AppendLine($"Owner: {tracker.UserId}");
          out_data.AppendLine($"Job: {tracker.Description}");
          Console.WriteLine(out_data.ToString());
        } */
      }

    }
  }
}
