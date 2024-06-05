open System

type Move =
    | Rock 
    | Paper 
    | Scissors

type Winner =
    | Human
    | Computer
    | Nobody

type UserInput =
    | Choose of Move
    | Quit
    | Invalid

type RoundResult = {
    PlayerMove: Move
    ComputerMove: Move
    Winner: Winner
}

let getComputerMove () =
    match Random().Next(3) with
    | 0 -> Rock
    | 1 -> Paper
    | _ -> Scissors

let determineWinner (playerMove: Move) (computerMove: Move) =
    match playerMove, computerMove with
    | Rock, Scissors | Paper, Rock | Scissors, Paper -> Human
    | Scissors, Rock | Rock, Paper | Paper, Scissors -> Computer
    | _ -> Nobody

let playRound (playerMove: Move) =
    let computerMove = getComputerMove ()
    let winner = determineWinner playerMove computerMove
    { PlayerMove = playerMove; ComputerMove = computerMove; Winner = winner }

let parseInput (playerInput: string) =
    match playerInput.Trim().ToLower() with
    | "1" | "rock" -> Choose Rock
    | "2" | "paper" -> Choose Paper
    | "3" | "scissors" -> Choose Scissors
    | "q" | "quit" -> Quit
    | _ -> Invalid

let printRoundResult (result: RoundResult) =
    match result.Winner with
    | Winner.Human -> printfn "%s" $"You win! Computer chose {result.ComputerMove}."
    | Computer -> printfn "%s" $"Computer wins! Computer chose {result.ComputerMove}"
    | Nobody -> printfn "%s" "It's a tie!"

let rec gameLoop () =
    printfn "%s" "Choose your move: (1) Rock, (2) Paper, (3) Scissors, or (q) to quit:"
    match Console.ReadLine() |> parseInput with
    | Choose playerMove -> playRound playerMove |> printRoundResult
    | Quit -> printfn "%s" "Thanks for playing! Goodbye!"; exit 0
    | Invalid -> printfn "%s" "Invalid input. Please try again."
    gameLoop ()

[<EntryPoint>]
let main argv =
    gameLoop ()
    0