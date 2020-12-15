using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using System.Net;
using System.Net.Sockets;
using System.Threading;

namespace UDPClient {
		public partial class UDPClient : Form {
				UdpValues udp = new UdpValues();
				Host host = new Host();
				Client client = new Client();

				public bool connected = false;
				public bool conListener = false;
				public static bool dataRecieved = false;

				public string dataType = "";

				int clientScore = 0;

				public UDPClient() {
						//Need some standards
						host.IP = IPAddress.Parse("127.0.0.1");
						host.Port = 44444;
						host.UserTag = "Host";
						
						
						client.IP = IPAddress.Parse("127.0.0.1");
						client.Port = GenerateClientPort(1024, 100000);
						client.UserTag = "Client";

						InitializeComponent();
				}

				public int GenerateClientPort(int min, int max) {
						Random random = new Random();
						int result = random.Next(min, max);
						if (result == host.Port) {
								result++;
						}
						return result;

				}

				/// <summary>
				/// Host Object
				/// </summary>
				public class Host {
						IPAddress ip;
						private int port = 44444;
						private string userTag = "";

						public IPAddress IP {
								get {
										return this.ip;
								}
								set {
										this.ip = value;
								}
						}
						public int Port {
								get {
										return this.port;
								}
								set {
										this.port = value;
								}
						}
						public string UserTag {
								get {
										return this.userTag;
								}
								set {
										this.userTag = value;
								}
						}
				}

				/// <summary>
				/// Client Object
				/// </summary>
				public class Client : Host {
						private int port = 44445;
				}

				public struct UdpValues {
						public UdpClient client;
						public IPEndPoint hostEndPoint;

						public UdpClient clientSend;
						public IPEndPoint hostEndPointSend;
				}

				public void ReceiveCallback(IAsyncResult arg) {
						if (!conListener) {
								dataType = "conData";
								conListener = true;
						} else {
								dataType = "gameData";
						}

						UdpClient client = ((UdpValues)(arg.AsyncState)).client;
						IPEndPoint hostEndPoint = ((UdpValues)(arg.AsyncState)).hostEndPoint;

						byte[] receiveBytes = client.EndReceive(arg, ref hostEndPoint);
						string receivedString = Encoding.UTF8.GetString(receiveBytes);

						dataRecieved = true;
						DisplayReceivedData(dataType, receivedString);
						UdpAsyncListener();
				}

				public void UdpAsyncListener() {

						//lblConStatus.Text = "Listening for Client";
						udp.client.BeginReceive(new AsyncCallback(ReceiveCallback), udp);

						while (!dataRecieved) {
								Thread.Sleep(100);
						}
				}

				delegate void DisplayRecievedDataCallback(string dataType, string arg);

				private void DisplayReceivedData(string dataType, string arg) {
						if (dataType == "conData") {
								if (this.lblConStatus.InvokeRequired) {
										DisplayRecievedDataCallback d = new DisplayRecievedDataCallback(DisplayReceivedData);
										this.Invoke(d, new object[] { dataType, arg });
								} else {
										this.lblConStatus.Text = arg;
								}
						}
						if (dataType == "gameData") {
								if (this.lblHostScore.InvokeRequired) {
										DisplayRecievedDataCallback d = new DisplayRecievedDataCallback(DisplayReceivedData);
										this.Invoke(d, new object[] { dataType, arg });
								} else {
										this.lblHostScore.Text = arg;
								}
						}
				}

				private void btnConnect_Click(object sender, EventArgs e) {
						
						if (!connected) {
								udp.hostEndPointSend = new IPEndPoint(host.IP, host.Port);
								udp.clientSend = new UdpClient();

								byte[] reqCon = Encoding.UTF8.GetBytes($"&sndr_ip={client.IP}&sndr_port={client.Port}&sndr_tag={client.UserTag}&sndr_msg=Connected");
								udp.clientSend.Send(reqCon, reqCon.Length, udp.hostEndPointSend);

								connected = true;
								btnConnect.Enabled = false;
						}

						

						if (!conListener) {
								udp.hostEndPoint = new IPEndPoint(host.IP, client.Port);
								udp.client = new UdpClient(udp.hostEndPoint);
								UdpAsyncListener();
						}


						
				}

				private void btnIncrement_Click(object sender, EventArgs e) {
						clientScore++;
						lblClientScore.Text = clientScore.ToString();

						byte[] reqCon = Encoding.UTF8.GetBytes($"{clientScore}");
						udp.clientSend.Send(reqCon, reqCon.Length, udp.hostEndPointSend);
				}
		}
}
