namespace Players;

public class Hero
{
   public string UserName { get; set; }
   public int Level {  get; set; }

    public Hero(string name,int level)
    {
        UserName = name;
        Level = level;
    }
    public override string ToString()
    {
        return $"Type: {this.GetType().Name} Usernane: {this.UserName} Level: {this.Level}";
    }
}
