namespace TiendasMásURLMM1089322
{


    public partial class Form1 : System.Windows.Forms.Form
    {
        private int productosVendidos = 0;
        private int facturasRealizdas = 0;
        private List<ProductoFactura> listaProductosFactura = new();
        private readonly Dictionary<string, double> productos = new()
        {
            {"001", 10.80},
            {"002", 3.80},
            {"003", 1.10},
            {"004", 17.00},
            {"005", 50.00}
        };

        public Form1()
        {
            InitializeComponent();
        }

        private int numFacturasRealizadas = 0;
        private int totalProductos = 0;
        private string cantidadUnidades;
        private int puntosCliente = 0;
        private int puntosGanadosEnFactura = 0;


        private void fACTURACIÓNToolStripMenuItem_Click(object sender, EventArgs e)
        {

            listaProductosFactura = new List<ProductoFactura>();

            string numeroFactura = Microsoft.VisualBasic.Interaction.InputBox("Ingrese el numero de factura: ", "Facturación", "");
            if (string.IsNullOrEmpty(numeroFactura))
            {
                return;
            }

            string nombreFactura = Microsoft.VisualBasic.Interaction.InputBox("Ingrese el nombre de la factura: ", "Facturación", "");
            if (string.IsNullOrEmpty(nombreFactura))
            {
                return;
            }

            string nit = Microsoft.VisualBasic.Interaction.InputBox("Ingrese el NIT del cliente:", "Facturación", "");
            if (string.IsNullOrEmpty(nit))
            {
                return;
            }

            string correoElectronico = Microsoft.VisualBasic.Interaction.InputBox("Ingrese el correo electrónico del cliente: ", "Facturación", "");
            if (string.IsNullOrEmpty(correoElectronico))
            {
                return;
            }

            string respuesta = "S";
            while (respuesta.ToUpper() == "S")
            {
                string codigo = Microsoft.VisualBasic.Interaction.InputBox("Ingrese el código del producto: ");
                if (string.IsNullOrEmpty(codigo))
                {
                    return;
                }

                double precioProducto;
                if (productos.ContainsKey(codigo))
                {
                    precioProducto = productos[codigo];
                }
                else
                {
                    _ = MessageBox.Show("El código del producto es desconocido...");
                    return;
                }
                cantidadUnidades = Microsoft.VisualBasic.Interaction.InputBox("Ingrese la cantidad de unidades del producto: ");
                double totalProducto = precioProducto * double.Parse(cantidadUnidades);

                ProductoFactura productoFactura = new()
                {
                    CodigoProducto = codigo,
                    Cantidad = int.Parse(cantidadUnidades),
                    Precio = precioProducto,
                    Total = totalProducto
                };

                listaProductosFactura.Add(productoFactura);

                respuesta = Microsoft.VisualBasic.Interaction.InputBox($"Producto {codigo} agregado. ¿Desea agregar otro producto? S/N", "Facturación", "");
            }

            respuesta = Microsoft.VisualBasic.Interaction.InputBox($"¿Desea pagar con tarjeta? S/N", "Facturación", "");

            bool pagaConTarjeta = respuesta == "S";

            //muestra la informacion final 
            double totalFactura = 0;
            string mensaje = $"Tiendas Más URL\n"
                            + "NIT del super mercado: 192837465\n"
                            + $"Fecha de la factura: {DateTime.Now:dd/MM/yyyy}\n"
                            + $"Numero de factura: {numeroFactura}\n"
                            + $"Nombre del cliente: {nombreFactura}\n"
                            + $"NIT del cliente: {nit}\n"
                            + $"Correo electrónico del cliente: {correoElectronico}\n";


            foreach (ProductoFactura item in listaProductosFactura)
            {
                //va armando el mensaje
                mensaje = mensaje + "\n"
                    + $"Código del producto: {item.CodigoProducto} \n"
                    + $"Cantidad de unidades del producto: {item.Cantidad}\n"
                    + $"Precio unitario del producto: Q.{item.Precio}\n"
                    + $"Total del producto: Q.{item.Total}\n";

                //lleva el total
                totalFactura += item.Total;


                //productos vendidos
                productosVendidos += item.Cantidad;
                totalProductos += int.Parse(cantidadUnidades);

            }

            //puntos ganados
            //Condicion 1
            int puntos = 0;
            switch (totalFactura)
            {
                case <= 50:
                    if (pagaConTarjeta)
                    {
                        puntos = 1;
                    }
                    break;
                case > 50 and <= 100:
                    if (pagaConTarjeta)
                    {
                        puntos = 2;
                    }
                    break;
                default:
                    //mas de 100
                    puntos = 3;
                    break;

            }

            puntosGanadosEnFactura = (int)Math.Floor(totalFactura / 10) * puntos; // update the value of the variable
            puntosCliente += puntosGanadosEnFactura;

            string factura = mensaje + "\nTotal a pagar: Q." + totalFactura.ToString();
            _ = MessageBox.Show(factura);

            numFacturasRealizadas++;

            // Update the puntosGanadosEnFactura variable
            if (puntosGanadosEnFactura > 0)
            {
                puntosGanadosEnFactura -= puntosGanadosEnFactura;
                puntosGanadosEnFactura += puntos;
            }



        }

        private void mostrarListaProductos()
        {

            _ = MessageBox.Show("No hay productos en la lista.");

        }

        private int NumdeFacturas()
        {
            return numFacturasRealizadas;
        }

        private int NumProductosVendidos()
        {
            return totalProductos;
        }

        private int NumPuntosGenerados()
        {
            return puntosGanadosEnFactura;
        }

        private void reporteFacturacion(int opcion)
        {

            switch (opcion)
            {
                case 1:
                    int totalFacturas = NumdeFacturas();
                    _ = MessageBox.Show($"El total de facturas realizadas es: {totalFacturas}");
                    break;

                case 2:
                    int totalProductos = NumProductosVendidos();
                    _ = MessageBox.Show($"El total de productos vendidos es: {totalProductos}");
                    break;


                case 3:
                    int puntosGenerados = NumPuntosGenerados();
                    _ = MessageBox.Show($"Se generaron {puntosGenerados} puntos.");
                    break;


                default:
                    _ = MessageBox.Show("Opción inválida");
                    break;
            }
        }

        private void rEPORTESToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string opcionSeleccionada = Microsoft.VisualBasic.Interaction.InputBox("Seleccione el reporte que desea ver:\n"
                + "1. Total de facturas realizadas\n"
                + "2. Total de productos vendidos\n"
                + "3. Total de puntos generados", "Reportes de facturación", "");
            if (int.TryParse(opcionSeleccionada, out int opcion))
            {
                reporteFacturacion(opcion);
            }
            else
            {
                _ = MessageBox.Show("Opción inválida");
            }
        }


        private void SalirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }


        private void lISTADECARRITOToolStripMenuItem_Click(object sender, EventArgs e)
        {
            mostrarListaProductos();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }
    }
}