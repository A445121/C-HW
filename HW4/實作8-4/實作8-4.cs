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
                    MessageBox.Show("�п�J6�Ӿ�ơA�γr���Ϊťդ��j");
                    return;
                }
                int[] numbers = inputParts.Select(s => int.Parse(s.Trim())).ToArray();
                int min = arrMin(numbers);
                int max = arrMax(numbers);
                label1.Text = $"�̤p��: {min}";
                label2.Text = $"�̤j��: {max}";
            }
            catch (FormatException)
            {
                MessageBox.Show("�п�J���T����Ʈ榡");
            }
         }
     }
 }

