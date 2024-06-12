namespace CalculatorImproved
{
    partial class Form1
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
            lstHistory = new ListBox();
            btnClear = new Button();
            btnSin = new Button();
            btnCos = new Button();
            btnTan = new Button();
            btnPow = new Button();
            btnRoot = new Button();
            txtCalc = new TextBox();
            btnOne = new Button();
            btnTwo = new Button();
            btnThree = new Button();
            btnFour = new Button();
            btnFive = new Button();
            btnSix = new Button();
            btnSeven = new Button();
            btnEight = new Button();
            btnNine = new Button();
            btnZero = new Button();
            btnAdd = new Button();
            btnSubtract = new Button();
            btnPoint = new Button();
            btnMultiply = new Button();
            btnDivide = new Button();
            btnEquals = new Button();
            radioButton1 = new RadioButton();
            radioButton2 = new RadioButton();
            groupBox1 = new GroupBox();
            label1 = new Label();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // lstHistory
            // 
            lstHistory.FormattingEnabled = true;
            lstHistory.ItemHeight = 15;
            lstHistory.Location = new Point(12, 32);
            lstHistory.Name = "lstHistory";
            lstHistory.Size = new Size(302, 94);
            lstHistory.TabIndex = 0;
            // 
            // btnClear
            // 
            btnClear.Font = new Font("Lucida Console", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnClear.Location = new Point(320, 132);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(58, 29);
            btnClear.TabIndex = 1;
            btnClear.Text = "Clear";
            btnClear.UseVisualStyleBackColor = true;
            btnClear.Click += btnClear_Click;
            // 
            // btnSin
            // 
            btnSin.Location = new Point(15, 167);
            btnSin.Name = "btnSin";
            btnSin.Size = new Size(54, 36);
            btnSin.TabIndex = 2;
            btnSin.Text = "Sin";
            btnSin.UseVisualStyleBackColor = true;
            btnSin.Click += btnSin_Click;
            // 
            // btnCos
            // 
            btnCos.Location = new Point(75, 167);
            btnCos.Name = "btnCos";
            btnCos.Size = new Size(54, 36);
            btnCos.TabIndex = 3;
            btnCos.Text = "Cos";
            btnCos.UseVisualStyleBackColor = true;
            btnCos.Click += btnCos_Click;
            // 
            // btnTan
            // 
            btnTan.Location = new Point(135, 167);
            btnTan.Name = "btnTan";
            btnTan.Size = new Size(54, 36);
            btnTan.TabIndex = 4;
            btnTan.Text = "Tan";
            btnTan.UseVisualStyleBackColor = true;
            btnTan.Click += btnTan_Click;
            // 
            // btnPow
            // 
            btnPow.Location = new Point(195, 167);
            btnPow.Name = "btnPow";
            btnPow.Size = new Size(54, 36);
            btnPow.TabIndex = 5;
            btnPow.Text = "x^y";
            btnPow.UseVisualStyleBackColor = true;
            btnPow.Click += btnPow_Click;
            // 
            // btnRoot
            // 
            btnRoot.Location = new Point(255, 167);
            btnRoot.Name = "btnRoot";
            btnRoot.Size = new Size(54, 36);
            btnRoot.TabIndex = 6;
            btnRoot.Text = "√x";
            btnRoot.UseVisualStyleBackColor = true;
            btnRoot.Click += btnRoot_Click;
            // 
            // txtCalc
            // 
            txtCalc.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtCalc.Location = new Point(12, 132);
            txtCalc.Name = "txtCalc";
            txtCalc.Size = new Size(302, 29);
            txtCalc.TabIndex = 1;
            // 
            // btnOne
            // 
            btnOne.Location = new Point(15, 224);
            btnOne.Name = "btnOne";
            btnOne.Size = new Size(52, 46);
            btnOne.TabIndex = 7;
            btnOne.Text = "1";
            btnOne.UseVisualStyleBackColor = true;
            btnOne.Click += btnOne_Click;
            // 
            // btnTwo
            // 
            btnTwo.Location = new Point(73, 224);
            btnTwo.Name = "btnTwo";
            btnTwo.Size = new Size(52, 46);
            btnTwo.TabIndex = 8;
            btnTwo.Text = "2";
            btnTwo.UseVisualStyleBackColor = true;
            btnTwo.Click += btnTwo_Click;
            // 
            // btnThree
            // 
            btnThree.Location = new Point(135, 224);
            btnThree.Name = "btnThree";
            btnThree.Size = new Size(52, 46);
            btnThree.TabIndex = 9;
            btnThree.Text = "3";
            btnThree.UseVisualStyleBackColor = true;
            btnThree.Click += btnThree_Click;
            // 
            // btnFour
            // 
            btnFour.Location = new Point(15, 276);
            btnFour.Name = "btnFour";
            btnFour.Size = new Size(52, 46);
            btnFour.TabIndex = 10;
            btnFour.Text = "4";
            btnFour.UseVisualStyleBackColor = true;
            btnFour.Click += btnFour_Click;
            // 
            // btnFive
            // 
            btnFive.Location = new Point(73, 276);
            btnFive.Name = "btnFive";
            btnFive.Size = new Size(52, 46);
            btnFive.TabIndex = 11;
            btnFive.Text = "5";
            btnFive.UseVisualStyleBackColor = true;
            btnFive.Click += btnFive_Click;
            // 
            // btnSix
            // 
            btnSix.Location = new Point(135, 276);
            btnSix.Name = "btnSix";
            btnSix.Size = new Size(52, 46);
            btnSix.TabIndex = 12;
            btnSix.Text = "6";
            btnSix.UseVisualStyleBackColor = true;
            btnSix.Click += btnSix_Click;
            // 
            // btnSeven
            // 
            btnSeven.Location = new Point(15, 328);
            btnSeven.Name = "btnSeven";
            btnSeven.Size = new Size(52, 46);
            btnSeven.TabIndex = 13;
            btnSeven.Text = "7";
            btnSeven.UseVisualStyleBackColor = true;
            btnSeven.Click += btnSeven_Click;
            // 
            // btnEight
            // 
            btnEight.Location = new Point(73, 328);
            btnEight.Name = "btnEight";
            btnEight.Size = new Size(52, 46);
            btnEight.TabIndex = 14;
            btnEight.Text = "8";
            btnEight.UseVisualStyleBackColor = true;
            btnEight.Click += btnEight_Click;
            // 
            // btnNine
            // 
            btnNine.Location = new Point(135, 328);
            btnNine.Name = "btnNine";
            btnNine.Size = new Size(52, 46);
            btnNine.TabIndex = 15;
            btnNine.Text = "9";
            btnNine.UseVisualStyleBackColor = true;
            btnNine.Click += btnNine_Click;
            // 
            // btnZero
            // 
            btnZero.Location = new Point(73, 380);
            btnZero.Name = "btnZero";
            btnZero.Size = new Size(52, 46);
            btnZero.TabIndex = 16;
            btnZero.Text = "0";
            btnZero.UseVisualStyleBackColor = true;
            btnZero.Click += btnZero_Click;
            // 
            // btnAdd
            // 
            btnAdd.Location = new Point(195, 224);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(54, 46);
            btnAdd.TabIndex = 17;
            btnAdd.Text = "+";
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += btnAdd_Click;
            // 
            // btnSubtract
            // 
            btnSubtract.Location = new Point(195, 276);
            btnSubtract.Name = "btnSubtract";
            btnSubtract.Size = new Size(54, 46);
            btnSubtract.TabIndex = 18;
            btnSubtract.Text = "-";
            btnSubtract.UseVisualStyleBackColor = true;
            btnSubtract.Click += btnSubtract_Click;
            // 
            // btnPoint
            // 
            btnPoint.Location = new Point(137, 380);
            btnPoint.Name = "btnPoint";
            btnPoint.Size = new Size(52, 46);
            btnPoint.TabIndex = 19;
            btnPoint.Text = ".";
            btnPoint.UseVisualStyleBackColor = true;
            btnPoint.Click += btnPoint_Click;
            // 
            // btnMultiply
            // 
            btnMultiply.Location = new Point(195, 328);
            btnMultiply.Name = "btnMultiply";
            btnMultiply.Size = new Size(54, 46);
            btnMultiply.TabIndex = 20;
            btnMultiply.Text = "x";
            btnMultiply.UseVisualStyleBackColor = true;
            btnMultiply.Click += btnMultiply_Click;
            // 
            // btnDivide
            // 
            btnDivide.Location = new Point(195, 380);
            btnDivide.Name = "btnDivide";
            btnDivide.Size = new Size(54, 46);
            btnDivide.TabIndex = 21;
            btnDivide.Text = "/";
            btnDivide.UseVisualStyleBackColor = true;
            btnDivide.Click += btnDivide_Click;
            // 
            // btnEquals
            // 
            btnEquals.Location = new Point(255, 328);
            btnEquals.Name = "btnEquals";
            btnEquals.Size = new Size(54, 98);
            btnEquals.TabIndex = 22;
            btnEquals.Text = "=";
            btnEquals.UseVisualStyleBackColor = true;
            btnEquals.Click += btnEquals_Click;
            // 
            // radioButton1
            // 
            radioButton1.AutoSize = true;
            radioButton1.Checked = true;
            radioButton1.Location = new Point(23, 15);
            radioButton1.Name = "radioButton1";
            radioButton1.Size = new Size(66, 19);
            radioButton1.TabIndex = 24;
            radioButton1.TabStop = true;
            radioButton1.Text = "Radians";
            radioButton1.UseVisualStyleBackColor = true;
            // 
            // radioButton2
            // 
            radioButton2.AutoSize = true;
            radioButton2.Location = new Point(23, 36);
            radioButton2.Name = "radioButton2";
            radioButton2.Size = new Size(67, 19);
            radioButton2.TabIndex = 25;
            radioButton2.Text = "Degrees";
            radioButton2.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(radioButton2);
            groupBox1.Controls.Add(radioButton1);
            groupBox1.Location = new Point(255, 241);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(123, 61);
            groupBox1.TabIndex = 26;
            groupBox1.TabStop = false;
            groupBox1.Text = "Mode:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(48, 15);
            label1.TabIndex = 27;
            label1.Text = "History:";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(390, 480);
            Controls.Add(label1);
            Controls.Add(btnEquals);
            Controls.Add(btnDivide);
            Controls.Add(btnMultiply);
            Controls.Add(btnPoint);
            Controls.Add(btnSubtract);
            Controls.Add(btnAdd);
            Controls.Add(btnZero);
            Controls.Add(btnNine);
            Controls.Add(btnEight);
            Controls.Add(btnSeven);
            Controls.Add(btnSix);
            Controls.Add(btnFive);
            Controls.Add(btnFour);
            Controls.Add(btnThree);
            Controls.Add(btnTwo);
            Controls.Add(btnOne);
            Controls.Add(txtCalc);
            Controls.Add(btnRoot);
            Controls.Add(btnPow);
            Controls.Add(btnTan);
            Controls.Add(btnCos);
            Controls.Add(btnSin);
            Controls.Add(btnClear);
            Controls.Add(lstHistory);
            Controls.Add(groupBox1);
            Name = "Form1";
            Text = "Calculator";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ListBox lstHistory;
        private Button btnClear;
        private Button btnSin;
        private Button btnCos;
        private Button btnTan;
        private Button btnPow;
        private Button btnRoot;
        private TextBox txtCalc;
        private Button btnOne;
        private Button btnTwo;
        private Button btnThree;
        private Button btnFour;
        private Button btnFive;
        private Button btnSix;
        private Button btnSeven;
        private Button btnEight;
        private Button btnNine;
        private Button btnZero;
        private Button btnAdd;
        private Button btnSubtract;
        private Button btnPoint;
        private Button btnMultiply;
        private Button btnDivide;
        private Button btnEquals;
        private RadioButton radioButton1;
        private RadioButton radioButton2;
        private GroupBox groupBox1;
        private Label label1;
    }
}
