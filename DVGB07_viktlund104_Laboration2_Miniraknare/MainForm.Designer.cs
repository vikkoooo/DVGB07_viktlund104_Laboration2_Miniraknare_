namespace DVGB07_viktlund104_Laboration2_Miniraknare
{
	partial class MainForm
	{
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}

			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			this.displayInputTextBox = new System.Windows.Forms.TextBox();
			this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
			this.sevenButton = new System.Windows.Forms.Button();
			this.eightButton = new System.Windows.Forms.Button();
			this.nineButton = new System.Windows.Forms.Button();
			this.fourButton = new System.Windows.Forms.Button();
			this.fiveButton = new System.Windows.Forms.Button();
			this.sixButton = new System.Windows.Forms.Button();
			this.oneButton = new System.Windows.Forms.Button();
			this.twoButton = new System.Windows.Forms.Button();
			this.threeButton = new System.Windows.Forms.Button();
			this.zeroButton = new System.Windows.Forms.Button();
			this.flowLayoutPanel2 = new System.Windows.Forms.FlowLayoutPanel();
			this.clearButton = new System.Windows.Forms.Button();
			this.divisionButton = new System.Windows.Forms.Button();
			this.multiplyButton = new System.Windows.Forms.Button();
			this.minusButton = new System.Windows.Forms.Button();
			this.plusButton = new System.Windows.Forms.Button();
			this.equalsButton = new System.Windows.Forms.Button();
			this.displayMemoryTextBox = new System.Windows.Forms.TextBox();
			this.flowLayoutPanel1.SuspendLayout();
			this.flowLayoutPanel2.SuspendLayout();
			this.SuspendLayout();
			// 
			// displayInputTextBox
			// 
			this.displayInputTextBox.Location = new System.Drawing.Point(270, 7);
			this.displayInputTextBox.Name = "displayInputTextBox";
			this.displayInputTextBox.ReadOnly = true;
			this.displayInputTextBox.Size = new System.Drawing.Size(75, 20);
			this.displayInputTextBox.TabIndex = 0;
			// 
			// flowLayoutPanel1
			// 
			this.flowLayoutPanel1.Controls.Add(this.sevenButton);
			this.flowLayoutPanel1.Controls.Add(this.eightButton);
			this.flowLayoutPanel1.Controls.Add(this.nineButton);
			this.flowLayoutPanel1.Controls.Add(this.fourButton);
			this.flowLayoutPanel1.Controls.Add(this.fiveButton);
			this.flowLayoutPanel1.Controls.Add(this.sixButton);
			this.flowLayoutPanel1.Controls.Add(this.oneButton);
			this.flowLayoutPanel1.Controls.Add(this.twoButton);
			this.flowLayoutPanel1.Controls.Add(this.threeButton);
			this.flowLayoutPanel1.Controls.Add(this.zeroButton);
			this.flowLayoutPanel1.Location = new System.Drawing.Point(14, 33);
			this.flowLayoutPanel1.Name = "flowLayoutPanel1";
			this.flowLayoutPanel1.Size = new System.Drawing.Size(247, 180);
			this.flowLayoutPanel1.TabIndex = 1;
			// 
			// sevenButton
			// 
			this.sevenButton.Location = new System.Drawing.Point(3, 3);
			this.sevenButton.Name = "sevenButton";
			this.sevenButton.Size = new System.Drawing.Size(75, 23);
			this.sevenButton.TabIndex = 0;
			this.sevenButton.Text = "7";
			this.sevenButton.UseVisualStyleBackColor = true;
			this.sevenButton.Click += new System.EventHandler(this.numberButton_Click);
			// 
			// eightButton
			// 
			this.eightButton.Location = new System.Drawing.Point(84, 3);
			this.eightButton.Name = "eightButton";
			this.eightButton.Size = new System.Drawing.Size(75, 23);
			this.eightButton.TabIndex = 1;
			this.eightButton.Text = "8";
			this.eightButton.UseVisualStyleBackColor = true;
			this.eightButton.Click += new System.EventHandler(this.numberButton_Click);
			// 
			// nineButton
			// 
			this.nineButton.Location = new System.Drawing.Point(165, 3);
			this.nineButton.Name = "nineButton";
			this.nineButton.Size = new System.Drawing.Size(75, 23);
			this.nineButton.TabIndex = 2;
			this.nineButton.Text = "9";
			this.nineButton.UseVisualStyleBackColor = true;
			this.nineButton.Click += new System.EventHandler(this.numberButton_Click);
			// 
			// fourButton
			// 
			this.fourButton.Location = new System.Drawing.Point(3, 32);
			this.fourButton.Name = "fourButton";
			this.fourButton.Size = new System.Drawing.Size(75, 23);
			this.fourButton.TabIndex = 3;
			this.fourButton.Text = "4";
			this.fourButton.UseVisualStyleBackColor = true;
			this.fourButton.Click += new System.EventHandler(this.numberButton_Click);
			// 
			// fiveButton
			// 
			this.fiveButton.Location = new System.Drawing.Point(84, 32);
			this.fiveButton.Name = "fiveButton";
			this.fiveButton.Size = new System.Drawing.Size(75, 23);
			this.fiveButton.TabIndex = 5;
			this.fiveButton.Text = "5";
			this.fiveButton.UseVisualStyleBackColor = true;
			this.fiveButton.Click += new System.EventHandler(this.numberButton_Click);
			// 
			// sixButton
			// 
			this.sixButton.Location = new System.Drawing.Point(165, 32);
			this.sixButton.Name = "sixButton";
			this.sixButton.Size = new System.Drawing.Size(75, 23);
			this.sixButton.TabIndex = 6;
			this.sixButton.Text = "6";
			this.sixButton.UseVisualStyleBackColor = true;
			this.sixButton.Click += new System.EventHandler(this.numberButton_Click);
			// 
			// oneButton
			// 
			this.oneButton.Location = new System.Drawing.Point(3, 61);
			this.oneButton.Name = "oneButton";
			this.oneButton.Size = new System.Drawing.Size(75, 23);
			this.oneButton.TabIndex = 7;
			this.oneButton.Text = "1";
			this.oneButton.UseVisualStyleBackColor = true;
			this.oneButton.Click += new System.EventHandler(this.numberButton_Click);
			// 
			// twoButton
			// 
			this.twoButton.Location = new System.Drawing.Point(84, 61);
			this.twoButton.Name = "twoButton";
			this.twoButton.Size = new System.Drawing.Size(75, 23);
			this.twoButton.TabIndex = 8;
			this.twoButton.Text = "2";
			this.twoButton.UseVisualStyleBackColor = true;
			this.twoButton.Click += new System.EventHandler(this.numberButton_Click);
			// 
			// threeButton
			// 
			this.threeButton.Location = new System.Drawing.Point(165, 61);
			this.threeButton.Name = "threeButton";
			this.threeButton.Size = new System.Drawing.Size(75, 23);
			this.threeButton.TabIndex = 9;
			this.threeButton.Text = "3";
			this.threeButton.UseVisualStyleBackColor = true;
			this.threeButton.Click += new System.EventHandler(this.numberButton_Click);
			// 
			// zeroButton
			// 
			this.zeroButton.Location = new System.Drawing.Point(3, 90);
			this.zeroButton.Name = "zeroButton";
			this.zeroButton.Size = new System.Drawing.Size(75, 23);
			this.zeroButton.TabIndex = 10;
			this.zeroButton.Text = "0";
			this.zeroButton.UseVisualStyleBackColor = true;
			this.zeroButton.Click += new System.EventHandler(this.numberButton_Click);
			// 
			// flowLayoutPanel2
			// 
			this.flowLayoutPanel2.Controls.Add(this.clearButton);
			this.flowLayoutPanel2.Controls.Add(this.divisionButton);
			this.flowLayoutPanel2.Controls.Add(this.multiplyButton);
			this.flowLayoutPanel2.Controls.Add(this.minusButton);
			this.flowLayoutPanel2.Controls.Add(this.plusButton);
			this.flowLayoutPanel2.Controls.Add(this.equalsButton);
			this.flowLayoutPanel2.Location = new System.Drawing.Point(267, 33);
			this.flowLayoutPanel2.Name = "flowLayoutPanel2";
			this.flowLayoutPanel2.Size = new System.Drawing.Size(81, 180);
			this.flowLayoutPanel2.TabIndex = 2;
			// 
			// clearButton
			// 
			this.clearButton.Location = new System.Drawing.Point(3, 3);
			this.clearButton.Name = "clearButton";
			this.clearButton.Size = new System.Drawing.Size(75, 23);
			this.clearButton.TabIndex = 0;
			this.clearButton.Text = "C";
			this.clearButton.UseVisualStyleBackColor = true;
			this.clearButton.Click += new System.EventHandler(this.clearButton_Click);
			// 
			// divisionButton
			// 
			this.divisionButton.Location = new System.Drawing.Point(3, 32);
			this.divisionButton.Name = "divisionButton";
			this.divisionButton.Size = new System.Drawing.Size(75, 23);
			this.divisionButton.TabIndex = 1;
			this.divisionButton.Text = "/";
			this.divisionButton.UseVisualStyleBackColor = true;
			this.divisionButton.Click += new System.EventHandler(this.functionButton_Click);
			// 
			// multiplyButton
			// 
			this.multiplyButton.Location = new System.Drawing.Point(3, 61);
			this.multiplyButton.Name = "multiplyButton";
			this.multiplyButton.Size = new System.Drawing.Size(75, 23);
			this.multiplyButton.TabIndex = 2;
			this.multiplyButton.Text = "*";
			this.multiplyButton.UseVisualStyleBackColor = true;
			this.multiplyButton.Click += new System.EventHandler(this.functionButton_Click);
			// 
			// minusButton
			// 
			this.minusButton.Location = new System.Drawing.Point(3, 90);
			this.minusButton.Name = "minusButton";
			this.minusButton.Size = new System.Drawing.Size(75, 23);
			this.minusButton.TabIndex = 3;
			this.minusButton.Text = "-";
			this.minusButton.UseVisualStyleBackColor = true;
			this.minusButton.Click += new System.EventHandler(this.functionButton_Click);
			// 
			// plusButton
			// 
			this.plusButton.Location = new System.Drawing.Point(3, 119);
			this.plusButton.Name = "plusButton";
			this.plusButton.Size = new System.Drawing.Size(75, 23);
			this.plusButton.TabIndex = 4;
			this.plusButton.Text = "+";
			this.plusButton.UseVisualStyleBackColor = true;
			this.plusButton.Click += new System.EventHandler(this.functionButton_Click);
			// 
			// equalsButton
			// 
			this.equalsButton.Location = new System.Drawing.Point(3, 148);
			this.equalsButton.Name = "equalsButton";
			this.equalsButton.Size = new System.Drawing.Size(75, 23);
			this.equalsButton.TabIndex = 5;
			this.equalsButton.Text = "=";
			this.equalsButton.UseVisualStyleBackColor = true;
			this.equalsButton.Click += new System.EventHandler(this.equalsButton_Click);
			// 
			// displayMemoryTextBox
			// 
			this.displayMemoryTextBox.Location = new System.Drawing.Point(17, 7);
			this.displayMemoryTextBox.Name = "displayMemoryTextBox";
			this.displayMemoryTextBox.ReadOnly = true;
			this.displayMemoryTextBox.Size = new System.Drawing.Size(237, 20);
			this.displayMemoryTextBox.TabIndex = 0;
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(362, 224);
			this.Controls.Add(this.flowLayoutPanel2);
			this.Controls.Add(this.flowLayoutPanel1);
			this.Controls.Add(this.displayMemoryTextBox);
			this.Controls.Add(this.displayInputTextBox);
			this.Name = "MainForm";
			this.Text = "Calculator";
			this.flowLayoutPanel1.ResumeLayout(false);
			this.flowLayoutPanel2.ResumeLayout(false);
			this.ResumeLayout(false);
			this.PerformLayout();
		}

		private System.Windows.Forms.TextBox displayMemoryTextBox;

		private System.Windows.Forms.Button equalsButton;

		private System.Windows.Forms.Button divisionButton;
		private System.Windows.Forms.Button multiplyButton;
		private System.Windows.Forms.Button minusButton;
		private System.Windows.Forms.Button plusButton;

		private System.Windows.Forms.Button clearButton;

		private System.Windows.Forms.Button zeroButton;

		private System.Windows.Forms.Button fiveButton;
		private System.Windows.Forms.Button sixButton;
		private System.Windows.Forms.Button oneButton;
		private System.Windows.Forms.Button twoButton;
		private System.Windows.Forms.Button threeButton;

		private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel2;

		private System.Windows.Forms.Button sevenButton;
		private System.Windows.Forms.Button eightButton;
		private System.Windows.Forms.Button nineButton;
		private System.Windows.Forms.Button fourButton;

		private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;

		private System.Windows.Forms.TextBox displayInputTextBox;

		#endregion
	}
}