﻿using Loans.Domain.Applications;
using NUnit.Framework;

namespace Loans.Tests
{
    [TestFixture]
    class LoanTermShould
    {
        [Test]
        public void ReturnTemInMonths()
        {
            var sut = new LoanTerm(1);
            Assert.That(sut.ToMonths(), Is.EqualTo(12));
        }

        [Test]
        public void StoreYears()
        {
            var sut = new LoanTerm(1);

            Assert.That(sut.Years, Is.EqualTo(1));
        }
    }
}
