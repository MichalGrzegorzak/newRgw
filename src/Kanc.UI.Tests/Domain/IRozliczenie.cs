using System;
using Kanc.UI.Tests;

namespace Kanc.UI.Tests
{
    public interface IRozliczenie
    {
        int Rok { get; set; }
        Kraje Kraj { get; set; }
        Klient_A KlientA { get; set; }
        string MandId { get; set; }
        Int64? Steuernummer { get; set; }
        string Imie { get; set; }
        string ImieDe { get; set; }
        string Nazwisko { get; set; }
        string NazwiskoDe { get; set; }
        string Telefon { get; set; }
        string Komorka { get; set; }
        string Notka { get; set; }
        string Email { get; set; }
        int? KontoLk { get; set; }
        int KontoBlz { get; set; }
        Int64 KontoNr { get; set; }
        int DzieciLiczba { get; set; }
        string DzieciDaty { get; set; }
        int Status { get; set; }
        int Pozycja { get; set; }
        int Zaplacono { get; set; }
        DateTime CreatedOn { get; set; }
        DateTime MovedOn { get; set; }
        string CreatedBy { get; set; }
        string ModifiedBy { get; set; }
        DateTime ModifiedOn { get; set; }
    }
}