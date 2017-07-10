using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using CustomCalculator.Common;
using CustomCalculator.SRP;

namespace CustomCalculator
{
    public partial class MainWindow : Window
    {
        private StringBuilder sb { get; set; }
        private int counter { get; set; } // check validator class
        private bool isClicked { get; set; }
        private bool equalTrigger { get; set; }
        private int? subInput { get; set; }
        private int? mainInput { get; set; }

        public MainWindow()
        {
            sb = new StringBuilder();
            counter = 0;
            subInput = null;
            mainInput = null;
            InitializeComponent();
        }

        private void BtnZero_Click(object sender, RoutedEventArgs e)
        {
            Validator validate = new Validator();
            MainInput.Text = validate.CheckInputLimitValidator(NumberConstants.buttonZero, sb, isClicked, MainInput.Text);
            isClicked = false;
        }

        private void BtnOne_Click(object sender, RoutedEventArgs e)
        {
            Validator validate = new Validator();
            MainInput.Text = validate.CheckInputLimitValidator(NumberConstants.buttonOne, sb, isClicked, MainInput.Text);
            isClicked = false;
        }

        private void BtnTwo_Click(object sender, RoutedEventArgs e)
        {
            Validator validate = new Validator();
            MainInput.Text = validate.CheckInputLimitValidator(NumberConstants.buttonTwo, sb, isClicked, MainInput.Text);
            isClicked = false;
        }

        private void BtnThree_Click(object sender, RoutedEventArgs e)
        {
            Validator validate = new Validator();
            MainInput.Text = validate.CheckInputLimitValidator(NumberConstants.buttonThree, sb, isClicked, MainInput.Text);
            isClicked = false;
        }

        private void BtnFour_Click(object sender, RoutedEventArgs e)
        {
            Validator validate = new Validator();
            MainInput.Text = validate.CheckInputLimitValidator(NumberConstants.buttonFour, sb, isClicked, MainInput.Text);
            isClicked = false;
        }

        private void BtnFive_Click(object sender, RoutedEventArgs e)
        {
            Validator validate = new Validator();
            MainInput.Text = validate.CheckInputLimitValidator(NumberConstants.buttonFive, sb, isClicked, MainInput.Text);
            isClicked = false;
        }

        private void BtnSix_Click(object sender, RoutedEventArgs e)
        {
            Validator validate = new Validator();
            MainInput.Text = validate.CheckInputLimitValidator(NumberConstants.buttonSix, sb, isClicked, MainInput.Text);
            isClicked = false;
        }

        private void BtnSeven_Click(object sender, RoutedEventArgs e)
        {
            Validator validate = new Validator();
            MainInput.Text = validate.CheckInputLimitValidator(NumberConstants.buttonSeven, sb, isClicked, MainInput.Text);
            isClicked = false;
        }

        private void BtnEight_Click(object sender, RoutedEventArgs e)
        {
            Validator validate = new Validator();
            MainInput.Text = validate.CheckInputLimitValidator(NumberConstants.buttonEight, sb, isClicked, MainInput.Text);
            isClicked = false;
        }

        private void BtnNine_Click(object sender, RoutedEventArgs e)
        {
            Validator validate = new Validator();
            MainInput.Text = validate.CheckInputLimitValidator(NumberConstants.buttonNine, sb, isClicked, MainInput.Text);
            isClicked = false;
        }

        private void BtnClear_Click(object sender, RoutedEventArgs e)
        {
            MainInput.Text = String.Empty;
            SubInput.Text  = String.Empty;
            
            sb.Clear().ToString();
            subInput = null;
            mainInput = null;
        }

