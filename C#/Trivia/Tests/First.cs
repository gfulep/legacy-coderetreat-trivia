using System;
using ApprovalTests;
using ApprovalTests.Reporters;
using Xunit;

[UseReporter(typeof(RiderReporter), typeof(VisualStudioReporter))]
public class SampleTest
{
    [Fact]
    public void TestList()
    {
        var names = new[] {"Llewellyn", "James", "Dan", "Jason", "Katrina"};
        Array.Sort(names);
        Approvals.VerifyAll(names, label: "");
    }
}