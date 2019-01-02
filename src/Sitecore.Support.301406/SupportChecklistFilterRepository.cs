using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Script.Serialization;

namespace Sitecore.Support.XA.Feature.Search.Repositories
{
  public class ChecklistFilterRepository: Sitecore.XA.Feature.Search.Repositories.ChecklistFilterRepository
  {
    protected override string JsonDataProperties
    {
      get
      {
        var obj = new
        {
          endpoint = HomeUrl + "/sxa/search/facets/",
          itemid = base.Context.Item.ID.ToString(),
          f = FacetItemName,
          showMoreText = ShowMoreText,
          showLessText = ShowLessText,
          otherText = OtherText,
          collapseOnSelection = CollapseOnSelection,
          highlightThreshold = HighlightThreshold,
          highlightBehaviour = HighlightBehaviour,
          multi = MultiSelection,
          emptyValueText = EmptyValueText,
          searchResultsSignature = SearchResultsSignature,
          sortOrder = Rendering.Parameters["SortOrder"]
        };
        return new JavaScriptSerializer().Serialize(obj);
      }
    }
  }
}