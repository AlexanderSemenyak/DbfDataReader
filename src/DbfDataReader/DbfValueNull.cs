﻿using System;

namespace Fond.DbfDataReader
{
    public class DbfValueNull : IDbfValue
    {
        public DbfValueNull(int start, int length)
        {
            Start = start;
            Length = length;
        }

        public int Start { get; }

        public int Length { get; }

        public object GetValue()
        {
            return null;
        }

        public void Read(byte[] bytes)
        {
            // do nothing
        }

        public T GetValue<T>()
        {
            throw new NotImplementedException();
        }

        public override string ToString()
        {
            return string.Empty;
        }

        public Type GetFieldType()
        {
            return null;
        }
    }
}