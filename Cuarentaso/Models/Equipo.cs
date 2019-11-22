using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Cuarentaso.Models
{
  public class Equipo
  {
    public int id { get; set; }
    public string nombre { get; set; }
    public string alias { get; set; }
    public int puntos { get; set; }
    public string estado { get; set; }
  }
}