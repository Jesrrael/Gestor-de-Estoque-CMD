using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestorEstoque
{
    [System.Serializable]
    internal class ProdutoFisico : Produto, IEstoque // ProdutoFisico é uma classe filho que esta herdando caracteristicas da classe pai Produto
    {
        public float frete;
        private int estoque;

        public ProdutoFisico(string nome, float preco, float frete)// construtor, nome e preco estao sendo herdados da classe pai
        {
            this.nome = nome;
            this.preco = preco;
            this.frete = frete;

        }

        public void AdicionarEntrada()
        {
            Console.WriteLine($"Adicionar entrada no estoque do produto {nome}");
            Console.WriteLine("Digite a QTD. que você quer dda entrada: ");
            int entrada = int.Parse(Console.ReadLine());   
            // estoque = estoque + entrada;
            estoque += entrada;
            Console.WriteLine("Entrada registrada");
            Console.ReadLine();

        }

        public void AdicionarSaida()
        {
            Console.WriteLine($"Adicionar saida no estoque do produto {nome}");
            Console.WriteLine("Digite a QTD. que você quer dar baixa: ");
            int entrada = int.Parse(Console.ReadLine());
            // estoque = estoque - entrada;
            estoque -= entrada;
            Console.WriteLine("Saída registrada");
            Console.ReadLine();
        }

        public void Exibir()
        {
            Console.WriteLine("Fisico!");
            Console.WriteLine($"nome: {nome}");
            Console.WriteLine($"Frete: {frete}");
            Console.WriteLine($"Preço: {preco}");
            Console.WriteLine($"Estoque: {estoque}");
            Console.WriteLine("=================================");
        }
    }
}
