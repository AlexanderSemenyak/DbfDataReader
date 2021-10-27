using System;
using System.Globalization;

namespace DbfDataReader
{
    public class DbfValueCurrency : DbfValue<float?>
    {
        public DbfValueCurrency(int start, int length, int decimalCount) : base(start, length)
        {
            DecimalCount = decimalCount;
        }

        public int DecimalCount { get; set; }

        public override void Read(byte[] bytes)
        {
            var value = BitConverter.ToInt64(bytes,0);
            Value = value / 10000.0f;
        }

        public override string ToString()
        {
            var format = DecimalCount != 0
                ? $"0.{new string('0', DecimalCount)}"
                : null;

            return Value?.ToString(format, NumberFormatInfo.CurrentInfo) ?? string.Empty;
        }
    }
}