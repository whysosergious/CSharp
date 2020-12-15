using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Net;
using System.Net.Sockets;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace networkCommunication {
		public partial class networkCommunication : Form {

				IPAddress ip = IPAddress.Parse("192.168.0.1");

				public networkCommunication() {
						InitializeComponent();
				}

				public class IPAddress {

				}
		}
}
