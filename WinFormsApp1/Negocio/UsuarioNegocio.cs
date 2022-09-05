using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Datos;
using Entidad;
using System.Data;

namespace Negocio
{
    public class UsuarioNegocio
    {
        Usuario us = new Usuario();
        UsuariosDatos dao = new UsuariosDatos();
        public bool ExisteUsuario(Usuario us)
        {
            if (dao.VerificarLogin(us))
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public bool verificarUsuario(string correo)
        {
            return dao.consultaCorreo(correo);
        }

        public bool verificarContraseña(string contraseña)
        {
            return dao.consultaContraseña(contraseña);
        }

        public DataTable TablaUsuario()
        {
            return dao.getTablaUsuario();
        }

        public List<string> DdlUsuario()
        {
            return dao.CargarDdlUsuario();
        }

        public string buscarPorDni(string dni)
        {
            return dao.traerNombreCompleto(dni);
        }
        public string buscarApellido(string dni)
        {
            return dao.traerApellido(dni);
        }
        public string buscarContraseña(string dni)
        {
            return dao.traerContraseña(dni);
        }
        public string buscarCelular(string dni)
        {
            return dao.traerCelular(dni);
        }
        public string buscarCorreo(string dni)
        {
            return dao.traerCorreo(dni);
        }
        public string buscarNombre(string dni)
        {
            return dao.traerNombre(dni);
        }
        public bool ModificarDatosUsuarios(string dni, Usuario us)
        {
           return dao.modificarUsuario(dni, us);
        }

        /*************************************************/
        //      Registro de Usuarios
        /*************************************************/

        public bool VerificarDni(string dni)
        {
            return dao.vefificarUsuarioDni(dni);
        }

        public void cargarUsuario(Usuario us)
        {
            dao.crearUsuario(us);
        }

        public void eliminarUsuario(string dni)
        {
            dao.bajarUsuario(dni);
        }
    }
}