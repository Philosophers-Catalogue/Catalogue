namespace Philosophers_Catalogue.DataAccess.Models;

[Flags]
public enum WorkTypes
{
    None = 0,
    Interview = 1,
    Essay = 2, 
    Lecture = 4,
    Book = 8,
    Collection = 16,
    Treatise = 32,
    Quotes = 64
}