using myproject;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyProject
{
  public static class Extension
    {
        /// <summary>
        /// Tính toán am
        /// </summary>
        /// <param name="M"></param>
        /// <param name="Rb"></param>
        /// <param name="b"></param>
        /// <param name="ho"></param>
        /// <returns></returns>
        public static double ExecuteAm(double M,double Rb,double b, double ho)
        {
            var response = M*Math.Pow(10,6) / (Rb * b*1000 * ho*ho);
            response = Math.Round(response, 2);
            return response;
        }
        /// <summary>
        /// Tính cờ xi
        /// </summary>
        /// <param name="am"></param>
        /// <returns></returns>
        public static double Execute_cosi(double am)
        {
            var response = 0.5 * (1 + Math.Sqrt(1 - 2 * am));
            response = Math.Round(response, 2);
            return response;
        }
        /// <summary>
        /// Tính moment 
        /// </summary>
        /// <param name="am"></param>
        /// <returns></returns>
        public static double Execute_Moment(double Qb, double L3)
        {
            try
            {
                double M = ((Qb * L3 * L3) / 8) / 1000000;
                return Math.Round(M, 2);
            }
            catch (Exception)
            {
                return 0;
            }
           
        }

        public static double Execute_As(double M,double c, double Rs, double ho)
        {
            try
            {

                double As = M * Math.Pow(10, 6) / (c * Rs/10 * ho);
                return Math.Round(As, 2);
            }
            catch (Exception)
            {
                return 0;
            }

        }

        public static double Execute_Ho(double H, double cover)
        {
            try
            {
                return H - cover;
            
            }
            catch (Exception)
            {
                return 0;
            }

        }

        public static double ExecuteAm_mm(double M, double b, double ho)
        {
            double rb = Data.Concrete.Rb;
            var response = M * Math.Pow(10, 6) / (rb * b * ho * ho);
            response = Math.Round(response, 4);
            return response;
        }


        public static double Execute_Hamluongcotthep(double As, double b, double ho)
        {
          
            var response = (As / (b *ho))*100;
            response = Math.Round(response, 4);
            return response;
        }
    }
}
