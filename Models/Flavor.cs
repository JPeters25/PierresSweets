using System.Collections.Generic;

namespace PierreSweets.Models
{
  public class Flavor
  {
    public Flavor()
    {
      this.JoinEntities = new HashSet<FlavorTreat>();
    }

    public int Flavor { get; set; }
    public string Description { get; set; }
    public virtual ICollection<FlavorTreat> JoinEntities { get; set; }
  }
}