using System.Collections.Generic;
using AutoMapper;
using Moq;
using OpenAPI.NBRB.Data.Contracts;
using OpenAPI.NBRB.Data.Entities;
using OpenAPI.NBRB.Domain.Contracts.ViewModels;

namespace OpenAPI.NBRB.Tests.Services
{
    public class BankMock
    {
        public Dictionary<string, Bank> BankDb;

        public BankMock()
        {
            SetBankDb();
        }

        public void SetBankDb()
        {
            BankDb = new Dictionary<string, Bank>
            {
                {
                    "PJCBBY2X",
                    new Bank
                    {
                        BIC = "PJCBBY2X",
                        IsActive = true,
                        Name = "ОАО \"Приорбанк\"",
                        City = "Минск",
                        Address = "220002, г.Минск, ул.Веры Хоружей, 31А",
                        Phone = "+375 (17) 289-90-90",
                    }
                },
                {
                    "OLMPBY2X",
                    new Bank
                    {
                        BIC = "OLMPBY2X",
                        IsActive = true,
                        Name = "ОАО \"Белгазпромбанк\"",
                        City = "Минск",
                        Address = "220121, г. Минск, ул. Притыцкого, 60/2",
                        Phone = "120",
                    }
                },
                {
                    "ALFABY2X",
                    new Bank
                    {
                        BIC = "ALFABY2X",
                        IsActive = true,
                        Name = "ЗАО \"Альфа – банк\"",
                        City = "Минск",
                        Address = "220013, г. Минск, ул. Сурганова, 43",
                        Phone = "+375 (44) 733-33-32",
                    }
                },
            };
        }

        public IBankRepository GetBankRepository()
        {
            var bankRepositoryMock = new Mock<IBankRepository>();

            bankRepositoryMock
                .Setup(m => m.GetAll())
                .Returns(() => BankDb.Values);

            return bankRepositoryMock.Object;
        }

        public IMapper GetMapper()
        {
            var mapperMock = new Mock<IMapper>();

            mapperMock
                .Setup(x => x.Map<BankViewModel>(It.IsAny<Bank>()))
                .Returns(new BankViewModel());

            mapperMock
                .Setup(x => x.Map<IEnumerable<BankViewModel>>(It.IsAny<IEnumerable<Bank>>()))
                .Returns(new List<BankViewModel>());

            return mapperMock.Object;
        }
    }
}
