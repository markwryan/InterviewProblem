using NUnit.Framework;

namespace InterviewProblem
{
    [TestFixture]
    public class MergeTests
    {
        [Test]
        public void MergeEqualItemsTest()
        {
            var array1 = new[] {'a', 'b', 'c'};
            var array2 = new[] {'1', '2', '3'};

            var expectedMergedArray = new[] {'a', '1', 'b', '2', 'c', '3'};
            var actualMergedArray = MergeArray.Merge(array1, array2);

            for (var i = 0; i < expectedMergedArray.Length; i++)
            {
                Assert.AreEqual(expectedMergedArray[i], actualMergedArray[i]);
            }
        }

        [Test]
        public void MergeUnequalItemsTest()
        {
            var array1 = new[] {'a', 'b'};
            var array2 = new[] {'1', '2', '3', '4'};

            var expectedMergedArray = new[] {'a', '1', 'b', '2', '3', '4'};
            var actualMergedArray = MergeArray.Merge(array1, array2);

            for (var i = 0; i < expectedMergedArray.Length; i++)
            {
                Assert.AreEqual(expectedMergedArray[i], actualMergedArray[i]);
            }
        }

        [Test]
        public void MergeLargeEqualItemsTest()
        {
            var array1 = new[] { 'f', '5', 'c', 'q', '9', '-', 't', '1' };
            var array2 = new[] { '4', '2', '3', '/', 'e', '8', 'v', 'x' };

            var expectedMergedArray = new[]
                {'f', '4', '5', '2', 'c', '3', 'q', '/', '9', 'e', '-', '8', 't', 'v', '1', 'x'};

            var actualMergedArray = MergeArray.Merge(array1, array2);

            for (var i = 0; i < expectedMergedArray.Length; i++)
            {
                Assert.AreEqual(expectedMergedArray[i], actualMergedArray[i]);
            }
        }

        [Test]
        public void MergeLargeUnequalItemsTest()
        {
            var array1 = new[] { 'f', '5', 'c', 'q', '9', '-', 't', '1' };
            var array2 = new[] { '4', '2', '3' };

            var expectedMergedArray = new[]
                {'f', '4', '5', '2', 'c', '3', 'q', '9', '-', 't', '1'};

            var actualMergedArray = MergeArray.Merge(array1, array2);

            for (var i = 0; i < expectedMergedArray.Length; i++)
            {
                Assert.AreEqual(expectedMergedArray[i], actualMergedArray[i]);
            }
        }

        [Test]
        public void MergeWithOneNull()
        {
            char[] array1 = null;
            var array2 = new[] {'4', '3', '2'};
            var expectedMergedArray = new[] {'4', '3', '2'};
            var actualMergedArray = MergeArray.Merge(array1, array2);

            for (var i = 0; i < expectedMergedArray.Length; i++)
            {
                Assert.AreEqual(expectedMergedArray[i], actualMergedArray[i]);
            }
        }

        [Test]
        public void MergeWithBothNull()
        {
            char[] array1 = null;
            char[] array2 = null;
            var actualMergedArray = MergeArray.Merge(array1, array2);
            Assert.IsNull(actualMergedArray);
        }

        [Test]
        public void MergeWithBothEmpty()
        {
            var array1 = new char[] { };
            var array2 = new char[] { };

            var actualMergedArray = MergeArray.Merge(array1, array2);
            
            Assert.IsTrue(actualMergedArray.Length == 0);
        }
    }
}
