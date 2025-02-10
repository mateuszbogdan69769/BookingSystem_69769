namespace BookingSystem_69769;

public class GlobalStore
{
    public string Username { get; protected set; } = String.Empty;

    private static GlobalStore _instance;

    private GlobalStore() { }

    public static GlobalStore GetInstance()
    {
        if (_instance == null)
        {
            _instance = new GlobalStore();
        }
        return _instance;
    }

    public void SetUsername(string username)
    { 
        Username = username; 
    }
}
