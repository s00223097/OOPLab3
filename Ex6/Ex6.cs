﻿/*
    2D array of movie ratings for 3 films.
*/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Initialise variables and arrays

            int total = 0; 

            int[,] movieReviews = new int[,]
            {
                { 3, 4, 5 }, // an array of reviews for the first film
                { 1, 2, 1 }, // an array of reviews for the second film
                { 5, 4, 2 }
            };

            double[] averages = new double[3];  // an array of the average rating for each film

            // Loop to go through each row in array
            for (int i = 0; i < movieReviews.GetLength(0); i++)  // getlength(0) = number of rows in array
            {
                // nested loop to go through each element in row of above loop

                for (int j = 0; j < movieReviews.GetLength(1); j++)  //getlength(1) = number of coloumns in array
                {
                    total += movieReviews[i, j];
                }

                averages[i] = (double)total / 3; // (double)total casts total to a double to make sure decimals are allowed
            }

            foreach (double average in averages)
            {
                Console.WriteLine("Average is {0:F2}", average); // F2 formats to two decimals
            }

            Console.ReadLine();

        }
    }
}
