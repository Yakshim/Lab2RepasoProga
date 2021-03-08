using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab2Repaso
{
    public partial class Form1 : Form
    {
        List<Cliente> clientes = new List<Cliente>();
        List<Vehiculo> vehiculos = new List<Vehiculo>();
        List<Alquiler> alquilers = new List<Alquiler>();

        public Form1()
        {
            InitializeComponent();
        }
        private void GuardarCliente(string fileName, string nit, string nombre, string direccion)
        {
            FileStream stream = new FileStream("Vehiculo.txt", FileMode.Append, FileAccess.Write);
            StreamWriter writer = new StreamWriter(stream);
            writer.WriteLine(nit);
            writer.WriteLine(nombre);
            writer.WriteLine(direccion);
            writer.Close();
        }
        private void GuardarVh(string fileName, string placa, string marca, string modelo, string color, string precioK)
        {
            FileStream stream = new FileStream("Vehiculo.txt", FileMode.Append, FileAccess.Write);
            StreamWriter writer = new StreamWriter(stream);
            writer.WriteLine(placa);
            writer.WriteLine(marca);
            writer.WriteLine(modelo);
            writer.WriteLine(color);
            writer.WriteLine(precioK);

            writer.Close();
        }
        private void Guardaralquiler(string fileName, string nit, string placa, string FechaAl, string FechaDev, string Recorrido)
        {
            FileStream stream = new FileStream("Alquiler.txt", FileMode.Append, FileAccess.Write);
            StreamWriter writer = new StreamWriter(stream);
            writer.WriteLine(nit);
            writer.WriteLine(placa);
            writer.WriteLine(FechaAl);
            writer.WriteLine(FechaDev);
            writer.WriteLine(Recorrido);

            writer.Close();
        }
        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void tabPage2_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
 
        }

        private void button1_Click_1(object sender, EventArgs e)
        { 
            if (textBoxNit.Text == "" && textBoxNombre.Text == "" && textBoxDireccion.Text == "")
            {
                labelRCliente.Text = "Error en ingreso de Datos";
            }
            else
            {
                string a = Convert.ToString(textBoxNit.Text);
                GuardarCliente("Cliente.txt", a, textBoxNombre.Text, textBoxDireccion.Text);
                labelRCliente.Text = "Datos Ingresados con Exito";
            }
            
        }

        private void buttonRefresh_Click(object sender, EventArgs e)
        {
            FileStream stream = new FileStream("Cliente.txt", FileMode.Open, FileAccess.Read);
            StreamReader reader = new StreamReader(stream);
            while (reader.Peek() > -1)
            {
                Cliente cliente = new Cliente();
                cliente.Nit = Convert.ToInt32(reader.ReadLine());
                cliente.Nombre = reader.ReadLine();
                cliente.Direccion = reader.ReadLine();

                clientes.Add(cliente);

            }
            reader.Close();

            FileStream stream2 = new FileStream("Vehiculo.txt", FileMode.Open, FileAccess.Read);
            StreamReader reader2 = new StreamReader(stream2);

            while (reader2.Peek() > -1)
            {
                Vehiculo vehiculo = new Vehiculo();
                vehiculo.Placa = reader2.ReadLine();
                vehiculo.Marca = reader2.ReadLine();
                vehiculo.Modelo = reader2.ReadLine();
                vehiculo.Color = reader2.ReadLine();
                vehiculo.PrecioKilometro = Convert.ToInt32(reader2.ReadLine());

                vehiculos.Add(vehiculo);

            }
            reader2.Close();

            DGWClientes.DataSource = null;
            DGWClientes.DataSource = clientes;

            DGWVehiculos.DataSource = null;
            DGWVehiculos.DataSource = vehiculos;

            comboBoxPlaca.DisplayMember = "Placa";
            comboBoxPlaca.ValueMember = "Placa";
            comboBoxPlaca.DataSource = null;
            comboBoxPlaca.DataSource = vehiculos;

            comboBoxNit.DisplayMember = "Nit";
            comboBoxNit.ValueMember = "Nit";
            comboBoxNit.DataSource = null;
            comboBoxNit.DataSource = clientes;

            DGWClientes.Refresh();
            DGWVehiculos.Refresh();
            comboBoxPlaca.Refresh();
        }

        private void buttonVh_Click(object sender, EventArgs e)
        {
            string a = textBoxPlaca.Text;
            if (textBoxPlaca.Text == "" && textBoxMarca.Text == "" && textBoxModelo.Text == "" && textBoxColor.Text == "" && textBoxVK.Text=="")
            {
                labelRVh.Text = "Error en ingreso de Datos";
            }
            else
            {
                GuardarVh("Vehiculo.txt", a,textBoxMarca.Text, textBoxModelo.Text, textBoxColor.Text, textBoxVK.Text);
                labelRVh.Text = "Datos Ingresados con Exito";
                textBoxPlaca.Clear();
                textBoxMarca.Clear();
                textBoxModelo.Clear();
                textBoxVK.Clear();
                textBoxColor.Clear();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if(comboBoxNit.Text == "" && comboBoxPlaca.Text == "" && textBoxKilometros.Text =="")
            {
                labelRAlquiler.Text = "Error en ingreso de Datos";
            }
            else
            {
                Guardaralquiler("Alquiler.txt",comboBoxNit.Text,comboBoxPlaca.Text,dateTimePickerAl.Value.ToString(),dateTimePickerDv.Value.ToString(),textBoxKilometros.Text);
                labelRAlquiler.Text = "Datos Ingresados con Exito";
                textBoxKilometros.Clear();
            }
        }

        private void buttonAlquiler_Click(object sender, EventArgs e)
        {
            FileStream stream = new FileStream("Alquiler.txt", FileMode.Open, FileAccess.Read);
            StreamReader reader = new StreamReader(stream);
            while (reader.Peek() > -1)
            {
                //Alquiler alquiler = new Alquiler();
                //Vehiculo vehiculo = new Vehiculo();
                ////alquiler.Nit1 =Convert.ToInt32(reader.ReadLine());
                ////alquiler.Placa1 = Convert.ToInt32(reader.ReadLine());
                //alquiler.FechaAlqui1 = Convert.ToDateTime(reader.ReadLine());
                //alquiler.FechaDev1 = Convert.ToDateTime(reader.ReadLine());
                ////alquiler.Recorridos1 = Convert.ToInt32(reader.ReadLine());
                ////alquiler.Pago = vehiculo.PrecioKilometro * alquiler.Recorridos1;
                //alquilers.Add(alquiler);

            }
            reader.Close();

            DGWAlquiler.DataSource = null;
            DGWAlquiler.DataSource = alquilers;
        }
    }
}
