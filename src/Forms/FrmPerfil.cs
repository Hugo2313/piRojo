﻿using pet4sitter.Clases;
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
    public partial class FrmPerfil : Form
    {
        public FrmPerfil()
        {
            InitializeComponent();
        }

        private void FrmPerfil_Load(object sender, EventArgs e)
        {
            ModoOscuro();
            CargarProductosDestacados();
            CultureInfo.CurrentCulture = ConfiguracionIdioma.Cultura;
            AplicarIdioma();
            if (Data.CurrentUser.Image != null)
            {
                pcbImagen.Image = Utiles.ByteArrayToImage(Data.CurrentUser.Image);
            }
            lblNombre.Text = Data.CurrentUser.Name.ToUpper();
            lblLocalizacion.Text = Data.CurrentUser.Location;
            CompruebaSitter();
            CompruebaPremium();
        }
        void ModoOscuro()
        {
            if (Data.DarkMode)
            {
                this.Icon = Utiles.BitmapToIcon(Properties.Resources.pet4sitterLogo1 as Bitmap);
                this.BackColor = Color.DarkGreen;
            }
        }


        private void CompruebaPremium()
        {
            if (Data.CurrentUser.Premium == true)
            {
                btnPremium.Visible = false;
            }
            else
            {
                btnPremium.Visible = false;
            }
        }

        private void CargarProductosDestacados()
        {
            if (ConBD.Conexion != null)
            {
                ConBD.AbrirConexion();
                string query = "Select * from products order by rand() limit 3;";
                List<Producto> lprod = Producto.ListarProductos(query);
                if (lprod.Count > 0)
                {

                    lblProd1.Text = lprod[0].NombreProducto;
                    lblPrecioProd1.Text = lprod[0].Precio.ToString() + " EUR";
                    pcbProd1.Image = lprod[0].UrlImagen;
                }

                if (lprod.Count > 1)
                {
                    lblProd2.Text = lprod[1].NombreProducto;
                    lblPrecioProd2.Text = lprod[1].Precio.ToString() + " EUR";
                    pcbProd2.Image = lprod[1].UrlImagen;
                }

                if (lprod.Count > 2)
                {

                    lblProd3.Text = lprod[2].NombreProducto;
                    lblPrecioProd3.Text = lprod[2].Precio.ToString() + " EUR";
                    pcbProd3.Image = lprod[2].UrlImagen;
                }

                ConBD.CerrarConexion();
            }
            else
            {
                MessageBox.Show("No existe conexión a la Base de datos");
            }//Comprueba si la bd está disponible
        }


        private void CompruebaSitter()
        {
            if (Data.CurrentUser.Sitter == true)
            {
                lblPrecio.Text = Data.CurrentUser.Precio.ToString() + "€/Día";
                btnDarAlta.Visible = false;
                btnDarseBaja.Visible = true;
            }
            else
            {
                btnDarAlta.Visible = true;
                btnDarseBaja.Visible = false;
                lblPrecio.Text = "Este Usuario NO es Cuidador";
            }
        }

        private void AplicarIdioma()
        {
            lblTePodriaInteresar.Text = Resources.Recursos_Localizable.FrmPerfil.lblUltimaCompra_Text;
            btnEditarPerfil.Text = Resources.Recursos_Localizable.FrmPerfil.btnEditarPerfil_Text;
            btnDarAlta.Text = Resources.Recursos_Localizable.FrmPerfil.btnDarAlta_Text;
            btnDarseBaja.Text = Resources.Recursos_Localizable.FrmPerfil.btnDarAlta_Text;
            btnDarseBaja.Text = Resources.Recursos_Localizable.FrmPerfil.btnDarseBaja_Text;
            btnPremium.Text = Resources.Recursos_Localizable.FrmPerfil.btnPremium_Text;
        }

        private void btnEditarPerfil_Click(object sender, EventArgs e)
        {
            FrmEditarPerfil frm = new FrmEditarPerfil();
            frm.ShowDialog();
            if (Data.CurrentUser.Image != null)
            {
                pcbImagen.Image = Utiles.ByteArrayToImage(Data.CurrentUser.Image);
            }
        }

        private void btnDarAlta_Click(object sender, EventArgs e)
        {
            FrmDarseDeAlta frm = new FrmDarseDeAlta();
            frm.ShowDialog();
            CompruebaSitter();

        }

        private void btnDarseBaja_Click(object sender, EventArgs e)
        {
            User u = new User(Data.CurrentUser.IdUser, Data.CurrentUser.IdGoogle, Data.CurrentUser.Name, Data.CurrentUser.Surname, Data.CurrentUser.Email, Data.CurrentUser.Dni, Data.CurrentUser.Password, Data.CurrentUser.Precio, Data.CurrentUser.Location, Data.CurrentUser.Premium, false, Data.CurrentUser.Admin, Data.CurrentUser.Image, Data.CurrentUser.Latitud, Data.CurrentUser.Longitud);
            if (ConBD.Conexion != null)
            {
                ConBD.AbrirConexion();
                User.ActualizarUsuario(u);
                ConBD.CerrarConexion();
                MessageBox.Show("Usuario: "+ Data.CurrentUser.Name+" dado de baja como cuidador con éxito!");
                this.Hide();
                btnDarAlta.Visible = true;
                btnDarseBaja.Visible = false;
                this.Show();
                lblPrecio.Text = "Este Usuario NO es Cuidador";

            }
            else
            {
                MessageBox.Show("No te has podido dar de baja!");
            }
        }

        private void FrmPerfil_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}
