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
    }
}