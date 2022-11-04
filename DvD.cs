
// See https://aka.ms/new-console-template for more information



//CLASSE DI DVD CREATA PER GESTIRE LA DURATA CHE EREDITA I DATI DI DOCUMENT MA NON DI BOOK
public class DvD : Document
{
    public string SerialNumber { get; set; } //messo stringa perchè è alfanum sia lettere che num
    public int Duration { get; set; }

}
