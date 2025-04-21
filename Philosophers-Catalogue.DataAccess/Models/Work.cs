using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using NodaTime;
using NpgsqlTypes;

namespace Philosophers_Catalogue.DataAccess.Models;

public class Work
{
    public Guid Id { get; set; }

    [Column("varchar(128)")]
    public required string Title { get; set; }

    [Column(TypeName = "text")]
    public string? Description { get; set; }

    public int? PublicationYear { get; set; }
    public long? PrimaryAuthorId { get; set; }
    public Uri? ExternalUrl { get; set; }
    public required NpgsqlTsVector Embeddings { get; set; } 

    public Instant CreatedAt { get; set; }
    public Instant UpdatedAt { get; set; }

    [Column(TypeName = "varchar(100)")]
    public WorkTypes Type { get; set; }

    [ForeignKey(nameof(PrimaryAuthorId))]
    public virtual Philosopher? PrimaryAuthor { get; set; }

    public virtual ICollection<Philosopher> AdditionalAuthors { get; set; } = new List<Philosopher>();
    public virtual ICollection<ItemBranch> Branches { get; set; } = new List<ItemBranch>();
    public virtual ICollection<ItemCategorySchool> CategoriesSchools { get; set; } = new List<ItemCategorySchool>();
    public virtual ICollection<ItemNotion> Notions { get; set; } = new List<ItemNotion>();
}