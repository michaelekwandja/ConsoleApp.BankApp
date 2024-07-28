using ConsoleApp.BankApp;

namespace BankAccountTests
{
    [TestClass]
    public class BankAccountTests
    {
        

        [TestMethod]
        public void Withdraw_From_Amount()
        {
            // Arrange
            Account account = new Account("mike", "6789", 500);
            decimal amount = 200;
            decimal expected = 300;
            //int answer = account.

            // Act
            Account.Withdraw(amount);

            // Assert
            Assert.AreEqual(expected, Account.Balance);
        }
        [TestMethod]
        public void Deposit_From_Account()
        {
            // Arrange
            Account account = new("mike", "123456", 500);
            decimal amount = 200;
            decimal expected = 700;
            // Act
            Account.Deposit(amount);

            // Assert
            Assert.AreEqual(expected, Account.Balance);
        }
    }
}