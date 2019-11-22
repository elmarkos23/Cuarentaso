using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Cuarentaso
{
  public partial class Equipos : System.Web.UI.Page
  {
    protected void Page_Load(object sender, EventArgs e)
    {
      List<Models.Equipo> equipos = new List<Models.Equipo>();
      equipos.Add(new Models.Equipo { id = 1, nombre = "A", puntos = 0, alias = "Ninguno", estado = "ACTIVO" }); ;
      gvDatos.DataSource = equipos;
      gvDatos.DataBind();
    }
  }
}