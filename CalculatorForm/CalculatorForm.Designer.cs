namespace CalculatorForm
{
    partial class CalculatorForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            resultTextBox = new TextBox();
            squareRootButton = new Button();
            squareButton = new Button();
            multiplyButton = new Button();
            divideButton = new Button();
            substractButton = new Button();
            addButton = new Button();
            yInput = new NumericUpDown();
            xInput = new NumericUpDown();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            ((System.ComponentModel.ISupportInitialize)yInput).BeginInit();
            ((System.ComponentModel.ISupportInitialize)xInput).BeginInit();
            SuspendLayout();
            // 
            // resultTextBox
            // 
            resultTextBox.Location = new Point(60, 380);
            resultTextBox.Name = "resultTextBox";
            resultTextBox.Size = new Size(125, 27);
            resultTextBox.TabIndex = 23;
            resultTextBox.Text = "result";
            // 
            // squareRootButton
            // 
            squareRootButton.Location = new Point(30, 329);
            squareRootButton.Name = "squareRootButton";
            squareRootButton.Size = new Size(135, 29);
            squareRootButton.TabIndex = 22;
            squareRootButton.Text = "Square Root";
            squareRootButton.UseVisualStyleBackColor = true;
            squareRootButton.Click += squareRootButton_Click;
            // 
            // squareButton
            // 
            squareButton.Location = new Point(30, 284);
            squareButton.Name = "squareButton";
            squareButton.Size = new Size(135, 29);
            squareButton.TabIndex = 21;
            squareButton.Text = "Square";
            squareButton.UseVisualStyleBackColor = true;
            squareButton.Click += squareButton_Click;
            // 
            // multiplyButton
            // 
            multiplyButton.Location = new Point(30, 194);
            multiplyButton.Name = "multiplyButton";
            multiplyButton.Size = new Size(135, 29);
            multiplyButton.TabIndex = 20;
            multiplyButton.Text = "Multiply";
            multiplyButton.UseVisualStyleBackColor = true;
            multiplyButton.Click += multiplyButton_Click;
            // 
            // divideButton
            // 
            divideButton.Location = new Point(30, 240);
            divideButton.Name = "divideButton";
            divideButton.Size = new Size(135, 29);
            divideButton.TabIndex = 19;
            divideButton.Text = "Divide";
            divideButton.UseVisualStyleBackColor = true;
            divideButton.Click += this.divideButton_Click;
            // 
            // substractButton
            // 
            substractButton.Location = new Point(30, 148);
            substractButton.Name = "substractButton";
            substractButton.Size = new Size(135, 29);
            substractButton.TabIndex = 18;
            substractButton.Text = "Substract";
            substractButton.UseVisualStyleBackColor = true;
            substractButton.Click += substractButton_Click;
            // 
            // addButton
            // 
            addButton.Location = new Point(30, 102);
            addButton.Name = "addButton";
            addButton.Size = new Size(135, 29);
            addButton.TabIndex = 17;
            addButton.Text = "Add";
            addButton.UseVisualStyleBackColor = true;
            addButton.Click += addButton_Click;
            // 
            // yInput
            // 
            yInput.Location = new Point(71, 49);
            yInput.Name = "yInput";
            yInput.Size = new Size(69, 27);
            yInput.TabIndex = 16;
            // 
            // xInput
            // 
            xInput.Location = new Point(71, 12);
            xInput.Name = "xInput";
            xInput.Size = new Size(69, 27);
            xInput.TabIndex = 15;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(30, 383);
            label3.Name = "label3";
            label3.Size = new Size(19, 20);
            label3.TabIndex = 14;
            label3.Text = "=";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(41, 51);
            label2.Name = "label2";
            label2.Size = new Size(19, 20);
            label2.TabIndex = 13;
            label2.Text = "y:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(41, 14);
            label1.Name = "label1";
            label1.Size = new Size(19, 20);
            label1.TabIndex = 12;
            label1.Text = "x:";
            // 
            // CalculatorForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(214, 450);
            Controls.Add(resultTextBox);
            Controls.Add(squareRootButton);
            Controls.Add(squareButton);
            Controls.Add(multiplyButton);
            Controls.Add(divideButton);
            Controls.Add(substractButton);
            Controls.Add(addButton);
            Controls.Add(yInput);
            Controls.Add(xInput);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "CalculatorForm";
            Text = "CalculatorForm";
            ((System.ComponentModel.ISupportInitialize)yInput).EndInit();
            ((System.ComponentModel.ISupportInitialize)xInput).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox resultTextBox;
        private Button squareRootButton;
        private Button squareButton;
        private Button multiplyButton;
        private Button divideButton;
        private Button substractButton;
        private Button addButton;
        private NumericUpDown yInput;
        private NumericUpDown xInput;
        private Label label3;
        private Label label2;
        private Label label1;
    }
}
