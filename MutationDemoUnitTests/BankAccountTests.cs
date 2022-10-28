using MutationDemo;
using FluentAssertions;

namespace MutationDemoUnitTests
{
    public class BankAccountTests
    {
        [Test]
        public void TestSpend()
        {
            BankAccount account = new(100);
            account.Spend(10);
            account.Balance.Should().Be(90);
        }

        [Test]
        public void TestDeposit()
        {
            BankAccount account = new(100);
            account.Deposit(10);
            account.Deposit(10);
            account.Balance.Should().Be(120);
        }

        // [Test]
        public void WhenNoRobbery_ThenAuditPasses()
        {
            BankAccount account = new(100);
            account.Spend(20);
            account.Deposit(5);
            account.Deposit(99);
            account.Audit().Should().BeTrue();
        }

        // [Test]
        public void WhenRobberyIsCommited_ThenAuditFails()
        {
            BankAccount account = new(100);
            account.Spend(20);
            account.Deposit(5);
            account.Deposit(99);
            account.Rob();
            account.Audit().Should().BeFalse();
        }

        // [Test]
        public void CheckAllSpendingReturnsRightValues()
        {
            BankAccount account = new();
            account.Spend(20);
            account.Spend(20);
            account.Spend(20);
            account.Deposit(20);
            account.Deposit(20);
            account.Deposit(20);
            account.AllSpending.Should().HaveCount(3);
        }

    }
}