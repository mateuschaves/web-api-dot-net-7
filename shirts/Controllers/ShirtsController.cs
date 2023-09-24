using Microsoft.AspNetCore.Mvc;

namespace shirts.Controllers;
[ApiController]
public class ShirtsController: ControllerBase
{
    public string GetShirts()
    {
        return "Reading all shirts";
    }

    public string GetShirtById(int id)
    {
        return $"Reading shirt {id}";
    }

    public string CreateShirt()
    {
        return $"Creating a shirt";
    }

    public string UpdateShirt()
    {
        return $"Update shirt";
    }

    public string DeleteShirt(int id)
    {
        return $"Deleting shirt {id}";
    }
}