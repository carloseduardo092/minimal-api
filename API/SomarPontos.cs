

using System.Text.Json;

public class SistemaPontos
{
    private readonly string arquivo = "dados.json";
    private Dictionary<string, int> pontosUsuarios = new();

    public SistemaPontos()
    {
        Carregar();
    }

    private void Carregar()
    {
        if (File.Exists(arquivo))
        {
            var json = File.ReadAllText(arquivo);
            pontosUsuarios = JsonSerializer.Deserialize<Dictionary<string, int>>(json) ?? new Dictionary<string, int>();
        }
    }

    private void Salvar()
    {
        var Json = JsonSerializer.Serialize(pontosUsuarios, new JsonSerializerOptions { WriteIndented = true });
        File.WriteAllText(arquivo, Json);
    }

    //Adiona pontos a um usuário (cria se não existir)
    public void AdicionarPontos(string nome, int pontos)
    {
        if (pontos < 0) return;

        if (pontosUsuarios.ContainsKey(nome))
            pontosUsuarios[nome] += pontos;

        else
            pontosUsuarios[nome] = pontos;

        Salvar();
    }

    // Retorna todos os usuários com seus pontos
    public Dictionary<string, int> ListarPontos()
    {
        return pontosUsuarios;
    }
}
