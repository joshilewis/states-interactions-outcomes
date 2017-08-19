using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;

namespace ATM
{
    [TestFixture]
    public class CheckBalanceSpecs : Fixture
    {
        [Test]
        public void AtmDisconnected()
        {
            Runner.RunScenario(
                given => DisconnectedATM(),
                when => CheckBalance(),
                then => Error_AtmDisconnected());

        }

        [Test]
        public void IncorrectPin()
        {
            Runner.RunScenario(
                given => ConnectedATM(),
                when => CheckBalanceWithIncorrectPin(),
                then => Error_IncorrectPin());

        }

        [Test]
        public void ZeroBalance()
        {
            Runner.RunScenario(
                given => ConnectedATM(),
                given => AccountBalanceIs(0),
                when => CheckBalance(),
                then => ReportedBalanceIs(0));

        }

        [Test]
        public void RegularBalance()
        {
            Runner.RunScenario(
                given => ConnectedATM(),
                given => AccountBalanceIs(100),
                when => CheckBalance(),
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

        private void CheckBalanceWithIncorrectPin()
        {
        }

        private void Error_IncorrectPin()
        {
        }

        private void CheckBalance()
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
