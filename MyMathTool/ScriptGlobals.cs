using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyMathTool
{
    public class ScriptGlobals
    {
        public ProgrammingForm Form { get; set; }

        public static int AND(int a, int b)
        {
            bool result = (a != 0) && (b != 0);
            return result ? 1 : 0;
        }
        public static int OR(int a, int b)
        {
            bool result = (a != 0) || (b != 0);
            return result ? 1 : 0;
        }
        public static int NOT(int a)
        {
            bool result = Convert.ToBoolean(a);
            return !result ? 1 : 0;
        }
        public static int NAND(int a, int b)
        {
            bool result = (a != 0) && (b != 0);
            return !result ? 1 : 0;
        }
        public static int XOR(int a, int b)
        {
            int notA = NOT(a);
            int notB = NOT(b);
            int aAndNotB = AND(a, notB);
            int notAAndB = AND(notA, b);
            return OR(aAndNotB, notAAndB);
        }
        public static int NOR(int a, int b)
        {
            return NOT(OR(a, b));
        }
    }

}
