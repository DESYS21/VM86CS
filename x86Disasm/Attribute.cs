﻿using System;
namespace x86Disasm
{
    [System.AttributeUsage(AttributeTargets.Method, AllowMultiple = true)]
    public class CPUFunction : Attribute
    {
        public ushort OpCode;
        public int Count;

        public CPUFunction()
        {
            Count = 1;
        }
    }
}
