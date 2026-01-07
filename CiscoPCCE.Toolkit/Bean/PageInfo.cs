using System.Xml.Serialization;

namespace CiscoPCCE.Toolkit.Bean
{





[XmlRoot("pageInfo")]
public class PageInfo : BaseApiBean {
  private string? firstPage;
  private string? lastPage;
  private string? nextPage;
  private string? prevPage;
  private int? resultsPerPage;
  private int? startIndex;
  private int? totalResults;

  public string? FirstPage
  {
      get => firstPage;
      set => firstPage = value;
  }


  public void setFirstPage(String firstPage) {
     this.firstPage = firstPage;
  }

  public string? LastPage
  {
      get => lastPage;
      set => lastPage = value;
  }


  public void setLastPage(String lastPage) {
     this.lastPage = lastPage;
  }

  public string? NextPage
  {
      get => nextPage;
      set => nextPage = value;
  }


  public void setNextPage(String nextPage) {
     this.nextPage = nextPage;
  }

  public string? PrevPage
  {
      get => prevPage;
      set => prevPage = value;
  }


  public void setPrevPage(String prevPage) {
     this.prevPage = prevPage;
  }

  public int? ResultsPerPage
  {
      get => resultsPerPage;
      set => resultsPerPage = value;
  }


  public void setResultsPerPage(int? resultsPerPage) {
     this.resultsPerPage = resultsPerPage;
  }

  public int? StartIndex
  {
      get => startIndex;
      set => startIndex = value;
  }


  public void setStartIndex(int? startIndex) {
     this.startIndex = startIndex;
  }

  public int? TotalResults
  {
      get => totalResults;
      set => totalResults = value;
  }


  public void setTotalResults(int? totalResults) {
     this.totalResults = totalResults;
  }


}

}