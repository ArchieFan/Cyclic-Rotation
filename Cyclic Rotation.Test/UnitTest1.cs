namespace Cyclic_Rotation.Test
{
    public class UnitTest1
    {
        [Theory]
        [InlineData(new int[] { 3, 8, 9, 7, 6 }, new int[] { 8, 9, 7, 6, 3 })]
        [InlineData(new int[] { 1, 2, 3, 4 }, new int[] { 1, 2, 3, 4 })]
        [InlineData(new int[] { }, new int[] { })]
        [InlineData(new int[] { 4 }, new int[] { 4 })]
        public void XUnitTest(int[] inputarr, int[] expectedarr)
        {
            Solution so = new Solution();
            int[] actualarr = so.solution(inputarr, 4);

            Assert.Equal(expectedarr, actualarr);
        }
    }
}