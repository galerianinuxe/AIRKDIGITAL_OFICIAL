namespace airksucata
{
    public partial class CustomMessageBox : Form
    {
        public CustomMessageBox()
        {
            InitializeComponent();
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
