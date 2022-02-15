using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

/*
 * Program is a calculator that can handle multiple operations
 * 
 * By Viktor Lundberg (viktlund104)
 * 2022-02-15
 */

namespace DVGB07_viktlund104_Laboration2_Miniraknare
{
	public partial class MainForm : Form
	{
		// Variables
		private double firstNumber; // input gets stored here when pressing operators
		private double secondNumber; // when clicking equal the input gets stored here instead
		private double sum; // the sum of the calculations so far
		private string newOperation = ""; // the next operation the user wants to do
		private string lastOperation = ""; // remember the last operation the user wanted to do
		private int firstInput = 0; // the absolute first input needs to be handled a little bit different

		// Initialize form
		public MainForm()
		{
			InitializeComponent();
		}

		// Fetch button click, this event is used by all the buttons 0 to 9
		private void numberButton_Click(object sender, EventArgs e)
		{
			Button button = (Button) sender; // sender is what object was clicked
			displayInputTextBox.Text += button.Text; // update display with the number we click
			displayMemoryTextBox.Text += button.Text; // also update the "memory" display slot
		}

		// Fetch function button click. This event is called by all the operators
		private void functionButton_Click(object sender, EventArgs e)
		{
			Button button = (Button) sender; // store the object that was clicked

			try
			{
				firstNumber = Double.Parse(displayInputTextBox.Text); // whatever we have in the display, make a number
			}
			catch (Exception exception)
			{
				// special case, user wants to do the first calc with negative number
				if (firstInput == 0 && button.Text == "-")
				{
					firstNumber = 0;
				}
				else
				{
					MessageBox.Show(exception.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
					return; // exit
				}
			}

			newOperation = button.Text; // find out which operation user wants to do
			displayInputTextBox.Text = ""; // clear input field, so we can use the function again next time we click
			displayMemoryTextBox.Text += $" {newOperation} "; // display the operation in memory box

			// Check if input was the absolute first after program launch or clear
			if (firstInput == 0)
			{
				sum = firstNumber; // sum is now whatever the user entered
				firstInput++; // to avoid running into this function again
				lastOperation = newOperation; // we want to "backtrack" the operation to enable multi calculations
			}
			// Do math
			else
			{
				switch (lastOperation)
				{
					case "+":
						sum += firstNumber;
						break;
					case "-":
						sum -= firstNumber;
						break;
					case "*":
						sum *= firstNumber;
						break;
					case "/":
						if (firstNumber == 0)
						{
							MessageBox.Show("Division with 0, please don't do that. Now you have to start over.", "Division with 0", MessageBoxButtons.OK, MessageBoxIcon.Information);
							clearButton_Click(null, null);
							return;
						}
						sum /= firstNumber;
						break;
				}

				lastOperation = newOperation; // replace the operation with the next one
			}
		}

		// Clear, only called when clicking the clear button
		private void clearButton_Click(object sender, EventArgs e)
		{
			displayInputTextBox.Text = "";
			displayMemoryTextBox.Text = "";
			firstInput = 0;
		}

		// Equals
		private void equalsButton_Click(object sender, EventArgs e)
		{
			try
			{
				secondNumber = Double.Parse(displayInputTextBox.Text); // remember what we wrote before clicking equals
			}
			catch (Exception exception)
			{
				MessageBox.Show(exception.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
				return; // exit
			}

			// Do math
			switch (newOperation)
			{
				case "+":
					displayInputTextBox.Text = (sum + secondNumber).ToString();
					break;
				case "-":
					displayInputTextBox.Text = (sum - secondNumber).ToString();
					break;
				case "*":
					displayInputTextBox.Text = (sum * secondNumber).ToString();
					break;
				case "/":
					if (secondNumber == 0)
					{
						MessageBox.Show("Division with 0, please don't do that. Now you have to start over.", "Division with 0", MessageBoxButtons.OK, MessageBoxIcon.Information);
						clearButton_Click(null, null);
						return;
					}
					displayInputTextBox.Text = (sum / secondNumber).ToString();
					break;
			}
		}
	}
}