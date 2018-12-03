using System;

namespace LambdaExpressionsMultipleParams
{
    class Program
    {
        static void Main(string[] args)
        {
            //Register with delefate as a lambda expression
            SimpleMath m = new SimpleMath();
            m.SetMathHandler((msg, result) =>
            { Console.WriteLine($"Message: {msg}, Result: {result}");});

            //This will execute the lambda expression
            m.Add(10, 10);

        }
    }

    public class SimpleMath
    {
        public delegate void MathMessage(string msg, int result);
        private MathMessage mmDelegate;

        public void SetMathHandler(MathMessage target)
        { mmDelegate = target; }

        public void Add(int x,int y)
        { mmDelegate?.Invoke("Adding has completed", x + y); }
    }
}