using System.Net.Http.Json;

internal class Program
{
    private static readonly string uri = "https://localhost:7156/api/user/registration";
    static async Task Main(string[] args)
    {
        HttpClient client = new HttpClient();
        var user = new
        {
            Username = "Arlikey",
            Password = "1234",
            Email = "arlikey@gmail.com"
        };

        using(var response = await client.PostAsJsonAsync(uri, user))
        {
            if(response.IsSuccessStatusCode)
            {
                User responseUser = await response.Content.ReadFromJsonAsync<User>();
                Console.WriteLine(responseUser.Username);
            }
            else
            {
                Error error = await response.Content.ReadFromJsonAsync<Error>();
                Console.WriteLine(error);
            }
        }
        
        Console.ReadLine(); 
    }
}

class Error
{
    public string message { get; set; }
    public override string ToString()
    {
        return message;
    }
}

class User
{
    public string Username { get; set; }
    public string Password { get; set; }
    public string Email { get; set; }
}