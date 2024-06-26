﻿using Lucene.Net.Documents;

namespace XiaWiki.Infrastructure.Search;

internal abstract class DocBase<T> where T : DocBase<T>
{
    public DocBase(string id)
    {
        Id = id;
    }

    public DocBase(Document luceneDoc)
    {
        Id = luceneDoc.Get(nameof(Id));
    }

    public string Id { get; set; }

    public virtual Document ToLuceneDoc()
    {
        return [
            new StringField(nameof(Id), Id, Field.Store.YES),
        ];
    }
}
