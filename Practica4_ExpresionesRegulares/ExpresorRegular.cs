using System.Text.RegularExpressions;

namespace Practica4_ExpresionesRegulares;

public class ExpresorRegular
{
    public static void Evaluar(string userInput, TiposValidos tipo) {
        bool valido = false;
        switch (tipo) {
            case TiposValidos.Nombre:
            
                break;
                
            case TiposValidos.Edad:
                break;
                
            case TiposValidos.Telefono:
                break;
                
            case TiposValidos.Salario:
                valido = Regex.IsMatch(userInput,"^[0-9]{1,3}(,[0-9]{3}(,[0-9]{3})*)?$");
                break;
                
            case TiposValidos.RFC:
                valido = Regex.IsMatch(userInput,"^\\w{4}-([0-9]{6}|[0-9]{9})$");
                break;
                
            case TiposValidos.Correo:
                break;
        }
        
        Console.WriteLine($"La expresión '{userInput}' es: {valido}");
    }
}