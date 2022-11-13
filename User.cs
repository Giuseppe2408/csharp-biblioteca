
// See https://aka.ms/new-console-template for more information




//CLASSE USER PER SALVARE I DATI
public class User
{
    public string Name { get; set; }

    public string Surname { get; set; }

    public string Email { get; set; }

    public string PhoneNumber { get; set; }

    public List<Prestito> DocumentiInPrestito { get; set; }

    public User (string name, string surname, string email, string phoneNumber)
    {
        Name = name;
        Surname = surname;
        Email = email;
        PhoneNumber = phoneNumber;
        DocumentiInPrestito = new List<Prestito>();
    }

    public void AggiungiPrestito(Prestito prestito)
    {
        DocumentiInPrestito.Add(prestito);
    }
}