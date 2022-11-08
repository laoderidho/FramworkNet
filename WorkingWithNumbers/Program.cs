﻿using static System.Console;
using System.Numerics;

WriteLine("Working with large integers:");
WriteLine("-----------------------------------");
ulong big = ulong.MaxValue;
WriteLine($"{big,40:N0}");
//this is one line statement
BigInteger bigger =
BigInteger.Parse("123456789012345678901234567890");
WriteLine($"{bigger,40:N0}");
