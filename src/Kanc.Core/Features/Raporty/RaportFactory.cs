using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Kanc.Core.Features.Raporty.DE;

namespace Kanc.Core.Features
{
    public class RptNiemcy
    {
        public RptNiemcy()
        {
            Initialize();
        }

        public void Initialize()
        {
            Volmacht = new Volmacht();
            UmowaDe = new UmowaDE();
            Bestatigung = new Bestatigung();
            KontoBankowe = new KontoBankowe();
            StronaNiemcy = new StronaNiemcy();
            Estk = new Estk();
            BrakKarty = new BrakKarty();
            EuEwr = new EuEwr();
            PodanieEuEwr = new PodanieEuEwr();
            PodanieUSKrapkowice = new PodanieUSKrapkowice();
            OswiadczenieMalzonka = new OswiadczenieMalzonka();
            PrzebiegAuta = new PrzebiegAuta();
            PrzekazanieAuta = new PrzekazanieAuta();
            Budowa = new Budowa();
            Ponaglenie = new Ponaglenie();
            //Braki = new Braki();
        }

        public Volmacht Volmacht;
        public UmowaDE UmowaDe;
        public Bestatigung Bestatigung;
        public KontoBankowe KontoBankowe;
        public StronaNiemcy StronaNiemcy; //frmPodatekStrona
        public Estk Estk;
        public BrakKarty BrakKarty;
        
        public EuEwr EuEwr; //frmEuEwr
        public PodanieEuEwr PodanieEuEwr; //frmEuEwr
        public PodanieUSKrapkowice PodanieUSKrapkowice; //frmEuEwr

        public OswiadczenieMalzonka OswiadczenieMalzonka;
        public PrzebiegAuta PrzebiegAuta;
        public PrzekazanieAuta PrzekazanieAuta;
        public Budowa Budowa;
        public Ponaglenie Ponaglenie;
        //public Braki Braki;

    }

    public class RptHolandia
    {
        public Volmacht VolmachtTest;
    }

    public static class RaportFactory
    {
        public static RptNiemcy Niemcy { get { return new RptNiemcy(); } }
        public static RptHolandia Holandia { get { return new RptHolandia(); } }
        //Austria
    }
}
