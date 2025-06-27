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
                    txbUsername.Text = "";
                    txbPassword.Text = "";

                    MessageBox.Show("Too many failed attempts. Please try again later.", "Locked Out", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    btnLogin.Visible = false;

                    System.Threading.Thread.Sleep(3000);

                    btnLogin.Visible = true;
                }
                return;
            }


            Dashboard dashboard = new Dashboard();
            dashboard.FormClosed += (s, args) => this.Show(); 
            dashboard.Show();
            this.Hide();
            txbPassword.Text = "";

        }


    }
}
