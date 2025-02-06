// See https://aka.ms/new-console-template for more information
public interface ITeam 
{
    int ScoreCount { get; set; }
    //string? Goalkeeper { get; set; }
}
//we need to create a new intarface for the goalkeeper
public interface IGoalkeeper 
{
    string? Goalkeeper { get; set; }

}
// class that inherits an interface should include all of its members
public class FootballTeam : ITeam, IGoalkeeper
{
    public string? Name { get; set; }
    public int ScoreCount { get; set; }
    public string? Goalkeeper { get; set; }
}

//basketball dont have goalkeeper
public class BasketballTeam : ITeam
{
    public string? Name { get; set; }
    public int ScoreCount { get; set; }
    //public string? Goalkeeper { get; set; }

}