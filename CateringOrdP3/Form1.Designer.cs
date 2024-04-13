namespace CateringOrdP3
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            pictureBox1 = new PictureBox();
            rBtnCheese = new RadioButton();
            rBtnWraps = new RadioButton();
            rBtnVeggie = new RadioButton();
            rBtnSausage = new RadioButton();
            rBtnFruit = new RadioButton();
            rBtnPre = new RadioButton();
            rBtnPay = new RadioButton();
            bttnCalculate = new Button();
            bttnClear = new Button();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            textBox1 = new TextBox();
            label4 = new Label();
            textBox2 = new TextBox();
            groupBox1 = new GroupBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(596, 21);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(482, 343);
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // rBtnCheese
            // 
            rBtnCheese.AutoSize = true;
            rBtnCheese.BackColor = SystemColors.ButtonHighlight;
            rBtnCheese.Location = new Point(165, 160);
            rBtnCheese.Name = "rBtnCheese";
            rBtnCheese.Size = new Size(227, 29);
            rBtnCheese.TabIndex = 1;
            rBtnCheese.TabStop = true;
            rBtnCheese.Text = "Gourmet Cheese $49.99";
            rBtnCheese.UseVisualStyleBackColor = false;
            rBtnCheese.CheckedChanged += radioButton1_CheckedChanged;
            // 
            // rBtnWraps
            // 
            rBtnWraps.AutoSize = true;
            rBtnWraps.BackColor = SystemColors.ButtonHighlight;
            rBtnWraps.Location = new Point(165, 195);
            rBtnWraps.Name = "rBtnWraps";
            rBtnWraps.Size = new Size(225, 29);
            rBtnWraps.TabIndex = 2;
            rBtnWraps.TabStop = true;
            rBtnWraps.Text = "PinWheel Wraps $59.99";
            rBtnWraps.UseVisualStyleBackColor = false;
            // 
            // rBtnVeggie
            // 
            rBtnVeggie.AutoSize = true;
            rBtnVeggie.BackColor = SystemColors.ButtonHighlight;
            rBtnVeggie.Location = new Point(165, 230);
            rBtnVeggie.Name = "rBtnVeggie";
            rBtnVeggie.Size = new Size(150, 29);
            rBtnVeggie.TabIndex = 3;
            rBtnVeggie.TabStop = true;
            rBtnVeggie.Text = "Veggie $29.99";
            rBtnVeggie.UseVisualStyleBackColor = false;
            // 
            // rBtnSausage
            // 
            rBtnSausage.AutoSize = true;
            rBtnSausage.BackColor = SystemColors.ButtonHighlight;
            rBtnSausage.Location = new Point(165, 265);
            rBtnSausage.Name = "rBtnSausage";
            rBtnSausage.Size = new Size(258, 29);
            rBtnSausage.TabIndex = 4;
            rBtnSausage.TabStop = true;
            rBtnSausage.Text = "Sausage and Cheese $49.99";
            rBtnSausage.UseVisualStyleBackColor = false;
            // 
            // rBtnFruit
            // 
            rBtnFruit.AutoSize = true;
            rBtnFruit.BackColor = SystemColors.ButtonHighlight;
            rBtnFruit.Location = new Point(165, 300);
            rBtnFruit.Name = "rBtnFruit";
            rBtnFruit.Size = new Size(131, 29);
            rBtnFruit.TabIndex = 5;
            rBtnFruit.TabStop = true;
            rBtnFruit.Text = "Fruit $29.99";
            rBtnFruit.UseVisualStyleBackColor = false;
            // 
            // rBtnPre
            // 
            rBtnPre.AutoSize = true;
            rBtnPre.BackColor = SystemColors.ButtonHighlight;
            rBtnPre.Location = new Point(6, 30);
            rBtnPre.Name = "rBtnPre";
            rBtnPre.Size = new Size(96, 29);
            rBtnPre.TabIndex = 6;
            rBtnPre.TabStop = true;
            rBtnPre.Text = "Pre-Pay";
            rBtnPre.UseVisualStyleBackColor = false;
            // 
            // rBtnPay
            // 
            rBtnPay.AutoSize = true;
            rBtnPay.BackColor = SystemColors.ButtonHighlight;
            rBtnPay.Location = new Point(6, 65);
            rBtnPay.Name = "rBtnPay";
            rBtnPay.Size = new Size(168, 29);
            rBtnPay.TabIndex = 7;
            rBtnPay.TabStop = true;
            rBtnPay.Text = "Pay upon Pickup";
            rBtnPay.UseVisualStyleBackColor = false;
            // 
            // bttnCalculate
            // 
            bttnCalculate.Location = new Point(661, 560);
            bttnCalculate.Name = "bttnCalculate";
            bttnCalculate.Size = new Size(112, 34);
            bttnCalculate.TabIndex = 8;
            bttnCalculate.Text = "Calculate";
            bttnCalculate.UseVisualStyleBackColor = true;
            bttnCalculate.Click += bttnCalculate_Click;
            // 
            // bttnClear
            // 
            bttnClear.Location = new Point(910, 560);
            bttnClear.Name = "bttnClear";
            bttnClear.Size = new Size(112, 34);
            bttnClear.TabIndex = 9;
            bttnClear.Text = "Clear";
            bttnClear.UseVisualStyleBackColor = true;
            bttnClear.Click += bttnClear_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            label1.Location = new Point(165, 38);
            label1.Name = "label1";
            label1.Size = new Size(111, 32);
            label1.TabIndex = 10;
            label1.Text = "Catering";
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label2.Location = new Point(138, 70);
            label2.Name = "label2";
            label2.Size = new Size(112, 25);
            label2.TabIndex = 11;
            label2.Text = "Star Market";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label3.Location = new Point(650, 428);
            label3.Name = "label3";
            label3.Size = new Size(131, 25);
            label3.TabIndex = 12;
            label3.Text = "Loyalty Points";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(838, 425);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(82, 31);
            textBox1.TabIndex = 13;
            textBox1.TextChanged += textBox1_TextChanged;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label4.Location = new Point(241, 713);
            label4.Name = "label4";
            label4.Size = new Size(112, 25);
            label4.TabIndex = 14;
            label4.Text = "Please Pay: ";
            // 
            // textBox2
            // 
            textBox2.Location = new Point(406, 713);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(150, 31);
            textBox2.TabIndex = 15;
            // 
            // groupBox1
            // 
            groupBox1.BackColor = Color.White;
            groupBox1.Controls.Add(rBtnPre);
            groupBox1.Controls.Add(rBtnPay);
            groupBox1.Location = new Point(165, 472);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(300, 96);
            groupBox1.TabIndex = 16;
            groupBox1.TabStop = false;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Moccasin;
            ClientSize = new Size(1090, 813);
            Controls.Add(groupBox1);
            Controls.Add(textBox2);
            Controls.Add(label4);
            Controls.Add(textBox1);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(bttnClear);
            Controls.Add(bttnCalculate);
            Controls.Add(rBtnFruit);
            Controls.Add(rBtnSausage);
            Controls.Add(rBtnVeggie);
            Controls.Add(rBtnWraps);
            Controls.Add(rBtnCheese);
            Controls.Add(pictureBox1);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox1;
        private RadioButton rBtnCheese;
        private RadioButton rBtnWraps;
        private RadioButton rBtnVeggie;
        private RadioButton rBtnSausage;
        private RadioButton rBtnFruit;
        private RadioButton rBtnPre;
        private RadioButton rBtnPay;
        private Button bttnCalculate;
        private Button bttnClear;
        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox textBox1;
        private Label label4;
        private TextBox textBox2;
        private GroupBox groupBox1;
    }
}
