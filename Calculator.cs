using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmpiricalFormulae
{
    public static class Calculator
    {
        public static string FormulaFromElements(Dictionary<string, double> elements)
        {
            // Firstly convert all of the masses into moles and divide through by the lowest number of moles. 
            elements = elements.ToDictionary(kvp => kvp.Key, kvp => kvp.Value / Consts.elements[kvp.Key]);

            double lowestMol = elements.OrderBy(kvp => kvp.Value).First().Value;
            elements = elements.ToDictionary(kvp => kvp.Key, kvp => kvp.Value / lowestMol);

            // To find the ratio between the elements multiply the moles by each value between 1 and 100.
            // When the variance from a whole number of ALL the elements is at max of 0.02 then that empirical formula is given.
            Dictionary<string, double> temp = new Dictionary<string, double>();
            double maxVariance;
            double currVariance;
            for (int n = 1; n <= 100; n++)
            {
                temp.Clear();
                temp = elements.ToDictionary(kvp => kvp.Key, kvp => kvp.Value * n);
                maxVariance = 0;
                foreach (KeyValuePair<string, double> kvp in temp)
                {
                    currVariance = Math.Abs(kvp.Value - Math.Round(kvp.Value)) / kvp.Value;
                    if (currVariance > maxVariance)
                    {
                        maxVariance = currVariance;
                    }
                }

                // If the maxVariance is at max of 0.02 then return the rounded 
                if (maxVariance <= 0.02)
                {
                    string result = "";
                    foreach (KeyValuePair<string, double> kvp in temp)
                    {
                        result += $"{kvp.Key}{SubscriptString((int)Math.Round(kvp.Value))} ";
                    }
                    return result;
                }
            }
            return "None found with 'maxVariance' of 0.02 within given computing time.";
        }
        
        static string SubscriptString(int n)
        {
            string strn = n.ToString();
            string str = "";
            for (int i = 0; i < strn.Length; i++)
            {
                // Note that since this function will only be called from within this class that no 'try parsing' is needed before casting.
                str += Consts.subscripts[int.Parse(strn[i].ToString())];
            }
            Console.WriteLine($"{str}, {n}");
            return str;
        }
    }
}
