using System.IO;
using System;
using Trivia;
using Xunit;

namespace Tests;

public class UserTests
{
    [Fact]
    public void If_CorrectlyAnsweredQuestion_Should_WriteOutMessageCorrectly()
    {
        var game = new Game();
        game.Add("Chet");
        var output = new StringWriter();
        Console.SetOut(output);
        
        game.WasCorrectlyAnswered();

        Assert.Contains("Answer was correct!", output.ToString());
    }

    [Fact]
    public void If_TenPlayerAdded_Should_WriteOutMessageCorrectly()
    {
        var output = new StringWriter();
        Console.SetOut(output);
        
        var game = new Game();
        for (int i = 0; i <= 10; i++)
        {
            game.Add("Chet" + i);
        }
        
        var lines = output.ToString().Split(Environment.NewLine);

        Assert.Contains("They are player number 10", lines[^1]);
    }
}