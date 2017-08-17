using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LightBDD;
using LightBDD.Coordination;
using LightBDD.Notification;
using NUnit.Framework;

namespace ATM
{
    [TestFixture]
    public abstract class Fixture
    {
        protected BDDRunner Runner { get; private set; }

        [OneTimeSetUp]
        public void FixtureSetUp()
        {
            Runner = new BDDRunner(this.GetType(), CreateProgressNotifier());
        }

        [OneTimeTearDown]
        public void FixtureTearDown()
        {
            FeatureCoordinator.Instance.AddFeature(Runner.Result);
        }

        protected virtual IProgressNotifier CreateProgressNotifier()
        {
            return new ConsoleProgressNotifier();
        }

    }
}
