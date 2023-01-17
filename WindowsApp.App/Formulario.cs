using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Entidades.Entidades.DocumentoComercial;
using Entidades.Entidades.Persona.Cliente;
using Entidades.Entidades.Persona.Empresa;
using Entidades.Entidades.Persona.Vendedor;
using Entidades.Entidades.Producto;
using Negocio.Listado;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;


namespace WindowsApp
{
    public partial class WindowsApp : Form
    {
        public WindowsApp()
        {
            InitializeComponent();
        }

        private void Crear(object sender, EventArgs e)
        {            

            var Producto = new Producto(textBoxNombre.Text, textBoxDescripcion.Text,
                           Convert.ToDecimal(textBoxPrecioCosto.Text.Replace(".", ",")),
                           Convert.ToDouble(textBoxMargen.Text.Replace(".", ",")),
                           textBoxProveedor.Text,
                           textBoxCategoria.Text, textBoxSubCategoria.Text);

            checkIva.Tag = Producto.IVA;
            Producto.PrecioCosto *= numProducts.Value;

            MessageBox.Show("¡Producto Creado!");
            listProducts.Items.Add(Producto.ToString());

            textBoxNombre.ResetText();
            textBoxDescripcion.ResetText();
            textBoxPrecioCosto.ResetText();
            textBoxMargen.ResetText();
            textBoxProveedor.ResetText();
            textBoxCategoria.ResetText();
            textBoxSubCategoria.ResetText();
        }

        private void Vendedor(object sender, EventArgs e)
        {
            var v = new Vendedor("Samuel", "samuelrm08@gmail.com", "11 9999-8888", "CABA", "Rivera", "46766847");

            MessageBox.Show(v.ToString());
        }

        private void Empresa(object sender, EventArgs e)
        {
            var em = new Empresa("Coca Cola", "20-1111111-1", "11 9999-8888", "coca@cola.com", "11 1234-5678", "CABA");
            MessageBox.Show(em.ToString());
        }

        private void Cliente(object sender, EventArgs e)
        {
            var c = new ClienteIndividuo("Cesar", "cesar@gmail.com", "11 111-11111", "CABA", "Boronat", "09090324");
            MessageBox.Show(c.ToString());
        }

        private void Remito(object sender, EventArgs e)
        {
            var r = new Remito("001-21421421", new DateTime(2023, 01, 16), "Cesar", "CABA", "Consumidor Final", "Contado", "Zapatillas", 22000, new DateTime(2023, 01, 18));
            MessageBox.Show(r.ToString());
        }

        private void Factura(object sender, EventArgs e)
        {
            var f = new Factura("001-123456", new DateTime(2023, 01, 16), "Cesar", "CABA", "Consumidor Final", "Contado", "Zapatillas", 22000, "Factura B");
            MessageBox.Show(f.ToString());
        }
    }
}

