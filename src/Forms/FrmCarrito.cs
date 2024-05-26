﻿using MySql.Data.MySqlClient;
using pet4sitter.Clases;
using pet4sitter.UserControls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pet4sitter
{
    public partial class FrmCarrito : Form
    {
        int cantProdList;
        string loc;
        bool tarjetaCargada = false;
        List<Producto> prodListAnt;

        public FrmCarrito()
        {
            InitializeComponent();
        }

        private void FrmCarrito_Load(object sender, EventArgs e)
        {
            AplicarModoOscuro();
            CultureInfo.CurrentCulture = ConfiguracionIdioma.Cultura;
            AplicarIdioma();
            CargarProductos();
            loc = Data.CurrentUser.Location;
            lblLocalizacion.Text = loc;
            cantProdList = Carrito.Productos.Count;
            prodListAnt = Carrito.CopiarProductos(Carrito.Productos);
            lblSubtotal.Text = Carrito.ObtenerPrecioTotal(Carrito.Productos).ToString() + " EUR";
            if (Data.CurrentTarjeta != null)
            {
                lblNumTarjeta.Text = "**** **** **** " + Data.CurrentTarjeta.NumeroTarjeta.ToString().Substring(Data.CurrentTarjeta.NumeroTarjeta.ToString().Length - 4);
                lblDescripcionTarjeta.Text += "\n" + Data.CurrentTarjeta.ToString();
            }
        }
        private void AplicarModoOscuro()
        {
            if (Data.DarkMode)
            {
                this.Icon = Utiles.BitmapToIcon(Properties.Resources.pet4sitterLogo1 as Bitmap);
                this.BackColor = Color.DarkGreen;
            }
        }

        private void AplicarIdioma()
        {
            lblDescripcionLocalizacion.Text = Resources.Recursos_Localizable.FrmCarrito.lblDescripcionLocalizacion_Text;
            btnEliminar.Text = Resources.Recursos_Localizable.FrmCarrito.btnEliminar_Text;
            lblSubtotal.Text = Resources.Recursos_Localizable.FrmCarrito.lblSubtotal_Text;
            btnEditarPago.Text = Resources.Recursos_Localizable.FrmCarrito.btnEditarPago_Text;
            btnEditar.Text = Resources.Recursos_Localizable.FrmCarrito.btnEditar_Text;
            lblResumen.Text = Resources.Recursos_Localizable.FrmCarrito.lblResumen_Text;
            btnVolverPago.Text = Resources.Recursos_Localizable.FrmCarrito.btnVolverPago_Text;
            lblDescripcionTarjeta.Text = Resources.Recursos_Localizable.FrmCarrito.lblDescripcionTarjeta_Text;
            lblMetodo.Text = Resources.Recursos_Localizable.FrmCarrito.lblMetodo_Text;
            btnRealizar.Text = Resources.Recursos_Localizable.FrmCarrito.btnRealizar_Text;
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            FrmEditarDireccion frmED = new FrmEditarDireccion();
            frmED.ShowDialog();
        }

        private void btnEditarPago_Click(object sender, EventArgs e)
        {
            FrmEditarTarjeta frmET = new FrmEditarTarjeta();
            frmET.ShowDialog();
            if (Data.CurrentTarjeta != null && !tarjetaCargada)
            {
                
                lblNumTarjeta.Text = "**** **** **** " + Data.CurrentTarjeta.NumeroTarjeta.ToString().Substring(Data.CurrentTarjeta.NumeroTarjeta.ToString().Length - 4);
                lblDescripcionTarjeta.Text += "\n" + Data.CurrentTarjeta.ToString();
                tarjetaCargada = true;
            }
        }

        private void CargarProductos()
        {
            fLPanelCarrito.Controls.Clear();
            if (Carrito.Productos.Count > 0)
            {
                foreach (Producto p in Carrito.Productos)
                {
                    ProductoEnCarrito pec = new ProductoEnCarrito();
                    pec.Dock = DockStyle.Top;
                    pec.BringToFront();
                    pec.Nombre = p.NombreProducto;
                    pec.Precio = p.Precio;
                    pec.Descripcion = p.Descripcion;
                    pec.Id = (int)p.Id;
                    pec.Cantidad = p.Cantidad;
                    pec.Imagen = p.UrlImagen;
                    fLPanelCarrito.Controls.Add(pec);
                }
            }
            else
            {
                lblInfo.Visible = true;
                lblInfo.Text = "NO HAY PRODUCTOS EXISTENTES!";
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("¿Estás seguro de que deseas eliminar el carrito?", "Confirmar eliminación", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            if (result == DialogResult.Yes)
            {
                Carrito.Productos.Clear();
                this.Close();
                this.Dispose();
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (Carrito.Productos.Count != cantProdList)
            {
                CargarProductos();
                lblSubtotal.Text = Carrito.ObtenerPrecioTotal(Carrito.Productos).ToString() + " EUR";
            }
            if (Carrito.HaCambiadoLaCantidad(this.prodListAnt))
            {

                lblSubtotal.Text = Carrito.ObtenerPrecioTotal(Carrito.Productos).ToString() + " EUR";
            }
            prodListAnt = Carrito.CopiarProductos(Carrito.Productos);
        }

        private void btnRealizar_Click(object sender, EventArgs e)
        {
            if (Carrito.Productos.Count > 0)
            {
                if (Data.CurrentTarjeta != null)
                {
                    bool pagoExitoso = StripePaymentService.ProcessPayment((decimal)Carrito.ObtenerPrecioTotal(Carrito.Productos), "eur");

                    if (pagoExitoso)
                    {
                        MessageBox.Show("Pago realizado con éxito.");
                        Pedido p = new Pedido((int)Data.CurrentUser.IdUser, loc, Carrito.Productos);
                        Pedido.GuardarPedido(p);
                        int idPedido = Pedido.ObtenerIdUltimoPedido();
                        Pedido.GuardarProductosPedido(idPedido, Carrito.Productos);
                        string htmlMailPedido = Pedido.GenerarHtmlPedido(p);

                        var mailService = new MailServices.MailPet4Sitter();
                        mailService.sendMailHtml("Pedido Realizado!", htmlMailPedido, Data.CurrentUser.Email);
                        if(ConBD.Conexion != null)
                        {
                            ConBD.AbrirConexion();
                            Data.CurrentUser = User.EncontrarUsuario((int)Data.CurrentUser.IdUser);
                            ConBD.CerrarConexion();
                        }
                    }
                    else
                    {
                        MessageBox.Show("El pago falló.");
                    }

                }
                else
                {
                    MessageBox.Show("Introduce una tarjeta válida");
                }
            }


            else
            {
                MessageBox.Show("Debes tener almenos un producto en el carrito");
            }
        }

        private void btnVolverPago_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
