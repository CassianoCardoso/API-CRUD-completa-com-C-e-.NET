using Microsoft.EntityFrameworkCore;
using Pessoa.Data;
using Pessoa.Models;

namespace Pessoa.Rotas;

public static class PessoaRota
{
    public static void PessoaRotas(this WebApplication app)
    {
        var rota = app.MapGroup("pessoa");
        rota.MapPost("", async (PessoaRequest req, PessoaContext context) =>
        {
            var pessoa = new PessoaModel(req.Nome);
            await context.AddAsync(pessoa);
            await context.SaveChangesAsync();
        });

        rota.MapGet("", async (PessoaContext context) =>
        {
            var pessoa = await context.Pessoa.ToListAsync();
            return Results.Ok(pessoa);
        });

        rota.MapPut("{id.guid}",
            async (Guid id,
                PessoaRequest req,
                PessoaContext context) =>
            {
                var pessoa = await context.Pessoa.FindAsync(id);

                if (pessoa == null)
                    return Results.NotFound();

                pessoa.ChaangeName(req.Nome);
                await context.SaveChangesAsync();
                return Results.Ok(pessoa);

            });

        rota.MapDelete("{id.guid}", async (Guid id, PessoaContext context) =>
        {
            var pessoa = await context.Pessoa.FindAsync(id);
            
            if (pessoa == null)
                return Results.NotFound();
            
            pessoa.SetInativo();
            await context.SaveChangesAsync();
            return Results.Ok(pessoa);
            
        });
    }
}