        private void BtnAdd_Click(object sender, RoutedEventArgs e)
        {
            string trigger = "BtnAdd";
            sb.Clear();

            if ((subInput.HasValue == true
                    && mainInput.HasValue == true))
            {
                this.Execute(subInput.Value, mainInput.Value);
                BinaryOperations bin = new BinaryOperations();
                SubInput.Text = bin.OperatorReplacer(SubInput.Text, trigger);
            }
            else if (subInput == null)
            {
                subInput = int.Parse(MainInput.Text);
                Operator.Text = OperatorConstants.AddSymbol.ToString();
                SubInput.Text += sb.Append(subInput).ToString() + Operator.Text;

                if (mainInput != null && subInput != null)
                    this.Execute(subInput.Value, mainInput.Value);
            }
            else if (subInput != null && mainInput == null)
            {
                mainInput = int.Parse(MainInput.Text);
                SubInput.Text += sb.Append(mainInput).ToString() + Operator.Text;
                this.Execute(subInput.Value, mainInput.Value);

                Operator.Text = OperatorConstants.AddSymbol.ToString();
                sb.Clear();
                
                /* Replace operator symbol*/
                int subLen = SubInput.Text.Length - 1;

                if (SubInput.Text != String.Empty
                && SubInput.Text.Substring(subLen, 1) != OperatorConstants.AddSymbol.ToString())
                {
                    BinaryOperations bin = new BinaryOperations();
                    SubInput.Text = bin.OperatorReplacer(SubInput.Text, trigger);

                }
            }
            else
            {
                MessageBox.Show("An Error occured", "Warning");
            }
            isClicked = true;
            equalTrigger = false;
        }

        private void BtnSubtract_Click(object sender, RoutedEventArgs e)
        {
            string trigger = "BtnSubtract";
            sb.Clear();

            if ((subInput.HasValue == true
                    && mainInput.HasValue == true))
            {
                this.Execute(subInput.Value, mainInput.Value);
                BinaryOperations bin = new BinaryOperations();
                SubInput.Text = bin.OperatorReplacer(SubInput.Text, trigger);
            }
            else if (subInput == null)
            {
                subInput = int.Parse(MainInput.Text);
                Operator.Text = OperatorConstants.SubtractSymbol.ToString(); //
                SubInput.Text += sb.Append(subInput).ToString() + Operator.Text;

                if (mainInput != null && subInput != null)
                    this.Execute(subInput.Value, mainInput.Value);
            }
            else if (subInput != null && mainInput == null)
            {
                mainInput = int.Parse(MainInput.Text);
                SubInput.Text += sb.Append(mainInput).ToString() + Operator.Text;
                this.Execute(subInput.Value, mainInput.Value);

                Operator.Text = OperatorConstants.SubtractSymbol.ToString();//
                sb.Clear();

                /* Replace operator symbol*/
                int subLen = SubInput.Text.Length - 1;

                if (SubInput.Text != String.Empty
                && SubInput.Text.Substring(subLen, 1) != OperatorConstants.SubtractSymbol.ToString()) //
                {
                    BinaryOperations bin = new BinaryOperations();
                    SubInput.Text = bin.OperatorReplacer(SubInput.Text, trigger);

                }
            }
            else
            {
                MessageBox.Show("An Error occured", "Warning");
            }
            isClicked = true;
            equalTrigger = false;
        }

        private void BtnMultply_Click(object sender, RoutedEventArgs e)
        {
            string trigger = "BtnMultply";
            sb.Clear();

            if ((subInput.HasValue == true
                    && mainInput.HasValue == true))
            {
                this.Execute(subInput.Value, mainInput.Value);
                BinaryOperations bin = new BinaryOperations();
                SubInput.Text = bin.OperatorReplacer(SubInput.Text, trigger);
            }
            else if (subInput == null)
            {
                subInput = int.Parse(MainInput.Text);
                Operator.Text = OperatorConstants.MultiplySymbol.ToString(); //
                SubInput.Text += sb.Append(subInput).ToString() + Operator.Text;

                if (mainInput != null && subInput != null)
                    this.Execute(subInput.Value, mainInput.Value);
            }
            else if (subInput != null && mainInput == null)
            {
                mainInput = int.Parse(MainInput.Text);
                SubInput.Text += sb.Append(mainInput).ToString() + Operator.Text;
                this.Execute(subInput.Value, mainInput.Value);

                Operator.Text = OperatorConstants.MultiplySymbol.ToString();//
                sb.Clear();

                /* Replace operator symbol*/
                int subLen = SubInput.Text.Length - 1;

                if (SubInput.Text != String.Empty
                && SubInput.Text.Substring(subLen, 1) != OperatorConstants.MultiplySymbol.ToString()) //
                {
                    BinaryOperations bin = new BinaryOperations();
                    SubInput.Text = bin.OperatorReplacer(SubInput.Text, trigger);

                }
            }
            else
            {
                MessageBox.Show("An Error occured", "Warning");
            }
            isClicked = true;
            equalTrigger = false;
        }

