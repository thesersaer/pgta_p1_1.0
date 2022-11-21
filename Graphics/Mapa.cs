﻿using System;
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
        GMarkerGoogle marker2;
        GMapOverlay markerOverlay;

        bool start = false;

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
            startTime = asterixFile.getListCatAll()[0].TimeofDayseg;
            labelTiempo.Text = Convert.ToString(asterixFile.getListCatAll()[0].TimeofDayseg);
            timer1.Interval = 1000;

            gMapControl1.DragButton = MouseButtons.Left;
            gMapControl1.CanDragMap = true;
            gMapControl1.MapProvider = GMapProviders.GoogleMap;
            gMapControl1.Position = new PointLatLng(LatInicial, LongInicial);
            gMapControl1.MinZoom = 0;
            gMapControl1.MaxZoom = 24;
            gMapControl1.Zoom = 13;
            gMapControl1.AutoScroll = true;

            // Marcador
            markerOverlay = new GMapOverlay("Marcador");
            marker = new GMarkerGoogle(new PointLatLng(LatInicial, LongInicial), GMarkerGoogleType.black_small);
            marker2 = new GMarkerGoogle(new PointLatLng(41.5218892, 2.10384403839652), GMarkerGoogleType.arrow);
            markerOverlay.Markers.Add(marker2);
            markerOverlay.Markers.Add(marker);
            marker.ToolTipMode = MarkerTooltipMode.Always;
            marker.ToolTipText = string.Format("Ubicación: \n Latitud:{0} \n Longitud: {1}", LatInicial, LongInicial);
            gMapControl1.Overlays.Add(markerOverlay);

        }

        private void buttonPlay_Click(object sender, EventArgs e)
        {
            if (start == false)
            {
                timer1.Start();
                buttonPlay.Text = "Pause";
                startTime = asterixFile.getListCatAll()[0].TimeofDayseg;
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
            labelTiempo.Text = Convert.ToString(startTime);
            startTime = startTime + 1;
        }
    }
}