namespace App.Services.Tests
{
    using Contracts.Data;
    using Data.Contracts;
    using Data.Model;
    using NSubstitute;
    using Xunit;

    public class GeoManagerTest
    {

        [Fact]
        public void GetZipInfo_Should_Return_ZipCodeData()
        {
            var repo = Substitute.For<IZipCodeDataAccess>();
            repo.GetZipCodeByZip(Arg.Any<string>()).Returns(new ZipCode {});

            var manager = new GeoManager(repo);

            ZipCodeData result = manager.GetZipInfo("");

            Assert.NotNull(result);
        }
    }
}
