namespace AtividadeWagner2BIM
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
            panel1 = new Panel();
            label2 = new Label();
            label1 = new Label();
            numericUpDown1 = new NumericUpDown();
            comboBox1 = new ComboBox();
            label3 = new Label();
            label4 = new Label();
            txtBox_altura = new TextBox();
            txtBox_largura = new TextBox();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            panel1.AutoSize = true;
            panel1.BackColor = SystemColors.ActiveCaption;
            panel1.Controls.Add(txtBox_largura);
            panel1.Controls.Add(txtBox_altura);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(numericUpDown1);
            panel1.Controls.Add(comboBox1);
            panel1.Location = new Point(0, 345);
            panel1.Name = "panel1";
            panel1.Size = new Size(1385, 149);
            panel1.TabIndex = 0;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.White;
            label2.Location = new Point(12, 100);
            label2.Name = "label2";
            label2.Size = new Size(234, 30);
            label2.TabIndex = 3;
            label2.Text = "Comprimento da Reta:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.White;
            label1.Location = new Point(12, 56);
            label1.Name = "label1";
            label1.Size = new Size(169, 30);
            label1.TabIndex = 2;
            label1.Text = "Função da Reta:";
            // 
            // numericUpDown1
            // 
            numericUpDown1.Location = new Point(246, 16);
            numericUpDown1.Maximum = new decimal(new int[] { 5, 0, 0, 0 });
            numericUpDown1.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            numericUpDown1.Name = "numericUpDown1";
            numericUpDown1.Size = new Size(120, 23);
            numericUpDown1.TabIndex = 1;
            numericUpDown1.Value = new decimal(new int[] { 1, 0, 0, 0 });
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(3, 15);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(237, 23);
            comboBox1.TabIndex = 0;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.White;
            label3.Location = new Point(444, 16);
            label3.Name = "label3";
            label3.Size = new Size(201, 30);
            label3.TabIndex = 4;
            label3.Text = "Largura Retângulo:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.ForeColor = Color.White;
            label4.Location = new Point(444, 56);
            label4.Name = "label4";
            label4.Size = new Size(187, 30);
            label4.TabIndex = 5;
            label4.Text = "Altura Retângulo:";
            // 
            // txtBox_altura
            // 
            txtBox_altura.Location = new Point(651, 63);
            txtBox_altura.Name = "txtBox_altura";
            txtBox_altura.Size = new Size(179, 23);
            txtBox_altura.TabIndex = 1;
            // 
            // txtBox_largura
            // 
            txtBox_largura.Location = new Point(651, 23);
            txtBox_largura.Name = "txtBox_largura";
            txtBox_largura.Size = new Size(179, 23);
            txtBox_largura.TabIndex = 2;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1385, 489);
            Controls.Add(panel1);
            Name = "Form1";
            Text = "Form1";
            SizeChanged += Form1_SizeChanged;
            Paint += Form1_Paint;
            MouseClick += Form1_MouseClick;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private ComboBox comboBox1;
        private NumericUpDown numericUpDown1;
        private Label label1;
        private Label label2;
        private Label label4;
        private Label label3;
        private TextBox txtBox_largura;
        private TextBox txtBox_altura;
    }
}
