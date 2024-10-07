using Calculator2._0;

namespace CalculatorForm
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();
            Application.Run(new CalculatorForm());


            int x = 23;
            int y = 2;

            SimpleCalculator myCalculator = new SimpleCalculator();


            AdvancedCalculator myAdvancedCalculator = new AdvancedCalculator();


            CalculatorForm newCalcForm = new CalculatorForm();
            newCalcForm.AddDelegate = new CalculatorForm.Add(myCalculator.Add);
            newCalcForm.SubstarctDelegate = new CalculatorForm.Sustract(myCalculator.Substract);
            newCalcForm.SquareDelegate = new CalculatorForm.Square(myAdvancedCalculator.Square);
            newCalcForm.SquareDelegate = new CalculatorForm.Square(myAdvancedCalculator.SquareRoot);
            newCalcForm.MultiplyDelegate = new CalculatorForm.Multiply(myAdvancedCalculator.Multiply);
            newCalcForm.DivideDelegate = new CalculatorForm.Divide(myAdvancedCalculator.Divide);

            newCalcForm.ShowDialog();
        }
    }
}