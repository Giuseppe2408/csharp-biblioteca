
// See https://aka.ms/new-console-template for more information


using System.Reflection.Metadata.Ecma335;
using System.Security.Cryptography.X509Certificates;
using System.Text.Json;

Console.WriteLine("Buongiorno bibliotecario");
Console.WriteLine("vuoi cercare un libro? inserisci il codice o il titolo");

string findBook = Console.ReadLine();

Book book1 = new Book("titolo", 1789, "matematica", "auth", "surnameauth", "fhhfhffhufhf33", 70);
Book book2 = new Book("titolo2", 1765, "matematica", "auth", "surnameauth", "codice2", 70);

List<Document> documentList = new List<Document>();

documentList.Add(book1);
documentList.Add(book2);

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
string doPrestito = Console.ReadLine();

if (doPrestito == "si")
{
    Console.WriteLine("chi utente vuole effettuarlo?");
    string userPrestito = Console.ReadLine();
    foreach (User user in userList)
    {
        if (user.Name == userPrestito)
        {
            Console.WriteLine("utente registrato può fare il prestito");
            Console.WriteLine();
            Console.WriteLine("inserisci il documento di cui vuoi fare il prestito");
            string libroPrestito = Console.ReadLine();
            
            foreach (Document documento in documentList)
            {
                if (documento.Title != libroPrestito)
                {
                    Console.WriteLine("il libro non esiste");
                }
                else
                {
                    Prestito prestito = new Prestito("20/10/2022", "23/11/2023");
                    user.AggiungiPrestito(prestito);
                }
        }
        }
        else
        {
            Console.WriteLine("utente non registrato");
        }
    }

}

Console.WriteLine();
Console.WriteLine("Vuoi controllare i tuoi attuali libri in prestito?");
string controlloPrestito = Console.ReadLine();

if (controlloPrestito == "si") 
{
    Console.WriteLine("di quale utente vuoi vedere i prestiti?");
    string nomeUtente = Console.ReadLine();
    foreach (User user in userList)
    {
        if (nomeUtente == user.Name)
        {
            
            foreach (Prestito prestito in user.DocumentiInPrestito)
            {
                Console.Write("l' utente " + user.Name + " ");
                Console.WriteLine("ha effettuato questi prestiti " + prestito);
            }
        }
    }
    

}









