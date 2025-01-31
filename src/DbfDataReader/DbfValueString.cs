using System.Text;

namespace Fond.DbfDataReader
{
    public class DbfValueString : DbfValue<string>
    {
        private const char NullChar = '\0';

        public DbfValueString(int start, int length, Encoding encoding) : base(start, length)
        {
            Encoding = encoding;
        }

        protected readonly Encoding Encoding;

        public override void Read(byte[] bytes)
        {
            if (bytes[0] == NullChar)
            {
                Value = null;
                return;
            }

            var value = Encoding.GetString(bytes);
            Value = value.Trim(NullChar, ' ');
        }
    }
}