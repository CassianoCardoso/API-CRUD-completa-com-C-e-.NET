namespace Pessoa.Models;

public class PessoaModel
{
    public PessoaModel(string nome)
    {
        Nome = nome;
        Id   = Guid.NewGuid();
    }
    
    public Guid Id { get; init; }
    public string Nome { get; private  set; }

    public void ChaangeName(string nome)
    {
        Nome = nome;
    }

    public void SetInativo()
    {
        Nome= "Desativado";
    }

}