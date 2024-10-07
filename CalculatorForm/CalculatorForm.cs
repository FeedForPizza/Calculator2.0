namespace CalculatorForm
{
    public partial class CalculatorForm : Form
    {

        // Delegate definitions
        public delegate int Add(int x, int y);
        public delegate int Sustract(int x, int y);
        public delegate long Multiply(int x, int y);
        public delegate float Divide(int x, int y);
        public delegate double Square(int x);
        public delegate long SquareRoot(int x);

        //Delegates
        public Add AddDelegate;
        public Sustract SubstarctDelegate;
        public Square SquareDelegate;
        public SquareRoot SquareRootDelegate;
        public Multiply MultiplyDelegate;
        public Divide DivideDelegate;

        private int X
        {
            get
            {
                if (xInput.Value > 1000)
                {
                    throw new ArgumentOutOfRangeException("X", "x cannot be larger than 1000");
                }
                return (int)xInput.Value;
            }
        }
        private int Y
        {
            get
            {
                if (yInput.Value > 1000)
                {
                    throw new ArgumentOutOfRangeException("Y", "y cannot be larger than 1000");
                }
                return (int)yInput.Value;
            }

        }


        public CalculatorForm()
        {
            InitializeComponent();

        }
        private void addButton_Click(object sender, EventArgs e)
        {
            try
            {
                resultTextBox.Text = AddDelegate(X, Y).ToString();
            }
            catch(ArgumentOutOfRangeException ex)
            {
                MessageBox.Show(ex.Message);
            }
            catch (NullReferenceException ex)
            {
                MessageBox.Show("Add functionality is not available: \n" + ex.Message);
                addButton.Enabled = false;
            }
        }
        private void substractButton_Click(object sender, EventArgs e)
        {
            try
            {
                resultTextBox.Text = SubstarctDelegate(X, Y).ToString();
            }
            catch (ArgumentOutOfRangeException ex)
            {
                MessageBox.Show(ex.Message);
            }
            catch (NullReferenceException ex)
            {
                MessageBox.Show("Sustract functionality is not available: \n" + ex.Message);
                substractButton.Enabled = false;
            }
        }
        private void squareButton_Click(object sender, EventArgs e)
        {
            try
            {
                resultTextBox.Text = SquareDelegate(X).ToString();
            }
            catch (ArgumentOutOfRangeException ex)
            {
                MessageBox.Show(ex.Message);
            }
            catch (NullReferenceException ex)
            {
                MessageBox.Show("Square functionality is not available: \n" + ex.Message);
                squareButton.Enabled = false;
            }
        }
        private void squareRootButton_Click(object sender, EventArgs e)
        {
            try
            {
                resultTextBox.Text = SquareRootDelegate(X).ToString();
            }
            catch (ArgumentOutOfRangeException ex)
            {
                MessageBox.Show(ex.Message);
            }
            catch (NullReferenceException ex)
            {
                MessageBox.Show("Square root functionality is not available: \n" + ex.Message);
                squareRootButton.Enabled = false;
            }
        }
        private void multiplyButton_Click(object sender, EventArgs e)
        {
            try
            {
                resultTextBox.Text = MultiplyDelegate(X, Y).ToString();
            }
            catch (ArgumentOutOfRangeException ex)
            {
                MessageBox.Show(ex.Message);
            }
            catch (NullReferenceException ex)
            {
                MessageBox.Show("Multiply functionality is not available: \n" + ex.Message);
                multiplyButton.Enabled = false;
            }
        }
        private void divideButton_Click(object sender, EventArgs e)
        {
            try
            {
                if(Y == 0)
                {
                    throw new DivideByZeroException();  
                }
                resultTextBox.Text = DivideDelegate(X, Y).ToString();
            }
            catch(DivideByZeroException ex)
            {
                MessageBox.Show(ex.Message);
            }
            catch (ArgumentOutOfRangeException ex)
            {
                MessageBox.Show(ex.Message);
            }
            catch (NullReferenceException ex)
            {
                MessageBox.Show("Divide root functionality is not available: \n" + ex.Message);
                divideButton.Enabled = false;
            }
        }
    }
}
