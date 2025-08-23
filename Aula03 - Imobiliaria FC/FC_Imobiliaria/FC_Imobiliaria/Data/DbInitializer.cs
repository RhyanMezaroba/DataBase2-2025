using FC_Imobiliaria.Data;
using FC_Imobiliaria.Models;

public static class DbInitializer
{
    public static void Initialize(ImobiliariaContext context)
    {
        context.Database.EnsureCreated();

        if (context.Imoveis.Any())
        {
            return;
        }

        var imoveis = new Imoveis[]
        {
            new Imoveis { Nome = "Apartamento Centro", Definicao = "Apartamento com 3 quartos, vista para o parque", NumeroQuartos = 3, Preco = 350000 },
            new Imoveis { Nome = "Casa Jardim", Definicao = "Casa com quintal grande e garagem para 2 carros", NumeroQuartos = 4, Preco = 480000 },
            new Imoveis { Nome = "Kitnet Estudantil", Definicao = "Kitnet próxima à universidade", NumeroQuartos = 1, Preco = 120000 },
            new Imoveis { Nome = "Cobertura Luxo", Definicao = "Cobertura com piscina privativa", NumeroQuartos = 5, Preco = 950000 },
            new Imoveis { Nome = "Apartamento Econômico", Definicao = "Apartamento de 2 quartos em bairro residencial", NumeroQuartos = 2, Preco = 210000 }
        };

        foreach (Imoveis imovel in imoveis)
        {
            context.Imoveis.Add(imovel);
        }

        context.SaveChanges();

        var inquilinos = new Inquilino[]
        {
            new Inquilino { Name = "Ricardinho Rei Delas", Idade = 24, QuantImoveis = 2},
            new Inquilino { Name = "Thiaguinho Do Pila", Idade = 25, QuantImoveis = 4},
            new Inquilino { Name = "Matheus Estudioso", Idade = 22, QuantImoveis = 1},
            new Inquilino { Name = "Rhyan Reymond", Idade = 68, QuantImoveis = 5},
            new Inquilino { Name = "Thiagão Agricultor", Idade = 33, QuantImoveis = 2}
        };

        foreach (Inquilino inquilino in inquilinos)
        {
            context.Inquilinos.Add(inquilino);
        }

        context.SaveChanges();

    }
}
