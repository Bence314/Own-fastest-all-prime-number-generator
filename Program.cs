﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace All_Prime_Number{
    class Program {
        static void Main(string[] args) {
            Console.WriteLine("\t \t All Prime Number: \n");
            int num = 1;
            int i = 2;
            bool prime = true;
            while (true) {
                while (prime) {  
                    if (num % i == 0 && i <= num / 2) {
                        prime = false;
                    }
                    else if (i > num/2) {
                        Console.WriteLine(num+" ");
                        prime = false;
                    }
                    i++;
                }
                i = 2;
                num++;
                prime = true;
            }
        }
    }
}
