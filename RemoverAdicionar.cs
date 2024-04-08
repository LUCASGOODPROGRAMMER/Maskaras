using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BibliotecaDeMaskaras
{
    public static class RemoverAdicionar
    {
        public static string MaskararNumero(string numero)
        {
            string ddd = numero.Substring(0, 2);
            string numero1 = numero.Substring(2, 5);
            string numero2 = numero.Substring(7);
            string esquerdo = "(";
            string direito = ")-";
            string traco = "-";

            return $"{esquerdo}{ddd}{direito}{numero1}{traco}{numero2}";
        }
        public static string MaskararCPF(string cpf)
        {
            string traco = "-";
            string ponto = ".";
            string num1 = cpf.Substring(0, 3);
            string num2 = cpf.Substring(3, 3);
            string num3 = cpf.Substring(6, 3);
            string num4 = cpf.Substring(9);
            return $"{num1}{ponto}{num2}{ponto}{num3}{traco}{num4}";
        }
        public static string MaskararCEP(string cep)
        {
            string num1 = cep.Substring(0, 5);
            string num2 = cep.Substring(5, 3);
            string traco = "-";
            return $"{num1}{traco}{num2}";
        }
        public static string DesmaskararNumero(string numero)
        {
            string ddd = numero.Substring(1, 2);
            string numero1 = numero.Substring(5, 5);
            string numero2 = numero.Substring(11);        
            return $"{ddd}{numero1}{numero2}";
        }
        public static string DesmaskararCPF(string cpf)
        {            
            string num1 = cpf.Substring(0, 3);
            string num2 = cpf.Substring(4, 3);
            string num3 = cpf.Substring(8, 3);
            string num4 = cpf.Substring(12);
            return $"{num1}{num2}{num3}{num4}";
        }
        public static string DesmaskararCEP(string cep)
        {
            string num1 = cep.Substring(0, 5);
            string num2 = cep.Substring(6, 3);
           
            return $"{num1}{num2}";
        }
    }
}
