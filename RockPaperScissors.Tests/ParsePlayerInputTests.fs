module RockPaperScissors.Tests.ParsePlayerInputTests

open NUnit.Framework
open Program

[<TestFixture>]
type ParsePlayerInputTests() =

    [<Test>]
    member _.``Parsing '1' should return Rock``() =
        Assert.AreEqual(Choice Rock, parsePlayerInput "1")

    [<Test>]
    member _.``Parsing 'rock' should return Rock``() =
        Assert.AreEqual(Choice Rock, parsePlayerInput "rock")

    [<Test>]
    member _.``Parsing '2' should return Paper``() =
        Assert.AreEqual(Choice Paper, parsePlayerInput "2")

    [<Test>]
    member _.``Parsing 'paper' should return Paper``() =
        Assert.AreEqual(Choice Paper, parsePlayerInput "paper")

    [<Test>]
    member _.``Parsing '3' should return Scissors``() =
        Assert.AreEqual(Choice Scissors, parsePlayerInput "3")

    [<Test>]
    member _.``Parsing 'scissors' should return Scissors``() =
        Assert.AreEqual(Choice Scissors, parsePlayerInput "scissors")

    [<Test>]
    member _.``Parsing 'q' should return Quit``() =
        Assert.AreEqual(Quit, parsePlayerInput "q")

    [<Test>]
    member _.``Parsing 'quit' should return Quit``() =
        Assert.AreEqual(Quit, parsePlayerInput "quit")

    [<Test>]
    member _.``Parsing invalid input should return Invalid``() =
        Assert.AreEqual(Invalid, parsePlayerInput "some invalid input")