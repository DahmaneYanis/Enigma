namespace Model;
class RequestSuperheroAPI {
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
}