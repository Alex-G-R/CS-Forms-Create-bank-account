namespace BankingApp
{
    public partial class Form1 : Form
    {

        private AccountCreated accountCreatedForm;
        public Form1()
        {
            InitializeComponent();
            accountCreatedForm = new AccountCreated();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string nameVal = name.Text;
            string surnameVal = surname.Text;
            string passwordVal = password.Text;
            string initialBalanceVal = initialBalance.Text;

            var account = new Account(nameVal, surnameVal, passwordVal, Convert.ToDecimal(initialBalanceVal));



            accountCreatedForm.SetLogText($"Account was created name: {account.OwnerName}, surname: {account.OwnerSurname}, password: {account.Password}, balance: ${account.Balance}");
            accountCreatedForm.Show();


        }

    }
}