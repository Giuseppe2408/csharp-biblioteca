
// See https://aka.ms/new-console-template for more information


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

Console.WriteLine("l'utente vuole effettuare un prestito?");


User user1 = new User("giuseppe", "acito", "email@mgm.it", "543336546554");

List<User> userList = new List<User>();

userList.Add(user1);

foreach (User user in userList)
{

}






