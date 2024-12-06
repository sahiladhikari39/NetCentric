using System;
using System.Windows.Forms;

namespace calculator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            // Initialize the ComboBox with operations
            comboBox1.Items.Add("Add");
            comboBox1.Items.Add("Subtract");
            comboBox1.Items.Add("Multiply");
            comboBox1.Items.Add("Divide");
            comboBox1.Items.Add("Modulus");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            // Get the numbers from the text boxes
            if (double.TryParse(textBox1.Text, out double number1) && double.TryParse(textBox2.Text, out double number2))
            {
                // Check if an item is selected in the ComboBox
                if (comboBox1.SelectedItem == null)
                {
                    MessageBox.Show("Please select an operation.");
                    return;
                }

                // Get the selected operation
                string operation = comboBox1.SelectedItem.ToString();
                double result = 0;

                // Perform the selected operation
                switch (operation)
                {
                    case "Add":
                        result = number1 + number2;
                        break;
                    case "Subtract":
                        result = number1 - number2;
                        break;
                    case "Multiply":
                        result = number1 * number2;
                        break;
                    case "Divide":
                        if (number2 != 0)
                        {
                            result = number1 / number2;
                        }
                        else
                        {
                            MessageBox.Show("Cannot divide by zero.");
                            return;
                        }
                        break;
                    case "Modulus":
                        result = number1 % number2;
                        break;
                    default:
                        MessageBox.Show("Invalid operation.");
                        return;
                }

                // Create a new form to display the result
                Form resultForm = new Form()
                {
                    Text = "Result",
                    Size = new System.Drawing.Size(300, 200)
                };

                // Create a label to display the result
                Label resultLabel = new Label()
                {
                    Text = $"Result: {result}",
                    AutoSize = true,
                    Location = new System.Drawing.Point(20, 20)
                };

                // Add the label to the new form
                resultForm.Controls.Add(resultLabel);

                // Show the new form
                resultForm.Show();
            }
            else
            {
                MessageBox.Show("Please enter valid numbers.");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Clear the text boxes and ComboBox
            textBox1.Clear();
            textBox2.Clear();
            comboBox1.SelectedIndex = -1; // Deselect any selected item
        }


        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}