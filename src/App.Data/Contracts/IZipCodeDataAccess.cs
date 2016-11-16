namespace App.Data.Contracts
{
    using Model;

    public interface IZipCodeDataAccess
    {
        ZipCode GetZipCodeByZip(string zip);
    }
}
