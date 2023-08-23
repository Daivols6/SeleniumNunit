using NUnit.Framework;

namespace DIPLOM.Diplom.Test
{
    internal class TestForAzure
    {
        [Test(Description = "test without skinshots for AzureDevOps")]
        public void AzureTestPassed()
        {
            Assert.Pass();
        }
    }
}
