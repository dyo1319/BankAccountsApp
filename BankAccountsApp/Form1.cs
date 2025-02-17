namespace BankAccountsApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            BankAccount bankAccount = new BankAccount();
            bankAccount.Owner = "ZoZo  Baba";
            bankAccount.AccountNumber = Guid.NewGuid();
            bankAccount.Balance = 250;


            BankAccount bankAccount2 = new BankAccount();
            bankAccount2.Owner = "Elon  Musk";
            bankAccount2.AccountNumber = Guid.NewGuid();
            bankAccount2.Balance = 350;


            BankAccount bankAccount3 = new BankAccount();
            bankAccount3.Owner = "Bat  Man";
            bankAccount3.AccountNumber = Guid.NewGuid();
            bankAccount3.Balance = 450;

            List<BankAccount> bankAccounts = new List<BankAccount>();
            bankAccounts.Add(bankAccount);
            bankAccounts.Add(bankAccount2);
            bankAccounts.Add(bankAccount3);

            BankAccountsGrid.DataSource = bankAccounts;

        }
        private void label1_Click(object sender, EventArgs e)
        {
            // Add your logic here if needed
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {

        }
    }
}
