using System;

namespace ClassSubs
{
    class AddingOutputs
    {
        public void OutputParameters(out int outputs)
        {
            int input1 = 189;
            outputs = input1;
        }
        public int overloadedMath(int over1, int over2)
        {
        int overSO = over1 + over2;
        return overSO;
        }
        public int overloadedMath(int over1, int over2, int over3)
        {
            int overSO = over1 + over2 + over3;
            return overSO;
        }
        static void Main(string[] args)
        {
            ClassyMath vclassy = new ClassyMath();
            Console.WriteLine("Choose a number!");
            int userN = Convert.ToInt32(Console.ReadLine());
            vclassy.method1(userN);

            AddingOutputs output1 = new AddingOutputs();
            int para1 = 150;
            output1.OutputParameters(out para1);
            Console.WriteLine(para1);

            AddingOutputs overV = new AddingOutputs();
            int overS1 = overV.overloadedMath(11, 34);
            int overS2 = overV.overloadedMath(11, 34, 55);
            Console.WriteLine("Overloaded Ex.: " + overS1 + " " + overS2);
        }
    }
}
