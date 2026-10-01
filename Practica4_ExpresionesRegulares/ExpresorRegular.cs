using System.Diagnostics.CodeAnalysis;
using System.Text.RegularExpressions;

namespace Practica4_ExpresionesRegulares;

public class ExpresorRegular
{
    public static Form1 formulario;
    public static void Setup(Form1 form)
    {
        formulario = form;

    }
    public static bool Evaluar(string userInput, TiposValidos tipo) {
        bool valido = false;
        string dato = "";
        int acum = 0;
        switch (tipo) {
            case TiposValidos.Nombre:
                valido = Regex.IsMatch(userInput, "^[A-Z][a-z]+( [A-Z][a-z]+)+$");
                if (!valido)
                {
                    dato = "Nombre invalido\n Solo se pueden letras \nDeben de tener al menos 2 caracteres antes de espacio\nDespues de un espacio debe de ir una mayuscula";
                }
                break;
            case TiposValidos.Edad:
                valido = Regex.IsMatch(userInput, "^19|[2-9]\\d$");
                if (!valido)
                {
                    dato = "Edad invalida\nSolo se puede con edades de 19 a 99";
                }
                break;
                
            case TiposValidos.Telefono:
                valido = Regex.IsMatch(userInput, "^\\(\\d{3}\\)-\\d{3}-\\d{2}-\\d{2}$");
                if (!valido)
                {
                    dato = "Telefono invalido\nFormato: (123)-456-78-90";
                }
                break;
                
            case TiposValidos.Salario:
                valido = Regex.IsMatch(userInput, "^\\d{1,3}(,\\d{3})*(\\.\\d{2})?$");
                if (!valido)
                {
                    dato = "Salario invalido\nFormato: 1,234.56 o 1,234";
                }
                break;
                
            case TiposValidos.RFC:
                valido = Regex.IsMatch(userInput, "^[A-Z&Ñ]{3,4}\\d{6}([A-Z\\d]{3})?$");
                if (!valido)
                {
                    dato = "RFC invalido\nFormato: ABCD123456ABC o ABCD123456";
                }
                break;
                
            case TiposValidos.Correo:
                valido = Regex.IsMatch(userInput, "^[a-zA-Z0-9\\-\\+=^*~_!\\?&%\\$#\\.]+@[\\da-zA-Z]((([\\-])?[\\da-zA-Z])+|[\\da-zA-Z]+)?\\.[a-zA-Z]+(\\.[a-zA-Z]+)?$");
                if (!valido)
                {
                    dato = "Correo invalido\nFormato: nombre@dominio.com";
                }
                break;
        }
        if (!valido)
        {
            MessageBox.Show("' " + userInput + " ' no es valido\n" + dato);
            return false;
        }
        return true;
    }
}