        private void BtnDivide_Click(object sender, RoutedEventArgs e)
        {
            string trigger = "BtnDivide";
            sb.Clear();

            if ((subInput.HasValue == true
                    && mainInput.HasValue == true))
            {
                this.Execute(subInput.Value, mainInput.Value);
                BinaryOperations bin = new BinaryOperations();
                SubInput.Text = bin.OperatorReplacer(SubInput.Text, trigger);
            }
            else if (subInput == null)
            {
                subInput = int.Parse(MainInput.Text);
                Operator.Text = OperatorConstants.DivideSymbol.ToString(); //
                SubInput.Text += sb.Append(subInput).ToString() + Operator.Text;

                if (mainInput != null && subInput != null)
                    this.Execute(subInput.Value, mainInput.Value);
            }
            else if (subInput != null && mainInput == null)
            {
                mainInput = int.Parse(MainInput.Text);
                SubInput.Text += sb.Append(mainInput).ToString() + Operator.Text;
                this.Execute(subInput.Value, mainInput.Value);

                Operator.Text = OperatorConstants.DivideSymbol.ToString();//
                sb.Clear();

                /* Replace operator symbol*/
                int subLen = SubInput.Text.Length - 1;

                if (SubInput.Text != String.Empty
                && SubInput.Text.Substring(subLen, 1) != OperatorConstants.DivideSymbol.ToString()) //
                {
                    BinaryOperations bin = new BinaryOperations();
                    SubInput.Text = bin.OperatorReplacer(SubInput.Text, trigger);

                }
            }
            else
            {
                MessageBox.Show("An Error occured", "Warning");
            }
            isClicked = true;
            equalTrigger = false;
        }

        private void BtnEquals_Click(object sender, RoutedEventArgs e)
        {
            equalTrigger = true;

            if (subInput.HasValue == false)
            {
                subInput = int.Parse(MainInput.Text.ToString());
            }
            if (mainInput.HasValue == false)
            {
                mainInput = int.Parse(MainInput.Text.ToString());
            }

            this.Execute(subInput.Value, mainInput.Value);
           
            Operator.Text = String.Empty;
            SubInput.Text = String.Empty;
        }

        private void Execute(int _sub, int _main)
        {
            mainInput = this.PerformCalculation(_sub, _main, Operator.Text);
            MainInput.Text = mainInput.ToString();
            subInput = null;
        }

        public int PerformCalculation(int firstNumber, int secondNumber, string operatorSymbol)
        {
            BinaryOperations execute = new BinaryOperations();

            if (operatorSymbol == OperatorConstants.AddSymbol.ToString())
            {
                secondNumber = execute.Addition(firstNumber, secondNumber);

                return secondNumber;
            }
            else if (operatorSymbol == OperatorConstants.SubtractSymbol.ToString())
            {
                secondNumber = execute.Subtraction(firstNumber, secondNumber);

                return secondNumber;
            }
            else if (operatorSymbol == OperatorConstants.DivideSymbol.ToString())
            {
                secondNumber = execute.Division(firstNumber, secondNumber);

                return secondNumber;
            }
            else if (operatorSymbol == OperatorConstants.MultiplySymbol.ToString())
            {
                secondNumber = execute.Multiplication(firstNumber, secondNumber);

                return secondNumber;
            }
            else
            {
                return 0;
            }
        }

    }
}
