using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Xunit;
namespace Teste
{
    public class ProdutoTeste
    {
         /* 
        Eu, como almoxarife, preciso cadastrar produtos para que sejam consumidos pleos funcionários da empresa

        Critérios de aceite?
        1 - Um novo produto deve ter obrigatoriamente um código único, nome,
        saldo 0, custo 0 e unidade de medida
        2 - As unidades de medida são PC, KG, MT, GR, LT, CX
        3 - um produto PODE ter uma descrição
        4 - Um produto PODE ter um código de barras EAN
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
        public int Codigo { get; private set; }
        public string Nome { get; private set; }
        public double Saldo { get; private set; }
        public double Custo { get; private set; }
        public string Medida { get; private set; }

        public Produto(int codigo, string nome, double saldo, double custo, string medida)
        {
            Codigo = codigo;
            Nome = nome;
            Saldo = saldo;
            Custo = custo;
            Medida = medida;
        }
    }
}
