using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace FactorialNumber
{
    public partial class Defauult : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void BttnGetFact_Click(object sender, EventArgs e)
        {
            LblFact.Text =  (ObtenerFactorial(Convert.ToInt32(TxtBxNum.Text))).ToString() + 
                "   Iterativo: " + (ObtenerFactorialIterativo(Convert.ToInt32(TxtBxNum.Text))).ToString();
        }

        protected long ObtenerFactorial(int num)
        {
            if (num == 0)
                return 1;
            return num * ObtenerFactorial(num - 1);
        }

        static long ObtenerFactorialIterativo(int n)
        {
            if (n < 0)
                throw new Exception("El parámetro debe ser positivo");
            long result = 1;

            for (long k = 1; k <= n; k++)
                result *= k;
            return result;
        }
        protected void BttnFibonacci_Click(object sender, EventArgs e)
        {
            LblNumFibonnaci.Text = (Fibonnaci(Convert.ToInt32(TxtBxNumFibb.Text))).ToString() +
                "   Iterativo: " + (FibonnaciIterativo(Convert.ToInt32(TxtBxNumFibb.Text))).ToString();
        }

        static long Fibonnaci(int n)
        {
            if (n == 0 || n == 1) return 1;
            else return Fibonnaci(n - 1) + Fibonnaci(n - 2);
        }

        static long FibonnaciIterativo(int n)
        {
            if (n < 0) throw new Exception("El parámetro debe ser positivo");
            long ultimo = 1, penultimo = 1;
            for (int k = 2; k <= n; k++)
            {
                long temp = penultimo; penultimo = ultimo; ultimo = ultimo + temp;
            }
            return ultimo;
        }

        public bool par(int n)
        {
            if (n == 0)
            {
                return true;
            }
            else
            {
                return impar(n - 1);
            }
        }

        public bool impar(int n)
        {
            if (n == 0)
            {
                return false;
            }
            else
            {
                return par(n - 1);
            }
        }
    }
}