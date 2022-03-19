using System.Collections.Generic;

namespace Factory.Models
{

  public class IndexDisplay
  {
      public IEnumerable<Engineer> Engineers { get; set; }
      public IEnumerable<Machine> Machines {get; set; }
  }
}