using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using OpenAPI.NBRB.Data.Contracts;
using OpenAPI.NBRB.Data.Entities;
using TinyCsvParser;

namespace OpenAPI.NBRB.Data.InMemory
{
    public class InMemoryBankRepository : IBankRepository
    {
        private readonly IEnumerable<Bank> _banks;

        private static readonly string _filePath = Path.Combine(
            Path.GetDirectoryName(Assembly.GetEntryAssembly().Location) ?? ".", "Files", "banks.csv");

        public InMemoryBankRepository()
        {
            CsvParserOptions csvParserOptions = new CsvParserOptions(true, ',');
            CsvBankMapping csvMapper = new CsvBankMapping();
            CsvParser<Bank> csvParser = new CsvParser<Bank>(csvParserOptions, csvMapper);

            var records = csvParser
                .ReadFromFile(_filePath, Encoding.UTF8);

            _banks = records.Select(x => x.Result).ToList();
        }

        public IEnumerable<Bank> GetAll()
        {
            return _banks;
        }
    }
}
