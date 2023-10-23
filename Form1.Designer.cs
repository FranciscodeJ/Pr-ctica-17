namespace Práctica_17
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
            button1 = new Button();
            label1 = new Label();
            textBox1 = new TextBox();
            button2 = new Button();
            label2 = new Label();
            label4 = new Label();
            label3 = new Label();
            textBox2 = new TextBox();
            textBox3 = new TextBox();
            textBox4 = new TextBox();
            textBox5 = new TextBox();
            textBox6 = new TextBox();
            SuspendLayout();
            // 
            // button1
            // 
            button1.BackColor = Color.Transparent;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Sitka Text", 18F, FontStyle.Regular, GraphicsUnit.Point);
            button1.ForeColor = Color.NavajoWhite;
            button1.Location = new Point(145, 284);
            button1.Name = "button1";
            button1.Size = new Size(159, 60);
            button1.TabIndex = 0;
            button1.Text = "Decisión";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Poor Richard", 18F, FontStyle.Regular, GraphicsUnit.Point);
            label1.ForeColor = Color.BlanchedAlmond;
            label1.Location = new Point(167, 34);
            label1.Name = "label1";
            label1.Size = new Size(463, 35);
            label1.TabIndex = 1;
            label1.Text = "Ordenar tres números de mayor a menor.";
            // 
            // textBox1
            // 
            textBox1.Font = new Font("Yu Mincho", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            textBox1.ForeColor = SystemColors.MenuText;
            textBox1.Location = new Point(145, 155);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(118, 44);
            textBox1.TabIndex = 2;
            // 
            // button2
            // 
            button2.BackColor = Color.Transparent;
            button2.FlatStyle = FlatStyle.Flat;
            button2.Font = new Font("Sitka Text", 18F, FontStyle.Regular, GraphicsUnit.Point);
            button2.ForeColor = Color.NavajoWhite;
            button2.Location = new Point(549, 284);
            button2.Name = "button2";
            button2.Size = new Size(123, 60);
            button2.TabIndex = 5;
            button2.Text = "Borrar";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Poor Richard", 18F, FontStyle.Regular, GraphicsUnit.Point);
            label2.ForeColor = Color.BlanchedAlmond;
            label2.Location = new Point(187, 202);
            label2.Name = "label2";
            label2.Size = new Size(37, 35);
            label2.TabIndex = 6;
            label2.Text = "A";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.Transparent;
            label4.Font = new Font("Poor Richard", 18F, FontStyle.Regular, GraphicsUnit.Point);
            label4.ForeColor = Color.BlanchedAlmond;
            label4.Location = new Point(402, 202);
            label4.Name = "label4";
            label4.Size = new Size(34, 35);
            label4.TabIndex = 8;
            label4.Text = "B";
            label4.Click += label4_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.Font = new Font("Poor Richard", 18F, FontStyle.Regular, GraphicsUnit.Point);
            label3.ForeColor = Color.BlanchedAlmond;
            label3.Location = new Point(605, 202);
            label3.Name = "label3";
            label3.Size = new Size(35, 35);
            label3.TabIndex = 11;
            label3.Text = "C";
            // 
            // textBox2
            // 
            textBox2.Font = new Font("Yu Mincho", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            textBox2.ForeColor = SystemColors.MenuText;
            textBox2.Location = new Point(358, 155);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(118, 44);
            textBox2.TabIndex = 12;
            // 
            // textBox3
            // 
            textBox3.Font = new Font("Yu Mincho", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            textBox3.ForeColor = SystemColors.MenuText;
            textBox3.Location = new Point(566, 155);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(118, 44);
            textBox3.TabIndex = 13;
            // 
            // textBox4
            // 
            textBox4.Font = new Font("Yu Mincho", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            textBox4.ForeColor = SystemColors.MenuText;
            textBox4.Location = new Point(145, 429);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(118, 44);
            textBox4.TabIndex = 14;
            // 
            // textBox5
            // 
            textBox5.Font = new Font("Yu Mincho", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            textBox5.ForeColor = SystemColors.MenuText;
            textBox5.Location = new Point(358, 429);
            textBox5.Name = "textBox5";
            textBox5.Size = new Size(118, 44);
            textBox5.TabIndex = 15;
            // 
            // textBox6
            // 
            textBox6.Font = new Font("Yu Mincho", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            textBox6.ForeColor = SystemColors.MenuText;
            textBox6.Location = new Point(566, 429);
            textBox6.Name = "textBox6";
            textBox6.Size = new Size(118, 44);
            textBox6.TabIndex = 16;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(882, 691);
            Controls.Add(textBox6);
            Controls.Add(textBox5);
            Controls.Add(textBox4);
            Controls.Add(textBox3);
            Controls.Add(textBox2);
            Controls.Add(label3);
            Controls.Add(label4);
            Controls.Add(label2);
            Controls.Add(button2);
            Controls.Add(textBox1);
            Controls.Add(label1);
            Controls.Add(button1);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private Label label1;
        private TextBox textBox1;
        private Button button2;
        private Label label2;
        private Label label4;
        private Label label3;
        private TextBox textBox2;
        private TextBox textBox3;
        private TextBox textBox4;
        private TextBox textBox5;
        private TextBox textBox6;
    }
}