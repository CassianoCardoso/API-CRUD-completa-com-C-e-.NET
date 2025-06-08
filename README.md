# 🧑‍💻 API de Gerenciamento de Pessoas – Treinamento com Henrique Giaretta

Este projeto foi desenvolvido como parte de um **treinamento prático** ministrado pelo [Henrique Giaretta](https://www.youtube.com/@giarettaio) no YouTube. O foco foi ensinar a criação de **APIs RESTful** com C# e .NET de forma simples, direta e com boas práticas de estruturação de código.

---

## 📦 Tecnologias Utilizadas

- **.NET 8 / .NET 9**
- **C#**
- **ASP.NET Core Minimal API**
- **Entity Framework Core**
- **SQLite**
- **Swagger** (recomendado para testes)

---

## 📂 Estrutura do Projeto

Pessoa/  
├── Data/  
│   └── PessoaContext.cs  # Configuração do banco de dados  
├── Models/  
│   └── PessoaModel.cs    # Modelo de dados da pessoa  
├── Rotas/  
│   └── PessoaRota.cs     # Definições de rotas da API  
├── Program.cs            # Ponto de entrada da aplicação  
└── pessoa.sqlite         # Banco de dados SQLite (gerado após execução)


## 🧠 Conceitos Aprendidos

- Criação de APIs REST com Minimal API  
- Organização por responsabilidade (Models, Data, Rotas)  
- Uso do DbContext e mapeamento com EF Core  
- Roteamento com MapGroup para melhor organização  
- Manipulação de GUIDs como identificadores  
- Práticas de atualização e "remoção lógica" (soft delete)  
- Separação entre requisição (PessoaRequest) e modelo de entidade (PessoaModel)  

---

## 👨‍🏫 Créditos

Este projeto foi inspirado e desenvolvido com base no conteúdo do canal:

🔗 [Henrique Giaretta no YouTube](https://www.youtube.com/@giarettaio)

