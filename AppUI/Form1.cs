namespace AppUI
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            int[] sample = { 1, 2, 3 };
            int asmOut = NativeMethods.BinarySearchASM(sample, sample.Length, 5, out double ms);
            MessageBox.Show($"Kết nối AsmCore.dll thành công!\nKết quả từ thanh ghi EAX (5 + 10) = {asmOut}\nThời gian: {ms:F4} ms");

        }
    }
}
