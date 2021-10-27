using System;

namespace Fond.DbfDataReader
{
    public class DbfValueLong : DbfValue<long?>
    {
        public DbfValueLong(int start, int length) : base(start, length)
        {
        }

        public override void Read(byte[] bytes)
        {
            Value = BitConverter.ToInt32(bytes, 0);
        }
    }
}