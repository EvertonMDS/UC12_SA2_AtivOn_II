
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace P_TXT

{
    class Program
    {

        static void Main(string[] args)
        {
            string a = "Oswaldo Loureiro";
            string b = "Rua: Gustavo Emiliano Carneiro Iânes, nº328, Bairro: Morumbi, Cidade: São Paulo, Cep: 05887490";
            string c = "69.744.447/0001-71";
            string d = "OL Transportes LTDA";
            string e = "669.698.148-90";
            string f = "11/02/1974";
            string g = "Avenida: Brigadeiro Antonio Barros da Costa, nº 3345, Bairro Santa Cecília, Cidade: São Paulo, Cep: 05887569";

            string caminhoDoArquivo = "C:\\Users\\eletr\\Desktop\\P_TXT\\p_Ativ.txt";

            var stream = new StreamWriter(caminhoDoArquivo);

            stream.WriteLine("");
            stream.WriteLine("FICHA CADASTRAL:");
            stream.WriteLine("");
            stream.WriteLine("");
            stream.WriteLine("Pessoa Jurídica");
            stream.WriteLine("");            
            stream.WriteLine("Nome do Proprietário: " + a);
            stream.WriteLine("Endereço do Proprietário: " + g);
            stream.WriteLine("Endereço Comercial: " + b);            
            stream.WriteLine("CNPJ: " + c);
            stream.WriteLine("Razão Social: " + d);
            stream.WriteLine("");
            stream.WriteLine("");
            stream.WriteLine("Pessoa Física");
            stream.WriteLine("");
            stream.WriteLine("Nome do Proprietário: " + a);
            stream.WriteLine("Endereço do Proprietário: " + g);
            stream.WriteLine("Endereço Comercial: " + b);
            stream.WriteLine("CPF: " + e);
            stream.WriteLine("Data de Nascimento: " + f);
            stream.Close();

            using (var reader = new StreamReader(caminhoDoArquivo))

            {
                Console.WriteLine(reader.ReadLine());

            }

        }

    }

}
