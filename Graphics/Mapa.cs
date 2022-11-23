using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using GMap.NET;
using GMap.NET.MapProviders;
using GMap.NET.WindowsForms;
using GMap.NET.WindowsForms.Markers;
using ClassLib;

namespace Graphics
{
    public partial class Mapa : Form
    {
        AsterixFile asterixFile = new AsterixFile();
        GMarkerGoogle marker;
        //GMarkerGoogle marker2;
        GMapOverlay markerOverlay = new GMapOverlay("Marcador");

        bool start = false;
        bool ShowSMR = true;
        bool ShowMLAT = true;
        bool ShowADSB = true;
        int multiplicador = 1000;
        string mapa = "ORI";

        //LAT i LONG arp Barcelona
        double LatInicial = 41.289182;
        double LongInicial = 2.0746423;
        double startTime = 0;

        public Mapa()
        {
            InitializeComponent();
        }


        public void setAsterix(AsterixFile asterix)
        {
            this.asterixFile = asterix;
        }

        private void Mapa_Load(object sender, EventArgs e)
        {
            startTime = timestart(asterixFile);
            labelTiempo.Text = Convert.ToString(TimeSpan.FromSeconds(startTime).ToString(@"hh\:mm\:ss"));
            TimeSpan timeextra = TimeSpan.FromSeconds(startTime);
            listBoxHH.Text = Convert.ToString(timeextra.Hours);
            listBoxMM.Text = Convert.ToString(timeextra.Minutes);
            listBoxSS.Text = Convert.ToString(timeextra.Seconds);
            timer1.Interval = multiplicador;

            gMapControl1.DragButton = MouseButtons.Left;
            gMapControl1.CanDragMap = true;
            gMapControl1.MapProvider = GMapProviders.GoogleMap;
            gMapControl1.Position = new PointLatLng(LatInicial, LongInicial);
            gMapControl1.MinZoom = 0;
            gMapControl1.MaxZoom = 24;
            gMapControl1.Zoom = 13;
            gMapControl1.AutoScroll = true;

            trackBarZOOM.Value = Convert.ToInt32(gMapControl1.Zoom);
            // Marcador
            //markerOverlay = new GMapOverlay("Marcador");
            //marker = new GMarkerGoogle(new PointLatLng(LatInicial, LongInicial), GMarkerGoogleType.black_small);
            //marker2 = new GMarkerGoogle(new PointLatLng(41.5218892, 2.10384403839652), GMarkerGoogleType.arrow);
            //markerOverlay.Markers.Add(marker2);
            //markerOverlay.Markers.Add(marker);
            //marker.ToolTipMode = MarkerTooltipMode.Always;
            //marker.ToolTipText = string.Format("Ubicación: \n Latitud:{0} \n Longitud: {1}", LatInicial, LongInicial);
            //gMapControl1.Overlays.Add(markerOverlay);

        }

        private void buttonPlay_Click(object sender, EventArgs e)
        {
            if (start == false)
            {
                timer1.Interval = multiplicador;
                timer1.Start();
                buttonPlay.Text = "Pause";
                start = true;
            }
            else
            {
                buttonPlay.Text = "Play";
                timer1.Stop();
                start = false;
            }

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            labelTiempo.Text = Convert.ToString(TimeSpan.FromSeconds(startTime).ToString(@"hh\:mm\:ss"));
            trackBarZOOM.Value = Convert.ToInt32(gMapControl1.Zoom);
            int n = 0;
            markerOverlay = new GMapOverlay("Marcador");
            while (n < asterixFile.getListCatAll().Count)
            {
                if (Math.Round(asterixFile.getListCatAll()[n].TimeofDayseg) == Math.Round(startTime))
                {
                    if (asterixFile.getListCatAll()[n].CATMode == "SMR" && ShowSMR == true)
                    {
                        marker = new GMarkerGoogle(new PointLatLng(asterixFile.getListCatAll()[n].LatWGS84, asterixFile.getListCatAll()[n].LongWGS84), GMarkerGoogleType.black_small);
                        markerOverlay.Markers.Add(marker);
                        gMapControl1.Overlays.Add(markerOverlay);
                    }
                    else if (asterixFile.getListCatAll()[n].CATMode == "MLAT" && ShowMLAT == true)
                    {
                        marker = new GMarkerGoogle(new PointLatLng(asterixFile.getListCatAll()[n].LatWGS84, asterixFile.getListCatAll()[n].LongWGS84), GMarkerGoogleType.blue_dot);
                        markerOverlay.Markers.Add(marker);
                        gMapControl1.Overlays.Add(markerOverlay);
                    }


                }
                n++;
            }
            startTime = startTime + 1;
        }

