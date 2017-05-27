namespace Graphics3
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.translationY = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.translationX = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.scaleY = new System.Windows.Forms.NumericUpDown();
            this.label4 = new System.Windows.Forms.Label();
            this.scaleX = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.angle = new System.Windows.Forms.NumericUpDown();
            this.label9 = new System.Windows.Forms.Label();
            this.rotationY = new System.Windows.Forms.NumericUpDown();
            this.label6 = new System.Windows.Forms.Label();
            this.rotationX = new System.Windows.Forms.NumericUpDown();
            this.label5 = new System.Windows.Forms.Label();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.shearY = new System.Windows.Forms.NumericUpDown();
            this.label8 = new System.Windows.Forms.Label();
            this.shearX = new System.Windows.Forms.NumericUpDown();
            this.label7 = new System.Windows.Forms.Label();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.checkBox3 = new System.Windows.Forms.CheckBox();
            this.checkBox2 = new System.Windows.Forms.CheckBox();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.translationY)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.translationX)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.scaleY)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.scaleX)).BeginInit();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.angle)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rotationY)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rotationX)).BeginInit();
            this.groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.shearY)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.shearX)).BeginInit();
            this.groupBox5.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.White;
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Left;
            this.pictureBox1.InitialImage = null;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(1176, 786);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Paint += new System.Windows.Forms.PaintEventHandler(this.pictureBox1_Paint);
            this.pictureBox1.MouseHover += new System.EventHandler(this.pictureBox1_MouseHover);
            this.pictureBox1.PreviewKeyDown += new System.Windows.Forms.PreviewKeyDownEventHandler(this.pictureBox1_PreviewKeyDown);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.translationY);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.translationX);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(1186, 18);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox1.Size = new System.Drawing.Size(272, 183);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Перенос";
            // 
            // translationY
            // 
            this.translationY.DecimalPlaces = 3;
            this.translationY.Increment = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.translationY.Location = new System.Drawing.Point(42, 71);
            this.translationY.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.translationY.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.translationY.Minimum = new decimal(new int[] {
            10000,
            0,
            0,
            -2147483648});
            this.translationY.Name = "translationY";
            this.translationY.Size = new System.Drawing.Size(220, 26);
            this.translationY.TabIndex = 3;
            this.translationY.ValueChanged += new System.EventHandler(this.ValueChanged);
            this.translationY.KeyUp += new System.Windows.Forms.KeyEventHandler(this.ValueChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 74);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(20, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "Y";
            // 
            // translationX
            // 
            this.translationX.DecimalPlaces = 3;
            this.translationX.Increment = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.translationX.Location = new System.Drawing.Point(42, 31);
            this.translationX.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.translationX.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.translationX.Minimum = new decimal(new int[] {
            10000,
            0,
            0,
            -2147483648});
            this.translationX.Name = "translationX";
            this.translationX.Size = new System.Drawing.Size(220, 26);
            this.translationX.TabIndex = 1;
            this.translationX.ValueChanged += new System.EventHandler(this.ValueChanged);
            this.translationX.KeyUp += new System.Windows.Forms.KeyEventHandler(this.ValueChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 34);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(20, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "X";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.scaleY);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.scaleX);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Location = new System.Drawing.Point(1186, 211);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox2.Size = new System.Drawing.Size(272, 183);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Масштаб";
            // 
            // scaleY
            // 
            this.scaleY.DecimalPlaces = 3;
            this.scaleY.Location = new System.Drawing.Point(42, 69);
            this.scaleY.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.scaleY.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            196608});
            this.scaleY.Name = "scaleY";
            this.scaleY.Size = new System.Drawing.Size(220, 26);
            this.scaleY.TabIndex = 5;
            this.scaleY.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.scaleY.ValueChanged += new System.EventHandler(this.ValueChanged);
            this.scaleY.KeyUp += new System.Windows.Forms.KeyEventHandler(this.ValueChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 72);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(20, 20);
            this.label4.TabIndex = 4;
            this.label4.Text = "Y";
            // 
            // scaleX
            // 
            this.scaleX.DecimalPlaces = 3;
            this.scaleX.Location = new System.Drawing.Point(42, 29);
            this.scaleX.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.scaleX.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            196608});
            this.scaleX.Name = "scaleX";
            this.scaleX.Size = new System.Drawing.Size(220, 26);
            this.scaleX.TabIndex = 3;
            this.scaleX.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.scaleX.ValueChanged += new System.EventHandler(this.ValueChanged);
            this.scaleX.KeyUp += new System.Windows.Forms.KeyEventHandler(this.ValueChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 32);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(20, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "X";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.angle);
            this.groupBox3.Controls.Add(this.label9);
            this.groupBox3.Controls.Add(this.rotationY);
            this.groupBox3.Controls.Add(this.label6);
            this.groupBox3.Controls.Add(this.rotationX);
            this.groupBox3.Controls.Add(this.label5);
            this.groupBox3.Location = new System.Drawing.Point(1186, 403);
            this.groupBox3.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox3.Size = new System.Drawing.Size(272, 183);
            this.groupBox3.TabIndex = 3;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Вращение";
            // 
            // angle
            // 
            this.angle.DecimalPlaces = 3;
            this.angle.Location = new System.Drawing.Point(72, 109);
            this.angle.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.angle.Maximum = new decimal(new int[] {
            180,
            0,
            0,
            0});
            this.angle.Minimum = new decimal(new int[] {
            180,
            0,
            0,
            -2147483648});
            this.angle.Name = "angle";
            this.angle.Size = new System.Drawing.Size(190, 26);
            this.angle.TabIndex = 7;
            this.angle.ValueChanged += new System.EventHandler(this.ValueChanged);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(12, 112);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(50, 20);
            this.label9.TabIndex = 6;
            this.label9.Text = "Angle";
            // 
            // rotationY
            // 
            this.rotationY.DecimalPlaces = 3;
            this.rotationY.Increment = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.rotationY.Location = new System.Drawing.Point(42, 69);
            this.rotationY.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.rotationY.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.rotationY.Minimum = new decimal(new int[] {
            1000,
            0,
            0,
            -2147483648});
            this.rotationY.Name = "rotationY";
            this.rotationY.Size = new System.Drawing.Size(220, 26);
            this.rotationY.TabIndex = 5;
            this.rotationY.ValueChanged += new System.EventHandler(this.ValueChanged);
            this.rotationY.KeyUp += new System.Windows.Forms.KeyEventHandler(this.ValueChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(12, 72);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(20, 20);
            this.label6.TabIndex = 4;
            this.label6.Text = "Y";
            // 
            // rotationX
            // 
            this.rotationX.DecimalPlaces = 3;
            this.rotationX.Increment = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.rotationX.Location = new System.Drawing.Point(42, 29);
            this.rotationX.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.rotationX.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.rotationX.Minimum = new decimal(new int[] {
            1000,
            0,
            0,
            -2147483648});
            this.rotationX.Name = "rotationX";
            this.rotationX.Size = new System.Drawing.Size(220, 26);
            this.rotationX.TabIndex = 3;
            this.rotationX.ValueChanged += new System.EventHandler(this.ValueChanged);
            this.rotationX.KeyUp += new System.Windows.Forms.KeyEventHandler(this.ValueChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 32);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(20, 20);
            this.label5.TabIndex = 2;
            this.label5.Text = "X";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.shearY);
            this.groupBox4.Controls.Add(this.label8);
            this.groupBox4.Controls.Add(this.shearX);
            this.groupBox4.Controls.Add(this.label7);
            this.groupBox4.Location = new System.Drawing.Point(1186, 595);
            this.groupBox4.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox4.Size = new System.Drawing.Size(272, 102);
            this.groupBox4.TabIndex = 4;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Растяжение";
            // 
            // shearY
            // 
            this.shearY.DecimalPlaces = 3;
            this.shearY.Location = new System.Drawing.Point(42, 69);
            this.shearY.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.shearY.Minimum = new decimal(new int[] {
            100,
            0,
            0,
            -2147483648});
            this.shearY.Name = "shearY";
            this.shearY.Size = new System.Drawing.Size(220, 26);
            this.shearY.TabIndex = 5;
            this.shearY.ValueChanged += new System.EventHandler(this.ValueChanged);
            this.shearY.KeyUp += new System.Windows.Forms.KeyEventHandler(this.ValueChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(12, 72);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(20, 20);
            this.label8.TabIndex = 4;
            this.label8.Text = "Y";
            // 
            // shearX
            // 
            this.shearX.DecimalPlaces = 3;
            this.shearX.Location = new System.Drawing.Point(42, 29);
            this.shearX.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.shearX.Minimum = new decimal(new int[] {
            100,
            0,
            0,
            -2147483648});
            this.shearX.Name = "shearX";
            this.shearX.Size = new System.Drawing.Size(220, 26);
            this.shearX.TabIndex = 3;
            this.shearX.ValueChanged += new System.EventHandler(this.ValueChanged);
            this.shearX.KeyUp += new System.Windows.Forms.KeyEventHandler(this.ValueChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(12, 32);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(20, 20);
            this.label7.TabIndex = 2;
            this.label7.Text = "X";
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.checkBox3);
            this.groupBox5.Controls.Add(this.checkBox2);
            this.groupBox5.Controls.Add(this.checkBox1);
            this.groupBox5.Location = new System.Drawing.Point(1186, 705);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(272, 69);
            this.groupBox5.TabIndex = 5;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "groupBox5";
            // 
            // checkBox3
            // 
            this.checkBox3.AutoSize = true;
            this.checkBox3.Location = new System.Drawing.Point(195, 24);
            this.checkBox3.Name = "checkBox3";
            this.checkBox3.Size = new System.Drawing.Size(66, 24);
            this.checkBox3.TabIndex = 2;
            this.checkBox3.Text = "y = x";
            this.checkBox3.UseVisualStyleBackColor = true;
            this.checkBox3.CheckedChanged += new System.EventHandler(this.checkBox3_CheckedChanged);
            // 
            // checkBox2
            // 
            this.checkBox2.AutoSize = true;
            this.checkBox2.Location = new System.Drawing.Point(101, 24);
            this.checkBox2.Name = "checkBox2";
            this.checkBox2.Size = new System.Drawing.Size(88, 24);
            this.checkBox2.TabIndex = 1;
            this.checkBox2.Text = "ось OY";
            this.checkBox2.UseVisualStyleBackColor = true;
            this.checkBox2.CheckedChanged += new System.EventHandler(this.checkBox2_CheckedChanged);
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(6, 25);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(88, 24);
            this.checkBox1.TabIndex = 0;
            this.checkBox1.Text = "ось OX";
            this.checkBox1.UseVisualStyleBackColor = true;
            this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1476, 786);
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.KeyPreview = true;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.translationY)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.translationX)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.scaleY)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.scaleX)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.angle)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rotationY)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rotationX)).EndInit();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.shearY)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.shearX)).EndInit();
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.NumericUpDown translationY;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown translationX;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.NumericUpDown scaleY;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.NumericUpDown scaleX;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.NumericUpDown rotationY;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.NumericUpDown rotationX;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.NumericUpDown shearY;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.NumericUpDown shearX;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.NumericUpDown angle;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.CheckBox checkBox3;
        private System.Windows.Forms.CheckBox checkBox2;
        private System.Windows.Forms.CheckBox checkBox1;
    }
}

