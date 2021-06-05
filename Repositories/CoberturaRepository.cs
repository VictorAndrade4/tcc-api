using System.Data;
using System.Collections.Generic;
using tcc_back.Models;
using Dapper;

namespace tcc_back.Repositories
{
    public class CoberturaRepository : ICoberturaRepository
    {
        private readonly IDbConnection _dbConnection;

        public CoberturaRepository(IDbConnection dbConnection)
        {
            _dbConnection = dbConnection;
        }
        public IEnumerable<string> GetCities(string uf)
        {
            const string sql = @"SELECT DISTINCT MUNICIPIO FROM cobertura WHERE UF = (@UF) ORDER BY MUNICIPIO";
            return _dbConnection.Query<string>(sql, new { UF = uf });
        }
    }

}