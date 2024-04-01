using Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace AccesoDB
{
    public class DatosNodosDB
    {
        public List<DatosNodos> BajarDatos()
        {
            List<DatosNodos> datos = new List<DatosNodos>();
            AccesoDB accesoDB = new AccesoDB();
            try
            {
                accesoDB.setquery("Select * from DatosNodo");
                accesoDB.runread();
                while (accesoDB.Reader.Read())
                {
                    DatosNodos aux = new DatosNodos();
                    aux.Id = (int)accesoDB.Reader["Id"];
                    aux.users = new Users();
                    aux.users.Id = (int)accesoDB.Reader["IdUsuario"];
                    aux.Empresa = (string)accesoDB.Reader["Empresa"];
                    if (!(accesoDB.Reader["Lugar"] is DBNull))
                        aux.Lugar = (string)accesoDB.Reader["Lugar"];
                    aux.IdNodo = (int)accesoDB.Reader["IdNodo"];
                    aux.Seccion = (string)accesoDB.Reader["Seccion"];
                    aux.Estado = (string)accesoDB.Reader["Estado"];
                    //aux.Time = new DateTime();
                    aux.Time = (DateTime)accesoDB.Reader["Time"];

                    datos.Add(aux);
                }

                return datos;
            }
            catch (Exception ex)
            {

                throw ex;
            }
            finally
            {
                accesoDB.closeconnection();
            }

        }
        public void subirDato(DatosNodos nuevo)
        {
            try
            {
                AccesoDB accesoDB = new AccesoDB();
                accesoDB.setquery("INSERT INTO DatosNodo (IdUsuario,Empresa,Lugar,IdNodo,Seccion,Estado,Time) VALUES (@IdUsuario,@Empresa,@Lugar,@IdNodo,@Seccion,@Estado,@Time)");
                accesoDB.setparametro("@Idusuario", nuevo.users.Id);
                accesoDB.setparametro("@Empresa", nuevo.Empresa);
                accesoDB.setparametro("@Lugar", nuevo.Lugar);
                accesoDB.setparametro("@IdNodo", nuevo.IdNodo);
                accesoDB.setparametro("@Seccion", nuevo.Seccion);
                accesoDB.setparametro("@Estado", nuevo.Estado);
                accesoDB.setparametro("@Time", nuevo.Time);
                accesoDB.exeaction();

            }
            catch (Exception ex)
            {
                throw ex;
            }

        }
    }
}
