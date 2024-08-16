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
using System.IO.Pipes;

namespace PresentationLayer
{
    //Funcion para obtener los eventos del programa
    public delegate void LogEventDelegate(string message);
    public partial class MainMenu : Form
    {

        //variables para asignar la comunicacion del servidor
        //Variable para el hilo
        private TcpClient client;
        private NetworkStream stream;
        public bool isConnected = false;
        private Thread clientThread;
        
        public MainMenu(TcpClient client, NetworkStream stream)
        {
            InitializeComponent();
            // Deshabilitar el botón de maximizar
            this.MaximizeBox = false;
            // Abrir en el centro del escritorio
            this.StartPosition = FormStartPosition.CenterScreen;
            this.stream = stream;
            this.client = client;
            dataGridView.Visible = true;
            dataGridViewLoan.Visible = false;
            isConnected = true;
          

            
        }

       

        //Desconectarse del servidor
        public void DisconnectFromServer()
        {
            try
            {
                byte[] data = Encoding.UTF8.GetBytes("CLOSE");
                stream.Write(data, 0, data.Length);
                stream.Close();
                client.Close();
                isConnected = false;
            }
            catch (IOException ex)
            {
                MessageBox.Show("Error al desconectar del servidor: " + ex.Message);
            }
        }

      //Obtener la lista de sucursales
       private List<Branch> GetBranchList()
       {
            try
            {

                byte[] data = Encoding.UTF8.GetBytes("GET_BRANCH");
                stream.Write(data, 0, data.Length);

                // Leer la respuesta del servidor.
                byte[] buffer = new byte[client.ReceiveBufferSize];
                int bytesRead = stream.Read(buffer, 0, client.ReceiveBufferSize);
                string response = Encoding.UTF8.GetString(buffer, 0, bytesRead);

               
                string jsonData = response.Replace("GET_BRANCH_RESPONSE", "");
                List<Branch> branchList = JsonConvert.DeserializeObject<List<Branch>>(jsonData);

                
                return branchList;

            }
            catch (IOException ex)
            {
                MessageBox.Show("Error al leer datos del servidor: " + ex.Message);
                return null;
            }
       }
        //Obtener la lista de las peliculas asociadas a la sucursal
        private List<Movie> GetMovieList()
        {
            try
            {
                Branch branch = BranchComboBox.SelectedItem as Branch;
                if (branch == null)
                {
                    MessageBox.Show("Por favor, seleccione una sucursal válida.");
                    return null;
                }

                // Construir el mensaje a enviar, incluyendo el ID de la sucursal
                string message = "GET_MOVIE|" + JsonConvert.SerializeObject(branch);
                byte[] data = Encoding.UTF8.GetBytes(message);
                stream.Write(data, 0, data.Length);

                // Leer la respuesta del servidor
                byte[] buffer = new byte[client.ReceiveBufferSize];
                int bytesRead = stream.Read(buffer, 0, client.ReceiveBufferSize);
                string response = Encoding.UTF8.GetString(buffer, 0, bytesRead);

                // Eliminar el encabezado "GET_MOVIE_RESPONSE"
                string jsonData = response.Replace("GET_MOVIE_RESPONSE", "");//Despues de eliminar el encabezado ya se guarda el objeto recibido
                List<Movie> movieList = JsonConvert.DeserializeObject<List<Movie>>(jsonData);

                return movieList;
            }
            catch (IOException ex)
            {
                MessageBox.Show("Error al leer datos del servidor: " + ex.Message);
                return null;
            }
        }

