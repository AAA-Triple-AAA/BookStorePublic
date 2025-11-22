using BookStoreBO;

namespace BookStoreUI;

public partial class frmLogin : Form
{
    public frmLogin()
    {
        InitializeComponent();
    }

    private bool ValidateInput(string username, string password)
    {
        var errMsg = Validator.IsPresent(txtUsername.Text, "Username");
        errMsg += Validator.IsPresent(txtPassword.Text, "Password");

        if (errMsg == "")
        {
            // TODO: SEARCH LOGIC
        }
        else
        {
            MessageBox.Show(errMsg);
            return false;
        }

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
        var username = txtUsername.Text;
        var password = txtPassword.Text;

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
