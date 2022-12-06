/* ********************************************************************
 * Projct:      Bubble Sort With Pass Counter
 * File:        BubbleSortWithPassCounter.cs
 * Language:    C#
 * 
 * Desription:  This class implements a Bubble Sort and counts the number of passes
 *              
 * College:     Husson University
 * Course:      IT 325
 * 
 * Edit History:
 * Ver   Who Date       Notes
 * ----- --- ---------- -----------------------------------------------
 * 0.1   KMC 11/30/2022 - initial writing
 * *******************************************************************/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace SwapCheckProgramKMC
{
    internal class BubbleSortWithPassCounter
    {
        
        // getter and setter for number of passes
        public static int numOfPasses { get; set; }

        /// <summary>
        /// This method will sort an array of integers using 
        /// a Bubble Sort
        /// </summary>
        /// <param name="data"></param>
        public static void Sort(int[] data)
        {
            numOfPasses = 0;
            // make n-1 passes through the data
            for (int pass = 0; pass < data.GetUpperBound(0); pass++)
            {
                // for each pass examine adjacent elements
                for (int index = 0; index < data.GetUpperBound(0) - pass; index++)
                {
                    // out of order check
                    if (data[index] > data[index + 1])
                    {
                        Swap(data, index, index + 1);
                        numOfPasses++;
                    }
                }
            }
        }

        /// <summary>
        /// This routine will swap the two array elements specified by
        /// first and second index.
        /// </summary>
        /// <param name="data"></param>
        /// <param name="firstIndex"></param>
        /// <param name="secondIndex"></param>
        private static void Swap(int[] data, int firstIndex, int secondIndex)
        {
            int temp;

            temp = data[firstIndex];
            data[firstIndex] = data[secondIndex];
            data[secondIndex] = temp;
        }
    }
}
