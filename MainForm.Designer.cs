namespace Ex2
{
    partial class MainForm
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
            calculateButton = new Button();
            tableLayoutPanel1 = new TableLayoutPanel();
            inputField = new TextBox();
            numButton0 = new Button();
            numButton1 = new Button();
            numButton2 = new Button();
            numButton3 = new Button();
            numButton4 = new Button();
            numButton5 = new Button();
            numButton6 = new Button();
            numButton7 = new Button();
            numButton8 = new Button();
            numButton9 = new Button();
            multiplyButton = new Button();
            divideButton = new Button();
            minusButton = new Button();
            plusButton = new Button();
            bracketsButton = new Button();
            clearButton = new Button();
            eraseButton = new Button();
            comaButton = new Button();
            degreeButton = new Button();
            menu = new MenuStrip();
            uploadMenuButton = new ToolStripMenuItem();
            saveMenuButton = new ToolStripMenuItem();
            tableLayoutPanel1.SuspendLayout();
            menu.SuspendLayout();
            SuspendLayout();
            // 
            // calculateButton
            // 
            calculateButton.Dock = DockStyle.Fill;
            calculateButton.FlatAppearance.BorderSize = 0;
            calculateButton.Font = new Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point);
            calculateButton.ForeColor = SystemColors.ControlText;
            calculateButton.Location = new Point(434, 434);
            calculateButton.Name = "calculateButton";
            calculateButton.Size = new Size(134, 77);
            calculateButton.TabIndex = 18;
            calculateButton.Text = "=";
            calculateButton.UseVisualStyleBackColor = true;
            calculateButton.Click += calculateButton_Click;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.CellBorderStyle = TableLayoutPanelCellBorderStyle.Single;
            tableLayoutPanel1.ColumnCount = 4;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            tableLayoutPanel1.Controls.Add(inputField, 0, 0);
            tableLayoutPanel1.Controls.Add(numButton0, 1, 5);
            tableLayoutPanel1.Controls.Add(calculateButton, 3, 5);
            tableLayoutPanel1.Controls.Add(numButton1, 0, 4);
            tableLayoutPanel1.Controls.Add(numButton2, 1, 4);
            tableLayoutPanel1.Controls.Add(numButton3, 2, 4);
            tableLayoutPanel1.Controls.Add(numButton4, 0, 3);
            tableLayoutPanel1.Controls.Add(numButton5, 1, 3);
            tableLayoutPanel1.Controls.Add(numButton6, 2, 3);
            tableLayoutPanel1.Controls.Add(numButton7, 0, 2);
            tableLayoutPanel1.Controls.Add(numButton8, 1, 2);
            tableLayoutPanel1.Controls.Add(numButton9, 2, 2);
            tableLayoutPanel1.Controls.Add(multiplyButton, 3, 2);
            tableLayoutPanel1.Controls.Add(divideButton, 3, 1);
            tableLayoutPanel1.Controls.Add(minusButton, 3, 3);
            tableLayoutPanel1.Controls.Add(plusButton, 3, 4);
            tableLayoutPanel1.Controls.Add(bracketsButton, 2, 1);
            tableLayoutPanel1.Controls.Add(clearButton, 0, 1);
            tableLayoutPanel1.Controls.Add(eraseButton, 1, 1);
            tableLayoutPanel1.Controls.Add(comaButton, 2, 5);
            tableLayoutPanel1.Controls.Add(degreeButton, 0, 5);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(0, 28);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.Padding = new Padding(10);
            tableLayoutPanel1.RowCount = 6;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 16.666666F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 16.666666F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 16.666666F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 16.666666F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 16.666666F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 16.666666F));
            tableLayoutPanel1.Size = new Size(582, 525);
            tableLayoutPanel1.TabIndex = 1;
            // 
            // inputField
            // 
            inputField.BorderStyle = BorderStyle.None;
            inputField.CharacterCasing = CharacterCasing.Lower;
            tableLayoutPanel1.SetColumnSpan(inputField, 4);
            inputField.Dock = DockStyle.Fill;
            inputField.Font = new Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point);
            inputField.Location = new Point(11, 11);
            inputField.Margin = new Padding(0);
            inputField.MaxLength = 60;
            inputField.Multiline = true;
            inputField.Name = "inputField";
            inputField.Size = new Size(560, 83);
            inputField.TabIndex = 0;
            inputField.TextChanged += inputField_TextChanged;
            inputField.KeyPress += inputField_KeyPress;
            // 
            // numButton0
            // 
            numButton0.Dock = DockStyle.Fill;
            numButton0.Font = new Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point);
            numButton0.Location = new Point(154, 434);
            numButton0.Name = "numButton0";
            numButton0.Size = new Size(133, 77);
            numButton0.TabIndex = 1;
            numButton0.Text = "0";
            numButton0.UseVisualStyleBackColor = true;
            numButton0.Click += numAndOperationButtons_Click;
            // 
            // numButton1
            // 
            numButton1.Dock = DockStyle.Fill;
            numButton1.Font = new Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point);
            numButton1.Location = new Point(14, 350);
            numButton1.Name = "numButton1";
            numButton1.Size = new Size(133, 77);
            numButton1.TabIndex = 2;
            numButton1.Text = "1";
            numButton1.UseVisualStyleBackColor = true;
            numButton1.Click += numAndOperationButtons_Click;
            // 
            // numButton2
            // 
            numButton2.Dock = DockStyle.Fill;
            numButton2.Font = new Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point);
            numButton2.Location = new Point(154, 350);
            numButton2.Name = "numButton2";
            numButton2.Size = new Size(133, 77);
            numButton2.TabIndex = 3;
            numButton2.Text = "2";
            numButton2.UseVisualStyleBackColor = true;
            numButton2.Click += numAndOperationButtons_Click;
            // 
            // numButton3
            // 
            numButton3.Dock = DockStyle.Fill;
            numButton3.Font = new Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point);
            numButton3.Location = new Point(294, 350);
            numButton3.Name = "numButton3";
            numButton3.Size = new Size(133, 77);
            numButton3.TabIndex = 4;
            numButton3.Text = "3";
            numButton3.UseVisualStyleBackColor = true;
            numButton3.Click += numAndOperationButtons_Click;
            // 
            // numButton4
            // 
            numButton4.Dock = DockStyle.Fill;
            numButton4.Font = new Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point);
            numButton4.Location = new Point(14, 266);
            numButton4.Name = "numButton4";
            numButton4.Size = new Size(133, 77);
            numButton4.TabIndex = 5;
            numButton4.Text = "4";
            numButton4.UseVisualStyleBackColor = true;
            numButton4.Click += numAndOperationButtons_Click;
            // 
            // numButton5
            // 
            numButton5.Dock = DockStyle.Fill;
            numButton5.Font = new Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point);
            numButton5.Location = new Point(154, 266);
            numButton5.Name = "numButton5";
            numButton5.Size = new Size(133, 77);
            numButton5.TabIndex = 6;
            numButton5.Text = "5";
            numButton5.UseVisualStyleBackColor = true;
            numButton5.Click += numAndOperationButtons_Click;
            // 
            // numButton6
            // 
            numButton6.Dock = DockStyle.Fill;
            numButton6.Font = new Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point);
            numButton6.Location = new Point(294, 266);
            numButton6.Name = "numButton6";
            numButton6.Size = new Size(133, 77);
            numButton6.TabIndex = 7;
            numButton6.Text = "6";
            numButton6.UseVisualStyleBackColor = true;
            numButton6.Click += numAndOperationButtons_Click;
            // 
            // numButton7
            // 
            numButton7.Dock = DockStyle.Fill;
            numButton7.Font = new Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point);
            numButton7.Location = new Point(14, 182);
            numButton7.Name = "numButton7";
            numButton7.Size = new Size(133, 77);
            numButton7.TabIndex = 8;
            numButton7.Text = "7";
            numButton7.UseVisualStyleBackColor = true;
            numButton7.Click += numAndOperationButtons_Click;
            // 
            // numButton8
            // 
            numButton8.Dock = DockStyle.Fill;
            numButton8.Font = new Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point);
            numButton8.Location = new Point(154, 182);
            numButton8.Name = "numButton8";
            numButton8.Size = new Size(133, 77);
            numButton8.TabIndex = 9;
            numButton8.Text = "8";
            numButton8.UseVisualStyleBackColor = true;
            numButton8.Click += numAndOperationButtons_Click;
            // 
            // numButton9
            // 
            numButton9.Dock = DockStyle.Fill;
            numButton9.Font = new Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point);
            numButton9.Location = new Point(294, 182);
            numButton9.Name = "numButton9";
            numButton9.Size = new Size(133, 77);
            numButton9.TabIndex = 10;
            numButton9.Text = "9";
            numButton9.UseVisualStyleBackColor = true;
            numButton9.Click += numAndOperationButtons_Click;
            // 
            // multiplyButton
            // 
            multiplyButton.Dock = DockStyle.Fill;
            multiplyButton.Font = new Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point);
            multiplyButton.Location = new Point(434, 182);
            multiplyButton.Name = "multiplyButton";
            multiplyButton.Size = new Size(134, 77);
            multiplyButton.TabIndex = 14;
            multiplyButton.Text = "×";
            multiplyButton.UseVisualStyleBackColor = true;
            multiplyButton.Click += numAndOperationButtons_Click;
            // 
            // divideButton
            // 
            divideButton.Dock = DockStyle.Fill;
            divideButton.Font = new Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point);
            divideButton.Location = new Point(434, 98);
            divideButton.Name = "divideButton";
            divideButton.Size = new Size(134, 77);
            divideButton.TabIndex = 15;
            divideButton.Text = "÷";
            divideButton.UseVisualStyleBackColor = true;
            divideButton.Click += numAndOperationButtons_Click;
            // 
            // minusButton
            // 
            minusButton.Dock = DockStyle.Fill;
            minusButton.Font = new Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point);
            minusButton.Location = new Point(434, 266);
            minusButton.Name = "minusButton";
            minusButton.Size = new Size(134, 77);
            minusButton.TabIndex = 13;
            minusButton.Text = "−";
            minusButton.UseVisualStyleBackColor = true;
            minusButton.Click += numAndOperationButtons_Click;
            // 
            // plusButton
            // 
            plusButton.Dock = DockStyle.Fill;
            plusButton.Font = new Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point);
            plusButton.Location = new Point(434, 350);
            plusButton.Name = "plusButton";
            plusButton.Size = new Size(134, 77);
            plusButton.TabIndex = 12;
            plusButton.Text = "+";
            plusButton.UseVisualStyleBackColor = true;
            plusButton.Click += numAndOperationButtons_Click;
            // 
            // bracketsButton
            // 
            bracketsButton.Dock = DockStyle.Fill;
            bracketsButton.Font = new Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point);
            bracketsButton.Location = new Point(294, 98);
            bracketsButton.Name = "bracketsButton";
            bracketsButton.Size = new Size(133, 77);
            bracketsButton.TabIndex = 17;
            bracketsButton.Text = "( )";
            bracketsButton.UseVisualStyleBackColor = true;
            bracketsButton.Click += bracketsButton_Click;
            // 
            // clearButton
            // 
            clearButton.Dock = DockStyle.Fill;
            clearButton.Font = new Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point);
            clearButton.Location = new Point(14, 98);
            clearButton.Name = "clearButton";
            clearButton.Size = new Size(133, 77);
            clearButton.TabIndex = 20;
            clearButton.Text = "C";
            clearButton.UseVisualStyleBackColor = true;
            clearButton.Click += clearButton_Click;
            // 
            // eraseButton
            // 
            eraseButton.Dock = DockStyle.Fill;
            eraseButton.Font = new Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point);
            eraseButton.Location = new Point(154, 98);
            eraseButton.Name = "eraseButton";
            eraseButton.Size = new Size(133, 77);
            eraseButton.TabIndex = 19;
            eraseButton.Text = "⌫";
            eraseButton.UseVisualStyleBackColor = true;
            eraseButton.Click += eraseButton_Click;
            // 
            // comaButton
            // 
            comaButton.Dock = DockStyle.Fill;
            comaButton.Font = new Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point);
            comaButton.Location = new Point(294, 434);
            comaButton.Name = "comaButton";
            comaButton.Size = new Size(133, 77);
            comaButton.TabIndex = 11;
            comaButton.Text = ",";
            comaButton.UseVisualStyleBackColor = true;
            comaButton.Click += numAndOperationButtons_Click;
            // 
            // degreeButton
            // 
            degreeButton.Dock = DockStyle.Fill;
            degreeButton.Font = new Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point);
            degreeButton.Location = new Point(14, 434);
            degreeButton.Name = "degreeButton";
            degreeButton.Size = new Size(133, 77);
            degreeButton.TabIndex = 16;
            degreeButton.Text = "xⁿ";
            degreeButton.UseVisualStyleBackColor = true;
            degreeButton.Click += degreeButton_Click;
            // 
            // menu
            // 
            menu.ImageScalingSize = new Size(20, 20);
            menu.Items.AddRange(new ToolStripItem[] { uploadMenuButton, saveMenuButton });
            menu.Location = new Point(0, 0);
            menu.Name = "menu";
            menu.Size = new Size(582, 28);
            menu.TabIndex = 2;
            menu.Text = "menuStrip1";
            // 
            // uploadMenuButton
            // 
            uploadMenuButton.Name = "uploadMenuButton";
            uploadMenuButton.Size = new Size(72, 24);
            uploadMenuButton.Text = "Upload";
            // 
            // saveMenuButton
            // 
            saveMenuButton.Name = "saveMenuButton";
            saveMenuButton.Size = new Size(54, 24);
            saveMenuButton.Text = "Save";
            saveMenuButton.Click += saveMenuButton_Click;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(582, 553);
            Controls.Add(tableLayoutPanel1);
            Controls.Add(menu);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            HelpButton = true;
            MainMenuStrip = menu;
            Name = "MainForm";
            Text = "Calculator";
            FormClosing += MainForm_FormClosing;
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            menu.ResumeLayout(false);
            menu.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button calculateButton;
        private TableLayoutPanel tableLayoutPanel1;
        private Button plusButton;
        private Button minusButton;
        private Button divideButton;
        private Button multiplyButton;
        private Button numButton4;
        private Button numButton5;
        private Button numButton6;
        private Button numButton7;
        private Button numButton0;
        private Button numButton1;
        private Button numButton2;
        private Button numButton3;
        private Button numButton8;
        private Button numButton9;
        private Button bracketsButton;
        private TextBox inputField;
        private Button clearButton;
        private Button eraseButton;
        private Button comaButton;
        private Button degreeButton;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem uploadMenuButton;
        private ToolStripMenuItem saveMenuButton;
        private MenuStrip menu;
    }
}