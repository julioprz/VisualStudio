using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace TestOGrande
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
           
          
        }

        

        protected void Button1_Click(object sender, EventArgs e)
        {
            int[] arr = { 1, 1, 2, 5, 3 };// { 14, 1, 2, 3, 8, 15, 3 };
            int x = 8; //15
            LblResult.Text = tripletSum(x, arr) ? "True 1" : "False 1";
        }

        bool tripletSum(int x, int[] a)
        {
            for (int i = 0; i < a.Length; i++)
            {
                for (int j = i + 1; j < a.Length; j++)
                {
                    if (a[i] + a[j] == x)
                    {
                        return true;
                    }
                }
            }
            return false;
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            int[] arr =  { 14, 1, 2, 3, 8, 15, 3 };//{ 1, 1, 2, 5, 3 };//
            int x = 15;// 8; //
            LblResult.Text = test(arr,x ) ? "True 2" : "False 2";
            
        }

        public static bool test(int[] a, int val)
        {
            Array.Sort(a);

          
            int i = 0;            // index of first element.
            int j = a.Length - 1; // index of last element. 

            while (i < j)
            {
                // check if the sum of elements at index i and j equals val, if yes we are done.
                if (a[i] + a[j] == val)
                    return true;
                // else if sum if more than val, decrease the sum.
                else if (a[i] + a[j] > val)
                    j--;
                // else if sum is less than val, increase the sum.
                else
                    i++;
            }
            // failed to find any such pair..return false. 
            return false;
        }
    }
}