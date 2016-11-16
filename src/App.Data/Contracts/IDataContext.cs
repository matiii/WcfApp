namespace App.Data.Contracts
{
    using System.Collections.Generic;
    using Model;

    public interface IDataContext
    {
        List<ZipCode> ZipCodes { get; }
    }
}
