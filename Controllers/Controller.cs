namespace Controllers;
using Microsoft.AspNetCore.Components;
using Model;
public abstract class Controller : ComponentBase {
        public RequestSuperheroAPI SuperheroAPI {get; protected set;}
}