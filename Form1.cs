using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MyLibrary;

namespace MethodSort
{
    public partial class SortingForm : Form
    {
        public SortingForm()
        {
            InitializeComponent();
        }
        
        private string ConvertStr(string str)
        {
            string[] arrStr = MyString.Split(str, " ");
            int[] arrInt = new int[arrStr.Length];
            for (int i = 0; i < arrStr.Length; i++)
                arrInt[i] = Int32.Parse(arrStr[i]);
            arrInt = ConvertArrInt(arrInt);
            for (int i = 0; i < arrInt.Length; i++)
                arrStr[i] = arrInt[i].ToString();
            return MyString.Join(" ", arrStr);

        }

        private int[] ConvertArrInt(int[] arrInt)
        {
            int[] arrResult = new int[arrInt.Length];
            int temp = arrInt[arrInt.Length-1];
            int j = arrInt.Length - 2;
            arrResult[arrResult.Length - 1] = arrInt[arrInt.Length - 1];
            for (int i = arrInt.Length - 2; i >= 0; i--)
            {
                if (temp < arrInt[i])
                {
                    arrResult[i] = temp;
                    temp = arrInt[i];
                }
                else
                {
                    arrResult[i] = temp;
                }
            }
            return arrResult;
        }

        private void MethodSortButton_Click(object sender, EventArgs e)
        {
            OutputTextBox.Text = ConvertStr(InputTextBox.Text);
        }

       
       
    }
}
