﻿using System;
using System.IO;

namespace ClassLibrarySpike
{
    class Program
    {
        static void Main(string[] args)
        {
            string root = Path.GetFullPath(Path.Combine(
                Path.GetDirectoryName(
                    Path.GetDirectoryName(
                        Path.GetDirectoryName(
                            Path.GetDirectoryName(
                                Path.GetDirectoryName(typeof(Program).Assembly.Location)))))));
            string rootWithoutCombine = Path.GetFullPath(
                Path.GetDirectoryName(
                    Path.GetDirectoryName(
                        Path.GetDirectoryName(
                            Path.GetDirectoryName(
                                Path.GetDirectoryName(typeof(Program).Assembly.Location))))));
            string rootWithoutCombineAndGetFullPath = 
                Path.GetDirectoryName(
                    Path.GetDirectoryName(
                        Path.GetDirectoryName(
                            Path.GetDirectoryName(
                                Path.GetDirectoryName(typeof(Program).Assembly.Location)))));
            Console.WriteLine(root);
            Console.WriteLine(rootWithoutCombine);
            Console.WriteLine(rootWithoutCombineAndGetFullPath);
            Console.WriteLine(typeof(Program).Assembly.Location);
            Console.WriteLine(Path.GetDirectoryName(typeof(Program).Assembly.Location));
            Console.WriteLine(Path.GetDirectoryName(Path.GetDirectoryName(typeof(Program).Assembly.Location)));

        }
    }
}
