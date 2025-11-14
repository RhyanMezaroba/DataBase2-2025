✈️ Transporte dos Guri

Sistema Gerenciador de Transporte Aéreo desenvolvido como projeto da disciplina Banco de Dados II do curso de Ciência da Computação – UNOESC.

🎯 Objetivo

O sistema tem como finalidade gerenciar de forma completa os processos de uma empresa aérea — desde o cadastro de aeronaves e aeroportos até o controle de voos, assentos, reservas e compras de passagens.
Também implementa controle de acesso baseado em papéis (usuário e administrador), garantindo segurança e organização nas operações.

🧰 Tecnologias Utilizadas

Back-end: ASP.NET Core MVC (C#)

Banco de Dados: SQL Server + Entity Framework

Front-end: CSHTML, Tailwind CSS e JavaScript

Autenticação: ASP.NET Identity com Roles e ApplicationUser

Integração Externa: API REST ViaCEP (para preenchimento automático de endereço)

PDF: Geração de recibos personalizados com QuestPDF

⚙️ Destaques do Projeto

Controle completo de aeronaves, aeroportos, voos, escalas e reservas

Geração de recibos em PDF após a compra de passagens

Autenticação com diferentes níveis de acesso

Interface moderna e responsiva utilizando Tailwind CSS

Relacionamentos modelados com Entity Framework, garantindo integridade entre entidades

🧩 Estrutura do Projeto

Controllers – controle das rotas e regras de negócio

Models – entidades principais do sistema

ViewModels – moldes para Views específicas (Admin e Usuário)

Views – páginas renderizadas com CSHTML

PDF – geração dos recibos via QuestPDF

wwwroot – arquivos estáticos (CSS, JS, imagens)

👥 Equipe

Thiago Wurster Balbinot

Thiago Thomasi

Rhyan Mezaroba

Mateus Ferreira da Silva

UNOESC – Ciência da Computação | 2025
