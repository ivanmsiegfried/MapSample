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

namespace MapSample
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void splitter1_SplitterMoved(object sender, SplitterEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            map.DragButton = MouseButtons.Left;
            map.MapProvider = GMapProviders.GoogleMap;
            double lat = Convert.ToDouble(textBox1.Text);
            double longt = Convert.ToDouble(textBox2.Text);
            double lat2 = Convert.ToDouble(textBox3.Text);
            double longt2 = Convert.ToDouble(textBox4.Text);

            map.Position = new PointLatLng(lat, longt);
            map.MinZoom = 5;
            map.MaxZoom = 100;
            map.Zoom = 10;

            PointLatLng point = new PointLatLng(lat, longt);
            GMapMarker marker = new GMarkerGoogle(point, GMarkerGoogleType.red_small);
            GMapOverlay markers = new GMapOverlay("marker");
            markers.Markers.Add(marker);
            map.Overlays.Add(markers);

            PointLatLng point2 = new PointLatLng(lat2, longt2);
            GMapMarker marker2 = new GMarkerGoogle(point2, GMarkerGoogleType.red_small);
            GMapOverlay markers2 = new GMapOverlay("marker");
            markers.Markers.Add(marker2);
            map.Overlays.Add(markers2);
        }

    }
}
