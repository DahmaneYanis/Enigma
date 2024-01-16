using Model;
using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Server.ProtectedBrowserStorage;
using Microsoft.JSInterop;

namespace Controllers;

public class ListCarteController : Controller {

    [Parameter]
    public string? mode { get; set; } = "open";
    public int MinId {get; set;} = 1;
    public int MaxId {get; set;} = 10;
    public List<SuperHero> Superheros {get; set;}

    public ListCarteController() {
        Superheros = new List<SuperHero>();
        SuperheroAPI = new RequestSuperheroAPI(new HttpClient());
    }

    protected override async Task OnInitializedAsync() {
        Superheros = await SuperheroAPI.GetListSuperheroById(MinId, MaxId);
    }

    public void Add(SuperHero hero) {
        ProtectedBrowserStorage.Set
    }

    public void Open(SuperHero hero) {
        
    }
}