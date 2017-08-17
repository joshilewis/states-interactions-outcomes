using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;

namespace ATM
{
    [TestFixture]
    public class CheckBalance : Fixture
    {
        [Test]
        public void AtmDisconnected()
        {
            Runner.RunScenario(
                given => DisconnectedATM(),
                when => ICheckBalance(),
                then => Error_AtmDisconnected());

        }

        [Test]
        public void IncorrectPin()
        {
            Runner.RunScenario(
                given => ConnectedATM(),
                when => ICheckBalanceWithIncorrectPin(),
                then => Error_IncorrectPin());

        }

        [Test]
        public void ZeroBalance()
        {
            Runner.RunScenario(
                given => ConnectedATM(),
                given => AccountBalanceIs(0),
                when => ICheckBalance(),
                then => ReportedBalanceIs(0));

        }

        [Test]
        public void RegularBalance()
        {
            Runner.RunScenario(
                given => ConnectedATM(),
                given => AccountBalanceIs(100),
                when => ICheckBalance(),
                then => ReportedBalanceIs(100));

        }

        private void AccountBalanceIs(decimal actualBalance)
        {
        }

        private void ReportedBalanceIs(decimal expectedBalance)
        {

        }

        private void ConnectedATM()
        {
        }

        private void ICheckBalanceWithIncorrectPin()
        {
        }

        private void Error_IncorrectPin()
        {
        }

        private void ICheckBalance()
        {
        }

        private void Error_AtmDisconnected()
        {
        }

        private void DisconnectedATM()
        {

        }
    }
}
