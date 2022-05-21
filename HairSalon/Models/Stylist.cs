using System.Collections.Generic;
// using HairSalon.Models;

namespace HairSalon.Models
{
  public class Stylist
  {
    public Stylist()
    {
      // this.Clients = new HashSet<Client>();
    }
    public int StylistsId { get; set; }
    public string Name { get; set; }
    public string Specialty { get; set; }
    // public virtual ICollection<Client> Clients { get; set; }
  }
}