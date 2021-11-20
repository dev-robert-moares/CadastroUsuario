using System;

namespace DesafioUsuario
{
    public class Program
    {
        public static void Main(string[] args)
        {
            // Título
            Console.WriteLine("*Cadástro de funcionários*\n");

            // Inserção do código
            Console.Write("Código: ");
            int codigoInt;
            bool codigo = Int32.TryParse(Console.ReadLine(), out codigoInt);

            if(codigoInt > 0){ 
                Console.WriteLine($"   Codigo => {codigoInt}");
            }else {
                Console.WriteLine("   O código não pode ser menor ou igual a 0!");
                Environment.Exit(0);
            }

            // Inserção do Nome - falta crashar e melhorar a condicinal
            Console.Write("Nome: ");
            string nome = Console.ReadLine();
            
            if (!(nome == "")){
                Console.WriteLine($"   Nome => {nome}");
            }else {
                Console.WriteLine("   O nome não pode ser NULO!");
                Environment.Exit(0);
            }

            // Inserção da idade
            Console.Write("Idade: ");
            int idadeInt;
            bool idade = Int32.TryParse(Console.ReadLine(), out idadeInt);

            if (idadeInt > 0){
                Console.WriteLine($"   Idade => {idadeInt}");
            }else {
                Console.WriteLine("   O código não pode ser menor ou igual a 0!");
            }

            // Escolha de Gênero
            Console.Write("Gênero: [M] - [F]: ");
            char genero = Convert.ToChar(Console.ReadLine());

            if (genero == 'M' || genero == 'm'){
                Console.WriteLine("   Gênero => Masculino");
            }else if (genero == 'F' || genero == 'f'){
                Console.WriteLine("   Gênero => Feminino");
            }else {
                Console.WriteLine("Comando não reconhecido!");
            }

            // Escolha de departamento
            Console.WriteLine("Departamento: \n[T] - Tecnologia da Informação\n[M] - Marketing e Publicidade\n[V] - Vendas e Comercial\n[F] - Financeiro e Contabilidade\n[A] - Administração e Recursos Humanos");
            char departamento = Convert.ToChar(Console.ReadLine());

            switch (departamento){

                case 'T':
                    Console.WriteLine("   Departamento => Tecnologia da informação");
                    break;

                case 'M':
                    Console.WriteLine("   Departamento => Marketing e Publicidade");
                    break;

                case 'V':
                    Console.WriteLine("   Departamento => Vendas e Comercial");
                    break;
                case 'F':
                    Console.WriteLine("   Departamentp => Financeiro e Contabilidade");
                    break;
                case 'A':
                    Console.WriteLine("   Departamento => Admin. e Recursos Humanos");
                    break;
                default:
                    Console.WriteLine("   Opção inexistente ou incorreta!");
                    break;
            }

            // Inserção de função
            Console.Write("Função: ");
            string funcao = Console.ReadLine();

            if (!(nome == "")){
                Console.WriteLine($"   Função => {funcao}");
            }else {
                Console.WriteLine("Função não pode ser NULA!");
                Environment.Exit(0);
            }

            // Inserção de remuneração
            Console.Write("Remuneração: ");
            int remuneracao = Int32.Parse(Console.ReadLine());
            Console.WriteLine($"   Remuneração => R${remuneracao},00");

            // Finalização
            Console.WriteLine("      *Cadastrado com sucesso!*");

            Console.ReadKey();

        }
      
    }
}
