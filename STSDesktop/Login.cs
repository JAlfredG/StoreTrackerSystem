using STSBusinessDataLogic;

namespace STSDesktop
{
    public partial class Login : Form
    {
        AccountBL accountService = new AccountBL();
        public Login()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string userName = txbUsername.Text;
            string password = txbPassword.Text;

            if (!accountService.LogInValid(userName, password))
            {
                MessageBox.Show("Invalid Username or Password.", "Login Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);

                if (accountService.LogInAttempts())
                {
                    MessageBox.Show("Too many failed attempts. Please try again later.", "Locked Out", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    btnLogin.Enabled = false;
                }
                return;
            }

            MessageBox.Show("Login successful!", "Welcome", MessageBoxButtons.OK, MessageBoxIcon.Information);

            Dashboard dashboardForm = new Dashboard();
            dashboardForm.FormClosed += (s, args) => this.Show(); 
            dashboardForm.Show();
            this.Hide();

        }


    }
}
