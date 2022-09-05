using Datos.Models;
using Entidad;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Data;
using System.Net;
using Usuario = Entidad.Usuario;

namespace Datos
{
    public class UsuariosDatos
    {
        public bool VerificarLogin(Usuario us)
        {
            using (var context = new ProyectoUsuariosContext())
            {
                foreach(var post in context.Usuarios.ToList())
                {
                    if(us.Correo == post.CorreoUsu && us.Contraseña == post.ContraseñaUsu)
                    {
                        return true;
                    }
                }
                return false;
            }
        }
        public bool consultaCorreo(string correo)
        {
            using (var context = new ProyectoUsuariosContext())
            {
                foreach (var post in context.Usuarios.ToList())
                {
                    if (correo == post.CorreoUsu)
                    {
                        return true;
                    }
                }
                return false;
            }
        }

        public bool consultaContraseña(string contraseña)
        {
            using (var context = new ProyectoUsuariosContext())
            {
                foreach (var post in context.Usuarios.ToList())
                {
                    if (contraseña == post.ContraseñaUsu)
                    {
                        return true;
                    }
                }
                return false;
            }
        }
        

        public DataTable getTablaUsuario()
        {
            using (var context = new ProyectoUsuariosContext())
            {
                DataTable TablaUsuarios = CrearTablaUsuarios();
                
                foreach (var post in context.Usuarios.ToList())
                {
                    DataRow dr = TablaUsuarios.NewRow();
                    dr["DNI"] = post.DniUsu;
                    dr["NOMBRE"] = post.NombreUsu;
                    dr["APELLIDO"] = post.ApellidoUsu;
                    dr["CORREO"] = post.CorreoUsu;
                    dr["CELULAR"] = post.CelularUsu;
                    TablaUsuarios.Rows.Add(dr);

                }
                
                return TablaUsuarios;
                
            }
        }

        public List<string> CargarDdlUsuario()
        {
            using (var context = new ProyectoUsuariosContext())
            {
                List<string> usuarios = new List<string>();

                foreach (var post in context.Usuarios.ToList())
                {
                    usuarios.Add(post.DniUsu);

                }

                return usuarios;

            }

        }

        public string traerNombreCompleto(string dni)
        {
            using (var context = new ProyectoUsuariosContext())
            {

                foreach (var post in context.Usuarios.ToList())
                {
                    if(dni == post.DniUsu)
                    {
                        return post.NombreUsu+" "+post.ApellidoUsu;
                    }
                }
                return "No existe";
            }
        }

        public string traerApellido(string dni)
        {
            using (var context = new ProyectoUsuariosContext())
            {

                foreach (var post in context.Usuarios.ToList())
                {
                    if (dni == post.DniUsu)
                    {
                        return post.ApellidoUsu;
                    }
                }
                return "No existe";
            }
        }

        public string traerContraseña(string dni)
        {
            using (var context = new ProyectoUsuariosContext())
            {

                foreach (var post in context.Usuarios.ToList())
                {
                    if (dni == post.DniUsu)
                    {
                        return post.ContraseñaUsu;
                    }
                }
                return "No existe";
            }
        }
        public string traerCelular(string dni)
        {
            using (var context = new ProyectoUsuariosContext())
            {

                foreach (var post in context.Usuarios.ToList())
                {
                    if (dni == post.DniUsu)
                    {
                        return post.CelularUsu;
                    }
                }
                return "No existe";
            }
        }
        public string traerNombre(string dni)
        {
            using (var context = new ProyectoUsuariosContext())
            {

                foreach (var post in context.Usuarios.ToList())
                {
                    if (dni == post.DniUsu)
                    {
                        return post.NombreUsu;
                    }
                }
                return "No existe";
            }
        }

        public string traerCorreo(string dni)
        {
            using (var context = new ProyectoUsuariosContext())
            {

                foreach (var post in context.Usuarios.ToList())
                {
                    if (dni == post.DniUsu)
                    {
                        return post.CorreoUsu;
                    }
                }
                return "No existe";
            }
        }

        public bool modificarUsuario(string dni, Usuario us)
        {
            using (var context = new ProyectoUsuariosContext())
            {

                var p = context.Usuarios.Find(dni);

                if(dni == us.Dni)
                {
                    p.DniUsu = us.Dni;
                    p.NombreUsu = us.Nombre;
                    p.ApellidoUsu = us.Apellido;
                    p.CorreoUsu = us.Correo;
                    p.ContraseñaUsu = us.Contraseña;
                    p.CelularUsu = us.Celular;

                    context.Entry(p).State = EntityState.Modified;
                    context.SaveChanges();

                    return true;
                }
                else
                {
                    bool bandera = true;
                    foreach (var post in context.Usuarios.ToList())
                    {
                        if (post.DniUsu == us.Dni)
                        {
                            bandera = false;
                        }
                    }
                    if(bandera == true)
                    {
                        /* eliminar el usuario y volverlo a crear*/
                        using (var context2 = new ProyectoUsuariosContext())
                        {
                            var u = context2.Usuarios.Find(dni);
                            context2.Remove(u);
                            context2.SaveChanges();
                        }

                        p.DniUsu = us.Dni;
                        p.NombreUsu = us.Nombre;
                        p.ApellidoUsu = us.Apellido;
                        p.CorreoUsu = us.Correo;
                        p.ContraseñaUsu = us.Contraseña;
                        p.CelularUsu = us.Celular;

                        context.Usuarios.Add(p);
                        context.SaveChanges();

                        return true;
                    }
                    return false;
                }
                
            }
            
        }
        public DataTable CrearTablaUsuarios()
        {
            DataTable dt = new DataTable();

            DataColumn Columna = new DataColumn("DNI", Type.GetType("System.String"));
            dt.Columns.Add(Columna);

            Columna = new DataColumn("NOMBRE", Type.GetType("System.String"));
            dt.Columns.Add(Columna);

            Columna = new DataColumn("APELLIDO", Type.GetType("System.String"));
            dt.Columns.Add(Columna);

            Columna = new DataColumn("CORREO", Type.GetType("System.String"));
            dt.Columns.Add(Columna);

            Columna = new DataColumn("CELULAR", Type.GetType("System.String"));
            dt.Columns.Add(Columna);

            return dt;
        }

        /*************************************************/
        //      Registro de Usuarios
        /*************************************************/

        public bool vefificarUsuarioDni(string dni)
        {
            using (var context = new ProyectoUsuariosContext())
            {
                foreach(var post in context.Usuarios.ToList())
                {
                    if(post.DniUsu == dni)
                    {
                        return true;
                    }
                }
                return false;
            }
        }

        public void crearUsuario(Usuario us)
        {
            using (var context = new ProyectoUsuariosContext())
            {
                var u = new Datos.Models.Usuario();
                u.NombreUsu = us.Nombre;
                u.DniUsu = us.Dni;
                u.ApellidoUsu = us.Apellido;
                u.CorreoUsu = us.Correo;
                u.CelularUsu = us.Celular;
                u.ContraseñaUsu = us.Contraseña;
                context.Usuarios.Add(u);
                context.SaveChanges();
            }
        }

        public void bajarUsuario(string dni)
        {
            using (var context = new ProyectoUsuariosContext())
            {
                var u = context.Usuarios.Find(dni);
                context.Remove(u);
                context.SaveChanges();
            }
        }
    }
}