        // Mostrar la lista de las peliculas disponibles
        private void DisplayMovie()
        {
            MoviesLabel.Visible = true;
            LoanLabel.Visible = false;
            dataGridViewLoan.Visible = false;
            List<Movie> movieList = GetMovieList();

            dataGridView.Rows.Clear();

            if (movieList != null && movieList.Count > 0)
            {
                foreach (var movie in movieList)
                {
                    
                    int rowIndex = dataGridView.Rows.Add();

                    dataGridView.Rows[rowIndex].Cells["MovieId"].Value = movie.Id;
                    dataGridView.Rows[rowIndex].Cells["MovieName"].Value = movie.Name;
                    dataGridView.Rows[rowIndex].Cells["CategoryId"].Value = movie.Category.Id;
                    dataGridView.Rows[rowIndex].Cells["MovieCategory"].Value = movie.Category.Name;
                    dataGridView.Rows[rowIndex].Cells["Description"].Value = movie.Category.Description;
                    dataGridView.Rows[rowIndex].Cells["ReleaseYear"].Value = movie.ReleaseYear;
                    dataGridView.Rows[rowIndex].Cells["MovieLanguage"].Value = movie.Language;

                }
            }

           // dataGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView.Visible = true;
        }

        //Obtener los datos de la fila seleccionada
        private Movie GetSelectedMovie()
        {
            if (dataGridView.SelectedRows.Count > 0) 
            {
                DataGridViewRow row = dataGridView.SelectedRows[0]; // Obtiene la primera fila seleccionada
                Movie movie = new Movie
                {
                    Id = (int)row.Cells["MovieId"].Value,
                    Name = (string)row.Cells["MovieName"].Value,
                    Category = new Category
                    {
                        Id = (int)row.Cells["CategoryId"].Value,
                        Name = (string)row.Cells["MovieCategory"].Value,
                        Description = (string)row.Cells["Description"].Value
                    },
                    ReleaseYear = (int)row.Cells["ReleaseYear"].Value,
                    Language = (string)row.Cells["MovieLanguage"].Value
                };

                return movie;
            }

            return null; // Retorna null si no se seleccionó ninguna fila
        }

        private void MainMenu_Load(object sender, EventArgs e)
        {

        }


        //actualizar la lista de las sucursales
        private void updateComboBox()
        {
            try
            {
                // Limpiar el ComboBox
                BranchComboBox.Items.Clear();

                // Obtener las sucursales desde la capa de negocio
                List<Branch> branchList = GetBranchList().Where(branch => branch.Active == true).ToList();

                // Asignar la lista filtrada al ComboBox
                BranchComboBox.DataSource = branchList;
                BranchComboBox.DisplayMember = "Name";
                BranchComboBox.ValueMember = "Id";

                
             //   BranchComboBox.SelectedIndexChanged += BranchComboBox_SelectedIndexChanged;
            }
            catch (Exception ex)
            {
                // Manejar cualquier excepción que pueda ocurrir durante el proceso
                MessageBox.Show(ex.Message);
            }
        }

        //Validar las opciones seleccionadas
        private bool validateInputs()//valida los formatos ingresados en los inputs
        {


            if (BranchComboBox.SelectedIndex == -1)
            {
                MessageBox.Show("Seleccione la Sucursal");
                return false;
            }

            if (dataGridView.SelectedRows.Count <= 0)
            {
                MessageBox.Show("Seleccione la Pelicula");
                return false;
            }

            return true;
        }

