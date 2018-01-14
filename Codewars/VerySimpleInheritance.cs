using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Codewars
{
    public static class VerySimpleInheritance
    {
        /* There exists a preloaded abstract class named Operation
         Your job is to create 4 new classes which inherit the 'Operation' class. Within the class, create the proper execute method and save the mathematical operation to the proper result variable.The class names must be as follows:
         Add
         Subtract
         Multiply
         Divide
         */

        public abstract class Operation
        {
            public double Result;
            public abstract void Execute(double variable1, double variable2);
        }

        public class Add : Operation
        {
            public override void Execute(double a, double b)
            {
                Result = a + b;
            }
        }

        public class Subtract : Operation
        {
            public override void Execute(double a, double b)
            {
                Result = a - b;
            }
        }

        public class Multiply : Operation
        {
            public override void Execute(double a, double b)
            {
                Result = a * b;
            }
        }

        public class Divide : Operation
        {
            public override void Execute(double a, double b)
            {
                Result = a / b;
            }
        }
    }
}
