using Microsoft.VisualStudio.TestTools.UnitTesting;
using TechJobsOO;

namespace TechJobsTests
{
    [TestClass]
    public class JobTests
    {
        [TestMethod]
        public void TestSettingJobId()
        {
            Job test_job = new Job("test", "test", "test", "test", "test");
            Job test_job2 = new Job("test", "test", "test", "test", "test");

            Assert.AreEqual(test_job2.Id, test_job.Id);
        }
    }
}
