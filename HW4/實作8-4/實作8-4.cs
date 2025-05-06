namespace _8_4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private int arrMin(int[] arr)
        {
            int min = arr[0];
            foreach (int num in arr)
            {
                if (num < min)
                    min = num;
            }
            return min;
        }

        private int arrMax(int[] arr)
        {
            int max = arr[0];
            foreach (int num in arr)
            {
                if (num > max)
                    max = num;
            }
            return max;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                string[] inputParts = textBox1.Text.Split(new char[] { ',', ' ' }, StringSplitOptions.RemoveEmptyEntries);
                if (inputParts.Length != 6)
                {
                    MessageBox.Show("請輸入6個整數，用逗號或空白分隔");
                    return;
                }
                int[] numbers = inputParts.Select(s => int.Parse(s.Trim())).ToArray();
                int min = arrMin(numbers);
                int max = arrMax(numbers);
                label1.Text = $"最小值: {min}";
                label2.Text = $"最大值: {max}";
            }
            catch (FormatException)
            {
                MessageBox.Show("請輸入正確的整數格式");
            }
         }
     }
 }

