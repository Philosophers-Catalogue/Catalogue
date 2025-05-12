namespace Philosophers_Catalogue.Models.Abstract;

public interface IWikipediaItem
{
    public int? WikipediaId { get; set; }
    public string NameEn { get; set; }
}