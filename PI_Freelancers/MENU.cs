using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PI_Freelancers
{
    public class MENU
    {
        private int _AutoID = 1; // AUTO IMPLEMENTO DO ID 
        private List<Freelancer> _ListaFreelancer = new List<Freelancer>(); // LISTA DE PROFISSINAIS CADASTRADOS
        public void ChamarMenuPrincipal()
        {
            Console.WriteLine("+-+-+-+-+-+-+-+-+-+-+-+-+-+");
            Console.WriteLine("|      MENU PRINCIPAL     |");
            Console.WriteLine("+-+-+-+-+-+-+-+-+-+-+-+-+-+");
            Console.WriteLine("");
            Console.Write("Digite 1 para EMPRESAS ou 2 para FREELANCERS: ");
            var opcaoMenuPrincipal = int.Parse(Console.ReadLine());

            switch (opcaoMenuPrincipal)
            {
                case 1:
                    Console.Clear();
                    Console.WriteLine("+-+-+-+-+-+-+-+-+-+-+-+-+-+");
                    Console.WriteLine("|      MENU EMPRESAS      |");
                    Console.WriteLine("+-+-+-+-+-+-+-+-+-+-+-+-+-+");
                    Console.WriteLine("");

                    break;
                case 2:
                    Console.WriteLine("");
                    Console.WriteLine("Você selecionou FREELANCERS.");
                    Thread.Sleep(3000);
                    Console.Clear();
                    ChamarMenuFreelancer();
                    break;
                default:
                    Console.WriteLine("Opção inválida, digite uma opção válida.");
                    Thread.Sleep(2000);
                    Console.Clear();
                    break;
            }                    
        }        
        public void ChamarMenuFreelancer()
        {
            Console.Clear();
            Console.WriteLine("+-+-+-+-+-+-+-+-+-+-+-+-+-+");
            Console.WriteLine("|     MENU FREELANCER     |");
            Console.WriteLine("+-+-+-+-+-+-+-+-+-+-+-+-+-+");
            Console.WriteLine("");
            Console.WriteLine("1 - Quero me cadastrar");
            Console.WriteLine("2 - Já sou cadastrado");
            Console.WriteLine("3 - Voltar ao menu principal");
            Console.WriteLine("");
            Console.Write("Escolha a opção desejada: ");
            int opcaoFreelancer1 = int.Parse(Console.ReadLine());
            switch (opcaoFreelancer1)
            {
                case 1:
                    Console.Clear();
                    Console.WriteLine("Para realizar seu cadastro preencha as seguintes informações:");
                    Console.WriteLine("");
                    AdicionarFreelancer(CadastrarFreelancer());
                    

                    Console.WriteLine("Tecle ENTER para voltar ao MENU.");
                    Console.ReadLine();
                    Console.WriteLine("");
                    Console.WriteLine("Voltando ao MENU..");
                    Thread.Sleep(2000);
                    Console.Clear();
                    ChamarMenuFreelancer();
                    break;
                case 2:
                    Console.Clear();
                    ChamarMenuCadastrado();
                    Console.WriteLine("Tecle ENTER para voltar ao MENU.");
                    Console.ReadLine();
                    Console.WriteLine("");
                    Console.WriteLine("Voltando ao MENU..");
                    Thread.Sleep(2000);
                    Console.Clear();
                    ChamarMenuFreelancer();
                    break;
                case 3:
                    Console.WriteLine("");
                    Console.WriteLine("Voltando ao MENU PRINCIPAL..");
                    Thread.Sleep(2000);
                    Console.Clear();
                    ChamarMenuPrincipal();
                    break;
                default:
                    Console.WriteLine("Opção inválida, digite uma opção válida.");
                    Thread.Sleep(2000);
                    Console.Clear();
                    break;
            }
        }
        private Freelancer CadastrarFreelancer()
        {
            Freelancer freelancer = new Freelancer();
            freelancer.Id = _AutoID;

            Console.Write("Digite o seu nome: ");
            freelancer.Nome = Console.ReadLine();
            Console.Write("Digite o seu CPF: ");
            freelancer.CPF = long.Parse(Console.ReadLine());
            Console.Write("Digite o seu endereço: ");
            freelancer.Endereco = Console.ReadLine();
            Console.Write("Digite o seu Telefone: ");
            freelancer.Telefone = long.Parse(Console.ReadLine());
            Console.Write("Digite o seu Email: ");
            freelancer.Email = Console.ReadLine();
            Console.Write("Digite os serviços que você já presta: ");
            freelancer.TiposServicos = Console.ReadLine();
            Console.Write("Digite suas observações: ");
            freelancer.Obervacoes = Console.ReadLine();
            Console.WriteLine("");
            Console.WriteLine("Seu cadastro foi realizado com sucesso!");
            Console.WriteLine("");
            Console.WriteLine($"Anote o seu ID de cadastro: {freelancer.Id}");


            _AutoID++;
            return freelancer;
        }
        private void AdicionarFreelancer(Freelancer freelancer)
        {
            _ListaFreelancer.Add(freelancer);
        }
        private void ListarFreelancer(long cpf)
        {



            if (_ListaFreelancer.Any(x => x.CPF == cpf)) 
            {
                var freelancerCPF = _ListaFreelancer.First(x => x.CPF == cpf);
                if (freelancerCPF == null)
                {
                    Console.WriteLine("Cadastro não encontrado.");
                    Console.WriteLine("");
                    Console.WriteLine("Voltando ao MENU..");
                    Thread.Sleep(2000);
                    Console.Clear();
                    ChamarMenuFreelancer();
                }
                else
                {
                    
                    Console.WriteLine("");
                    Console.WriteLine($"Bem vindo, {freelancerCPF.Nome}!");
                    Console.WriteLine("");
                }
            }
        }
        private void ChamarMenuCadastrado()
        {
            Console.Write("Digite o seu CPF: ");
            long cpfCadastrado = long.Parse(Console.ReadLine());
            ListarFreelancer(cpfCadastrado);
            Thread.Sleep(2000);
            Console.Clear();
            if (_ListaFreelancer.Any(x => x.CPF == cpfCadastrado))
            {
                var freelancer = _ListaFreelancer.First(x => x.Id == cpfCadastrado);
                Console.WriteLine($"{freelancer.Nome}, o que deseja fazer?");
                Console.WriteLine("1 - Exibir o seu perfil.");
                Console.WriteLine("2 - Alterar o seu perfil.");
                Console.WriteLine("3 - Excluir o seu perfil.");
                Console.WriteLine("4 - Voltar ao MENU.");

            }
            



        }
    }
}
