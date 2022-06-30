namespace TestProject1
{
    [TestClass]
    //[DataRow(new[] { 3, 8, 9, 7, 6 }, 6, new[] { 6, 3, 8, 9, 7 })]
    public class UnitTest1n
    {
        [TestMethod]
        public void TestMethod1(int[] A, int K, int[] B)
        {

            Assert.AreEqual(A.Length, B.Length);

        }
    }
}