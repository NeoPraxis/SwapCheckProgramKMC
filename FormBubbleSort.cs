/* ********************************************************************
 * Projct:      Bubble Sort With Pass Counter
 * File:        FormBubbleSort.cs
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
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SwapCheckProgramKMC
{
    public partial class FormBubbleSort : Form
    {
        // array of values set by professor
        private int[] valueArray = { 57, 63, 40, 13, 74, 99, 21, 8 };
        public FormBubbleSort()
        {
            InitializeComponent();
        }

        /// <summary>
        /// This button executes the sort and displays the number of passes
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonExecuteSort_Click(object sender, EventArgs e)
        {
            // display pre sorted data
            DisplayData(valueArray, listBoxPreSort);

            // sort the array
            BubbleSortWithPassCounter.Sort(valueArray);

            // display the array
            DisplayData(valueArray, listBoxPostSort);

            // display the number of passes
            listBoxPostSort.Items.Add("Number of passes: " + BubbleSortWithPassCounter.numOfPasses.ToString());
        }

        /// <summary>
        /// This routine will display the array of data in the list box
        /// </summary>
        /// <param name="data"></param>
        /// <param name="theListBox"></param>
        private void DisplayData(int[] data, ListBox theListBox)
        {
            // clear the list box
            theListBox.Items.Clear();

            // index itself, is the value in the array, hence the naming.
            for (int numsInArray = 0; numsInArray <= data.GetUpperBound(0); numsInArray++)
            {
                // format and display each item in the array in the listbox
                theListBox.Items.Add(String.Format("[{0}] = {1}", numsInArray, data[numsInArray]));
            }
        }
    }
}
