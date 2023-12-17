namespace Lab_6_task_1
{
    public class ArithmeticCalculator<T>
    {
        public delegate T ArithmeticOperation(T a, T b);

        public ArithmeticOperation Add { get; set; }
        public ArithmeticOperation Subtract { get; set; }
        public ArithmeticOperation Multiply { get; set; }
        public ArithmeticOperation Divide { get; set; }

        public ArithmeticCalculator()
        {
            Add = (a, b) => AddOperation(a, b);
            Subtract = (a, b) => SubtractOperation(a, b);
            Multiply = (a, b) => MultiplyOperation(a, b);
            Divide = (a, b) => DivideOperation(a, b);
        }

        public T PerformOperation(T a, T b, ArithmeticOperation operation)
        {
            return operation(a, b);
        }

        private T AddOperation(T a, T b) => (dynamic)a + b;
        private T SubtractOperation(T a, T b) => (dynamic)a - b;
        private T MultiplyOperation(T a, T b) => (dynamic)a * b;
        private T DivideOperation(T a, T b) => (dynamic)a / b;
    }
}