using Trivia;
using Xunit;

namespace Tests;

public class UserTests
{
    [Fact]
    public void AddPlayer()
    {
        var game = new Game();

        game.Add("Chet");
        game.Add("Pat");

        Assert.Equal(1, game.HowManyPlayers());
    }
}