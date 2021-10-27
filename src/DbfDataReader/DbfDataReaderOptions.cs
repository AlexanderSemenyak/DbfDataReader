using System.Text;

namespace Fond.DbfDataReader
{
    public class DbfDataReaderOptions
    {
        public DbfDataReaderOptions()
        {
            SkipDeletedRecords = false;
            Encoding = null;
        }

        public bool SkipDeletedRecords { get; set; }
        public Encoding Encoding { get; set; }
    }
}