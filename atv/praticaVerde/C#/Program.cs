﻿using System;

class DonaLourdes {

    public static void Main() {
        double r = 0, n = 0, s = 998;
            for (; r != 999;) {
                r = double.Parse(Console.ReadLine());
                if ( r > n && r != 999) n = r;
                if ( r < s) s = r;
            }
        Console.WriteLine( n + " "+ s );

    }
}