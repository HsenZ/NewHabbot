using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace ClientServerApp
{
    public partial class ClientForm : Form
    {
        private TcpClient client;
        private NetworkStream stream;
        private string serverIP = "192.168.1.1"; // Change this to your server's IP address
        private int port = 8888; // Change this to your server's port number

        public ClientForm()
        {
            InitializeComponent();
            // Attach KeyDown event handler to inputTextBox
            inputTextBox.KeyDown += inputTextBox_KeyDown;
            
        }
        // KeyDown event handler for inputTextBox
        private void inputTextBox_KeyDown(object sender, KeyEventArgs e)
        {
            // Check if Ctrl+L is pressed
            if (e.Control && e.KeyCode == Keys.L)
            {
                // Clear the content of inputTextBox
                inputTextBox.Clear();
            }
        }

        private void sendButton_Click(object sender, EventArgs e)
        {
            try
            {
                client = new TcpClient(serverIP, port);
                stream = client.GetStream();
                byte[] data = Encoding.ASCII.GetBytes(inputTextBox.Text);
                stream.Write(data, 0, data.Length);

                // Receive response from server if needed
                byte[] responseData = new byte[1024];
                int bytesRead = stream.Read(responseData, 0, responseData.Length);
                string response = Encoding.ASCII.GetString(responseData, 0, bytesRead);
                // Display response in ListBox
                outputTextBox.Items.Add("Server response: " + response);
                // Split the response into lines
                string[] lines = response.Split(new[] { Environment.NewLine }, StringSplitOptions.None);

                // Display each line of response in ListBox
                outputTextBox.Items.Add("Server response:");
                foreach (string line in lines)
                {
                    object value = outputTextBox.Items.Add(line);
                }
                stream.Close();
                client.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void ClientForm_Load(object sender, EventArgs e)
        {

        }
        private void inputTextBox_Enter(object sender, EventArgs e)
        {
            if (inputTextBox.Text == "Message HAMbot....")
            {
                inputTextBox.Text = "";
            }
        }

        private void inputTextBox_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(inputTextBox.Text))
            {
                inputTextBox.Text = "Message HAMbot....";
            }
        }

        private void outputTextBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
