﻿using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Diagnostics.CodeAnalysis;
using JetBrains.Annotations;
using NodaTime;
using NpgsqlTypes;
using Philosophers_Catalogue.Models.Abstract;
using Philosophers_Catalogue.Models.Enums;

namespace Philosophers_Catalogue.Models;

[PublicAPI]
public class Work : IWikipediaItem
{
    public Guid Id { get; set; }

    public int? WikipediaId { get; set; }

    [MaxLength(128)]
    public required string NameEn { get; set; }

    [MaxLength(128)]
    public required string NameRu { get; set; }

    [Column(TypeName = "text")]
    [SuppressMessage("ReSharper", "EntityFramework.ModelValidation.UnlimitedStringLength")]
    public string? DescriptionEn { get; set; }

    [Column(TypeName = "text")]
    [SuppressMessage("ReSharper", "EntityFramework.ModelValidation.UnlimitedStringLength")]
    public string? DescriptionRu { get; set; }

    public int? PublicationYear { get; set; }
    public Guid? PrimaryAuthorId { get; set; }
    public Uri? ExternalUrl { get; set; }
    public NpgsqlTsVector Embeddings { get; set; } = null!;

    public Instant CreatedAt { get; set; }
    public Instant UpdatedAt { get; set; }
    
    public WorkTypes Type { get; set; }

    [ForeignKey(nameof(PrimaryAuthorId))]
    public Philosopher? PrimaryAuthor { get; set; }

    public ICollection<CategorySchool> CategoriesSchools { get; set; } = null!;
    public ICollection<Notion> Notions { get; set; } = null!;
}