using System.Text.Json;

public class LinqQueries
{
    private List<Book> librosCollection = new List<Book>();
    public LinqQueries()
    {
        using (StreamReader reader = new StreamReader("books.json"))
        {
            string json = reader.ReadToEnd();
            //Convertir objeto JSON a tipo List<Book>
            this.librosCollection = System.Text.Json.JsonSerializer.Deserialize<List<Book>>(json, new System.Text.Json.JsonSerializerOptions() { PropertyNameCaseInsensitive = true, ReadCommentHandling = JsonCommentHandling.Skip })!; //"!" para indicar nulo
        }
       
            
    }
    //Retornar toda la colección
    public IEnumerable<Book> TodaLaColeccion()
    {
        return librosCollection;
    }
    //Retornar libros publicados después del año 2000
    public IEnumerable<Book> LibrosDespuesdel2000()
    {
        //extension method
        //return librosCollection.Where(p=>p.PublishedDate.Year > 2000);

        //query expression
        return from l in librosCollection where l.PublishedDate.Year > 2000 select l; //"select l" señala que se tome todos los campos del objeto l (libros collection).

    }

    //Retornar libros que tengan más de 250 páginas y que incluyan la cadena "in Action".
    public IEnumerable<Book> Librosespecificos()
    {
        //extension method
        //return librosCollection.Where(p => p.PageCount > 250 && p.Title.Contains("in Action"));
        
        //query expression
        return from l in librosCollection where l.PageCount>250 && l.Title.Contains("in Action") select l;

    }
}   
    