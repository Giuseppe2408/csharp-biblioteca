
// See https://aka.ms/new-console-template for more information






//CLASSE DI BOOK CREATA PER GESTIRE IL NUMERO DI PAGINA CHE EREDITA I DATI DI DOCUMENT
using static System.Collections.Specialized.BitVector32;

public class Book : Document
{
    public string IsbnCode { get; set; }
    public int NumberPage { get; set; }

    public Book(string titolo, int year, string section, string nameaut, string surnameaut, string isbnCode, int numberPage) : base(titolo, year, section, nameaut, surnameaut)   
    {
        IsbnCode = isbnCode;
        NumberPage = numberPage;
    }
}
