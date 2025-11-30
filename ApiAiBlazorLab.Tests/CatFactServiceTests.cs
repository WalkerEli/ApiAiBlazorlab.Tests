using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ApiAiBlazorLab.Services;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Xunit;


namespace ApiAiBlazorLab.Tests
{
    public class CatFactServiceTests

    {

        [Fact]

        public async Task GetRandomFact_ReturnsFact()

        {

            var json = "{\"fact\":\"Cats sleep 16 hours a day.\",\"length\":32}";

            var client = new HttpClient(new FakeHandler(json));


            var service = new CatFactService(client);


            var result = await service.GetRandomFactAsync();


            Xunit.Assert.Equal("Cats sleep 16 hours a day.", result);

        }

    }
}
