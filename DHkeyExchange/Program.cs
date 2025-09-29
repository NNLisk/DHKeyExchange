using System;
using System.Numerics;
using DiffieHellman;

class Program
{
    static void Main()
    {
        BigInteger prime = DHkeyUtil.GetPrime();
        int generator = DHkeyUtil.GetGenerator();

        Console.WriteLine($"Prime: {prime}");
        Console.WriteLine($"Generator: {generator}");
    }
}