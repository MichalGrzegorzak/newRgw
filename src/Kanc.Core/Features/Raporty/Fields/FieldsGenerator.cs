using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using Kanc.Core.Entities;
using Kanc.Commons;

namespace Kanc.Core.Features.Raporty
{
	public class Fields : Dictionary<string, string>
	{
		protected F F = new F();    	

		public Fields() 
	    {
	    }
		
		public void AddRange(Dictionary<string, string> dict)
        {
            foreach (var pair in dict)
            {
                if (this.ContainsKey(pair.Key))
                    this[pair.Key] = pair.Value;
                else
                    this.Add(pair.Key, pair.Value);
            }
        }

        //public override void Add()
		
		public string Nazwisko
	    {
	        get { return this[F.Nazwisko]; }
	        set { this[F.Nazwisko] = value; }
	    }
    
		public string Imie
	    {
	        get { return this[F.Imie]; }
	        set { this[F.Imie] = value; }
	    }
    
		public string Zawod
	    {
	        get { return this[F.Zawod]; }
	        set { this[F.Zawod] = value; }
	    }
    
		public string AdresKod
	    {
	        get { return this[F.AdresKod]; }
	        set { this[F.AdresKod] = value; }
	    }
    
		public string AdresUlica
	    {
	        get { return this[F.AdresUlica]; }
	        set { this[F.AdresUlica] = value; }
	    }
    
		public string Religia
	    {
	        get { return this[F.Religia]; }
	        set { this[F.Religia] = value; }
	    }
    
		public string Steuernummer
	    {
	        get { return this[F.Steuernummer]; }
	        set { this[F.Steuernummer] = value; }
	    }
    
		public string Urodzony
	    {
	        get { return this[F.Urodzony]; }
	        set { this[F.Urodzony] = value; }
	    }
    
		public string AdresMiasto
	    {
	        get { return this[F.AdresMiasto]; }
	        set { this[F.AdresMiasto] = value; }
	    }
    
		public string Data
	    {
	        get { return this[F.Data]; }
	        set { this[F.Data] = value; }
	    }
    
		public string Adres
	    {
	        get { return this[F.Adres]; }
	        set { this[F.Adres] = value; }
	    }
    
		public string BankKonto
	    {
	        get { return this[F.BankKonto]; }
	        set { this[F.BankKonto] = value; }
	    }
    
		public string BankKod
	    {
	        get { return this[F.BankKod]; }
	        set { this[F.BankKod] = value; }
	    }
    
		public string BankAdres
	    {
	        get { return this[F.BankAdres]; }
	        set { this[F.BankAdres] = value; }
	    }
    
		public string FirmaPoczta
	    {
	        get { return this[F.FirmaPoczta]; }
	        set { this[F.FirmaPoczta] = value; }
	    }
    
		public string FirmaAdres
	    {
	        get { return this[F.FirmaAdres]; }
	        set { this[F.FirmaAdres] = value; }
	    }
    
		public string FirmaOkreg
	    {
	        get { return this[F.FirmaOkreg]; }
	        set { this[F.FirmaOkreg] = value; }
	    }
    
		public string FirmaNazwa1
	    {
	        get { return this[F.FirmaNazwa1]; }
	        set { this[F.FirmaNazwa1] = value; }
	    }
    
		public string FirmaNazwa2
	    {
	        get { return this[F.FirmaNazwa2]; }
	        set { this[F.FirmaNazwa2] = value; }
	    }
    
		public string ZonaImie
	    {
	        get { return this[F.ZonaImie]; }
	        set { this[F.ZonaImie] = value; }
	    }
    
		public string ZonaData
	    {
	        get { return this[F.ZonaData]; }
	        set { this[F.ZonaData] = value; }
	    }
    
		public string ZonaReligia
	    {
	        get { return this[F.ZonaReligia]; }
	        set { this[F.ZonaReligia] = value; }
	    }
    
		public string Imiona
	    {
	        get { return this[F.Imiona]; }
	        set { this[F.Imiona] = value; }
	    }
    
		public string UlicaNrDomu
	    {
	        get { return this[F.UlicaNrDomu]; }
	        set { this[F.UlicaNrDomu] = value; }
	    }
    
