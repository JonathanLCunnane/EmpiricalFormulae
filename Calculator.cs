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
            bool[] currDPS;
            bool[] foundDPS = new bool[3]
            {
                false,
                false,
                false
            };
            int rounded;
            string result = "";
            for (int n = 1; n <= 1000; n++)
            {
                temp.Clear();
                temp = elements.ToDictionary(kvp => kvp.Key, kvp => kvp.Value * n);
                currDPS = new bool[foundDPS.Length];
                for (int i = 0; i < foundDPS.Length; i++)
                {
                    currDPS[i] = !foundDPS[i];
                }
                foreach (KeyValuePair<string, double> kvp in temp)
                {
                    rounded = (int)Math.Round(kvp.Value);
                    if (Math.Round(kvp.Value, 1) != rounded & !foundDPS[0])
                    {
                        currDPS[0] = false;
                        currDPS[1] = false;
                        currDPS[2] = false;
                    }
                    else if (Math.Round(kvp.Value, 2) != rounded & !foundDPS[1])
                    {
                        currDPS[1] = false;
                        currDPS[2] = false;
                    }
                    else if (Math.Round(kvp.Value, 3) != rounded & !foundDPS[2])
                    {
                        currDPS[2] = false;
                    }
                }

                // Check if the current temp compound is at a certain amount of DP and add to the result
                if (currDPS[0])
                {
                    foundDPS[0] = true;
                    result += $"1.d.p accuracy: {FormatCompound(temp)}\nMr:{getMr(temp)}\n\n";
                }
                if (currDPS[1])
                {
                    foundDPS[1] = true;
                    result += $"2.d.p accuracy: {FormatCompound(temp)}\nMr:{getMr(temp)}\n\n";
                }
                if (currDPS[2])
                {
                    foundDPS[2] = true;
                    result += $"3.d.p accuracy: {FormatCompound(temp)}\nMr:{getMr(temp)}";
                    return result;
                }
            }
            if (result == "")
            {
                return "No empirical formula found within given computing time to a suitable degree of accuracy.";
            }
            return result;
        }

        static double getMr(Dictionary<string, double> elements)
        {
            double mr = 0;
            foreach (KeyValuePair<string, double> kvp in elements)
            {
                mr += Math.Round(kvp.Value) * Consts.elements[kvp.Key];
            }
            return Math.Round(mr, 2);
        }

        static string FormatCompound(Dictionary<string, double> elements)
        {
            // This function will format the compound based on the 'Hill Sytstem' or 'Hill Notation'
            string soln = "";
            Dictionary<string, double> temp = elements.ToDictionary(kvp => kvp.Key, kvp => kvp.Value);
            if (temp.ContainsKey("C"))
            {
                soln += $"C{SubscriptString((int)Math.Round(temp["C"]))}";
                temp.Remove("C");
                if (temp.ContainsKey("H"))
                {
                    soln += $"H{SubscriptString((int)Math.Round(temp["H"]))}";
                    temp.Remove("H");
                }
            }
            // Add each element in alphabetical order if present in compound
            foreach(string element in Consts.order)
            {
                if (temp.ContainsKey(element))
                {
                    soln += $"{element}{SubscriptString((int)Math.Round(temp[element]))}";
                    temp.Remove(element);
                }
                // Break if there are no elements left
                if (temp.Count == 0)
                {
                    break;
                }
            }
            return soln;
        }

        static string SubscriptString(int n)
        {
            // If n is 1 then return an empty string as you do not need a subscript in this case.
            if (n == 1)
            {
                return "";
            }
            string strn = n.ToString();
            string str = "";
            for (int i = 0; i < strn.Length; i++)
            {
                // Note that since this function will only be called from within this class that no 'try parsing' is needed before casting.
                str += Consts.subscripts[int.Parse(strn[i].ToString())];
            }
            return str;
        }
    }
}
