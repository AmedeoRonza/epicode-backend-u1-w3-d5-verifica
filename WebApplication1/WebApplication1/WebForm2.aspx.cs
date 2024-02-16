using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication1
{
    public partial class WebForm2 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Request.Cookies["Dettagli"] != null)
            {
                string nome = Request.Cookies["Dettagli"]["Nome"];
                string prezzo = Request.Cookies["Dettagli"]["Prezzo"];
                string urlImmagine = Request.Cookies["Dettagli"]["UrlImmagine"];

                // Visualizza il nome e il prezzo come testo
                DatiProdotti.InnerText = "Nome: " + nome + ", Prezzo: " + prezzo;

                // Imposta l'URL dell'immagine
                imgProdotto.ImageUrl = urlImmagine;
            }
            else
            {
                Response.Redirect("Default.aspx");
            }
        }
        protected void logout_Click(object sender, EventArgs e)
        {
            HttpCookie Dettagli = new HttpCookie("Dettagli");
            Dettagli.Expires = DateTime.Now.AddDays(-1);
            Response.Cookies.Add(Dettagli);

            Response.Redirect("Default");
        }
    }
}
    

    