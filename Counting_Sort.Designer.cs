namespace WinFormsAppCountingSort
{
    partial class Counting_Sort
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
            label_infoSize = new Label();
            numericUpDown_Size = new NumericUpDown();
            textBox_GeneratedArray = new TextBox();
            label_infoArrayAtFirst = new Label();
            button_Sort = new Button();
            label_infoSortedArray = new Label();
            textBox_SortedArray = new TextBox();
            button_Generate = new Button();
            richTextBox1 = new RichTextBox();
            label_infoSteps = new Label();
            button_Clear = new Button();
            label_infoTime = new Label();
            textBox_Time = new TextBox();
            ((System.ComponentModel.ISupportInitialize)numericUpDown_Size).BeginInit();
            SuspendLayout();
            // 
            // label_infoSize
            // 
            label_infoSize.AutoSize = true;
            label_infoSize.Font = new Font("Century Gothic", 9F, FontStyle.Italic, GraphicsUnit.Point, 204);
            label_infoSize.Location = new Point(55, 32);
            label_infoSize.Name = "label_infoSize";
            label_infoSize.Size = new Size(204, 18);
            label_infoSize.TabIndex = 0;
            label_infoSize.Text = "Введіть розмір масиву n =";
            // 
            // numericUpDown_Size
            // 
            numericUpDown_Size.Font = new Font("Berlin Sans FB", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            numericUpDown_Size.Location = new Point(258, 30);
            numericUpDown_Size.Minimum = new decimal(new int[] { 2, 0, 0, 0 });
            numericUpDown_Size.Name = "numericUpDown_Size";
            numericUpDown_Size.Size = new Size(50, 24);
            numericUpDown_Size.TabIndex = 1;
            numericUpDown_Size.Value = new decimal(new int[] { 2, 0, 0, 0 });
            // 
            // textBox_GeneratedArray
            // 
            textBox_GeneratedArray.BackColor = Color.LightCyan;
            textBox_GeneratedArray.Font = new Font("Berlin Sans FB", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBox_GeneratedArray.Location = new Point(55, 129);
            textBox_GeneratedArray.Name = "textBox_GeneratedArray";
            textBox_GeneratedArray.Size = new Size(410, 24);
            textBox_GeneratedArray.TabIndex = 2;
            // 
            // label_infoArrayAtFirst
            // 
            label_infoArrayAtFirst.AutoSize = true;
            label_infoArrayAtFirst.BackColor = Color.LightCyan;
            label_infoArrayAtFirst.Font = new Font("Century Gothic", 9F, FontStyle.Regular, GraphicsUnit.Point, 204);
            label_infoArrayAtFirst.ForeColor = Color.MidnightBlue;
            label_infoArrayAtFirst.Location = new Point(194, 107);
            label_infoArrayAtFirst.Name = "label_infoArrayAtFirst";
            label_infoArrayAtFirst.Size = new Size(148, 20);
            label_infoArrayAtFirst.TabIndex = 3;
            label_infoArrayAtFirst.Text = "Початковий масив";
            // 
            // button_Sort
            // 
            button_Sort.BackColor = Color.RoyalBlue;
            button_Sort.Cursor = Cursors.AppStarting;
            button_Sort.Font = new Font("Century Gothic", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button_Sort.ForeColor = Color.Azure;
            button_Sort.Location = new Point(352, 171);
            button_Sort.Name = "button_Sort";
            button_Sort.Size = new Size(113, 44);
            button_Sort.TabIndex = 4;
            button_Sort.Text = "Сортувати";
            button_Sort.UseVisualStyleBackColor = false;
            // 
            // label_infoSortedArray
            // 
            label_infoSortedArray.AutoSize = true;
            label_infoSortedArray.BackColor = Color.LightCyan;
            label_infoSortedArray.Font = new Font("Century Gothic", 9F, FontStyle.Regular, GraphicsUnit.Point, 204);
            label_infoSortedArray.ForeColor = Color.MidnightBlue;
            label_infoSortedArray.Location = new Point(181, 275);
            label_infoSortedArray.Name = "label_infoSortedArray";
            label_infoSortedArray.Size = new Size(172, 20);
            label_infoSortedArray.TabIndex = 6;
            label_infoSortedArray.Text = "Посортований масив";
            // 
            // textBox_SortedArray
            // 
            textBox_SortedArray.BackColor = Color.LightCyan;
            textBox_SortedArray.Font = new Font("Berlin Sans FB", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBox_SortedArray.Location = new Point(55, 298);
            textBox_SortedArray.Name = "textBox_SortedArray";
            textBox_SortedArray.Size = new Size(410, 24);
            textBox_SortedArray.TabIndex = 5;
            // 
            // button_Generate
            // 
            button_Generate.BackColor = Color.Azure;
            button_Generate.Font = new Font("Century Gothic", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button_Generate.ForeColor = Color.MidnightBlue;
            button_Generate.Location = new Point(352, 24);
            button_Generate.Name = "button_Generate";
            button_Generate.Size = new Size(113, 37);
            button_Generate.TabIndex = 7;
            button_Generate.Text = "Згенерувати";
            button_Generate.UseVisualStyleBackColor = false;
            // 
            // richTextBox1
            // 
            richTextBox1.BackColor = Color.Azure;
            richTextBox1.Font = new Font("Berlin Sans FB", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            richTextBox1.Location = new Point(524, 50);
            richTextBox1.Name = "richTextBox1";
            richTextBox1.Size = new Size(526, 306);
            richTextBox1.TabIndex = 8;
            richTextBox1.Text = "";
            // 
            // label_infoSteps
            // 
            label_infoSteps.AutoSize = true;
            label_infoSteps.BackColor = Color.Azure;
            label_infoSteps.Font = new Font("Century Gothic", 9F, FontStyle.Regular, GraphicsUnit.Point, 204);
            label_infoSteps.ForeColor = Color.MidnightBlue;
            label_infoSteps.Location = new Point(724, 27);
            label_infoSteps.Name = "label_infoSteps";
            label_infoSteps.Size = new Size(145, 20);
            label_infoSteps.TabIndex = 9;
            label_infoSteps.Text = "Кроки сортування";
            // 
            // button_Clear
            // 
            button_Clear.BackColor = Color.Azure;
            button_Clear.Font = new Font("Century Gothic", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button_Clear.ForeColor = Color.MidnightBlue;
            button_Clear.Location = new Point(937, 373);
            button_Clear.Name = "button_Clear";
            button_Clear.Size = new Size(113, 37);
            button_Clear.TabIndex = 11;
            button_Clear.Text = "Очистити";
            button_Clear.UseVisualStyleBackColor = false;
            // 
            // label_infoTime
            // 
            label_infoTime.AutoSize = true;
            label_infoTime.Font = new Font("Century Gothic", 9F, FontStyle.Italic, GraphicsUnit.Point, 204);
            label_infoTime.Location = new Point(55, 387);
            label_infoTime.Name = "label_infoTime";
            label_infoTime.Size = new Size(127, 18);
            label_infoTime.TabIndex = 12;
            label_infoTime.Text = "Час сортування";
            // 
            // textBox_Time
            // 
            textBox_Time.BackColor = SystemColors.ControlLightLight;
            textBox_Time.Font = new Font("Berlin Sans FB", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBox_Time.Location = new Point(188, 383);
            textBox_Time.Name = "textBox_Time";
            textBox_Time.Size = new Size(277, 24);
            textBox_Time.TabIndex = 13;
            // 
            // Counting_Sort
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.AliceBlue;
            ClientSize = new Size(1062, 430);
            Controls.Add(textBox_Time);
            Controls.Add(label_infoTime);
            Controls.Add(button_Clear);
            Controls.Add(label_infoSteps);
            Controls.Add(richTextBox1);
            Controls.Add(button_Generate);
            Controls.Add(label_infoSortedArray);
            Controls.Add(textBox_SortedArray);
            Controls.Add(button_Sort);
            Controls.Add(label_infoArrayAtFirst);
            Controls.Add(textBox_GeneratedArray);
            Controls.Add(numericUpDown_Size);
            Controls.Add(label_infoSize);
            Name = "Counting_Sort";
            Text = "Сортування підрахунком";
            ((System.ComponentModel.ISupportInitialize)numericUpDown_Size).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label_infoSize;
        private NumericUpDown numericUpDown_Size;
        private TextBox textBox_GeneratedArray;
        private Label label_infoArrayAtFirst;
        private Button button_Sort;
        private Label label_infoSortedArray;
        private TextBox textBox_SortedArray;
        private Button button_Generate;
        private RichTextBox richTextBox1;
        private Label label_infoSteps;
        private Button button_Clear;
        private Label label_infoTime;
        private TextBox textBox_Time;
    }
}
