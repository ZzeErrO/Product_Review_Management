﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinqToDataTable
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Data Table demo");
            LinqToDataTable linqToDataTable = new LinqToDataTable();
            linqToDataTable.AddToDataTableDemo();
            Console.ReadKey();
        }

    }
}
