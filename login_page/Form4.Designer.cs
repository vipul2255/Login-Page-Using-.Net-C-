namespace login_page
{
    partial class Form4
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
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            radioButton1 = new RadioButton();
            radioButton2 = new RadioButton();
            checkBox1 = new CheckBox();
            checkBox2 = new CheckBox();
            button1 = new Button();
            button2 = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 19F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(101, 48);
            label1.Name = "label1";
            label1.Size = new Size(105, 45);
            label1.TabIndex = 0;
            label1.Text = "Name";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 19F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(101, 112);
            label2.Name = "label2";
            label2.Size = new Size(132, 45);
            label2.TabIndex = 1;
            label2.Text = "Country";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 19F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(101, 177);
            label3.Name = "label3";
            label3.Size = new Size(124, 45);
            label3.TabIndex = 2;
            label3.Text = "Gender";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 19F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(101, 239);
            label4.Name = "label4";
            label4.Size = new Size(139, 45);
            label4.TabIndex = 3;
            label4.Text = "Hobbies";
            // 
            // textBox1
            // 
            textBox1.Font = new Font("Segoe UI", 19F, FontStyle.Regular, GraphicsUnit.Point);
            textBox1.Location = new Point(282, 48);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(309, 50);
            textBox1.TabIndex = 4;
            // 
            // textBox2
            // 
            textBox2.Font = new Font("Segoe UI", 19F, FontStyle.Regular, GraphicsUnit.Point);
            textBox2.Location = new Point(282, 112);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(309, 50);
            textBox2.TabIndex = 5;
            // 
            // radioButton1
            // 
            radioButton1.AutoSize = true;
            radioButton1.Font = new Font("Segoe UI", 19F, FontStyle.Regular, GraphicsUnit.Point);
            radioButton1.Location = new Point(282, 177);
            radioButton1.Name = "radioButton1";
            radioButton1.Size = new Size(111, 49);
            radioButton1.TabIndex = 6;
            radioButton1.TabStop = true;
            radioButton1.Text = "Male";
            radioButton1.UseVisualStyleBackColor = true;
            // 
            // radioButton2
            // 
            radioButton2.AutoSize = true;
            radioButton2.Font = new Font("Segoe UI", 19F, FontStyle.Regular, GraphicsUnit.Point);
            radioButton2.Location = new Point(448, 175);
            radioButton2.Name = "radioButton2";
            radioButton2.Size = new Size(143, 49);
            radioButton2.TabIndex = 7;
            radioButton2.TabStop = true;
            radioButton2.Text = "Female";
            radioButton2.UseVisualStyleBackColor = true;
            // 
            // checkBox1
            // 
            checkBox1.AutoSize = true;
            checkBox1.Font = new Font("Segoe UI", 19F, FontStyle.Regular, GraphicsUnit.Point);
            checkBox1.Location = new Point(282, 238);
            checkBox1.Name = "checkBox1";
            checkBox1.Size = new Size(140, 49);
            checkBox1.TabIndex = 8;
            checkBox1.Text = "Cricket";
            checkBox1.UseVisualStyleBackColor = true;
            // 
            // checkBox2
            // 
            checkBox2.AutoSize = true;
            checkBox2.Font = new Font("Segoe UI", 19F, FontStyle.Regular, GraphicsUnit.Point);
            checkBox2.Location = new Point(448, 239);
            checkBox2.Name = "checkBox2";
            checkBox2.Size = new Size(158, 49);
            checkBox2.TabIndex = 9;
            checkBox2.Text = "Football";
            checkBox2.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            button1.Font = new Font("Segoe UI", 19F, FontStyle.Regular, GraphicsUnit.Point);
            button1.Location = new Point(101, 322);
            button1.Name = "button1";
            button1.Size = new Size(151, 55);
            button1.TabIndex = 10;
            button1.Text = "Preview";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Font = new Font("Segoe UI", 19F, FontStyle.Regular, GraphicsUnit.Point);
            button2.Location = new Point(440, 322);
            button2.Name = "button2";
            button2.Size = new Size(151, 55);
            button2.TabIndex = 11;
            button2.Text = "Back";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // Form4
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(checkBox2);
            Controls.Add(checkBox1);
            Controls.Add(radioButton2);
            Controls.Add(radioButton1);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form4";
            Text = "Form4";
            Load += Form4_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private TextBox textBox1;
        private TextBox textBox2;
        private RadioButton radioButton1;
        private RadioButton radioButton2;
        private CheckBox checkBox1;
        private CheckBox checkBox2;
        private Button button1;
        private Button button2;
    }
}