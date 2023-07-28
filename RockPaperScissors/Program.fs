open System

// Defines the possible game moves.
type Move = Rock | Paper | Scissors

// Generates a random move for the computer.
let getRandomMove () =
    let random = Random()
    match random.Next(3) with
    | 0 -> Rock
    | 1 -> Paper
    | _ -> Scissors

// Determines the winner of the game.
let determineWinner (playerMove: Move) (computerMove: Move) =
    match playerMove, computerMove with
    | Rock, Scissors | Paper, Rock | Scissors, Paper -> "Player wins!"
    | Rock, Rock | Paper, Paper | Scissors, Scissors -> "It's a tie!"
    | _ -> "Computer wins!"

// Main game loop.
let rec gameLoop () =
    printfn "Choose your move: (1) Rock, (2) Paper, (3) Scissors, or (q) to quit."
    let playerInput = Console.ReadLine().Trim().ToLower()
    match playerInput with
    | "1" | "rock" -> play Rock
    | "2" | "paper" -> play Paper
    | "3" | "scissors" -> play Scissors
    | "q" | "quit" -> printfn "Thanks for playing! Goodbye!"
    | _ -> printfn "Invalid input. Please try again."; gameLoop ()

// Play one round of the game.
and play (playerMove: Move) =
    let computerMove = getRandomMove()
    printfn "Player chose: %A" playerMove
    printfn "Computer chose: %A" computerMove
    printfn "%s" (determineWinner playerMove computerMove)
    printfn ""
    gameLoop ()

// Starts the main game loop.
[<EntryPoint>]
let main argv =
    printfn "Welcome to Rock Paper Scissors!"
    gameLoop ()
    0