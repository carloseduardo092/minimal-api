using MinimalApi.Dominio.Enuns;
namespace MinimalApi.Dominio.ModelViews;

public record AdministradorModelView

{
    public int Id { get; set; } = default!;
    public string Email { get; set; } = default!;
    /*
    Mostra informações de senha no JSON.
     public string Senha { get; set; } = default!;*/
    public string Perfil { get; set; } = default!;

}