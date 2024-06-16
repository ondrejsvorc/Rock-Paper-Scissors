module RockPaperScissors.Tests.ParsePlayerInputTests

open NUnit.Framework
open Program

[<TestFixture>]
type ParsePlayerInputRockTests() =

    [<Test>]
    member _.``Parsing '1' should return Rock``() =
        Assert.AreEqual(Choice Rock, parsePlayerInput "1")

    [<Test>]
    member _.``Parsing 'rock' should return Rock``() =
        Assert.AreEqual(Choice Rock, parsePlayerInput "rock")

    [<Test>]
    member _.``Parsing 'ROCK' should return Rock``() =
        Assert.AreEqual(Choice Rock, parsePlayerInput "ROCK")

    [<Test>]
    member _.``Parsing 'Rock' should return Rock``() =
        Assert.AreEqual(Choice Rock, parsePlayerInput "Rock")

    [<Test>]
    member _.``Parsing 'RoCk' should return Rock``() =
        Assert.AreEqual(Choice Rock, parsePlayerInput "RoCk")


[<TestFixture>]
type ParsePlayerInputPaperTests() =

    [<Test>]
    member _.``Parsing '2' should return Paper``() =
        Assert.AreEqual(Choice Paper, parsePlayerInput "2")

    [<Test>]
    member _.``Parsing 'paper' should return Paper``() =
        Assert.AreEqual(Choice Paper, parsePlayerInput "paper")

    [<Test>]
    member _.``Parsing 'PAPER' should return Paper``() =
        Assert.AreEqual(Choice Paper, parsePlayerInput "PAPER")

    [<Test>]
    member _.``Parsing 'Paper' should return Paper``() =
        Assert.AreEqual(Choice Paper, parsePlayerInput "Paper")

    [<Test>]
    member _.``Parsing 'PaPeR' should return Paper``() =
        Assert.AreEqual(Choice Paper, parsePlayerInput "PaPeR")


[<TestFixture>]
type ParsePlayerInputScissorsTests() =

    [<Test>]
    member _.``Parsing '3' should return Scissors``() =
        Assert.AreEqual(Choice Scissors, parsePlayerInput "3")

    [<Test>]
    member _.``Parsing 'scissors' should return Scissors``() =
        Assert.AreEqual(Choice Scissors, parsePlayerInput "scissors")

    [<Test>]
    member _.``Parsing 'SCISSORS' should return Scissors``() =
        Assert.AreEqual(Choice Scissors, parsePlayerInput "SCISSORS")

    [<Test>]
    member _.``Parsing 'Scissors' should return Scissors``() =
        Assert.AreEqual(Choice Scissors, parsePlayerInput "Scissors")

    [<Test>]
    member _.``Parsing 'ScIsSoRs' should return Scissors``() =
        Assert.AreEqual(Choice Scissors, parsePlayerInput "ScIsSoRs")


[<TestFixture>]
type ParsePlayerInputQuitTests() =

    [<Test>]
    member _.``Parsing 'q' should return Quit``() =
        Assert.AreEqual(Quit, parsePlayerInput "q")

    [<Test>]
    member _.``Parsing 'quit' should return Quit``() =
        Assert.AreEqual(Quit, parsePlayerInput "quit")

    [<Test>]
    member _.``Parsing 'QUIT' should return Quit``() =
        Assert.AreEqual(Quit, parsePlayerInput "QUIT")

    [<Test>]
    member _.``Parsing 'Quit' should return Quit``() =
        Assert.AreEqual(Quit, parsePlayerInput "Quit")

    [<Test>]
    member _.``Parsing 'QuIt' should return Quit``() =
        Assert.AreEqual(Quit, parsePlayerInput "QuIt")


[<TestFixture>]
type ParsePlayerInputInvalidTests() =

    [<Test>]
    member _.``Parsing 'some invalid input' should return Invalid``() =
        Assert.AreEqual(Invalid, parsePlayerInput "some invalid input")

    [<Test>]
    member _.``Parsing empty input should return Invalid``() =
        Assert.AreEqual(Invalid, parsePlayerInput "")

    [<Test>]
    member _.``Parsing whitespace input should return Invalid``() =
        Assert.AreEqual(Invalid, parsePlayerInput "    ")

    [<Test>]
    member _.``Parsing numeric invalid input should return Invalid``() =
        Assert.AreEqual(Invalid, parsePlayerInput "4")

    [<Test>]
    member _.``Parsing rock typo invalid input should return Invalid``() =
        Assert.AreEqual(Invalid, parsePlayerInput "roc2k")