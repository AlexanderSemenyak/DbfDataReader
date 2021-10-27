using System.Globalization;
using System.Text;

namespace Fond.DbfDataReader
{
    public class DbfValueInt : DbfValue<int?>
    {
        private static readonly NumberFormatInfo _intNumberFormat = new NumberFormatInfo();

        public DbfValueInt(int start, int length) : base(start, length)
        {
        }

        public override void Read(byte[] bytes)
        {
            if (bytes[0] == '\0')
            {
                Value = null;
            }
            else
            {
                var stringValue = Encoding.ASCII.GetString(bytes);

                if (int.TryParse(stringValue,
                    NumberStyles.Integer | NumberStyles.AllowLeadingWhite | NumberStyles.AllowTrailingWhite,
                    _intNumberFormat, out var value))
                    Value = value;
                else
                    Value = null;
            }
        }
    }
}