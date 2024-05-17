﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.IO;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net.Sockets;
using Newtonsoft.Json.Linq;
using System.Reflection;
using static System.Net.WebRequestMethods;
using static Google.Apis.Requests.BatchRequest;
using System.Runtime.Remoting.Contexts;
using piTest.Clases;
using Mysqlx;

namespace piTest
{
    public partial class FrmRegister : Form
    {
        public FrmRegister()
        {
            InitializeComponent();
        }


        private void txtMail_Enter(object sender, EventArgs e)
        {
            if (txtMail.Text == "Introduce email")
            {
                txtMail.Text = "";
                txtMail.ForeColor = Color.White; // Cambiar el color del texto al color normal
            }
        }

        private void txtMail_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtMail.Text))
            {
                txtMail.Text = "Introduce email";
                txtMail.ForeColor = Color.Gray; // Cambiar el color del texto al color del marcador de posición
            }
        }

        private void txtPass_Enter(object sender, EventArgs e)
        {
            if (txtPass.Text == "Introduce contraseña")
            {
                txtPass.Text = "";
                txtPass.ForeColor = Color.White; // Cambiar el color del texto al color normal
            }
        }

        private void txtPass_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtPass.Text))
            {
                txtPass.Text = "Introduce contraseña";
                txtPass.ForeColor = Color.Gray; // Cambiar el color del texto al color del marcador de posición
            }
        }



        private void lblClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void lblForgPass_Click(object sender, EventArgs e)
        {
            // Mostrar el MessageBox
            DialogResult result = MessageBox.Show("¿Olvidaste tu contraseña?", "Recuperar Contraseña", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            // Comprobar la respuesta del usuario
            if (result == DialogResult.Yes)
            {
                // Código para recuperar la contraseña aquí
                MessageBox.Show("Se ha enviado un enlace de recuperación a tu correo electrónico.", "Recuperar Contraseña", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("¡No hay problema! Puedes recuérdala más tarde.", "Recuperar Contraseña", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private async void btnIniciarSesionGoogle_Click(object sender, EventArgs e)
        {
            if (ConBD.Conexion != null)
            {
                ConBD.AbrirConexion();
                await GoogleAuthenticator.exchangeCode();
                if (Data.UserGoogle.IdGoogle != null && !User.CompruebaUsuarioConGoogle(Data.UserGoogle.IdGoogle))
                {
                    this.Activate();
                    txtNombre.Text = Data.UserGoogle.Name;
                    MessageBox.Show("Es la primera vez que te registras, completa tus datos, solo será una vez", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Ya existe un usuario vinculado a esa cuenta de google");
                }
                ConBD.CerrarConexion();
            }else
            {
                MessageBox.Show("No existe conexión a la Base de datos");
            }//Comprueba si la bd está disponible
        }


        // Agrega el texto dado al registro en pantalla y a la consola de depuración
        public void output(string output)
        {
            Console.WriteLine(output);
        }

        private void btnContinueWGoogle_MouseHover(object sender, EventArgs e)
        {
            this.pictureBoxContinueGoogle.BackColor = Color.FromArgb(224, 238, 249);
        }

        private void btnContinueWGoogle_Leave(object sender, EventArgs e)
        {
            this.pictureBoxContinueGoogle.BackColor = Color.White;
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {

        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            FrmLogin l = new FrmLogin();
            this.Dispose();
            l.Show();
        }

        private void btnRegistro_Click(object sender, EventArgs e)
        {
            if (ConBD.Conexion != null)
            {
                ConBD.AbrirConexion();
                if (!User.CompruebaUsuarioExistente(txtMail.Text))
                {
                    MessageBox.Show("Si");
                    User u = null;
                    if (Data.UserGoogle != null)
                    {
                        u = new User(null, Data.UserGoogle.IdGoogle, txtNombre.Text, txtApellido.Text, txtMail.Text, txtDni.Text, txtPass.Text, txtDireccion.Text, null, chkCuidador.Checked, null, null);
                    }
                    else
                    {
                        u = new User(null, null, txtNombre.Text, txtApellido.Text, txtMail.Text, txtDni.Text, txtPass.Text, txtDireccion.Text, null, chkCuidador.Checked, null, null);
                    }
                    User.RegistrarUsuario(u);
                }
                else
                {
                    MessageBox.Show("Ya existe un usuario con ese email", "Usuario Existente", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                ConBD.CerrarConexion();
            }
            else
            {
                MessageBox.Show("No existe conexión a la Base de datos");
            }//Comprueba si la bd está disponible
        }


        private void txtNombre_Enter(object sender, EventArgs e)
        {
            if (txtNombre.Text == "Nombre")
            {
                txtNombre.Text = "";
                txtNombre.ForeColor = Color.White; // Cambiar el color del texto al color normal
            }
        }

        private void txtNombre_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtNombre.Text))
            {
                txtNombre.Text = "Nombre";
                txtNombre.ForeColor = Color.Gray; // Cambiar el color del texto al color del marcador de posición
            }
        }

        private void txtNombre_TextChanged(object sender, EventArgs e)
        {
            if (txtNombre.Text != "Nombre")
            {
                txtNombre.ForeColor = Color.White; // Cambiar el color del texto al color normal
            }
        }
    }
}