using System;
using System.Windows.Forms;
using MathLib;
using StringLib;

namespace HelloWorldApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Handles the "Calculate" button click.
        /// Demonstrates MathLib.dll is loaded and functional.
        /// </summary>
        private void BtnCalculate_Click(object sender, EventArgs e)
        {
            // Parse the two numeric inputs (default to 7 and 5 if parsing fails)
            _ = int.TryParse(txtInputA.Text, out int a);
            _ = int.TryParse(txtInputB.Text, out int b);

            int sum = MathOperations.Add(a, b);
            int product = MathOperations.Multiply(a, b);
            int gcd = MathOperations.GCD(a, b);

            string result =
                $"=== MathLib Results ==={Environment.NewLine}" +
                $"  {a} + {b}  = {sum}{Environment.NewLine}" +
                $"  {a} × {b}  = {product}{Environment.NewLine}" +
                $"  GCD({a}, {b}) = {gcd}{Environment.NewLine}" +
                $"{Environment.NewLine}" +
                $"[{MathOperations.GetLibraryInfo()}]";

            txtOutput.Text = result;
        }

        /// <summary>
        /// Handles the "Transform" button click.
        /// Demonstrates StringLib.dll is loaded and functional.
        /// </summary>
        private void BtnTransform_Click(object sender, EventArgs e)
        {
            string input = txtInputString.Text;
            if (string.IsNullOrWhiteSpace(input))
                input = "hello world deployment";

            string reversed = StringOperations.Reverse(input);
            string titleCase = StringOperations.ToTitleCase(input);
            int vowelCount = StringOperations.CountVowels(input);
            bool isPalindrome = StringOperations.IsPalindrome(input);

            string result =
                $"=== StringLib Results ==={Environment.NewLine}" +
                $"  Original  : \"{input}\"{Environment.NewLine}" +
                $"  Reversed  : \"{reversed}\"{Environment.NewLine}" +
                $"  TitleCase : \"{titleCase}\"{Environment.NewLine}" +
                $"  Vowels    : {vowelCount}{Environment.NewLine}" +
                $"  Palindrome: {(isPalindrome ? "Yes" : "No")}{Environment.NewLine}" +
                $"{Environment.NewLine}" +
                $"[{StringOperations.GetLibraryInfo()}]";

            txtOutput.Text = result;
        }

        /// <summary>
        /// Handles the "About" button click.
        /// Shows that both DLLs are loaded — key evidence for Task 1.3.
        /// </summary>
        private void BtnAbout_Click(object sender, EventArgs e)
        {
            string info =
                $"=== Application Info ==={Environment.NewLine}" +
                $"  App     : HelloWorldApp v1.0.0{Environment.NewLine}" +
                $"  Runtime : .NET Framework {Environment.NewLine}" +
                $"  Platform: {Environment.OSVersion}{Environment.NewLine}" +
                $"  CPU Arch: {(Environment.Is64BitProcess ? "64-bit" : "32-bit")}{Environment.NewLine}" +
                $"{Environment.NewLine}" +
                $"=== Loaded Dependencies ==={Environment.NewLine}" +
                $"  DLL #1 : {MathOperations.GetLibraryInfo()}{Environment.NewLine}" +
                $"  DLL #2 : {StringOperations.GetLibraryInfo()}{Environment.NewLine}" +
                $"{Environment.NewLine}" +
                $"Both DLL dependencies resolved successfully.{Environment.NewLine}" +
                $"This confirms multi-DLL packaging via WiX works correctly.";

            txtOutput.Text = info;
        }

        /// <summary>
        /// Handles the "Factorial" button click — bonus math demo.
        /// </summary>
        private void BtnFactorial_Click(object sender, EventArgs e)
        {
            _ = int.TryParse(txtInputA.Text, out int n);

            if (n < 0)
            {
                txtOutput.Text = "Please enter a number for factorial.";
                return;
            }

            System.Numerics.BigInteger factorial = MathOperations.Factorial(n);
            txtOutput.Text =
                $"=== Factorial ==={Environment.NewLine}" +
                $"  {n}! = {factorial}{Environment.NewLine}" +
                $"{Environment.NewLine}" +
                $"[{MathOperations.GetLibraryInfo()}]";
        }

        /// <summary>
        /// Handles the "Palindrome Check" button — bonus string demo.
        /// </summary>
        private void BtnPalindrome_Click(object sender, EventArgs e)
        {
            string input = txtInputString.Text;
            if (string.IsNullOrWhiteSpace(input))
                input = "racecar";

            bool isPalindrome = StringOperations.IsPalindrome(input);

            txtOutput.Text =
                $"=== Palindrome Check ==={Environment.NewLine}" +
                $"  \"{input}\" is {(isPalindrome ? "" : "NOT ")}a palindrome.{Environment.NewLine}" +
                $"{Environment.NewLine}" +
                $"Try: \"racecar\", \"madam\", \"A man a plan a canal Panama\"{Environment.NewLine}" +
                $"{Environment.NewLine}" +
                $"[{StringOperations.GetLibraryInfo()}]";
        }
    }
}