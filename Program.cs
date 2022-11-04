
// See https://aka.ms/new-console-template for more information


using System.Reflection.Metadata.Ecma335;
using System.Security.Cryptography.X509Certificates;

Console.WriteLine("Buongiorno bibliotecario");
Console.WriteLine("vuoi cercare un libro? inserisci il codice o il titolo");

string findBook = Console.ReadLine();

Book book1 = new Book("titolo", 1789, "matematica", "auth", "surnameauth", "fhhfhffhufhf33", 70);

List<Document> documentList = new List<Document>();

documentList.Add(book1);

foreach (Book book in documentList)
{
    if (book.IsbnCode == findBook || book.Title == findBook)
    {
        Console.WriteLine("trovato il libro {0}", book.ToString());
    }
}

//Parte user

User user1 = new User("giuseppe", "acito", "email@mgm.it", "543336546554");

List<User> userList = new List<User>();

userList.Add(user1);

Console.WriteLine("l'utente vuole effettuare un prestito?");
string prestito = Console.ReadLine();

if (prestito == "si")
{
    Console.WriteLine("chi utente vuole effettuarlo?");
    string userPrestito = Console.ReadLine();
    foreach (User user in userList)
    {
        if (user.Name == userPrestito)
        {
            Console.WriteLine("utente registrato può fare il prestito");
        }
    }

}











