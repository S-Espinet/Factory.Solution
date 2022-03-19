using System;
using System.ComponentModel;
using System.Collections.Generic;

namespace Factory.Models
{
  public class Engineer
  {
    public Engineer()
    {
      this.JoinEntities = new HashSet<EngineerMachine>();
    }

    public int EngineerId { get; set; }
    [DisplayName("Name")]
    public string EngineerName { get; set; }
    public DateTime HireDate { get; set; }

    public virtual ICollection<EngineerMachine> JoinEntities { get;}
  }
}