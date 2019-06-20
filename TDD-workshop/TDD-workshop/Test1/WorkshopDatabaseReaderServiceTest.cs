using Moq;
using NUnit.Framework;
using System.Collections.Generic;
using System.Linq;
using TDDWorkshop.Interfaces;
using TDDWorkshop.Models;
using TDDWorkshop.Services;

namespace Tests
{
    public class WorkshopDatabaseReaderServiceTest
    {
        public class TheReadAllSortedMethod
        {
            #region Specification
            /* Specification: Read all entries from the database. */
            #endregion

            [Test]
            public void ReadsAllEntriesFromDatabaseSorted()
            {
                #region Step1
                /* Create a service for reading a database */
                var workshopDatabaseReaderService = new WorkshopDatabaseReaderService();
                #endregion

                #region Step3
                /* Mock the database entries and have the test pass */
                var databaseMock = new Mock<IWorkshopDatabase>();
                var jelicaEntry = new WorkshopDatabaseEntry() { Name = "Jelica", LastName = "Kapetina" };
                var aleksandarEntry = new WorkshopDatabaseEntry() { Name = "Aleksandar", LastName = "Kahriman" };
                databaseMock.Setup(workshopDatabase => workshopDatabase.DatabaseEntries).Returns(
                        new List<WorkshopDatabaseEntry>() { jelicaEntry, aleksandarEntry });
                workshopDatabaseReaderService.WorkshopDatabase = databaseMock.Object;
                #endregion

                #region Step2
                /* Invoke a method, and assert the result */
                var results = workshopDatabaseReaderService.ReadAllSorted().ToList();
                Assert.IsTrue(results != null);
                Assert.IsTrue(results[0] == aleksandarEntry);
                #endregion
            }
        }
    }
}