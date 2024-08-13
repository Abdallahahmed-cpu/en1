using ConsoleApp1;
using Microsoft.EntityFrameworkCore;

internal class Program
{
    public static void Main(string[] args)
    {
        //1
        //    var booksWithAuthors = LibraryContext.Books
        //.Select(b => new
        //{
        //    b.Title,
        //    Authors = b.BookAuthors
        //               .Select(ba => ba.Author.Name)
        //               .ToList()
        //})
        //.ToList();


        //2

        //var membersWithBorrowedBooks = LibraryContext.members
        //                              .Select(m => new
        //                              {
        //                                  m.Name,
        //                                  BorrowedBooks = m.Borrows
        //                                                  .Select(b => b.Book.Title)
        //                                                  .ToList()
        //                              })
        //                              .ToList();


        //3


        //var totalBooksBorrowedByMember = LibraryContext.Members
        //                                .Select(m => new
        //                                {
        //                                    m.Name,
        //                                    TotalBooksBorrowed = m.Borrows.Count()
        //                                })
        //                                .ToList();

        //4


        //int year = 2010; 
        //var booksPublishedAfterYear = LibraryContext.Books
        //                                     .Where(b => b.PublicationYear > year)
        //                                     .Select(b => new { b.Title, b.PublicationYear })
        //.ToList();

        //5
        //var authorsWithBooks = LibraryContext.Authors
        //                      .Select(a => new
        //                      {
        //                          a.Name,
        //                          BooksWritten = a.BookAuthors
        //                                          .Select(ba => ba.Book.Title)
        //                                          .ToList()
        //                      })
        //                      .ToList();


        //6

        //var booksNotBorrowed = LibraryContext.Books
        //                      .Where(b => !b.Borrows.Any())
        //                      .Select(b => new { b.Title, b.ISBN })
        //                      .ToList();

    }
}