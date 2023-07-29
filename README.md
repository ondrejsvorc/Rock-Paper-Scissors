# Rock Paper Scissors

The `Rock Paper Scissors` game is created with `functional programming` in mind using `F#`.

## Code Overview

#### [Discriminated Unions](https://learn.microsoft.com/en-us/dotnet/fsharp/language-reference/discriminated-unions) 

```fsharp
// Defines the possible game moves.
type Move =
    | Rock 
    | Paper 
    | Scissors
```

#### [Pattern Matching](https://learn.microsoft.com/en-us/dotnet/fsharp/language-reference/pattern-matching)

```fsharp
// Generates a random move for the computer.
let getRandomMove () =
    let random = Random()
    match random.Next(3) with
    | 0 -> Rock
    | 1 -> Paper
    | _ -> Scissors
```

#### [Function Parameters](https://learn.microsoft.com/en-us/dotnet/fsharp/language-reference/functions/)
```fsharp
// Determines the winner of the game.
let determineWinner (playerMove: Move) (computerMove: Move) =
    match playerMove, computerMove with
    | Rock, Scissors | Paper, Rock | Scissors, Paper -> "Player wins!"
    | Rock, Rock | Paper, Paper | Scissors, Scissors -> "It's a tie!"
    | _ -> "Computer wins!"
```

#### [Keyword 'rec'](https://learn.microsoft.com/en-us/dotnet/fsharp/language-reference/functions/recursive-functions-the-rec-keyword)
```fsharp
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
```

#### [Keyword 'and'](https://learn.microsoft.com/en-us/dotnet/fsharp/language-reference/keyword-reference)
```fsharp
// Play one round of the game.
and play (playerMove: Move) =
    let computerMove = getRandomMove()
    printfn "Player chose: %A" playerMove
    printfn "Computer chose: %A" computerMove
    printfn "%s" (determineWinner playerMove computerMove)
    printfn ""
    gameLoop ()
```

#### [Entry Point](https://learn.microsoft.com/en-us/dotnet/fsharp/language-reference/functions/entry-point#explicit-entry-point)
```fsharp
// Starts the main game loop.
[<EntryPoint>]
let main argv =
    printfn "Welcome to Rock Paper Scissors!"
    gameLoop ()
    0
```

You can see the code [here](https://github.com/ondrejsvorc/Rock-Paper-Scissors/blob/main/RockPaperScissors/Program.fs).
