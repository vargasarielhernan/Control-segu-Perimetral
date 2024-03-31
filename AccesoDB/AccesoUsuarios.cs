using Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccesoDB
{
    public class AccesoUsuarios
    {
        public bool findUser(Users User)
        {
            AccesoDB accesoDB = new AccesoDB();
            try
            {
                accesoDB.setquery("select Id, Usuario, Contraseña, Rol from Users where Usuario=@Name AND Contraseña=@Password");
                accesoDB.setparametro("@Name", User.Name);
                accesoDB.setparametro("@Password", User.Password);
                accesoDB.runread();
                while (accesoDB.Reader.Read())
                {
                    User.Id = (int)accesoDB.Reader["Id"];
                    User.Name = (string)accesoDB.Reader["Usuario"];
                    if (!(accesoDB.Reader["Rol"] is DBNull))
                    {
                        User.Rol = (int)accesoDB.Reader["Rol"];
                    }
                    return true;
                }
                return false;

            }
            catch (Exception e)
            {

                throw e;
            }
            finally
            {
                accesoDB.closeconnection();
            }
        }


    }
}
