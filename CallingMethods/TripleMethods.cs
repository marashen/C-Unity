using System;

namespace CallingMethods
{
    public class TripleMethods
    {
        public int para1;
        public int para2;
        public int para3;
        public int method1(int para1) => para1 += 9;
        public int method2(int para2) => para2 -= 14;
        public int method3(int para3) => para3 += 2;
    }
}
