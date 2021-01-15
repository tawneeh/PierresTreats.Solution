using System.Collections.Generic;

namespace PierresTreats.Models
{
  public class Treat
  {
    public Treat()
    {
      this.Flavors = new HashSet<FlavorTreat>();
    }
    public int Id { get; set; }
    public string Name { get; set; } 
    public virtual ApplicationUser User { get; set; }
    public ICollection<FlavorTreat> Flavors { get; }

  }
}