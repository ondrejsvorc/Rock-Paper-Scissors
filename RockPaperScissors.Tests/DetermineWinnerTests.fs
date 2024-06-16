module RockPaperScissors.Tests.DetermineWinnerTests

open NUnit.Framework
open Program

[<TestFixture>]
type DetermineWinnerHumanWinsTests() =

    [<Test>]
    member _.``Human wins when using Rock against Scissors``() =
        Assert.AreEqual(Human, determineWinner Rock Scissors)

    [<Test>]
    member _.``Human wins when using Paper against Rock``() =
        Assert.AreEqual(Human, determineWinner Paper Rock)

    [<Test>]
    member _.``Human wins when using Scissors against Paper``() =
        Assert.AreEqual(Human, determineWinner Scissors Paper)


[<TestFixture>]
type DetermineWinnerComputerWinsTests() =

    [<Test>]
    member _.``Computer wins when using Scissors against Rock``() =
        Assert.AreEqual(Computer, determineWinner Scissors Rock)

    [<Test>]
    member _.``Computer wins when using Rock against Paper``() =
        Assert.AreEqual(Computer, determineWinner Rock Paper)

    [<Test>]
    member _.``Computer wins when using Paper against Scissors``() =
        Assert.AreEqual(Computer, determineWinner Paper Scissors)


[<TestFixture>]
type DetermineWinnerTieTests() =

    [<Test>]
    member _.``It's a tie when both use Rock``() =
        Assert.AreEqual(Nobody, determineWinner Rock Rock)

    [<Test>]
    member _.``It's a tie when both use Paper``() =
        Assert.AreEqual(Nobody, determineWinner Paper Paper)

    [<Test>]
    member _.``It's a tie when both use Scissors``() =
        Assert.AreEqual(Nobody, determineWinner Scissors Scissors)