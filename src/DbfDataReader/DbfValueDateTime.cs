using System;
using Fond.DbfDataReader.Core;

namespace Fond.DbfDataReader
{
    public class DbfValueDateTime : DbfValue<DateTime?>
    {
        public DbfValueDateTime(int start, int length) : base(start, length)
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
                var datePart = BitConverter.ToInt32(bytes,0);
                var timePart = BitConverter.ToInt32(bytes.FromThisToEnd(4),0 /*[4..]*/);
                Value = new DateTime(1, 1, 1).AddDays(datePart).Subtract(TimeSpan.FromDays(1721426))
                    .AddMilliseconds(timePart);
            }
        }
    }
}