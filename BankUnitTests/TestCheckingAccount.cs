using Microsoft.VisualStudio.TestTools.UnitTesting;
using codingChallenge;

namespace BankUnitTests
{
    [TestClass]
    public class TestCheckingAccount
    {

        #region Deposit Tests

        [TestMethod]
        public void CheckingDeposit()
        {
            //Arrange
            decimal startingBalance = 10;
            decimal depositAmount = 20;
            decimal expected = 30;
            string accountOwner = "Bob Smith";
            Account account = new Account(AccountTypes.Checking, accountOwner, startingBalance);

            //Act
            account.Transaction(TransactionTypes.Deposit, depositAmount);

            //Assert
            decimal actual = account.AccountBalance;
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void IndividualInvestmentDeposit()
        {
            //Arrange
            decimal startingBalance = 10;
            decimal depositAmount = 20;
            decimal expected = 30;
            string accountOwner = "Bob Smith";
            Account account = new Account(AccountTypes.IndividualInvestment, accountOwner, startingBalance);

            //Act
            account.Transaction(TransactionTypes.Deposit, depositAmount);

            //Assert
            decimal actual = account.AccountBalance;
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void CorporateInvestmentDeposit()
        {
            //Arrange
            decimal startingBalance = 10;
            decimal depositAmount = 20;
            decimal expected = 30;
            string accountOwner = "Bob Smith";
            Account account = new Account(AccountTypes.CorporateInvestment, accountOwner, startingBalance);

            //Act
            account.Transaction(TransactionTypes.Deposit, depositAmount);

            //Assert
            decimal actual = account.AccountBalance;
            Assert.AreEqual(expected, actual);
        }

        #endregion



        #region Withdrawal Tests

        [TestMethod]
        public void CheckingWithdrawal()
        {
            //Arrange
            decimal startingBalance = 1000;
            decimal withdrawalAmount = 499;
            decimal expected = 501;
            string accountOwner = "Bob Smith";
            Account account = new Account(AccountTypes.Checking, accountOwner, startingBalance);

            //Act
            account.Transaction(TransactionTypes.Withdrawal, withdrawalAmount);

            //Assert
            decimal actual = account.AccountBalance;
            Assert.AreEqual(expected, actual);

        }

        [TestMethod]
        public void IndividualInvestmentWithdrawal()
        {
            //Arrange
            decimal startingBalance = 1000;
            decimal withdrawalAmount = 499;
            decimal expected = 501;
            string accountOwner = "Bob Smith";
            Account account = new Account(AccountTypes.IndividualInvestment, accountOwner, startingBalance);

            //Act
            account.Transaction(TransactionTypes.Withdrawal, withdrawalAmount);

            //Assert
            decimal actual = account.AccountBalance;
            Assert.AreEqual(expected, actual);

        }

        [TestMethod]
        public void CorporateInvestmentWithdrawal()
        {
            //Arrange
            decimal startingBalance = 1000;
            decimal withdrawalAmount = 499;
            decimal expected = 501;
            string accountOwner = "Bob Smith";
            Account account = new Account(AccountTypes.CorporateInvestment, accountOwner, startingBalance);

            //Act
            account.Transaction(TransactionTypes.Withdrawal, withdrawalAmount);

            //Assert
            decimal actual = account.AccountBalance;
            Assert.AreEqual(expected, actual);

        }

        #endregion


        #region Transfer Tests

        [TestMethod]
        public void CheckingToIndividualInvestmentTransfer()
        {
            //Arrange
            decimal toAccountStartBalance = 0;
            decimal fromAccountStartBalance = 1000;
            decimal transferAmount = 100;
            decimal expected = 100; 
            string toAccountOwner = "Bob Smith";
            string fromAccountOwner = "Fred Smith";
            Account toAccount = new Account(AccountTypes.IndividualInvestment, toAccountOwner, toAccountStartBalance);
            Account fromAccount = new Account(AccountTypes.Checking, fromAccountOwner, fromAccountStartBalance);

            //Act
            fromAccount.Transaction(TransactionTypes.Transfer, transferAmount, fromAccount, toAccount);

            //Assert
            decimal actual = toAccount.AccountBalance;
            Assert.AreEqual(expected, actual);
        }

        public void IndividualToCorporateInvestmentTransfer()
        {
            //Arrange
            decimal toAccountStartBalance = 0;
            decimal fromAccountStartBalance = 1000;
            decimal transferAmount = 100;
            decimal expected = 100;
            string toAccountOwner = "Bob Smith";
            string fromAccountOwner = "Fred Smith";
            Account toAccount = new Account(AccountTypes.CorporateInvestment, toAccountOwner, toAccountStartBalance);
            Account fromAccount = new Account(AccountTypes.IndividualInvestment, fromAccountOwner, fromAccountStartBalance);

            //Act
            fromAccount.Transaction(TransactionTypes.Transfer, transferAmount, fromAccount, toAccount);

            //Assert
            decimal actual = toAccount.AccountBalance;
            Assert.AreEqual(expected, actual);
        }

        public void CorporateInvestmentToCheckingTransfer()
        {
            //Arrange
            decimal toAccountStartBalance = 0;
            decimal fromAccountStartBalance = 1000;
            decimal transferAmount = 100;
            decimal toExpected = 100;
            decimal fromExpected = 900;
            string toAccountOwner = "Bob Smith";
            string fromAccountOwner = "Fred Smith";
            Account toAccount = new Account(AccountTypes.Checking, toAccountOwner, toAccountStartBalance);
            Account fromAccount = new Account(AccountTypes.CorporateInvestment, fromAccountOwner, fromAccountStartBalance);

            //Act
            fromAccount.Transaction(TransactionTypes.Transfer, transferAmount, fromAccount, toAccount);

            //Assert
            decimal toActual = toAccount.AccountBalance;
            decimal fromActual = fromAccount.AccountBalance;
            Assert.AreEqual(toExpected, toActual);
            Assert.AreEqual(fromExpected, fromActual);
        }


        #endregion

    }
}
