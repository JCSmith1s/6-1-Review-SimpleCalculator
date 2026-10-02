namespace SimpleCalculator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btn_Calculate_Click(object sender, EventArgs e)
        {
            decimal operand1 = Convert.ToDecimal(txtOper1.Text);
            string operator1 = Convert.ToString(txtOperator.Text);
            decimal operand2 = Convert.ToDecimal(txtOper2.Text);

       

            decimal result = Calculate(operand1, operator1, operand2);
            txtResult.Text = result.ToString();

        }

        private decimal Calculate(decimal operand1, string operator1, decimal operand2)
        {
            return operator1 switch
            {
                "+" => operand1 + operand2,
                "-" => operand1 - operand2,
                "*" => operand1 * operand2,
                "/" => operand1 / operand2,
                "%" => operand1 % operand2,
                _ => 0,
            };

           
        }

        private void btn_Exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

    }
}
