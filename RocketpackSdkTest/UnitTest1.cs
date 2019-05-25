using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace RocketpackSdkTest
{
  [TestClass]
  public class UnitTest1
  {
    [TestMethod]
    public void GetAllCollections()
    {
      var rp = new RocketpackSdk.RocketpackClient(new RocketpackSdk.RocketpackConfig
      {
        RepositoryID = Guid.Parse("AAC8C3B3-28A7-4DF4-B2E5-0B40D5BB27E0")
      });

    }
  }
}
