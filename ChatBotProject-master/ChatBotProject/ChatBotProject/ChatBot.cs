using System;
using System.Windows.Forms;
using System.Media;
using System.IO; // needed for filing
using System.Speech.Synthesis;
using System.Net.Sockets;
using System.Text;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Threading.Tasks;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;



namespace ChatBotProject
{
    public partial class Form1 : Form
    {
        private TcpClient client;
        private NetworkStream stream;
        private string serverIP = "192.168.0.109"; // Change this to your server's IP address
        private int port = 8888; // Change this to your server's port number


        public Form1()
        {
            InitializeComponent();
            InputTxt.KeyDown += InputTxt_KeyDown;
        }

        SpeechSynthesizer reader = new SpeechSynthesizer();
        bool textToSpeech = false;

        private void Form1_Load(object sender, EventArgs e)
        {

            // Sets Position for the first bubble on the top
            bbl_old.Top = 0 - bbl_old.Height;

            // Load Chat from the log file
            if (File.Exists("chat.log"))
            {
                using (StreamReader sr = File.OpenText("chat.log"))
                {
                    int i = 0; // to count lines
                    while (sr.Peek() >= 0) // loop till the file ends
                    {
                        if (i % 2 == 0) // check if line is even
                        {
                            addInMessage(sr.ReadLine());
                        }
                        else
                        {
                            addOutMessage(sr.ReadLine());
                        }
                        i++;
                    }
                    // scroll to the bottom once finished loading.
                    panel2.VerticalScroll.Value = panel2.VerticalScroll.Maximum;
                    panel2.PerformLayout();
                }
            }
        }

       
            
              

        private void InputTxt_Enter(object sender, EventArgs e)
        {
            if (InputTxt.Text == "Message HAMbot....")
            {
                InputTxt.Text = "";
            }
        }

        private void InputTxt_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(InputTxt.Text))
            {
                InputTxt.Text = "Message HAMbot....";
            }
        }
        private void SendButton_Click(object sender, EventArgs e)
        {

            if (!(string.IsNullOrWhiteSpace(InputTxt.Text))) // Make sure the textbox isnt empty
            {
                SoundPlayer Send = new SoundPlayer("SOUND1.wav"); // Send Sound Effect
                SoundPlayer Rcv = new SoundPlayer("SOUND2.wav"); // Recieve Sound Effect

                // Show the user message and play the sound
                addInMessage(InputTxt.Text);
                Send.Play();
                InputTxt.Enabled = false;
                txtTyping.Show();
                try
                {
                             
                    client = new TcpClient(serverIP, port);
                    stream = client.GetStream();
                    byte[] data = Encoding.ASCII.GetBytes(InputTxt.Text);
                    stream.Write(data, 0, data.Length);

                    // Receive response from server if needed
                    byte[] responseData = new byte[1024];
                    int bytesRead = stream.Read(responseData, 0, responseData.Length);
                    string ServerReply = Encoding.ASCII.GetString(responseData, 0, bytesRead);
                    if (ServerReply.Length == 0)
                    {
                        ServerReply = "I don't understand.";
                    }
                    FileStream fs = new FileStream(@"chat.log", FileMode.Append, FileAccess.Write);
                    if (fs.CanWrite)
                    {
                        byte[] write = System.Text.Encoding.ASCII.GetBytes(InputTxt.Text + Environment.NewLine + ServerReply + Environment.NewLine);
                        fs.Write(write, 0, write.Length);
                    }
                    fs.Flush();
                    fs.Close();
                    // Enable Chat box                   

                    // Show the bot message and play the sound
                    addOutMessage(ServerReply);
                    Rcv.Play();

                    // Text to Speech if enabled
                    if (textToSpeech)
                    {
                        reader.SpeakAsync(ServerReply);
                    }

                    stream.Close();
                    client.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                }
                txtTyping.Hide();
                InputTxt.Enabled = true;
                InputTxt.Focus();
                // Append response to the outputTextBox
                InputTxt.Text = "";
            }

        }


        // Call the Output method when the enter key is pressed.
        private void InputTxt_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Control && e.KeyCode == Keys.L)
            {
                // Clear the content of inputTextBox
                InputTxt.Text = "";
            }
            if (e.KeyCode == Keys.Enter)
            {
                SendButton_Click(sender,e);
            }
        }
        
        // Dummy Bubble created to store the previous bubble data.
        bubble bbl_old = new bubble();

        // User Message Bubble Creation
        public void addInMessage(string message)
        {
            // Create new chat bubble
            bubble bbl = new bubble(message, msgtype.In);
            bbl.Location = bubble1.Location; // Set the new bubble location from the bubble sample.
            bbl.Left += 50; // Indent the bubble to the right side.
            bbl.Size = bubble1.Size; // Set the new bubble size from the bubble sample.
            bbl.Top = bbl_old.Bottom + 10; // Position the bubble below the previous one with some extra space.
            
            // Add the new bubble to the panel.
            panel2.Controls.Add(bbl);

            // Force Scroll to the latest bubble
            bbl.Focus();

            // save the last added object to the dummy bubble
            bbl_old = bbl;
        }

        // Bot Message Bubble Creation
        public void addOutMessage(string message)
        {
            // Create new chat bubble
            bubble bbl = new bubble(message, msgtype.Out);
            bbl.Location = bubble1.Location; // Set the new bubble location from the bubble sample.
            bbl.Size = bubble1.Size; // Set the new bubble size from the bubble sample.
            bbl.Top = bbl_old.Bottom + 10; // Position the bubble below the previous one with some extra space.
            
            // Add the new bubble to the panel.
            panel2.Controls.Add(bbl);

            // Force Scroll to the latest bubble
            bbl.Focus();

            // save the last added object to the dummy bubble
            bbl_old = bbl;
        }

        // Custom close button to close the program when clicked.
        private void close_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }
        
        // Clear all the bubbles and chat.log
        private void clearChatToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Delete the log file
            File.Delete(@"chat.log");

            // Clear the chat Bubbles
            panel2.Controls.Clear();

            // This reset the position for the next bubble to come back to the top.
            bbl_old.Top = 0 - bbl_old.Height;
        }

        private void contextMenuStrip1_Opening(object sender, System.ComponentModel.CancelEventArgs e)
        {

        }

        private void menuButton_Click(object sender, EventArgs e)
        {
            contextMenuStrip1.Show(menuButton, new System.Drawing.Point(0, -contextMenuStrip1.Size.Height));
        }

        private void toggleVoiceToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // whenever the toggle is clicked, true is set to false visa versa.
            textToSpeech = !textToSpeech;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void txtTyping_Click(object sender, EventArgs e)
        {

        }

        private void bunifuImageButton1_Click(object sender, EventArgs e)
        {

        }

        private void panel2_Scroll(object sender, ScrollEventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}