using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bank {
		public partial class xrsBank : Form {
				private Bank bank = new Bank();
				public xrsBank() {
						InitializeComponent();
				}

				private void UpdateAccountList() {
						lbxAccounts.Items.Clear();
						foreach (BankAccount account in bank.Accounts) lbxAccounts.Items.Add(account);
				}

				private void btnDeposit_Click(object sender, EventArgs e) {
						if(lbxAccounts.SelectedItem != null) {
								double amount;
								
								if( ! double.TryParse(tbxAmount.Text, out amount)) {
										MessageBox.Show("Wrong amount");
										return;
								}
								
								(lbxAccounts.SelectedItem as BankAccount).Deposit(amount);
								UpdateAccountList();
						} else {
								MessageBox.Show("Select an account", Text);
						}
				}

				private void btnWithdraw_Click(object sender, EventArgs e) {
						if(lbxAccounts.SelectedItem != null) {
								double amount;
								if( ! double.TryParse(tbxAmount.Text, out amount)) {
										MessageBox.Show("Wrong amount", Text);
										return;
								}

								if ((lbxAccounts.SelectedItem as BankAccount).Withdraw(amount) == false) {
										MessageBox.Show("Insufficient funds", Text);
								}  else {
										UpdateAccountList();
								} 
						} else {
								MessageBox.Show("Select an account", Text);
						}
				}

				private void btnRegister_Click(object sender, EventArgs e) {
						double interestRate;
						if( ! double.TryParse(tbxInterestRate.Text, out interestRate)) {
								MessageBox.Show("Illegal interest rate", Text);
								return;
						}

						double credit;
						if( ! double.TryParse(tbxCredit.Text, out credit)) {
								MessageBox.Show("Illegal credit amount", Text);
								return;
						}

						BankAccount newAccount;
						if(credit == 0) {
								newAccount = new SavingsAccount(tbxAccountNr.Text, interestRate);
						} else {
								newAccount = new CreditAccount(tbxAccountNr.Text, interestRate, credit);
						}

						bank.Accounts.Add(newAccount);
						lbxAccounts.Items.Add(newAccount);

						foreach(Control control in gbxOpenAccount.Controls) {
								if (control is TextBox) (control as TextBox).Clear();
						}
				}

				private void btnUpdateWI_Click(object sender, EventArgs e) {
						foreach(BankAccount account in bank.Accounts) {
								account.CalculateInterest();
						}
						UpdateAccountList();
				}

				public abstract class BankAccount {

						protected string accountNr = "";
						protected double holdings = 0;
						protected double interestRate = 0;

						//constructor
						public BankAccount(string accountNr, double interestRate) {
								this.accountNr = accountNr;
								this.interestRate = interestRate;
						}

						//values
						public double Holdings {
								get { return this.holdings; }
								set { this.holdings = value; }
						}

						//methods
						public void Deposit(double amount) {
								this.holdings += amount;
						}
						public abstract bool Withdraw(double amount);
						public abstract double CalculateInterest();
				}

				public class SavingsAccount : BankAccount {
						public SavingsAccount(string accountNr, double interestRate) : base(accountNr, interestRate) {

						}

						public override bool Withdraw(double amount) {
								if(amount <= holdings) {
										holdings -= amount;
										return true;
								} else {
										return false;
								}
						}

						public override double CalculateInterest() {
								double rate = holdings * interestRate / 100;
								holdings += rate;
								return rate;
						}

						public override string ToString() {
								return "Savings Acc nr: " + accountNr + ": " + holdings;
						}
				}

				public class CreditAccount : BankAccount {
						protected double credit = 0;

						public CreditAccount (string accountNr, double interestRate, double credit) : base(accountNr, interestRate) {
								this.credit = credit;
						}

						public override bool Withdraw (double amount) {
								if (amount <= holdings + credit) {
										holdings -= amount;
										return true;
								} else {
										return false;
								}
						}

						public override double CalculateInterest() {
								double rate = 0;
								if(holdings < 0) {
										rate = holdings * interestRate / 100;
										holdings += rate;
								}
								return rate;
						}

						public override string ToString() {
								return "Credit Acc nr: " + accountNr + ": " + holdings;
						}
				}

				public class Bank {
						public List<BankAccount> Accounts = new List<BankAccount>();

						public double Holdings {
								get {
										double holdings = 0;
										foreach (BankAccount account in Accounts) holdings += account.Holdings;
										return holdings;
								}
						}
				}
		}
}
