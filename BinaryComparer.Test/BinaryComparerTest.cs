using NUnit.Framework;
using System;
using System.Collections.Generic;
using BinaryComparer;

namespace BinaryComparer.Test {
    public class BinaryComparerTest {
        private static readonly List<Difference> EmptyList = new List<Difference>();

        [Test, TestCaseSource(nameof(SanityTestCases))]
        public void SanityTests(byte[] left, byte[] right, List<Difference> expectedResult) {
            Assert.IsNotNull(left);
        }

        internal static object[] SanityTestCases = {
            new object[] { new byte[0], new byte[0], EmptyList },
            new object[] { null, null, EmptyList },
        };
    }
}