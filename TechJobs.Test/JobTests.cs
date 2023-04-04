
using Microsoft.VisualStudio.TestPlatform.Utilities;
using System.Xml.Linq;

namespace TechJobs.Tests
{
    [TestClass]
    public class JobTests
    {
        //Testing Objects
        //initalize your testing objects here

        //Testing objects
        Job job1 = new Job();

        Job job2 = new Job();

        Job job3 = new Job("Product tester", new Employer("ACME"), new Location("Desert"), new PositionType("Quality control"), new CoreCompetency("Persistence"));

        Job job4 = new Job("Product tester", new Employer("ACME"), new Location("Desert"), new PositionType("Quality control"), new CoreCompetency("Persistence"));

        [TestMethod]
        public void TestSettingJobId()
        {
            // test_Job(1);
            //Assert.AreEqual(1, test_job1.id, .001);

            Assert.AreNotEqual(job1.Id, job2.Id, .001);
            Assert.AreEqual(job1.Id, job2.Id - 1, .001);
        }
        [TestMethod]
        public void TestJobConstructorSetsAllFields()
        {
            //Assert.AreEqual(job3(Product tester), Job.string Name) , .001);
            Assert.AreEqual("Product tester", job3.Name);
            Assert.AreEqual("ACME", job3.EmployerName);
            Assert.AreEqual("Desert", job3.EmployerLocation);
            Assert.AreEqual("Quality control", job3.JobType);
            Assert.AreEqual("Persistence", job3.JobCoreCompetency);
        }

        [TestMethod]
        public void TestJobsForEquality()
        {

            bool result = Equals(job3);

            Assert.IsFalse(result, "Id's are not equal");
        }
        [TestMethod]

        public void TestToStringStartsAndEndsWithNewLine()
        {
            Assert.IsTrue(job3.ToString().StartsWith(Environment.NewLine));
            Assert.IsTrue(job3.ToString().EndsWith(Environment.NewLine));

        }

        [TestMethod]
        public void TestToStringContainsCorrectLabelsAndData()
        {
            Assert.IsTrue(job3.ToString().Contains("Name: Product tester"));
            Assert.IsTrue(job3.ToString().Contains("Employer: ACME"));
            Assert.IsTrue(job3.ToString().Contains("Location: Desert"));
            Assert.IsTrue(job3.ToString().Contains("Position Type: Quality control"));
            Assert.IsTrue(job3.ToString().Contains("Core Competency: Persistence"));
           
        }

        [TestMethod]
        public void TestToStringHandlesEmptyField()
        {
            Assert.IsTrue(job2.ToString().Contains("Name: Data not available"));
            Assert.IsTrue(job2.ToString().Contains("Employer: Data not available"));
            Assert.IsTrue(job2.ToString().Contains("Location: Data not available"));
            Assert.IsTrue(job2.ToString().Contains("Position Type: Data not available"));
            Assert.IsTrue(job2.ToString().Contains("Core Competency: Data not available"));

        }
    }
}



