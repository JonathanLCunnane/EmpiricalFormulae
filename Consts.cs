using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmpiricalFormulae
{
    static class Consts
    {
        public static readonly Dictionary<string, float> elements = new Dictionary<string, float>()
        {
            {"H", (float)1.01 },
            {"He", (float)4.00 },
            {"Li", (float)6.94 },
            {"Be", (float)9.01 },
            {"B", (float)10.81 },
            {"C", (float)12.01 },
            {"N", (float)14.01 },
            {"O", (float)16.00 },
            {"F", (float)19.00 },
            {"Ne", (float)20.18 },
            {"Na", (float)22.99 },
            {"Mg", (float)24.31 },
            {"Al", (float)26.98 },
            {"Si", (float)28.09 },
            {"P", (float)30.97 },
            {"S", (float)32.06 },
            {"Cl", (float)35.45 },
            {"Ar", (float)39.95 },
            {"K", (float)39.10 },
            {"Ca", (float)40.08 },
            {"Sc", (float)44.96 },
            {"Ti", (float)47.88 },
            {"V", (float)50.94 },
            {"Cr", (float)51.99 },
            {"Mn", (float)54.94 },
            {"Fe", (float)55.85 },
            {"Co", (float)63.55 },
            {"Ni", (float)58.69 },
            {"Cu", (float)63.55 },
            {"Zn", (float)65.38 },
            {"Ga", (float)69.72 },
            {"Ge", (float)72.63 },
            {"As", (float)74.92 },
            {"Se", (float)78.97 },
            {"Br", (float)79.90 },
            {"Kr", (float)83.80 },
            {"Rb", (float)85.47 },
            {"Sr", (float)87.62 },
            {"Y", (float)88.91 },
            {"Zr", (float)91.22 },
            {"Nb", (float)92.91 },
            {"Mo", (float)95.95 },
            {"Tc", (float)98.91 },
            {"Ru", (float)101.07 },
            {"Rh", (float)102.91 },
            {"Pd", (float)106.42 },
            {"Ag", (float)107.87 },
            {"Cd", (float)112.41 },
            {"In", (float)114.82 },
            {"Sn", (float)118.71 },
            {"Sb", (float)121.76 },
            {"Te", (float)127.6 },
            {"I", (float)126.90 },
            {"Xe", (float)131.29 },
            {"Cs", (float)132.91 },
            {"Ba", (float)137.33 },
            {"La", (float)138.91 },
            {"Ce", (float)140.12 },
            {"Pr", (float)140.91 },
            {"Nd", (float)144.24 },
            {"Pm", (float)144.91 },
            {"Sm", (float)150.36 },
            {"Eu", (float)151.96 },
            {"Gd", (float)157.25 },
            {"Tb", (float)158.93 },
            {"Dy", (float)162.50 },
            {"Ho", (float)164.93 },
            {"Er", (float)167.26 },
            {"Tm", (float)168.93 },
            {"Yb", (float)173.06 },
            {"Lu", (float)174.97 },
            {"Hf", (float)178.49 },
            {"Ta", (float)180.95 },
            {"W", (float)183.85 },
            {"Re", (float)186.21 },
            {"Os", (float)190.23 },
            {"Ir", (float)192.22 },
            {"Pt", (float)195.08 },
            {"Au", (float)196.97 },
            {"Hg", (float)200.59 },
            {"Tl", (float)204.38 },
            {"Pb", (float)207.20 },
            {"Bi", (float)208.98 },
            {"Po", (float)208.98 },
            {"At", (float)209.98 },
            {"Rn", (float)222.02 },
            {"Fr", (float)223.02 },
            {"Ra", (float)226.03 },
            {"Ac", (float)227.03 },
            {"Th", (float)232.04 },
            {"Pa", (float)231.04 },
            {"U", (float)238.03 },
            {"Np", (float)237.05 },
            {"Pu", (float)244.06 },
            {"Am", (float)243.06 },
            {"Cm", (float)247.07 },
            {"Bk", (float)247.07 },
            {"Cf", (float)251.08 },
            {"Es", 254 },
            {"Fm", (float)257.10 },
            {"Md", (float)258.10 },
            {"No", (float)259.10 },
            {"Lr", 262 },
            {"Rf", 261 },
            {"Db", 262 },
            {"Sg", 266 },
            {"Bh", 264 },
            {"Hs", 269 },
            {"Mt", 278 },
            {"Ds", 281 },
            {"Rg", 280 },
            {"Cn", 285 },
            {"Nh", 286 },
            {"Fl", 289 },
            {"Mc", 289 },
            {"Lv", 293 },
            {"Ts", 294 },
            {"Og", 294 }
        };

        public static readonly Dictionary<int, char> subscripts = new Dictionary<int, char>()
        {
            {0, '\u2080' },
            {1, '\u2081' },
            {2, '\u2082' },
            {3, '\u2083' },
            {4, '\u2084' },
            {5, '\u2085' },
            {6, '\u2086' },
            {7, '\u2087' },
            {8, '\u2088' },
            {9, '\u2089' }
        };

        public static readonly string[] order = new string[118]
        {
            "Ac",
            "Al",
            "Am",
            "Sb",
            "Ar",
            "As",
            "At",
            "Ba",
            "Bk",
            "Be",
            "Bi",
            "Bh",
            "B",
            "Br",
            "Cd",
            "Ca",
            "Cf",
            "C",
            "Ce",
            "Cs",
            "Cl",
            "Cr",
            "Co",
            "Cn",
            "Cu",
            "Cm",
            "Ds",
            "Db",
            "Dy",
            "Es",
            "Er",
            "Eu",
            "Fm",
            "Fl",
            "F",
            "Fr",
            "Gd",
            "Ga",
            "Ge",
            "Au",
            "Hf",
            "Hs",
            "He",
            "Ho",
            "H",
            "In",
            "I",
            "Ir",
            "Fe",
            "Kr",
            "La",
            "Lr",
            "Pb",
            "Li",
            "Lv",
            "Lu",
            "Mg",
            "Mn",
            "Mt",
            "Md",
            "Hg",
            "Mo",
            "Mc",
            "Nd",
            "Ne",
            "Np",
            "Ni",
            "Nh",
            "Nb",
            "N",
            "No",
            "Og",
            "Os",
            "O",
            "Pd",
            "P",
            "Pt",
            "Pu",
            "Po",
            "K",
            "Pr",
            "Pm",
            "Pa",
            "Ra",
            "Rn",
            "Re",
            "Rh",
            "Rg",
            "Rb",
            "Ru",
            "Rf",
            "Sm",
            "Sc",
            "Sg",
            "Se",
            "Si",
            "Ag",
            "Na",
            "Sr",
            "S",
            "Ta",
            "Tc",
            "Te",
            "Ts",
            "Tb",
            "Tl",
            "Th",
            "Tm",
            "Sn",
            "Ti",
            "W",
            "U",
            "V",
            "Xe",
            "Yb",
            "Y",
            "Zn",
            "Zr"
        };

        public static readonly Dictionary<string, Dictionary<string, int>> combustionProducts = new Dictionary<string, Dictionary<string, int>>()
        {
            {
                "C",
                new Dictionary<string, int>()
                {
                    {"C", 1 }
                }
            },
            {
                "CO",
                new Dictionary<string, int>()
                {
                    {"C", 1 },
                    {"O", 1 }
                }
            },
            {
                $"CO{subscripts[2]}",
                new Dictionary<string, int>()
                {
                    {"C", 1 },
                    {"O", 2 }
                }
            },
            {
                $"SO{subscripts[2]}",
                new Dictionary<string, int>()
                {
                    {"S", 1 },
                    {"O", 2 }
                }
            },
            {
                "NO",
                new Dictionary<string, int>()
                {
                    {"N", 1 },
                    {"O", 1 }
                }
            },
            {
                $"NO{subscripts[2]}",
                new Dictionary<string, int>()
                {
                    {"N", 1 },
                    {"O", 2 }
                }
            },
            {
                $"N{subscripts[2]}O",
                new Dictionary<string, int>()
                {
                    {"N", 2 },
                    {"O", 1 }
                }
            },
            {
                $"H{subscripts[2]}O",
                new Dictionary<string, int>()
                {
                    {"H", 2 },
                    {"O", 1 }
                }
            },
            {
                $"H{subscripts[2]}",
                new Dictionary<string, int>()
                {
                    {"H", 2 }
                }
            }
        };

        public static readonly Dictionary<string, string> tableCombustionProducts = new Dictionary<string, string>()
        {
            {"C", "C" },
            {"CO", "CO" },
            {$"CO{subscripts[2]}", "CO2" },
            {$"SO{subscripts[2]}", "SO2" },
            {"NO", "NO" },
            {$"NO{subscripts[2]}", "NO2" },
            {$"N{subscripts[2]}O", "N2O" },
            {$"H{subscripts[2]}O", "H2O" },
            {$"H{subscripts[2]}", "H2" }
        };
    }
}
