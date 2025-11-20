namespace BookStoreUI;

public partial class frmLogin : Form
{
    public frmLogin()
    {
        InitializeComponent();
    }

    private bool ValidateInput(string username, string password)
    {
        // TODO: IMPLEMENT FUNCTION
        // Must ensure valid input was entered by user in text boxes
        return true;
    }

    private bool ValidateLogin(string username, string password)
    {
        // TODO: IMPLEMENT FUNCTION
        // Must validate the credentials passed by the user
        return true;
    }

    private void btnLogin_Click(object sender, EventArgs e)
    {
        string username = txtUsername.Text;
        string password = txtPassword.Text;

        // TODO: IMPLEMENT PROPER VERIFICATION
        if (!ValidateInput(username, password)) return;
        if (!ValidateLogin(username, password)) return;

        frmMainMenu frm = new();
        frm.FormClosed += (s, args) => this.Close();

        frm.Show();

        this.Hide();
    }

    private void btnExit_Click(object sender, EventArgs e)
    {
        this.Close();
    }
}
