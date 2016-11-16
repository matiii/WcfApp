namespace App.Data.Repositories
{
    using Contracts;
    using Model;

    public class ZipCodeRepository: IZipCodeDataAccess
    {
        public ZipCode GetZipCodeByZip(string zip)
        {
            return new ZipCode();
        }
    }
}
