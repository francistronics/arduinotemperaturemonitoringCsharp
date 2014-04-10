///projet arduino temperature monitoring
// pour recevoir les valeur de l'arduino, entrer le mot "temperature" dans la send texbox 
// et cliquer sur envoyer. pour arreter la reception envoyer "stop"
//pour l'instant le tracer est purement statique, il se fait tout les "ticks evenement"
// j'aimerai k'il soit dynamique et kon voi les fluctuations de temperature toute les 10 secondes.
// j'y travaille encore...





using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Net.Sockets;
using System.Net;
using ZedGraph;
using System.Threading;
namespace monudpCsharp
{
    public partial class Form1 : Form
    {
        UdpClient serveur = new UdpClient(9000);
        UdpClient receivemessage = new UdpClient(13000);
        byte [] datatosend = new byte [1024];
        int val;
        private Object _Lock = new Object();
        

        public Form1()
        {
            InitializeComponent();
          
        }

        private void BtnSend_Click(object sender, EventArgs e)
        {

            serveur.Connect(IPAddress.Parse(TbIPdestinataire.Text), int.Parse(TbPortdestinataire.Text));
            datatosend = ASCIIEncoding.ASCII.GetBytes(TbMessageToSend.Text);
            serveur.Send(datatosend, datatosend.Length);
             

            
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            receivemessage.Client.ReceiveTimeout = 100;
            receivemessage.Client.Blocking = false;
            
           // 169.254.245.198
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            try
            {

                IPEndPoint RemoteIpEndPoint = new IPEndPoint(IPAddress.Any, 13000);
                Byte[] rcvbytes = receivemessage.Receive(ref RemoteIpEndPoint);
                TbMessageReceive.Text = ASCIIEncoding.ASCII.GetString(rcvbytes); // valeur recu dans le texbox message recu

                 val = int.Parse(TbMessageReceive.Text); // on recupere la valeur recu pour lutiliser dans le tracer du graphe
                
               
                labeltemp.Text = ASCIIEncoding.ASCII.GetString(rcvbytes); //valeur recu dans le label de temperature
                ////////////////////////////////////////////////////////////
                // tracer du graphe avec zedgraph///

                // Lets generate graph
               

                double[] x = new double[100];
                double[] y = new double[100];
                
                //  ici je donne les valeurs a mes coordonnees
                for (int i = 0; i < x.Length; i++)
                {
                    x[i] = i; // ici j'aimerai avoir le temps reel.j'y travail encor
                    y[i] = val; // valeur recu
                    

                }


                // This is to remove all plots
                zedGraphControl1.GraphPane.CurveList.Clear();

                // GraphPane object holds one or more Curve objects (or plots)
                GraphPane myPane = zedGraphControl1.GraphPane;

                // PointPairList holds the data for plotting, X and Y arrays 
                PointPairList spl1 = new PointPairList(x, y);
                

                // Add cruves to myPane object
                LineItem myCurve1 = myPane.AddCurve("temperature", spl1, Color.Blue, SymbolType.None);
               

                myCurve1.Line.Width = 3.0F;
              
                myPane.Title.Text = "arduino temperature monitoring";

                // I add all three functions just to be sure it refeshes the plot.   
                zedGraphControl1.AxisChange();
                zedGraphControl1.Invalidate();
                zedGraphControl1.Refresh();
                ///////////////////////////////////////////////////////////
            }

            catch (Exception ex) 
            {
                string code = ex.HelpLink;
            }

             
        }

       

       
    }
}
