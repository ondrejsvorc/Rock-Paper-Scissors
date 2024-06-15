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
    | Choice of Move
    | Quit
    | Invalid

type RoundResult = {
    PlayerMove : Move
    ComputerMove : Move
    Winner : Winner
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

let printRoundResult (result: RoundResult) =
    match result.Winner with
    | Human -> $"You win! Computer chose {result.ComputerMove}."
    | Computer -> $"Computer wins! Computer chose {result.ComputerMove}"
    | Nobody -> "It's a tie!"
    |> printfn "%s"

let printMoveOptions () =
    printfn "%s" "Choose your move: (1) Rock, (2) Paper, (3) Scissors, or (q) to quit:"

let parsePlayerInput (playerInput: string) =
    match playerInput.Trim().ToLower() with
    | "1" | "rock" -> Choice Rock
    | "2" | "paper" -> Choice Paper
    | "3" | "scissors" -> Choice Scissors
    | "q" | "quit" -> Quit
    | _ -> Invalid

let handlePlayerInput (playerInput: string) =
    match parsePlayerInput playerInput with
    | Choice playerMove -> playRound playerMove |> printRoundResult
    | Quit -> printfn "%s" "Thanks for playing! Goodbye!"; exit 0
    | Invalid -> printfn "%s" "Invalid input. Please try again."

let rec gameLoop () =
    printMoveOptions ()
    Console.ReadLine() |> handlePlayerInput
    gameLoop ()

[<EntryPoint>]
let main argv =
    gameLoop ()
    0