using System;
using System.Linq;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace RocketpackSdk
{
  public class RocketpackClient
  {
    // private variables
    private RocketpackConfig config;
    private DataService.DataService dataService;

    // public properties
    public DataService.DataService DataService
    {
      get => dataService != null ? dataService : new DataService.DataService(config);
    }

    // constructor
    public RocketpackClient(RocketpackConfig config)
    {
      this.config = config;
    }

  }
}
