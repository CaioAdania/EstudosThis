using System.Globalization;

namespace EstudosThis.Entities;

class Teste
{
    public string Nome;
    public double Preco;
    public int Quantidade;

    public Teste()
    {
        Quantidade = 0;
    }
    public Teste(string Nome, double Preco) : this()
    {
        this.Nome = Nome; //temos esses casos para o uso do this, porem em C# como temos o CamelCase para cada "Função" , não é utilizado
        this.Preco = Preco;
    }
    public Teste(string Nome, double Preco, int Quantidade) : this(Nome, Preco) //this nesta situação ele resume o seu código para que não fique repetindo toda a sintaxe do Nome e Preco
    {
        this.Quantidade = Quantidade;
    }
    public double ValorTotalEmEstoque()
    {
        return Preco * Quantidade;
    }
    public void AdicionarProdutos(int quantidade)
    {
        Quantidade += quantidade;
    }
    public void RemoverProdutos(int quantidade)
    {
        Quantidade -= quantidade;
    }
    public override string ToString()
    {
        return Nome
        + ", $ "
        + Preco.ToString("F2", CultureInfo.InvariantCulture)
        + ", "
        + Quantidade
        + " unidades, Total: $ "
        + ValorTotalEmEstoque().ToString("F2", CultureInfo.InvariantCulture);
    }
}