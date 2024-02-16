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
        protected void Page_Load(object sender, EventArgs e) // evento all'avvio della pagina che riprende tramite cookie i dettagli del prodotto dalla pagina precedente
        {
            if (Request.Cookies["Dettagli"] != null)
            {
                string nome = Request.Cookies["Dettagli"]["Nome"];
                string prezzo = Request.Cookies["Dettagli"]["Prezzo"];
                string descrizione = Request.Cookies["Dettagli"]["Descrizione"];
                string urlImmagine = Request.Cookies["Dettagli"]["UrlImmagine"];

                // Visualizza il nome e il prezzo come testo
                DatiProdotti.InnerText = "Nome: " + nome + ", Prezzo: " + prezzo + " Descrizione: " + descrizione;

                // Imposta l'URL dell'immagine
                imgProdotto.ImageUrl = urlImmagine;
            }
            else
            {
                Response.Redirect("Default.aspx");
            }
        }
        

        protected void Button1_Click(object sender, EventArgs e) // evento button che dovrebbe aggiungere un prodotto al carrello ma che in realtà fa solo apparire la scritta
        {
            MessageLiteral.Text = "<p>Prodotto aggiunto al carrello</p>";
        }

        protected void Button2_Click(object sender, EventArgs e) // evento button per tornare alla pagina prodotti in quanto dopo "aver aggiunto" un prodotto al carrello, facendo indietro dal browser, non torna indietro
        {
            HttpCookie ComeBack = new HttpCookie("ComeBack");
            ComeBack.Expires = DateTime.Now.AddDays(-1);
            Response.Cookies.Add(ComeBack);
            Response.Redirect("Default.aspx");
        }
    }
}
    

    