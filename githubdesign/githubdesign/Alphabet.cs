using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace githubdesign
{
    /// <summary>
    /// Contains Alphabet pattern
    /// 1 - colored
    /// 0 - not colored
    /// Check out how all the alphabets look using the Image attached with the Project.
    /// </summary>
    class Alphabet
    {
        public static readonly int[,] A = new int[5, 3] { { 1, 1, 1 }, { 1, 0, 1 }, { 1, 1, 1 }, { 1, 0, 1 }, { 1, 0, 1 } };
        public static readonly int[,] B = new int[5, 3] { { 1, 1, 0 }, { 1, 0, 1 }, { 1, 1, 0 }, { 1, 0, 1 }, { 1, 1, 0 } };
        public static readonly int[,] C = new int[5, 3] { { 1, 1, 1 }, { 1, 0, 0 }, { 1, 0, 0 }, { 1, 0, 0 }, { 1, 1, 1 } };
        public static readonly int[,] D = new int[5, 3] { { 1, 1, 0 }, { 1, 0, 1 }, { 1, 0, 1 }, { 1, 0, 1 }, { 1, 1, 0 } };
        public static readonly int[,] E = new int[5, 3] { { 1, 1, 1 }, { 1, 0, 0 }, { 1, 1, 1 }, { 1, 0, 0 }, { 1, 1, 1 } };
        public static readonly int[,] F = new int[5, 3] { { 1, 1, 1 }, { 1, 0, 0 }, { 1, 1, 1 }, { 1, 0, 0 }, { 1, 0, 0 } };
        public static readonly int[,] G = new int[5, 3] { { 1, 1, 1 }, { 1, 0, 0 }, { 1, 0, 1 }, { 1, 0, 1 }, { 1, 1, 1 } };
        public static readonly int[,] H = new int[5, 3] { { 1, 0, 1 }, { 1, 0, 1 }, { 1, 1, 1 }, { 1, 0, 1 }, { 1, 0, 1 } };
        public static readonly int[,] I = new int[5, 1] { { 1 }, { 1 }, { 1 }, { 1 }, { 1 } };
        public static readonly int[,] J = new int[5, 3] { { 0, 0, 1 }, { 0, 0, 1 }, { 0, 0, 1 }, { 1, 0, 1 }, { 1, 1, 1 } };
        public static readonly int[,] K = new int[5, 3] { { 1, 0, 1 }, { 1, 0, 1 }, { 1, 1, 0 }, { 1, 1, 0 }, { 1, 0, 1 } };
        public static readonly int[,] L = new int[5, 3] { { 1, 0, 0 }, { 1, 0, 0 }, { 1, 0, 0 }, { 1, 0, 0 }, { 1, 1, 1 } };
        public static readonly int[,] M = new int[5, 3] { { 1, 0, 1 }, { 1, 1, 1 }, { 1, 1, 1 }, { 1, 0, 1 }, { 1, 0, 1 } };
        public static readonly int[,] N = new int[5, 3] { { 0, 0, 0 }, { 1, 1, 1 }, { 1, 0, 1 }, { 1, 0, 1 }, { 1, 0, 1 } };
        public static readonly int[,] O = new int[5, 3] { { 1, 1, 1 }, { 1, 0, 1 }, { 1, 0, 1 }, { 1, 0, 1 }, { 1, 1, 1 } };
        public static readonly int[,] P = new int[5, 3] { { 1, 1, 1 }, { 1, 0, 1 }, { 1, 1, 1 }, { 1, 0, 0 }, { 1, 0, 0 } };
        public static readonly int[,] Q = new int[5, 4] { { 0, 1, 1, 0 }, { 1, 0, 0, 1 }, { 1, 0, 0, 1 }, { 0, 1, 1, 1 }, { 0, 0, 0, 1 } };
        public static readonly int[,] R = new int[5, 3] { { 1, 1, 1 }, { 1, 0, 1 }, { 1, 1, 0 }, { 1, 0, 1 }, { 1, 0, 1 } };
        public static readonly int[,] S = new int[5, 3] { { 1, 1, 1 }, { 1, 0, 0 }, { 1, 1, 1 }, { 0, 0, 1 }, { 1, 1, 1 } };
        public static readonly int[,] T = new int[5, 3] { { 1, 1, 1 }, { 0, 1, 0 }, { 0, 1, 0 }, { 0, 1, 0 }, { 0, 1, 0 } };
        public static readonly int[,] U = new int[5, 3] { { 1, 0, 1 }, { 1, 0, 1 }, { 1, 0, 1 }, { 1, 0, 1 }, { 1, 1, 1 } };
        public static readonly int[,] V = new int[5, 3] { { 1, 0, 1 }, { 1, 0, 1 }, { 1, 0, 1 }, { 1, 0, 1 }, { 0, 1, 0 } };
        public static readonly int[,] W = new int[5, 3] { { 1, 0, 1 }, { 1, 0, 1 }, { 1, 1, 1 }, { 1, 1, 1 }, { 1, 0, 1 } };
        public static readonly int[,] X = new int[5, 3] { { 1, 0, 1 }, { 1, 0, 1 }, { 0, 1, 0 }, { 1, 0, 1 }, { 1, 0, 1 } };
        public static readonly int[,] Y = new int[5, 3] { { 1, 0, 1 }, { 1, 0, 1 }, { 0, 1, 0 }, { 0, 1, 0 }, { 0, 1, 0 } };
        public static readonly int[,] Z = new int[5, 3] { { 1, 1, 1 }, { 0, 0, 1 }, { 0, 1, 0 }, { 1, 0, 0 }, { 1, 1, 1 } };

    }
}
