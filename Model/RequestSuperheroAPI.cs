namespace Model;
public class RequestSuperheroAPI {
    private string BaseApi { get ;}
    HttpClient Http;
    public RequestSuperheroAPI(HttpClient http) {
        BaseApi = "https://superheroapi.com/api/358984949949157/";
        Http = http;
    }

    public async Task<SuperHero?> GetSuperheroById(int id) {
        SuperHero? superHero = await Http.GetFromJsonAsync<SuperHero>(BaseApi + id);
        return superHero;
    }

    public async Task<List<SuperHero>> GetListSuperheroById(int minId, int maxId) {
        List<SuperHero> superheros = new List<SuperHero>();
        int id = minId;

        while (true) {
            try
            {
                if (id > maxId) {
                    break;
                }
                // Effectue la requête GET à l'API
                SuperHero? superhero = await GetSuperheroById(id);
                if (superhero == null) {
                    break;
                } else {
                    superheros.Add(superhero);
                    id++;
                }
            }
            catch (Exception ex)
            {
                // Gère les erreurs ici, par exemple, en affichant un message d'erreur à l'utilisateur
                Console.WriteLine($"Erreur lors de la récupération des tâches : {ex.Message}");
                break;
            }
        }
        return superheros;
    }

}