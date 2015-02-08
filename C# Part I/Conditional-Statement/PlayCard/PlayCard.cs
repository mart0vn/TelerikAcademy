﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Classical play cards use the following signs to designate the card face: `2, 3, 4, 5, 6, 7, 8, 9, 10, J, Q, K and A. Write a program that enters a
//string and prints “yes” if it is a valid card sign or “no” otherwise. Examples:
//character	Valid card sign?
//5	yes
//1	no
//Q	yes
//q	no
//P	no
//10	yes
//500	no
class PlayCard
{
    static void Main()
    {
        Console.WriteLine("Enter card: ");
        string card = Console.ReadLine();

        switch (card)
        {
            case "2":
            case "3": 
            case "4":
            case "5":
            case "6":
            case "7":
            case "8":
            case "9":
            case "10":
            case "J":
            case "Q": 
            case "K":
            case "A":
                {
                    Console.WriteLine("Yes");
                    break;
                }
            default:
                Console.WriteLine("No");
                break;
        }
    }
}

