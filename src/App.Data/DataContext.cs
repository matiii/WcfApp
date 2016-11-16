namespace App.Data
{
    using System.Collections.Generic;
    using Contracts;
    using Model;

    public class DataContext: IDataContext
    {
        public List<ZipCode> ZipCodes { get; }

        public DataContext()
        {
            ZipCodes = new List<ZipCode>(new []{ new ZipCode(), new ZipCode()});
        }
    }
}
