using System;

namespace Fond.DbfDataReader
{
    public interface IDbfValue
    {
        int Start { get; }

        int Length { get; }

        void Read(byte[] bytes);

        object GetValue();

        Type GetFieldType();
    }
}