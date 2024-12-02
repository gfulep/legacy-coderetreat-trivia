using System;
using System.IO;
using ApprovalTests;
using ApprovalTests.Reporters;
using Trivia;
using Xunit;

namespace Tests;

[UseReporter(typeof(RiderReporter), typeof(VisualStudioReporter))]
public class GameLogicTest
{
    private static bool _notAWinner;
    
    [Fact]
    public void TestLogic()
    {

        var output = new StringWriter();
        Console.SetOut(output);
        
        var aGame = new Game();

        aGame.Add("Chet");
        aGame.Add("Pat");
        aGame.Add("Sue");

        var rand = new Random(10);

        do
        {
            aGame.Roll(rand.Next(5) + 1);

            if (rand.Next(9) == 7)
            {
                _notAWinner = aGame.WrongAnswer();
            }
            else
            {
                _notAWinner = aGame.WasCorrectlyAnswered();
            }
        } while (_notAWinner);

        var ASD = output.ToString();
        Approvals.VerifyAll(ASD, label: "");
    }
}