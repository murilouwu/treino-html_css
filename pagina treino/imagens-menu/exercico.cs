using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Consensionaria
{
    class Program
    {
        static void Main(string[] args)
        {
            int lcr;
            int lcm;
            lcr = 300;
            lcm = 200;
            Caminhao[] truck = new Caminhao[lcm];
            Carro[] car = new Carro[lcr];
            bool l;
            l = true;

            while (l == true)
            {
                string es;
                menu();
                es = Console.ReadLine();
                switch (es)
                {
                    case "1":
                        c();
                        int lp;
                        for (lp=0; lp<lcr ; lp++)
                        {
                            if (car[lp].apelido == "")
                            {
                                string d, ve;
                                d = "digite ";
                                ve = "carro";

                                Console.WriteLine("\n\n***cadastrar carro***\n\n");
                                Console.WriteLine(d+"o modelo do "+ve+":"); string m = Console.ReadLine();
                                Console.WriteLine(d+ "o nome do fabricante do "+ve+":"); string f = Console.ReadLine();
                                Console.WriteLine(d+ "a cor do "+ve+":"); string c = Console.ReadLine();
                                Console.WriteLine(d+ "o ano de lançamento do "+ve+":"); int a = int.Parse(Console.ReadLine());
                                Console.WriteLine(d+"o número de porta do "+ve+":");  int np = int.Parse(Console.ReadLine());
                                Console.WriteLine(d+"a capacidade de mala do "+ve+"(não digite o kg):"); int cp = int.Parse(Console.ReadLine());
                                Console.WriteLine("responda "+ve+" possui bagageiro:"); string r = Console.ReadLine();

                                car[lp].modelo = m; car[lp].fabricante = f; car[lp].cor = c;
                                car[lp].ano = a; car[lp].nporta = np; car[lp].cpmala = cp; car[lp].bag = r;
                                break;
                            } else {
                                continue;
                            }
                        }
                    break;

                    case "2":
                        int lp1;
                        for (lp1 = 0; lp1 < lcm; lp1++)
                        {
                            c();
                            if (truck[lp1].placa == "")
                            {
                                string d, ve;
                                d = "digite ";
                                ve = "caminhão";

                                Console.WriteLine("\n\n***cadastrar carro***\n\n");
                                Console.WriteLine(d+"o modelo do "+ve+":"); string m = Console.ReadLine();
                                Console.WriteLine(d+"o nome do fabricante do "+ve+":"); string f = Console.ReadLine();
                                Console.WriteLine(d+"a cor do "+ve+":"); string c = Console.ReadLine();
                                Console.WriteLine(d+"o ano de lançamento do "+ve+":"); int a = int.Parse(Console.ReadLine());
                                Console.WriteLine(d+"o número de porta do "+ve+":"); int np = int.Parse(Console.ReadLine());
                                Console.WriteLine(d+"o numero de eixos do "+ve+":"); int ne = int.Parse(Console.ReadLine());
                                Console.WriteLine(d+"a peso maximo do "+ve+" aguenta(não digite o kg):"); int cp = int.Parse(Console.ReadLine());
                                Console.WriteLine(d+"a placa do "+ve+":"); string r = Console.ReadLine();

                                truck[lp1].modelo = m; truck[lp1].fabricante = f; truck[lp1].cor = c;
                                truck[lp1].ano = a; truck[lp1].nporta = np; truck[lp1].neixo = ne; truck[lp1].pesom = cp; truck[lp1].placa = r;
                                break;
                            }
                            else
                            {
                                continue;
                            }
                        }
                    break;

                    case "3":
                        c();
                        string res;
                        Console.WriteLine("digite uma placa:");
                        res = Console.ReadLine();
                        int lp2;
                        for (lp2 = 0; lp2 < lcm; lp2++)
                        {
                            if (truck[lp2].placa == res)
                            {
                                Console.WriteLine("carro {0}\n{1}", lp2, car[lp2].ToString());
                                break;
                            }
                            else
                            {
                                continue;
                            }
                        }
                    break;

                    case "4":
                        break;

                    case "5":
                        break;

                    case "6":
                        break;

                    case "7":
                        break;

                    case "0":
                        ex();
                        break;

                    default:
                        c();
                        Console.WriteLine("digite um valor válido");
                        l = true;
                    break;
                };
                Console.ReadKey();
            }
        }
        static void c()
        {
            Console.Clear();
        }
        static void ex()
        {
            Environment.Exit(1);
        }
        static void menu()
        {
            string p;
            p = "para ";

            Console.WriteLine("\n\n***Menu Consensionaria***\n");
            Console.WriteLine("Digite:\n");
            Console.WriteLine("1-"+p+"Cadastro de Carro\n2-"+p+"Cadastro de Caminhão\n3-"+p+"Consulta por placa\n4-"+p+"Consultar Caminhão por modelo/marca");
            Console.WriteLine("5-"+p+"Consultar Carro por cor\n6-"+p+"Exibir todos os Carros cadastrados\n7-"+p+ "Exibir todos os Caminhões cadastrados\n0-" + p+"sair");
        }
    }
    abstract class Veiculo
    {
        public string modelo;
        public string fabricante;
        public string cor;
        public int ano;
        public int nporta;

        public Veiculo()
        {
            this.modelo = null;
            this.fabricante = null;
            this.cor = null;
            this.ano = 0;
            this.nporta = 0;
        }
        public Veiculo(string modelo, string fabricante, string cor, int ano, int nporta)
        {
            this.modelo = modelo;
            this.fabricante = fabricante;
            this.cor = cor;
            this.ano = ano;
            this.nporta = nporta;
        }
        public string Modelo
        {
            get { return modelo; }
            set { modelo = value; }
        }
        public string Fabricante
        {
            get { return fabricante; }
            set { fabricante = value; }
        }
        public string Cor
        {
            get { return cor; }
            set { cor = value; }
        }
        public int Ano
        {
            get { return ano; }
            set { ano = value; }
        }
        public int Nporta
        {
            get { return nporta; }
            set { nporta = value; }
        }
        public override string ToString()
        {
            return string.Format("Modelo: {0}\nFabricante: {1}\nAno: {2}\nCor: {3}\nNúmero de portas: {4}\n", modelo, fabricante, ano, cor, nporta);
        }
    }
    public class Carro:Veiculo
    {
        public int cpmala;
        public string apelido;
        public string bag;

        public Carro()
            :base()
        {
            this.cpmala = 0;
            this.apelido = null;
            this.bag = null;
        }
        public Carro(string modelo, string fabricante, string cor, int ano, int nporta, int cpmala, string bag, string apelido)
            :base(modelo, fabricante, cor, ano, nporta)
        {
            this.cpmala = cpmala;
            this.apelido = apelido;
            this.bag = bag;
        }
        public int Cpmala
        {
            get { return cpmala; }
            set { cpmala = value; }
        }
        public string Bag
        {
            get { return bag; }
            set { bag = value; }
        }
        public string Apelido
        {
            get { return apelido; }
            set { apelido = value; }
        }
        public override string ToString()
        {
            return string.Format("{0}Capacidade do porta malas: {1} kg\nBagajeiro: {2}", base.ToString(), cpmala, bag, apelido);
        }
    }
    public class Caminhao:Veiculo
    {
        public int neixo;
        public double pesom;
        public string placa;

        public Caminhao()
            : base()
        {
            this.neixo = 0;
            this.pesom = 0;
            this.placa = null;
        }
        public Caminhao(string modelo, string fabricante, string cor, int ano, int nporta, int neixo, double pesom, string placa)
            : base(modelo, fabricante, cor, ano, nporta)
        {
            this.neixo = neixo;
            this.pesom = pesom;
            this.placa = placa;
        }
        public int Neixo
        {
            get { return neixo; }
            set { neixo = value; }
        }
        public double Pesom
        {
            get { return pesom; }
            set { pesom = value; }
        }
        public string Placa
        {
            get { return placa; }
            set { placa = value; }
        }
        public override string ToString()
        {
            return string.Format("{0}Número de eixos: {1}\nPeso Máximo de carga: {2} kg\nPlaca: {3}", base.ToString(), neixo, pesom, placa);
        }
    }
}