		public string KodPocztowy
	    {
	        get { return this[F.KodPocztowy]; }
	        set { this[F.KodPocztowy] = value; }
	    }
    
		public string MiejsceZamieszkania
	    {
	        get { return this[F.MiejsceZamieszkania]; }
	        set { this[F.MiejsceZamieszkania] = value; }
	    }
    
		public string AusgeubterBeruf
	    {
	        get { return this[F.AusgeubterBeruf]; }
	        set { this[F.AusgeubterBeruf] = value; }
	    }
    
		public string Verheiratetseitdem
	    {
	        get { return this[F.Verheiratetseitdem]; }
	        set { this[F.Verheiratetseitdem] = value; }
	    }
    
		public string NrTelefonu
	    {
	        get { return this[F.NrTelefonu]; }
	        set { this[F.NrTelefonu] = value; }
	    }
    
		public string DataUrodzenia
	    {
	        get { return this[F.DataUrodzenia]; }
	        set { this[F.DataUrodzenia] = value; }
	    }
    
		public string MalzonekImie
	    {
	        get { return this[F.MalzonekImie]; }
	        set { this[F.MalzonekImie] = value; }
	    }
    
		public string MalzonekInneNazwisko
	    {
	        get { return this[F.MalzonekInneNazwisko]; }
	        set { this[F.MalzonekInneNazwisko] = value; }
	    }
    
		public string MalzonekInnaUlicaNrDomu
	    {
	        get { return this[F.MalzonekInnaUlicaNrDomu]; }
	        set { this[F.MalzonekInnaUlicaNrDomu] = value; }
	    }
    
		public string MalzonekInnyKodPocztowy
	    {
	        get { return this[F.MalzonekInnyKodPocztowy]; }
	        set { this[F.MalzonekInnyKodPocztowy] = value; }
	    }
    
		public string MalzonekInneMiejsceZamieszkania
	    {
	        get { return this[F.MalzonekInneMiejsceZamieszkania]; }
	        set { this[F.MalzonekInneMiejsceZamieszkania] = value; }
	    }
    
		public string MalzonekAusgeubterBeruf
	    {
	        get { return this[F.MalzonekAusgeubterBeruf]; }
	        set { this[F.MalzonekAusgeubterBeruf] = value; }
	    }
    
		public string MalzonekDataUrodzenia
	    {
	        get { return this[F.MalzonekDataUrodzenia]; }
	        set { this[F.MalzonekDataUrodzenia] = value; }
	    }
    
		public string MalzonekReligia
	    {
	        get { return this[F.MalzonekReligia]; }
	        set { this[F.MalzonekReligia] = value; }
	    }
    
		public string BiuroNrKonta
	    {
	        get { return this[F.BiuroNrKonta]; }
	        set { this[F.BiuroNrKonta] = value; }
	    }
    
		public string BiuroNrBanku
	    {
	        get { return this[F.BiuroNrBanku]; }
	        set { this[F.BiuroNrBanku] = value; }
	    }
    
		public string BiuroName
	    {
	        get { return this[F.BiuroName]; }
	        set { this[F.BiuroName] = value; }
	    }
    
		public string BiuroVorname
	    {
	        get { return this[F.BiuroVorname]; }
	        set { this[F.BiuroVorname] = value; }
	    }
    
		public string BiuroUlicaNr
	    {
	        get { return this[F.BiuroUlicaNr]; }
	        set { this[F.BiuroUlicaNr] = value; }
	    }
    
		public string BiuroKodPocztowy
	    {
	        get { return this[F.BiuroKodPocztowy]; }
	        set { this[F.BiuroKodPocztowy] = value; }
	    }
    
		public string BiuroMiejsceZamieszkania
	    {
	        get { return this[F.BiuroMiejsceZamieszkania]; }
	        set { this[F.BiuroMiejsceZamieszkania] = value; }
	    }
    
 

