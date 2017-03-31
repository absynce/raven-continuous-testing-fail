using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Raven.Tests.Helpers;

namespace raven_continuous_testing_fail
{
   [TestClass]
   public class RavenDbTest : RavenTestBase
   {
      public class Car
      {
         public string Id { get; set; }
         public string Make { get; set; }
         public string Model { get; set; }
         public int Year { get; set; }
      }

      [TestMethod]
      public void FailsWhenRunningInResharperContinuousTestingSession()
      {
         using (
            var store =
               NewDocumentStore(
                  configureStore: documentStore =>
                  {
                     documentStore.Configuration.Storage.Voron.AllowOn32Bits = true;
                  }
               ))
         {
            Car car;
            using (var session = store.OpenSession())
            {
               car = new Car
               {
                  Make = "Tesla",
                  Model = "X",
                  Year = 2017
               };

               session.Store(car);
               session.SaveChanges();
            }

            using (var session = store.OpenSession())
            {
               var loadedCar = session.Load<Car>(car.Id);
               Assert.IsNotNull(loadedCar);
            }
         }
      }
   }
}
