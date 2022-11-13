
// See https://aka.ms/new-console-template for more information


//CLASSE DI TUTTI I DOCUMENTI CON I DATI IN COMUNE FRA DVD E BOOK
public class Document
{
    public string Title { get; set; }

    protected int Year { get; set; }

    protected string Section { get; set; }

    public int Rack { get; set; }   

    public string NameAuthor { get; set; }  

    public string SurnameAuthor { get; set; }   

    public bool InPrestito { get; set; }

    


    public Document ()
    {
        
    }



    public Document(string title, int year, string section, string nameaut, string surnameaut) {
        
        Title = title;
        Year = year;
        Section = section;
        NameAuthor = nameaut;
        SurnameAuthor = surnameaut;
        InPrestito = false;  
    }

    public override string ToString()
    {
        return Title;
    }

    public bool Prestito(int num)
    {
        if (num == 0) { 
            return false;
        }

        return true;
        
    }

    
}
