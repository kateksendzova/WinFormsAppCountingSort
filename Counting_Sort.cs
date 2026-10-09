using System;
using System.Diagnostics;
using System.Windows.Forms;

namespace WinFormsAppCountingSort
{
    public partial class Counting_Sort : Form
    {
        private int[] array;
        private int maxEl = 10;

        public Counting_Sort()
        {
            InitializeComponent();

            button_Generate.Click += button_Generate_Click;
            button_Sort.Click += button_Sort_Click;
            button_Clear.Click += button_Clear_Click;
        }

        private void button_Generate_Click(object sender, EventArgs e)
        {
            int n = (int)numericUpDown_Size.Value;
            array = new int[n];
            Random rand = new Random();

            for (int i = 0; i < n; i++)
            {
                array[i] = rand.Next(0, maxEl);
            }

            textBox_GeneratedArray.Text = string.Join(", ", array);
            textBox_SortedArray.Clear();
            richTextBox1.Clear();
            textBox_Time.Clear();
        }

        private void button_Sort_Click(object sender, EventArgs e)
        {
            if (array == null || array.Length == 0)
            {
                MessageBox.Show("Будь ласка, спочатку згенеруйте масив!", "Попередження", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            richTextBox1.Clear();
            Stopwatch stopwatch = Stopwatch.StartNew();

            CountingSort();

            stopwatch.Stop();

            textBox_SortedArray.Text = string.Join(", ", array);

            textBox_Time.Text = stopwatch.Elapsed.ToString(@"hh\:mm\:ss\.ffffff");
        }

        private void CountingSort()
        {
            int n = array.Length;
            int[] additionalArray = new int[maxEl];

            for (int i = 0; i < maxEl; i++)
            {
                additionalArray[i] = 0;
            }


            for (int i = 0; i < maxEl; ++i)
            {
                for (int j = 0; j < n; j++)
                {
                    if (array[j] == i)
                    {
                        additionalArray[i]++;
                    }
                }
            }

            richTextBox1.AppendText($"Додатковий масив: {string.Join(", ", additionalArray)}\n\n");

            int index = 0;
            for (int i = 0; i < maxEl; i++)
            {
                while (additionalArray[i] > 0)
                {
                    array[index] = i;
                    index++;
                    additionalArray[i]--;

                    richTextBox1.AppendText($"{string.Join(", ", array)}\n");
                    richTextBox1.AppendText($"Додатковий масив: {string.Join(", ", additionalArray)}\n\n");
                }
            }
        }

        private void button_Clear_Click(object sender, EventArgs e)
        {
            array = null;
            textBox_GeneratedArray.Clear();
            textBox_SortedArray.Clear();
            richTextBox1.Clear();
            textBox_Time.Clear();
            numericUpDown_Size.Value = numericUpDown_Size.Minimum;
        }


    }
}