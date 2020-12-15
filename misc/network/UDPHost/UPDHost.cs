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

namespace UDPHost {
		public partial class UPDHost : Form {
				UdpValues udp = new UdpValues();
				Host host = new Host();
				Client client = new Client();

				public bool connected = false;
				public static bool dataRecieved = false;

				public bool echoed = false;

				public string dataType = "";

				int hostScore = 0;

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
						public UdpClient host;
						public IPEndPoint clientEndPoint;

						public UdpClient hostSend;
						public IPEndPoint clientEndPointSend;
				}

				public UPDHost() {
						//Need some standards
						host.IP = IPAddress.Parse("127.0.0.1");
						host.Port = 44444;
						host.UserTag = "Host";

						InitializeComponent();
				}

				public void ReceiveCallback(IAsyncResult arg) {
						if (!connected) {
								dataType = "conData";
								connected = true;
						} else {
								dataType = "gameData";
						}



						UdpClient host = ((UdpValues)(arg.AsyncState)).host;
						IPEndPoint clientEndPoint = ((UdpValues)(arg.AsyncState)).clientEndPoint;

						

						byte[] receiveBytes = host.EndReceive(arg, ref clientEndPoint);

						string receivedString = Encoding.UTF8.GetString(receiveBytes);
						

						dataRecieved = true;
						ProcessReceivedData(dataType, receivedString);

						if (echoed) {
								UdpAsyncListener();
						}
				}

				public void UdpAsyncListener() {
						
						udp.host.BeginReceive(new AsyncCallback(ReceiveCallback), udp);

						while (!dataRecieved) {
								Thread.Sleep(100);
						}
				}

				private void ProcessReceivedData(string dataType, string arg) {
						if (dataType == "conData") {
								
								string[] dataDvdr = { "&" };
								string[] dataList = arg.Split(dataDvdr, StringSplitOptions.RemoveEmptyEntries);

								int clientIP = dataList[0].IndexOf("sndr_ip=") + "sndr_ip=".Length;
								int clientPort = dataList[1].IndexOf("sndr_port=") + "sndr_port=".Length;
								int clientName = dataList[2].IndexOf("sndr_tag=") + "sndr_tag=".Length;

								client.IP = IPAddress.Parse(dataList[0].Substring(clientIP, dataList[0].Length - clientIP));
								client.Port = Int32.Parse(dataList[1].Substring(clientPort, dataList[1].Length - clientPort));
								client.UserTag = dataList[2].Substring(clientName, dataList[2].Length - clientName);

								DisplayProcessedData(dataType, $"Connected with {client.UserTag}");

								
								echoConnection();
								
						} 
						if (dataType == "gameData") {
								DisplayProcessedData(dataType, arg);
						}
						
						
						UdpAsyncListener();
				}

				private async void echoConnection() {
						await Task.Delay(100);

						udp.clientEndPointSend = new IPEndPoint(client.IP, client.Port);
						udp.hostSend = new UdpClient();

						byte[] reqCon = Encoding.UTF8.GetBytes($"Connected with {host.UserTag}");

						

						udp.hostSend.Send(reqCon, reqCon.Length, udp.clientEndPointSend);

						
						echoed = true;
						
				}

				delegate void DisplayProcessedDataCallback(string dataType, string arg);

				private void DisplayProcessedData(string dataType, string arg) {

						if (dataType == "conData") {
								if (this.lblConStatus.InvokeRequired) {
										DisplayProcessedDataCallback dataCallback = new DisplayProcessedDataCallback(DisplayProcessedData);
										this.Invoke(dataCallback, new object[] { dataType, arg });
								} else {
										this.lblConStatus.Text = arg;
								}
						}

						if (dataType == "gameData") {
								if (this.lblClientScore.InvokeRequired) {
										DisplayProcessedDataCallback dataCallback = new DisplayProcessedDataCallback(DisplayProcessedData);
										this.Invoke(dataCallback, new object[] { dataType, arg });
								} else {
										this.lblClientScore.Text = arg;
								}
						}
				}

				private void btnConnect_Click(object sender, EventArgs e) {
						
						//Listen for Client
						if (!connected) {
								udp.clientEndPoint = new IPEndPoint(IPAddress.Any, host.Port);
								udp.host = new UdpClient(udp.clientEndPoint);

								UdpAsyncListener();
								btnConnect.Enabled = false;
						} 

						
				}

				private void btnIncrement_Click(object sender, EventArgs e) {
						hostScore++;
						lblHostScore.Text = hostScore.ToString();

						byte[] reqCon = Encoding.UTF8.GetBytes($"{hostScore}");

						udp.hostSend.Send(reqCon, reqCon.Length, udp.clientEndPointSend);
				}
		}
}
