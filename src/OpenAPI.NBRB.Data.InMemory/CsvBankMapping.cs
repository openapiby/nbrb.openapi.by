using OpenAPI.NBRB.Data.Entities;
using TinyCsvParser.Mapping;

namespace OpenAPI.NBRB.Data.InMemory
{
    public class CsvBankMapping : CsvMapping<Bank>
    {
        public CsvBankMapping()
        {
            MapProperty(0, x => x.BIC);
            MapProperty(1, x => x.IsActive);
            MapProperty(2, x => x.Name);
            MapProperty(3, x => x.City);
            MapProperty(4, x => x.Address);
            MapProperty(5, x => x.Phone);
        }
    }
}
