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
        public class TheReadAllMethod
        {
            #region Specification
            /* Specification: Read all entries from the database. */
            #endregion

            [Test]
            public void ReadsAllEntriesFromDatabase()
            {
                #region Step1
                /* Create a service for reading a database */
                var workshopDatabaseReaderService = new WorkshopDatabaseReaderService();
                #endregion

                #region Step3
                /* Mock the database entries and have the test pass */
                var databaseMock = new Mock<IWorkshopDatabase>();
                databaseMock.Setup(workshopDatabase => workshopDatabase.DatabaseEntries).Returns(
                    new List<WorkshopDatabaseEntry>() {
                        new WorkshopDatabaseEntry() { Name = "Aleksandar", LastName = "Kahriman" },
                        new WorkshopDatabaseEntry() { Name = "Jelica", LastName = "Kapetina" } });
                workshopDatabaseReaderService.WorkshopDatabase = databaseMock.Object;
                #endregion

                #region Step2
                /* Invoke a method, and assert the result */
                var results = workshopDatabaseReaderService.ReadAll().ToList();
                Assert.IsTrue(results.Count >  0);
                #endregion
            }
        }
    }
}