using System.Collections.Generic;
using tcc_back.Models;

namespace tcc_back.Repositories
{
    public interface ICoberturaRepository
    {
        IEnumerable<string> GetCities(string uf);
        string GetCityCode(string uf, string city);
        IEnumerable<Cobertura> GetAreas(string uf, string city);
        IEnumerable<CoveragePercentage> GetCityAvgPercentualCobertura(string uf, string city);
        IEnumerable<CoveragePercentage> GetAreasAvgPercentualCobertura(IEnumerable<string> selectedAreas);
        double GetTotalAccessFor(string uf, string city, string company);
        double GetTotalClaimedIssuesFor(string uf, string city, string company);
        (decimal? price, int? gigabytes) GetPlanForMobileOperator(string uf, string city, string company);
    }

}