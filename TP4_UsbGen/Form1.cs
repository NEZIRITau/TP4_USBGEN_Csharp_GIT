using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO.Ports;

namespace TP4_UsbGen
{
    public partial class Form1 : Form
    {
        // Attributs global
        private char Val_Signal;
        public delegate void ReceiverD();
        public ReceiverD myDelegate;


        //int m_SendCount = 0;
        //int m_DispCount = 0;
        byte[] Mess1 = new byte[5];

        const byte stx = 0xAA;
        const int m_MessSize = 5;

        public Form1()
        {
            InitializeComponent();

            // Get a list of serial port names.
            string[] ports = SerialPort.GetPortNames();
            comboBox_PortCOM.Items.AddRange(ports);
            comboBox_PortCOM.SelectedIndex = 0;
        }


        /// <summary>
        /// 
        ///     Gestion du port
        /// 
        /// 
        /// </summary>


        // Contrôle et obtention des ports disponibles
        public void CheckPortCom()
        {
            // Obtention de la liste des ports disponible
            string[] ports = SerialPort.GetPortNames();

            foreach (string PortList in ports)
            { 
                comboBox_PortCOM.Items.Add(PortList);
            }
        }

        // Fermeture du port
        private void Cls_Port_Click(object sender, EventArgs e)
        {
            serialPort1.Close(); // Close the serial port

            // Affichage texte de la fermeture du port
            Lab_Port.Text = "Port fermée";
        }

        // Ouverture du port
        private void Ouv_Port_Click(object sender, EventArgs e)
        {
            if (serialPort1.IsOpen == false)
            {
                try
                {
                    // Config du port
                    serialPort1.PortName = (string)comboBox_PortCOM.SelectedItem;
                    serialPort1.BaudRate = 57600;
                    serialPort1.Parity = Parity.None;
                    serialPort1.DataBits = 8;
                    serialPort1.StopBits = StopBits.One;
                    serialPort1.Handshake = Handshake.RequestToSend;

                    // Set the read/write timeouts
                    serialPort1.ReadTimeout = 500;
                    serialPort1.WriteTimeout = 500;

                    // Ouverture du port
                    serialPort1.Open();

                    // Affichage texte de l'ouverture du port
                    Lab_Port.Text = "Port ouvert";
                }
                catch
                {
                    string Message = "Veuillez rafraîchir les ports COM !";
                    string Titre = "ERROR";

                    MessageBox.Show(Message, Titre);
                }
            }
        }

        // Rafraîchissement des ports disponibles
        private void Btn_refresh_Click(object sender, EventArgs e)
        {
            // Nettoyage des items(Dans ce cas, les ports) disponibles
            comboBox_PortCOM.Items.Clear();

            try
            { 
                // Obtention de la liste des ports disponible
                string[] ports = SerialPort.GetPortNames();

                // Chaque ports disponible est ajouté
                foreach (string PortList in ports)
                {
                   comboBox_PortCOM.Items.Add(PortList);
                }

            }
            catch
            {
                string Message = "Le port sélectionné n'est pas disponible !";
                string Titre = "ERROR";

                MessageBox.Show(Message, Titre);
             }
        }


        /// <summary>
        /// 
        ///     Envoi de la trame 
        /// 
        /// 
        /// </summary>

        // Mise en forme de la trame I2C
        private void button_Envoi_Click(object sender, EventArgs e)
        {
                try
                {
                    // Mise en forme des paramètres pour les signaux
                    string ValFreq = "F=" + numeric_Freq.Value.ToString("0000");
                    string ValAmpl = "A=" + numeric_Ampl.Value.ToString("00000");
                    string ValOff = "O=+" + numeric_Offset.Value.ToString("0000");

                    // Mise en forme des valeurs de l'offset avec le signe +/-
                    if (numeric_Offset.Value > 0)
                    {
                        ValOff = "O=+" + numeric_Offset.Value.ToString("0000");
                    }

                    if (numeric_Offset.Value < 0)
                    {
                      ValOff = "O=" + numeric_Offset.Value.ToString("0000");
                    }

                    // Affichage de la chaîne de caractère en une ligne
                    textBox_USB.Text = "!S=" + Val_Signal + ValFreq + ValAmpl + ValOff + "W=0#";

                    // Envoi de la chaîne de caractère en une ligne
                    string outputUSB = textBox_USB.Text;

                    // Send data over the serial port
                    serialPort1.Write(outputUSB);
                }
                catch
                {
                    string Message = "Veuillez contrôler vos réglages !";
                    string Titre = "ERROR";

                    MessageBox.Show(Message, Titre);
                }
        }

            // Sauvegarde de la trame I2C
            private void buttn_Save_Click(object sender, EventArgs e)
            {
                // Mise en forme des paramètres pour les signaux
                string ValFreq = "F=" + numeric_Freq.Value.ToString("0000");
                string ValAmpl = "A=" + numeric_Ampl.Value.ToString("00000");
                string ValOff = "O=+" + numeric_Offset.Value.ToString("0000");

                // Mise en forme des valeurs de l'offset avec le signe +/-
                if (numeric_Offset.Value > 0)
                {
                    ValOff = "O=+" + numeric_Offset.Value.ToString("0000");
                }

                if (numeric_Offset.Value < 0)
                {
                    ValOff = "O=" + numeric_Offset.Value.ToString("0000");
                }

                // Envoi de la trame pour la sauvegarde
                textBox_USB.Text = "!S=" + Val_Signal + ValFreq + ValAmpl + ValOff + "W=1#";

                // Envoi de la chaîne de caractère en une ligne
                string outputUSB = textBox_USB.Text;

                // Send data over the serial port
                serialPort1.Write(outputUSB);
            }
     
   

            // Choix du type de signals
            private void comboBox_Signal_SelectedIndexChanged(object sender, EventArgs e)
            {

                switch (comboBox_Signal.SelectedIndex)
                {
                    case 0:

                        Val_Signal = 'S';
                        Pic_Box.Image = TP4_UsbGen.Properties.Resources.SignSinus;

                        break;

                    case 1:

                        Val_Signal = 'T';
                        Pic_Box.Image = TP4_UsbGen.Properties.Resources.SignTriangle;

                        break;

                    case 2:

                        Val_Signal = 'C';
                        Pic_Box.Image = TP4_UsbGen.Properties.Resources.SignRect;

                        break;

                    case 3:

                        Val_Signal = 'D';
                        Pic_Box.Image = TP4_UsbGen.Properties.Resources.SignDentdS;

                        break;

                    default:
                        break;
                }
            }


        /// <summary>
        /// 
        ///     Réception de la trame
        /// 
        /// 
        /// </summary>

        // Méthode pour la lecture du port et appel d'un delegate
        private void serialPort1_DataReceived(object sender, SerialDataReceivedEventArgs e)
        {
            string DataIN = serialPort1.ReadExisting();
            DelAffiche(DataIN);
        }

        // Delegate affichant la trame reçue
        private void DelAffiche(string INData)
        {
            BeginInvoke(new EventHandler(delegate
            {
                textBox1.Text = INData;
            }));
        }
    }
}
