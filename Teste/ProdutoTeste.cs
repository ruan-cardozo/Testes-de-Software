using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System;
using Xunit;

namespace Teste
{
    public class ProdutoTeste
    {
        /* 
        Eu, como almoxarife, preciso cadastrar produtos para que sejam consumidos pelos funcionários da empresa

        Critérios de aceite:
        1 - Um novo produto deve ter obrigatoriamente um código único, nome, saldo 0, custo 0 e unidade de medida.
        2 - As unidades de medida são PC, KG, MT, GR, LT, CX.
        3 - Um produto PODE ter uma descrição.
        4 - Um produto PODE ter um código de barras EAN.
        */

        [Fact]
        public void criarObjeto()
        {
            // Arrange - prepara as variáveis
            int codigo = 1;
            string nome = "Caneca";
            double saldo = 0;
            double custo = 0;
            string medida = "PC";

            // Act
            Produto produto = new Produto(codigo, nome, saldo, custo, medida);

            // Assert
            Assert.Equal(codigo, produto.Codigo);
            Assert.Equal(nome, produto.Nome);
            Assert.Equal(saldo, produto.Saldo);
            Assert.Equal(custo, produto.Custo);
            Assert.Equal(medida, produto.Medida);
        }
    }

    internal class Produto
    {
        private int codigo;
        private string nome;
        private double saldo;
        private double custo;
        private string medida;

        public int Codigo { get => codigo; }
        public string Nome { get => nome; }
        public double Saldo { get => saldo; }
        public double Custo { get => custo; }
        public string Medida { get => medida; }

        public Produto(int codigo, string nome, double saldo, double custo, string medida)
        {
            this.codigo = codigo;
            this.nome = nome;
            this.saldo = saldo;
            this.custo = custo;
            this.medida = medida;
        }
    }
}