        private double timestart(AsterixFile asterix)
        {
            double timelow = asterix.getListCatAll()[0].TimeofDayseg;
            return timelow;
        }

        private void buttonConfig_Click(object sender, EventArgs e)
        {
            buttonPlay.Text = "Play";
            timer1.Stop();
            start = false;
            Configuration Config = new Configuration();
            Config.setMultiplicador(multiplicador);
            Config.setSMR(ShowSMR);
            Config.setMLAT(ShowMLAT);
            Config.setADSB(ShowADSB);
            Config.setMAP(mapa);
            Config.ShowDialog();
            this.multiplicador = Config.GetMultiplicador();
            this.ShowSMR = Config.GetSMR();
            this.ShowMLAT = Config.GetMLAT();
            this.ShowADSB = Config.GetADSB();
            this.mapa = Config.GetMAP();
            if (mapa == "ORI")
            {
                gMapControl1.MapProvider = GMapProviders.GoogleMap;
            }
            else if (mapa == "SAT")
            {
                gMapControl1.MapProvider = GMapProviders.GoogleSatelliteMap;
            }
            else if (mapa == "REL")
            {
                gMapControl1.MapProvider = GMapProviders.GoogleTerrainMap;
            }
            timer1.Interval = multiplicador;
        }

        private void gMapControl1_OnMarkerClick(GMapMarker item, MouseEventArgs e)
        {
            dataGridViewINFO.Columns.Clear();
            
        }

        private void buttonLEBL_Click(object sender, EventArgs e)
        {
            gMapControl1.Zoom = 13;
            gMapControl1.Position = new PointLatLng(LatInicial, LongInicial);
        }

        private void buttonBCN_Click(object sender, EventArgs e)
        {
            gMapControl1.Zoom = 10;
            gMapControl1.Position = new PointLatLng(LatInicial, LongInicial);
        }

        private void buttonCAT_Click(object sender, EventArgs e)
        {
            gMapControl1.Zoom = 7;
            gMapControl1.Position = new PointLatLng(LatInicial, LongInicial);
        }

        private void buttonReset_Click(object sender, EventArgs e)
        {
            timer1.Stop();
            buttonPlay.Text = "Play";
            start = false;
            while (gMapControl1.Overlays.Count > 0)
            {
                gMapControl1.Overlays.RemoveAt(0);
            }
            gMapControl1.Refresh();
            startTime = timestart(asterixFile);
        }

        private void buttonInitialH_Click(object sender, EventArgs e)
        {
            double HH = Convert.ToDouble(listBoxHH.Text)*3600;
            double MM = Convert.ToDouble(listBoxMM.Text)*60;
            double SS = Convert.ToDouble(listBoxSS.Text) + MM + HH;
            startTime = SS;
            buttonPlay.Text = "Play";
            timer1.Stop();
            start = false;
            while (gMapControl1.Overlays.Count > 0)
            {
                gMapControl1.Overlays.RemoveAt(0);
            }
            gMapControl1.Refresh();
            labelTiempo.Text = Convert.ToString(TimeSpan.FromSeconds(startTime).ToString(@"hh\:mm\:ss"));
        }

        private void trackBarZOOM_ValueChanged(object sender, EventArgs e)
        {
            gMapControl1.Zoom = trackBarZOOM.Value;
        }
    }
}
