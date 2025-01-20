using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Desafio4
{
    public class Administrador : Usuario, IPersistencia
    {
        string password = "adm";
        
        public void CriarEleicao(string nome, DateTime dataInicial, DateTime dataFinal, ECargosEmDisputa Cargos) {

            Eleicao eleicao = new Eleicao (nome, dataInicial, dataFinal, Cargos);
        }

        public void CadastrarCandidato(string nome, ECargosEmDisputa cargo, int NumeroIndentificador) {

            Canditado candidato = new Canditado(nome, cargo, NumeroIndentificador);
            
        }

        public void GerarRelatorio(Eleicao eleicao) {
            
        }

        public Administrador() { }

        public void SalvarVotosEncriptados(string password, Eleicao eleicao)
        {
    
            string VotosEncriptados = "VotosEncriptados.csv";
            string VotosEncriptadosTemp = "VotosEncriptadosTemp.csv";

            try
            {
                 using (StreamWriter writer = new StreamWriter(VotosEncriptados))
            {
                foreach (var guid in guidsAleatorios)
                {
                    writer.WriteLine(guid.ToString());    
                }
            }


                byte[] key = Encoding.UTF8.GetBytes(password.PadRight(32).Substring(0, 32));
                byte[] iv = Encoding.UTF8.GetBytes(password.PadRight(16).Substring(0, 16));

                using (Aes aes = Aes.Create())
                {
                    aes.Key = key;
                    aes.IV = iv;

                    using (FileStream inputFileStream = new FileStream(VotosEncriptados, FileMode.Open))
                    using (FileStream outputFileStream = new FileStream(VotosEncriptadosTemp, FileMode.Create))
                    using (CryptoStream cryptoStream = new CryptoStream(outputFileStream, aes.CreateEncryptor(), CryptoStreamMode.Write))
                    {
                        inputFileStream.CopyTo(cryptoStream);
                    }
                }

                File.Delete(VotosEncriptados);
                File.Move(VotosEncriptadosTemp, VotosEncriptados);

                Console.WriteLine("Votos encriptados com sucesso!");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Erro ao processar o arquivo: {ex.Message}");
            }
        }
        

       publ void CarregarResultadoDesencriptado(string password)
        {

            string VotosEncriptados = "VotosEncriptados.csv";
            string VotosDesencriptados = "VotosDesencriptados.csv";

            byte[] key = Encoding.UTF8.GetBytes(password.PadRight(32).Substring(0, 32)); 
            byte[] iv = Encoding.UTF8.GetBytes(password.PadRight(16).Substring(0, 16));

            try
            {
                using (Aes aes = Aes.Create())
                {
                    aes.Key = key;
                    aes.IV = iv;

                    using (FileStream inputFileStream = new FileStream(VotosEncriptados, FileMode.Open))
                    using (FileStream outputFileStream = new FileStream(VotosDesencriptados, FileMode.Create))
                    using (CryptoStream cryptoStream = new CryptoStream(inputFileStream, aes.CreateDecryptor(), CryptoStreamMode.Read))
                    {
                        cryptoStream.CopyTo(outputFileStream);
                    }
                }

                Console.WriteLine("Votos desencriptados com sucesso!");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Erro ao desencriptar o arquivo: {ex.Message}");
            }
        }
    }
}










    
