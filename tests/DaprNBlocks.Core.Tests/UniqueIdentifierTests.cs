using DaprNBlocks.Core.Helpers;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using NFluent;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DaprNBlocks.Core.Tests
{
    [TestClass]
    public class UniqueIdentifierTests
    {
        [TestMethod]
        public void GivenWhenNeededAUniqueIdentifier()
        {
            Check.That(Guid.Parse(UniqueIdentifier.New())).IsInstanceOf<Guid>();
        }
    }
}
