using Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;


namespace AccesoDB
{
    public class AccesoUsuarios
    {
        public int findId(Users User)
        {
            AccesoDB accesoDB = new AccesoDB();
            try
            {
                accesoDB.setquery("select Id, Usuario, Contraseña, Rol, Imagen from Users where Usuario=@Name AND Contraseña=@Password");
                accesoDB.setparametro("@Name", User.Name);
                accesoDB.setparametro("@Password", User.Password);
                accesoDB.runread();
                Users User1 = new Users();
                while (accesoDB.Reader.Read())
                {
                    User1.Id = (int)accesoDB.Reader["Id"];
                    User1.Name = (string)accesoDB.Reader["Usuario"];
                    if (!(accesoDB.Reader["Rol"] is DBNull))
                    {
                        User1.Rol = (int)accesoDB.Reader["Rol"];
                    }
                    if (!(accesoDB.Reader["Imagen"] is DBNull))
                    {
                        User1.Imagen = (byte[])accesoDB.Reader["Imagen"];
                    }
                }
                return User1.Id;

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
        public Users CargarUsuario(int Id)
        {
            AccesoDB accesoDB = new AccesoDB();
            try
            {
                accesoDB.setquery("select Usuario, Contraseña, Rol, Imagen from Users where Id=@Id");
                accesoDB.setparametro("@Id", Id);
                accesoDB.runread();
                Users User1 = new Users();
                while (accesoDB.Reader.Read())
                {
                    User1.Name = (string)accesoDB.Reader["Usuario"];
                    User1.Password = (string)accesoDB.Reader["Contraseña"];
                    if (!(accesoDB.Reader["Rol"] is DBNull))
                    {
                        User1.Rol = (int)accesoDB.Reader["Rol"];
                    }
                    if (!(accesoDB.Reader["Imagen"] is DBNull))
                    {
                        User1.Imagen = (byte[])accesoDB.Reader["Imagen"];
                    }
                }
                return User1;

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
        public bool findUser(Users User)
        {
            AccesoDB accesoDB = new AccesoDB();
            try
            {
                accesoDB.setquery("select Id, Usuario, Contraseña, Rol, Imagen from Users where Usuario=@Name AND Contraseña=@Password");
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
                    if (!(accesoDB.Reader["Imagen"] is DBNull))
                    {
                        User.Imagen = (byte[])accesoDB.Reader["Imagen"];
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

        private void EditarUser(Users User)
        {
            AccesoDB accesoDB = new AccesoDB();
            try
            {
                accesoDB.setquery("UPDATE Users SET (Usuario=@Name,Contraseña=@Password,Imagen=@Imagen) where Id=@ID");
                accesoDB.setparametro("@Name", User.Name);
                accesoDB.setparametro("@Password", User.Password);
                accesoDB.setparametro("@Imagen", User.Imagen);
                accesoDB.setparametro("@Id", User.Id);
                accesoDB.exeaction();
            }
            catch (Exception ex)
            {

                throw ex; ;
            }
        }

    }
}
