using System.Runtime.ConstrainedExecution;

namespace Using_C_SHARP
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Nesse caso temos um texto que a classe StringReader fará a leitura /
            string linhas = @"Esta é a primeira linha 
                            Esta é a segunda linha
                            Está é a penultima linha
                            Esta é a última linha";

            string item; //Criamos uma variável do tipo string com o nome de item 

            //Aqui utilizamos o using pois está instrução fornece uma abordagem melhor para destruição de arquivos
            //criamos a variável leitor do tipo var que recebe a Classe StringReader derivada da classe TextReader que fará a leitura do arquivo linhas.
            using (var leitor = new StringReader(linhas)) 
                            
                do //Estrutura de repetição Do while (Faça enquanto), irá executar se o arquivo dentro de item for diferente de nulo.
                {
                    item = leitor.ReadLine(); //Item recebe o leitor que é o tipo var(maneira implícita ou indireta de definir os dados),
                                              //que dentro do leitor tem o arquivo linhas

                    Console.WriteLine(item); //Se tudo estiver correto será printado na tela.
                } while (item != null); //O que está dentro do do while só irá executar se o arquivo for dirente de nulo.
        }
    }
}