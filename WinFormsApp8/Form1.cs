namespace WinFormsApp8
{
    public partial class Form1 : Form
    {
        double result = 0;
        string operation = "";
        bool valueEntered = false;

        public Form1()
        {
            InitializeComponent();
        }

        private void Numbers_Only(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            if (tbox_Display.Text == "0" || valueEntered)
                tbox_Display.Text = "";
            valueEntered = false;
            if (button.Text == ".")
            {
                if (!tbox_Display.Text.Contains("."))
                    tbox_Display.Text += button.Text;

            }
            else
            {
                tbox_Display.Text += button.Text;

            }

        }

        private void Operations_only(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            if (result != 0)
            {
                btn_Equal.PerformClick();
                valueEntered = true;
                operation = button.Text;
                lbl_ShowOperations.Text = Convert.ToString(result) + "   " + operation;

            }
            else
            {
                operation = button.Text;
                result = double.Parse(tbox_Display.Text);
                tbox_Display.Text = "";
                lbl_ShowOperations.Text = Convert.ToString(result) + "   " + operation;
            }
        }

        private void btn_C_Click(object sender, EventArgs e)
        {
            tbox_Display.Text = "0";
            result = 0;

        }

        private void btn_Ce_Click(object sender, EventArgs e)
        {
            tbox_Display.Text = "0";
        }

        private void btn_Equal_Click(object sender, EventArgs e)
        {
            lbl_ShowOperations.Text = "";
            switch (operation)
            {
                case "+":
                    tbox_Display.Text = (result + double.Parse(tbox_Display.Text)).ToString();
                    break;
                case "-":
                    tbox_Display.Text = (result - double.Parse(tbox_Display.Text)).ToString();
                    break;
                case "*":
                    tbox_Display.Text = (result * double.Parse(tbox_Display.Text)).ToString();
                    break;
                case "/":
                    if (double.Parse(tbox_Display.Text) != 0)
                    {
                        tbox_Display.Text = (result / double.Parse(tbox_Display.Text)).ToString();
                    }
                    else
                    {
                        MessageBox.Show("Divide by zero is not acceptable");
                    }
                    break;
                default:
                    break;
            }
            result = double.Parse(tbox_Display.Text);
            operation = "";
        }

        private void btn_Clear_Click(object sender, EventArgs e)
        {
            if (tbox_Display.Text.Length > 0)
            {
                tbox_Display.Text = tbox_Display.Text.Remove(tbox_Display.Text.Length - 1, 1);
            }
            if (tbox_Display.Text == "")
            {
                tbox_Display.Text = "0";
            }
        }

        private void btn_Sqrt_Click(object sender, EventArgs e)
        {
            if (result == 0)
            {
                result = (Math.Sqrt(double.Parse(tbox_Display.Text)));
                tbox_Display.Text = result.ToString();


            }
            else
            {
                tbox_Display.Text = (Math.Sqrt(result)).ToString();
            }
        }

        private void btn_Power_Click(object sender, EventArgs e)
        {
            if (result == 0)
            {
                result = (Math.Pow(double.Parse(tbox_Display.Text), 2));
                tbox_Display.Text = result.ToString();


            }
            else
            {
                tbox_Display.Text = (Math.Pow(double.Parse(tbox_Display.Text), 2)).ToString();

            }
        }

        private void btn_DivOne_Click(object sender, EventArgs e)
        {
            if (result == 0)
            {
                result = (1 / (double.Parse(tbox_Display.Text)));
                tbox_Display.Text = result.ToString();


            }
            else
            {
                tbox_Display.Text = (1 / (double.Parse(tbox_Display.Text))).ToString();

            }
        }

        bool isClicked = false;
        private void btn_PlusMinus_Click(object sender, EventArgs e)
        {
            isClicked = true;
            if (isClicked)
            {
                if (result == 0)
                {
                    result = ((double.Parse(tbox_Display.Text)) * (-1));
                    tbox_Display.Text = result.ToString();

                }
                else
                {
                    tbox_Display.Text = (-1 * (double.Parse(tbox_Display.Text))).ToString();

                }
            }
        }
    }
}