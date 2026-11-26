namespace AppUI
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            SetupTabs();
        }

        private void SetupTabs()
        {
            this.Text = "Microprocessor Utility (C# + x86 Assembly)";
            this.Size = new Size(1000, 650);
            this.StartPosition = FormStartPosition.CenterScreen;

            var tabControl = new TabControl { Dock = DockStyle.Fill };

            var tabEncrypt = new TabPage("1. Mã hóa & Giải mã File");
            tabEncrypt.Controls.Add(new UcEncryption { Dock = DockStyle.Fill });

            var tabSort = new TabPage("2. Sắp xếp & Tìm kiếm Mảng");
            tabSort.Controls.Add(new UcSorting { Dock = DockStyle.Fill });

            tabControl.TabPages.Add(tabEncrypt);
            tabControl.TabPages.Add(tabSort);
            this.Controls.Add(tabControl);
        }
    }
}