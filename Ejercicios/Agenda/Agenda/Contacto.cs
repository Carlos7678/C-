using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Agenda
{
    class Contacto
    {
        string nombre;
        string apellido1;
        string apellido2;
        string direccion;
        string telFijo;
        string telMovil;
        string mail;
        string dni;
        
        public Contacto(string n,string ap1,string ap2,string telfM,string DNI)
        {
            nombre = n;
            apellido1 = ap1;
            apellido2 = ap2;
            telMovil = telfM;
            dni = DNI;
        }

      public Contacto(string n,string ap1,string telfM,string DNI)
        {
            nombre = n;
            apellido1 = ap1;
            telMovil = telfM;
            dni = DNI;
        }

        public Contacto(string n,string ap1,string dir,string telfM,string telF,string correo,string DNI)
        {
            nombre=n;
            apellido1=ap1;
            direccion = dir;
            telMovil = telfM;
            telFijo = telF;
            mail = correo;
            dni=DNI;    
        }

        public void setNombre(string n)
        { 
            nombre = n;
        }

        public void setApellido1(string ap1)
        {
            apellido1=ap1;
        }

        public void setApellido2(string ap2)
        {
            apellido2 = ap2;
        }
         
        public void setDireccion(string dir)
        {
            direccion = dir;
        }
        public void setTelFijo(string telF)
        {
            telFijo= telF;
        }
        public void setTelMovil(string telfM)
        {
            telMovil=telfM;
        }
        public void setMail(string correo)
        { 
            mail = correo; 
        }
        public void setDni(string DNI)
        {
            dni= DNI;
        }
        public string getNombre()
        {
            return nombre;
        }

        public string getApellido1()
        {
            return apellido1;
        }

        public string getApellido2()
        {
            return apellido2;
        }
        public string getTelFijo()
        {
            return telFijo;
        }
        public string getDireccion()
        {
            return direccion;
        }
        public string getTelMovil()
        {
            return telMovil;
        }
        public string getMail()
        {
            return mail;
        }
        public string getDni()
        {
            return dni;
        }
    }
}
