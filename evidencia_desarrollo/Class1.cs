﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace evidencia_desarrollo
{
    public class estudiante
    {
        public int Codigo { get; set; }
        public string Nombre { get; set; }
        public string Correo { get; set; }
        public double Promedio { get; set; }

    }
}
class Validaciones
{
    public bool Vacio(string texto)
    {
        if (texto.Equals(""))
        {
            Console.WriteLine(" La entrada no puede ser VACIO");
            return true;
        }
        else
            return false;
    }

    public bool TipoNumero(string texto)
    {
        Regex regla = new Regex("[0-9]{1,9}(//.[0-9]{0,2})?$");

        if (regla.IsMatch(texto))
            return true;
        else
        {
            Console.WriteLine(" La entrada no debe ser NUMERICA");
            return false;
        }
    }

    public bool TipoTexto(string texto)
    {
        var regla = new Regex("^[a-zA-Z ]*$");

        if (regla.IsMatch(texto))
            return true;
        else
        {
            Console.WriteLine(" La entrada no debe ser SOLO TEXTO");
            return false;
        }
    }

    public bool emailValido(String email)

    {
        try
        {
            var address = new System.Net.Mail.MailAddress(email);
            return address.Address == email;
        }
        catch
        {
            Console.WriteLine("el correo ingresado no es valido, ingrese uno valido");
            return false;

        }

        /* String expresion;
         expresion = "\\w+([-+.']\\w+)@\\w+([-.]\\w+)\\.\\w+([-.]\\w+)*";
         if (Regex.IsMatch(email, expresion))
         {

             if (Regex.Replace(email, expresion, String.Empty).Length == 0)
             {
                 return true;

             }
             else
             {
                 return false;
             }
         }
         else
         {
             return false;
         }
        */
    }
}
