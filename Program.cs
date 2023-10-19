LinqQueries linqQueries = new LinqQueries();

//Reto 0) Imprimir toda la colección
//ImprimirValores(linqQueries.TodaLaColeccion());

//Reto 1) Imprimir registros con libros publicados después del año 2000
//ImprimirValores(linqQueries.LibrosDespuesdel2000());

//Reto 2) Imprimir registros con libros con más de 250 pag. y que en su título contengan "in Action"
ImprimirValores(linqQueries.Librosespecificos());

void ImprimirValores(IEnumerable<Book> listadelibros)
{   
    // {value1, value2}: value1 indica el nro de columna. value2 indica el nro de caracteres que abarcará el valor de la columna.
    Console.WriteLine("{0,-60} {1,15} {2,15} \n", "Titulo", "N. Paginas", "Fecha publicacion"); 
    foreach (var item in listadelibros)
    {
        Console.WriteLine("{0,-60} {1,15} {2,15}", item.Title,item.PageCount,item.PublishedDate.ToShortDateString());
    }
}