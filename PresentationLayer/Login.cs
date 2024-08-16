using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Newtonsoft.Json;
using System.Threading;
using System.Net.Sockets;
using EntityLayer;
using System.IO;
using System.Runtime.Remoting;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace PresentationLayer
{
    public partial class Login : Form
    {
        private bool isConneted = false;
        public Login()
        {
            InitializeComponent();
            // Deshabilitar el botón de maximizar
            this.MaximizeBox = false;
            // Abrir en el centro del escritorio
            this.StartPosition = FormStartPosition.CenterScreen;
           
        }

        

        private void Login_Load(object sender, EventArgs e)
        {

        }

        private TcpClient client;
        private NetworkStream stream;
        private bool isConnected = false; // Variable para controlar el estado de conexión
        private Thread clientThread;
        


        private void StartClientThreads()
        {
            try
            {
                // Conectar al servidor
                client = new TcpClient("127.0.0.1", 15500); // Conectar al servidor en localhost, puerto 15500
                stream = client.GetStream();
                
                // Ejecutar la función existId() en un nuevo hilo para manejar la sesión de inicio de sesión
                clientThread = new Thread(() =>
                {
                    Customer customer = existId();

                   
                    if (customer != null)
                    {
                        Invoke(new Action(() =>
                        {
                            ShowWelcomeMessage(customer);
                            MainMenu window = new MainMenu(client, stream); // Pasar el stream al MainMenu 
                            window.Show();
                           

                        }));

                        

                    }
                    else
                    {
                        Invoke(new Action(() =>
                        {
                            MessageBox.Show("Ingrese un ID válido o activo.");
                        }));
                        Task.Delay(3000).Wait(); 

                        // Habilitar la entrada de datos nuevamente para el usuario
                        Invoke(new Action(() =>
                        {
                            IdBox.Enabled = true; // Habilitar IdBox
                        }));
                    }
                });

                clientThread.Start(); // Iniciar el hilo para manejar la sesión de inicio de sesión
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al conectar al servidor: " + ex.Message);
                isConnected = false;
            }
        }
        


        private Customer existId()
        {
            bool exist = false;
            Customer customer;
            try
            {
                
                // Obtener el ID del TextBox
                string id = IdBox.Text; // Asegúrate de que el TextBox tenga el nombre adecuado, por ejemplo, idTextBox
                if (string.IsNullOrWhiteSpace(id))
                {
                    MessageBox.Show("Por favor, ingrese un ID válido.");
                    return null;
                }


                // Construir el mensaje a enviar, incluyendo el ID
                string message = "VALIDATE_CLIENT|" + id;
                byte[] data = Encoding.UTF8.GetBytes(message);
                stream.Write(data, 0, data.Length);

                // Leer la respuesta del servidor
                byte[] buffer = new byte[client.ReceiveBufferSize];
                int bytesRead = stream.Read(buffer, 0, client.ReceiveBufferSize);
                string response = Encoding.UTF8.GetString(buffer, 0, bytesRead);

                // Eliminar el encabezado "GET_ADMINISTRADORES_RESPONSE"
                string jsonData = response.Replace("VALIDATE_RESPONSE", "");
                customer = JsonConvert.DeserializeObject<Customer>(jsonData);
            }
            catch (IOException ex)
            {
                MessageBox.Show("Error al leer datos del servidor: " + ex.Message);
                return null;
            }

            return customer;
        }



        public void DisconnectFromServer()
        {
            try
            {
                if(isConnected)
                {
                    byte[] data = Encoding.UTF8.GetBytes("CLOSE");
                    stream.Write(data, 0, data.Length);
                    stream.Close();
                    client.Close();
                }
            }
            catch (IOException ex)
            {
                MessageBox.Show("Error al desconectar del servidor: " + ex.Message);
            }
        }
        private async void ShowWelcomeMessage(Customer customer)
        {
            string welcomeMessage = customer.Name + " " + customer.FirstLastName + " " + customer.SecondLastName;
            WelcomeLabel.Text = welcomeMessage;
            WelcomeLabel.Visible = true;
            
        }


        private void ConnectButton_Click(object sender, EventArgs e)
        {
            
             StartClientThreads();
           
            
        }

        private void DisconectButton_Click(object sender, EventArgs e)
        {
          
           
        }

        private async void AcceptButton_Click(object sender, EventArgs e)
        {

            StartClientThreads();
           
        }

        private void button5_Click(object sender, EventArgs e)
        {
           
            this.Close();
        }

        private void IdBox_KeyPress(object sender, KeyPressEventArgs e)
        {
           
        }
    }
}
