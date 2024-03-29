﻿using System;
using System.Collections.Generic;
using System.Web;
using System.Web.UI;
using System.Web.UI.HtmlControls;
using System.Web.UI.WebControls;

namespace WebApplication3                         // nella pagina html non mi fa inserire i commenti
{
    public partial class _Default : Page
    {
        public class Prodotto             // creazione classe
        {
            public int Id { get; set; }
            public string Nome { get; set; }
            public string Descrizione { get; set; }
            public decimal Prezzo { get; set; }
            public string UrlImmagine { get; set; }
        }

        public static class ProductsList // creazione classe lista
        {
            public static List<Prodotto> Prodotti { get; private set; }

            static ProductsList()
            {
                Prodotti = new List<Prodotto> // creazione lista
                {
                    new Prodotto { Id = 1, Nome = "Xiaomi 11", Descrizione = "Beeeeeeeeeeeeello", Prezzo = 100.00m, UrlImmagine = "./Content/Immagini/11.jpg" },
                    new Prodotto { Id = 2, Nome = "Xiaomi 12", Descrizione = "Troppo cool bro", Prezzo = 200.00m, UrlImmagine = "./Content/Immagini/12.jpg" },
                    new Prodotto { Id = 3, Nome = "Xiaomi 13", Descrizione = "Pazzesco", Prezzo = 300.00m, UrlImmagine = "./Content/Immagini/13.jpg" },
                    new Prodotto { Id = 4, Nome = "Xiaomi 15", Descrizione = "Ma è strabiliaaaaaaaante", Prezzo = 400.00m, UrlImmagine = "./Content/Immagini/14.jpg" },
                };
            }
        }

        protected void Page_Load(object sender, EventArgs e)   //evento all'avvio della pagina
        {
            if (!IsPostBack)
            {
                // Bind the ProductsList to the Repeater
                ProductRepeater.DataSource = ProductsList.Prodotti;
                ProductRepeater.DataBind();
            }
        }

        protected void Dettagli_Click(object sender, EventArgs e)        // evento button che porta tramite cookie alla pagina dettagli prodotto
        {
            Button btn = (Button)sender;
            RepeaterItem item = (RepeaterItem)btn.NamingContainer;

            Literal lblNome = (Literal)item.FindControl("Nome");
            Literal lblPrezzo = (Literal)item.FindControl("Prezzo");
            Literal lblDescrizione = (Literal)item.FindControl("Descrizione");
            HtmlImage imgImmagine = (HtmlImage)item.FindControl("UrlImmagine");

            string nome = lblNome.Text;
            string prezzo = lblPrezzo.Text;
            string descrizione = lblDescrizione.Text;
            string urlImmagine = imgImmagine.Src;

            HttpCookie Dettagli = new HttpCookie("Dettagli");
            Dettagli.Values["Nome"] = nome;
            Dettagli.Values["Prezzo"] = prezzo;
            Dettagli.Values["Descrizione"] = descrizione;
            Dettagli.Values["UrlImmagine"] = urlImmagine; // Assegna l'URL dell'immagine al valore "UrlImmagine" nel cookie
            Dettagli.Expires = DateTime.Now.AddDays(10);

            Response.Cookies.Add(Dettagli);

            Response.Redirect("WebForm2.aspx");
        }

        protected void Button2_Click(object sender, EventArgs e)   // evento button che porta alla pagina Carrello
        {
            HttpCookie Carrello = new HttpCookie("Carrello");
            Carrello.Expires = DateTime.Now.AddDays(10);

            Response.Cookies.Add(Carrello);

            Response.Redirect("Carrello.aspx");
        }
    }
}
