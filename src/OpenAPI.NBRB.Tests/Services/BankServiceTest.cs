using System;
using System.Collections.Generic;
using AutoMapper;
using Moq;
using OpenAPI.NBRB.Data.Contracts;
using OpenAPI.NBRB.Data.Entities;
using OpenAPI.NBRB.Domain.Contracts;
using OpenAPI.NBRB.Domain.Contracts.ViewModels;
using OpenAPI.NBRB.Domain.Services;
using OpenAPI.NBRB.Tests.Services;
using Xunit;

namespace OpenAPI.NBRB.Tests
{
    public class BankServiceTest
    {
        private readonly BankMock _bankMock;

        private readonly IBankService _bankService;

        public BankServiceTest()
        {
            _bankMock = new BankMock();

            _bankService = new BankService(
                _bankMock.GetBankRepository(),
                _bankMock.GetMapper());
        }

        [Fact]
        public void GetAllBanks_not_null()
        {
            // Arange

            // Act
            var news = _bankService.GetBanksAsync().Result;

            // Assert
            Assert.NotNull(news);
        }
    }
}
