using System;
using System.IO;
using System.Net;
using System.Runtime.Serialization;
using System.Windows.Forms;

namespace SBBTest
{
    public partial class Form1 : Form
    {
        SBB_Serializer sbb_serializer = new SBB_Serializer();

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
        }

        private void btnFrom_Click(object sender, EventArgs e)
        {
            SBB_Serializer.Stations stations = sbb_serializer.getStations(tbxFrom.Text);
            string[] names = sbb_serializer.getStationNames(stations);
            chblFrom.Items.AddRange(names);
        }

        private void btnTo_Click(object sender, EventArgs e)
        {
            SBB_Serializer.Stations stations = sbb_serializer.getStations(tbxTo.Text);
            string[] names = sbb_serializer.getStationNames(stations);
            chblTo.Items.AddRange(names);
        }

        private void chblFrom_ItemCheck(object sender, ItemCheckEventArgs e)
        {
            for (int ix = 0; ix < chblFrom.Items.Count; ++ix)
            {
                if (ix != e.Index)
                {
                    chblFrom.SetItemChecked(ix, false);
                }
            }
        }

        private void chblTo_ItemCheck(object sender, ItemCheckEventArgs e)
        {
            for (int ix = 0; ix < chblTo.Items.Count; ++ix)
            {
                if (ix != e.Index)
                {
                    chblTo.SetItemChecked(ix, false);
                }
            }
        }

        private void chbStart_CheckedChanged(object sender, EventArgs e)
        {
            bool c1 = chbStart.Checked,
                c2 = chbEnd.Checked;
            if (c1 && c2)
            {
                chbEnd.Checked = false;
            }
            else if (!c1 && !c2)
            {
                chbEnd.Checked = true;
            }
        }

        private void chbEnd_CheckedChanged(object sender, EventArgs e)
        {
            bool c1 = chbEnd.Checked,
                c2 = chbStart.Checked;
            if (c1 && c2)
            {
                chbStart.Checked = false;
            }
            else if (!c1 && !c2)
            {
                chbStart.Checked = true;
            }
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            sbb_serializer.UpdateIsArrivalTime(chbEnd.Checked);
            SBB_Serializer.Connections connections = sbb_serializer.getConnections(chblFrom.SelectedItem.ToString(), chblTo.SelectedItem.ToString(), dtpDate.Value);
            string[] names = sbb_serializer.getConnectionsNames(connections);
            libConn.Items.AddRange(names);
            string t = sbb_serializer.displayConnections(connections);
            txtConn.Text = t;
        }

        private void btnFromDel_Click(object sender, EventArgs e)
        {
            chblFrom.Items.Clear();
        }

