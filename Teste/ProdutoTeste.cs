using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Xunit;

namespace Teste
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

    public class ProdutoTeste
    {
        [Fact]
        public void criarObjeto()
        {
            //Arrange - prepara as variaveis
            int codigo = 1;
            string nome = "Caneca";
            double saldo = 0;
            double custo = 0;
            string medida = "PC";

            //objeto anonimo
            var obj = new {
                codigo: 1,
                nome: "Caneca";,
                saldo: (double)0,
                custo: (double)0,
                medida: "PC"
            };

            //Act
            Produto produto = new Produto(codigo, nome, saldo, custo, medida);

            Produto produto = new Produto(obj.codigo, obj.nome, obj.saldo, obj.custo, obj.medida);




            //Assert
        }
    }
}