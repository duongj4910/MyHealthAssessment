namespace Medical_Risks
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void GUI_Load(object sender, EventArgs e)
        {

        }

        private void login_btn_Click(object sender, EventArgs e)
        {
            if (username_TextBox.Text == "")
            {
                MessageBox.Show("Enter Username.");
            }
            else if (password_TextBox.Text == "")
            {
                MessageBox.Show("Enter Password.");
            }
            else if (username_TextBox.Text == "test" && password_TextBox.Text == "test")
            {
                this.Hide();
                Selection selection = new Selection();
                selection.ShowDialog();
            }
            else
            {
                MessageBox.Show("Invalid Credentials.");
            }
        }

    }
}