		public virtual void InitFieldsName(Rozliczenie rozlicz)
	    {
            this[F.Imie] = rozlicz.Klient.Imie;
			this[F.Nazwisko] = rozlicz.Klient.Nazwisko;
            this[F.Zawod] = rozlicz.Klient.Zawod;
            this[F.AdresKod] = rozlicz.AdresRozliczenia.Kod;
            this[F.AdresUlica] = rozlicz.AdresRozliczenia.Ulica;
            this[F.Steuernummer] = rozlicz.Klient.Steuernummer;
            this[F.Urodzony] = rozlicz.Klient.Urodz.IfValueThenShortDate();
            this[F.AdresMiasto] = rozlicz.AdresRozliczenia.Miasto;
            this[F.Data] = DateTime.Now.ToShortDateString();
            this[F.Adres] = rozlicz.AdresRozliczenia.Ulica; //??
            this[F.BankKonto] = rozlicz.Konto.KontoNr;
            this[F.BankKod] = rozlicz.Konto.BankSwift; //BLZ ?
            this[F.BankAdres] = rozlicz.Konto.BankAdres;
            
            this[F.ZonaImie] = rozlicz.Partner.Imie;
            this[F.ZonaData] = rozlicz.Partner.Urodz.IfValueThenShortDate();
            this[F.ZonaReligia] = rozlicz.Partner.Religia.ToString();
			
			this[F.Imiona] = rozlicz.Klient.Imie;
            this[F.UlicaNrDomu] = rozlicz.AdresRozliczenia.Ulica;
            this[F.KodPocztowy] = rozlicz.AdresRozliczenia.Kod;
            this[F.MiejsceZamieszkania] = rozlicz.AdresRozliczenia.Miejsce;
		    this[F.Verheiratetseitdem] = rozlicz.Klient.DataSlubu.IfValueThenShortDate();
			this[F.NrTelefonu] = rozlicz.Klient.Telefon;
			this[F.DataUrodzenia] = rozlicz.Klient.Urodz.IfValueThenShortDate();
			this[F.MalzonekImie] = rozlicz.Partner.Imie;
			this[F.MalzonekInneNazwisko] = rozlicz.Partner.Nazwisko;
			this[F.MalzonekDataUrodzenia] = rozlicz.Partner.Urodz.IfValueThenShortDate();
			this[F.AusgeubterBeruf] = rozlicz.Klient.Zawod;
			this[F.MalzonekAusgeubterBeruf] = rozlicz.Partner.Zawod;
            //
            this[F.Religia] = rozlicz.Klient.Religia.ToString();
            this[F.MalzonekReligia] = rozlicz.Partner.Religia.ToString();
			//this[F.MalzonekInnaUlicaNrDomu] = rozlicz.MalzonekInnaUlicaNrDomu;
			//this[F.MalzonekInnyKodPocztowy] = rozlicz.MalzonekInnyKodPocztowy;
			//this[F.MalzonekInneMiejsceZamieszkania] = rozlicz.MalzonekInneMiejsceZamieszkania;
			
            this[F.BiuroNrKonta] = Context.Slownik.Biuro.BiuroNrKonta;
			this[F.BiuroNrBanku] = Context.Slownik.Biuro.BiuroNrBanku;
			this[F.BiuroName] = Context.Slownik.Biuro.BiuroName;
			this[F.BiuroVorname] = Context.Slownik.Biuro.BiuroVorname;
			this[F.BiuroUlicaNr] = Context.Slownik.Biuro.BiuroUlicaNr;
			this[F.BiuroKodPocztowy] = Context.Slownik.Biuro.BiuroKodPocztowy;
			this[F.BiuroMiejsceZamieszkania] = Context.Slownik.Biuro.BiuroMiejsce;

            this[F.FirmaNazwa1] = Context.Slownik.Biuro.BiuroName;
            this[F.FirmaNazwa2] = Context.Slownik.Biuro.BiuroVorname;
            this[F.FirmaAdres] = Context.Slownik.Biuro.BiuroUlicaNr;
            this[F.FirmaPoczta] = Context.Slownik.Biuro.BiuroKodPocztowy; //biuro nazwa ?
            this[F.FirmaOkreg] = Context.Slownik.Biuro.BiuroMiejsce;
            
		}
	}
}