        //Metodo de captura de datos
        private MovieByBranch captureData()//Captura los datos de los inputs y los almacena en el objeto de la clase
        {
            try
            {
                Movie movie = GetSelectedMovie();
                Branch branch = BranchComboBox.SelectedItem as Branch;
                int Qty = 1;

                

                if (movie != null && branch != null)
                {
                    MovieByBranch movieByBranch = new MovieByBranch(branch, movie, Qty);
                    return movieByBranch;
                }
                else
                {
                    MessageBox.Show("Se Estan Recibiendo Objetos Nulos");
                    return null;
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return null;
            }
            return null;
        }

        //Recibir el objeto para enviarlo al servidor 
        private void saveData(MovieByBranch movieByBranch)//recibe el objeto capturado  y lo guarda
        {
            try
            {
                if (movieByBranch != null)
                {

                    string message = "INSERT_LOAN|" + JsonConvert.SerializeObject(movieByBranch);
                    byte[] data = Encoding.UTF8.GetBytes(message);
                    stream.Write(data, 0, data.Length);

                    // Leer la respuesta del servidor
                    byte[] buffer = new byte[client.ReceiveBufferSize];
                    int bytesRead = stream.Read(buffer, 0, client.ReceiveBufferSize);
                    string response = Encoding.UTF8.GetString(buffer, 0, bytesRead);

                    
                    string jsonData = response.Replace("GET_INSERT_RESPONSE", "");
                    int answer = JsonConvert.DeserializeObject<int>(jsonData);

                    if (answer == 2)
                    {
                        MessageBox.Show("No Hay Peliculas Disponibles");
                    }
                    else if (answer == 3) 
                    {
                        MessageBox.Show("Ya Cuenta con Este Prestamo Activo");
                    }
                }
                

            }
            catch (IOException ex)
            {
                MessageBox.Show("Error al leer datos del servidor: " + ex.Message);
            }

        }


        //Obtener la lista con los prestamos
        private List<Loan> GetLoanList()
        {
            try
            {

                byte[] data = Encoding.UTF8.GetBytes("GET_LOAN");
                stream.Write(data, 0, data.Length);

                // Leer la respuesta del servidor.
                byte[] buffer = new byte[client.ReceiveBufferSize];
                int bytesRead = stream.Read(buffer, 0, client.ReceiveBufferSize);
                string response = Encoding.UTF8.GetString(buffer, 0, bytesRead);


                string jsonData = response.Replace("GET_LIST_RESPONSE", "");
                List<Loan> loanList = JsonConvert.DeserializeObject<List<Loan>>(jsonData);


                return loanList;

            }
            catch (IOException ex)
            {
                MessageBox.Show("Error al leer datos del servidor: " + ex.Message);
                return null;
            }
        }


        //Imprimir los datos de los prestamos
        private void DisplayLoan()
        {
            LoanLabel.Visible = true;
            MoviesLabel.Visible = false;

            dataGridViewLoan.Visible = false;
            List<Loan> loanList = GetLoanList();

            dataGridViewLoan.Rows.Clear();

            if (loanList != null && loanList.Count > 0)
            {
                foreach (var loan in loanList)
                {
                    int rowIndex = dataGridViewLoan.Rows.Add();

                    if (dataGridViewLoan.Columns.Contains("IdLoan"))
                        dataGridViewLoan.Rows[rowIndex].Cells["IdLoan"].Value = loan.LoanId;

                    if (dataGridViewLoan.Columns.Contains("IdCustomer"))
                        dataGridViewLoan.Rows[rowIndex].Cells["IdCustomer"].Value = loan.CustomerId;

                    if (dataGridViewLoan.Columns.Contains("IdBranch"))
                        dataGridViewLoan.Rows[rowIndex].Cells["IdBranch"].Value = loan.BranchId;

                    if (dataGridViewLoan.Columns.Contains("IdMovie"))
                        dataGridViewLoan.Rows[rowIndex].Cells["IdMovie"].Value = loan.MovieId;

                    if (dataGridViewLoan.Columns.Contains("LoanDate"))
                        dataGridViewLoan.Rows[rowIndex].Cells["LoanDate"].Value = loan.Date;

                    if (dataGridViewLoan.Columns.Contains("Pending"))
                        dataGridViewLoan.Rows[rowIndex].Cells["Pending"].Value = loan.Pending;
                }
            }

            dataGridViewLoan.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewLoan.Visible = true;
        }



        private void dataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void BranchComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }


        //boton para actualizar el combobox 
        private void button1_Click(object sender, EventArgs e)
        {
            updateComboBox();
        }

        //boton para actualizar la tabla de peliculas
        private void button2_Click(object sender, EventArgs e)
        {
            DisplayMovie();
        }


        //boton para guardar el prestamo y mostrar la lista actualizada
        private void button3_Click(object sender, EventArgs e)
        {
            if (validateInputs())
            {
                saveData(captureData());
                DisplayLoan();
            }
        }


        //boton para mostrar la tabla con los prestamos
        private void button4_Click(object sender, EventArgs e)
        {

            DisplayLoan();
        }


        //boton para salir del menu y llamar al metodo para desconectarse del servidor
        private void button5_Click(object sender, EventArgs e)
        {
            DisconnectFromServer();
            isConnected = false;
            this.Close();
        }


        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void dataGridViewLoan_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }


}