        private void btnToDel_Click(object sender, EventArgs e)
        {
            chblTo.Items.Clear();
        }
    }

    public class SBB_Serializer
    {
        bool isArrivalTime = false;

        // Main
        public SBB_Serializer()
        {
            if (Directory.Exists(@"C:\temp"))
            {
                Directory.CreateDirectory(@"C:\temp");
            }
        }

        private string readWebData(string url)
        {
            Console.WriteLine("Downloading data from : \"" + url + "\"");
            string data = string.Empty;
            using (WebClient wc = new WebClient())
            {
                data = wc.DownloadString(url);
            }

            return data;
        }

        // Stations

        public Stations getStations(string query)
        {
            return getStations(query, string.Empty, string.Empty, string.Empty);
        }

        public Stations getStations(string query, string x)
        {
            return getStations(query, x, string.Empty, string.Empty);
        }

        public Stations getStations(string query, string x, string y)
        {
            return getStations(query, x, y, string.Empty);
        }

        public Stations getStations(string query, string x, string y, string type)
        {
            Console.WriteLine("Working...");
            string data = readWebData("https://transport.opendata.ch/v1/locations?"
                + (query == string.Empty ? "" : "query=" + query + "&")
                + (x == string.Empty ? "" : "x=" + x + "&")
                + (y == string.Empty ? "" : "y=" + y + "&")
                + (type == string.Empty ? "" : "type=" + y));


            File.WriteAllText(@"C:\temp\jsonData.json", data);
            StreamReader sr = new StreamReader(@"C:\temp\jsonData.json");

            System.Runtime.Serialization.Json.DataContractJsonSerializer serializer = new System.Runtime.Serialization.Json.DataContractJsonSerializer(typeof(Stations));
            Stations stations = serializer.ReadObject(sr.BaseStream) as Stations;
            sr.Dispose();
            Console.WriteLine("Complete !");
            return stations;
        }

        public string displayStations(Stations stations)
        {
            string output = string.Empty;
            if (stations != null)
            {
                foreach (var item in stations.stations)
                {
                    output += "#######################" + Environment.NewLine;
                    output += "Station : " + item.name + Environment.NewLine;
                    output += "Id : " + item.id + Environment.NewLine;
                    output += "score : " + item.score + Environment.NewLine;
                    output += "coordinate : " + Environment.NewLine;
                    output += "\ttype : " + item.coordinate.type + Environment.NewLine;
                    output += "\tx : " + item.coordinate.x + Environment.NewLine;
                    output += "\ty : " + item.coordinate.y + Environment.NewLine;
                }
            }
            return output;
        }

        public string[] getStationNames(Stations stations)
        {
            string[] names = new string[stations.stations.Length];
            for (int i = 0; i < stations.stations.Length; i++)
            {
                names[i] = stations.stations[i].name;
            }
            return names;
        }

        [DataContract]
        public class Stations
        {
            [DataMember]
            public Station[] stations;

            [DataContract]
            public class Station
            {
                [DataMember]
                public string id;
                [DataMember]
                public string name;
                [DataMember]
                public string score;
                [DataMember]
                public Coordinate coordinate;
                [DataMember]
                public string distance;

                [DataContract]
                public class Coordinate
                {
                    [DataMember]
                    public string type;
                    [DataMember]
                    public object x;
                    [DataMember]
                    public object y;
                }
            }
        }

        // Connections

        public void UpdateIsArrivalTime(bool newValue)
        {
            isArrivalTime = newValue;
        }

        public Connections getConnections(string from)
        {
            return getConnections(from, string.Empty, DateTime.Now);
        }

        public Connections getConnections(string from, string to)
        {
            return getConnections(from, to, DateTime.Now);
        }

        public Connections getConnections(string from, string to, DateTime date)
        {
            Console.WriteLine("Working...");
            string data = readWebData("https://transport.opendata.ch/v1/connections?"
                + (from == string.Empty ? "" : "from=" + from + "&")
                + (to == string.Empty ? "" : "to=" + to + "&")
                + (date == null ? "" : "date=" + date.ToString("yyyy-MM-dd") + "&")
                + (date == null ? "" : "time=" + date.ToString("hh:mm") + "&")
                + "isArrivalTime=" + (isArrivalTime ? "1" : "0"));

            File.WriteAllText(@"C:\temp\jsonData.json", data);
            StreamReader sr = new StreamReader(@"C:\temp\jsonData.json");

            System.Runtime.Serialization.Json.DataContractJsonSerializer serializer = new System.Runtime.Serialization.Json.DataContractJsonSerializer(typeof(Connections));
            Connections connections = serializer.ReadObject(sr.BaseStream) as Connections;
            sr.Dispose();
            Console.WriteLine("Complete !");
            return connections;
        }

        public string displayConnections(Connections connections)
        {
            string output = string.Empty;
            if (connections != null)
            {
                foreach (var item in connections.connections)
                {
                    output += "#######################" + Environment.NewLine;
                    output += "Connection : " + Environment.NewLine;
                    output += "From : " + item.from.station.name.ToString() + Environment.NewLine;
                    output += "At : " + item.from.departure.ToString() + Environment.NewLine;
                    output += "To : " + item.to.station.name.ToString() + Environment.NewLine;
                    output += "At : " + item.to.arrival.ToString() + Environment.NewLine;
                    output += "Duration : " + item.duration.ToString() + Environment.NewLine;
                }
            }
            return output;
        }

        public string[] getConnectionsNames(Connections connections)
        {
            string[] names = new string[connections.connections.Length];
            for (int i = 0; i < connections.connections.Length; i++)
            {
                names[i] = connections.connections[i].from.station.name + " ||| " + connections.connections[i].to.station.name;
            }
            return names;
        }

        [DataContract]
        public class Connections
        {
            [DataMember]
            public Connection[] connections;

            [DataContract]
            public class Connection
            {
                [DataMember]
                public ConnectionDetails from;
                [DataMember]
                public ConnectionDetails to;
                [DataMember]
                public string duration;
                [DataMember]
                public int transfers;
                [DataMember]
                public object service;
                [DataMember]
                public object products;
                [DataMember]
                public object capacity1st;
                [DataMember]
                public object capacity2st;
                [DataMember]
                public object sections;

                [DataContract]
                public class ConnectionDetails
                {
                    [DataMember]
                    public Stations.Station station;
                    [DataMember]
                    public object arrival;
                    [DataMember]
                    public object arrivalTimestamp;
                    [DataMember]
                    public string departure;
                    [DataMember]
                    public object departureTimestamp;
                    [DataMember]
                    public object delay;
                    [DataMember]
                    public object platform;
                    [DataMember]
                    public object prognosis;
                    [DataMember]
                    public object realtimeAvailability;
                    [DataMember]
                    public Stations.Station location;

                    [DataContract]
                    public class Prognosis
                    {
                        [DataMember]
                        public object platform;
                        [DataMember]
                        public object arrival;
                        [DataMember]
                        public object departure;
                        [DataMember]
                        public object capacity1st;
                        [DataMember]
                        public object capacity2nd;
                    }
                }

                [DataContract]
                public class Sections
                {
                    [DataMember]
                    public object journey;
                    [DataMember]
                    public object walk;
                    [DataMember]
                    public ConnectionDetails departure;
                    [DataMember]
                    public ConnectionDetails arrival;

                    [DataContract]
                    public class Walk
                    {
                        [DataMember]
                        public string duration;
                    }
                }
            }
        }
    }
}
