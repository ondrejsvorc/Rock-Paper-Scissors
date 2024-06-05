# Rock Paper Scissors

The `Rock Paper Scissors` game is created with `functional programming` in mind using `F#`.

## Learning Resources

### [Discriminated Unions](https://learn.microsoft.com/en-us/dotnet/fsharp/language-reference/discriminated-unions) 
```fsharp
type Move =
    | Rock 
    | Paper 
    | Scissors
```

### [Pattern Matching](https://learn.microsoft.com/en-us/dotnet/fsharp/language-reference/pattern-matching)
```fsharp
let getComputerMove () =
    match Random().Next(3) with
    | 0 -> Rock
    | 1 -> Paper
    | _ -> Scissors
```

### [Function Parameters](https://learn.microsoft.com/en-us/dotnet/fsharp/language-reference/functions/)
```fsharp
let determineWinner (playerMove: Move) (computerMove: Move) =
    match playerMove, computerMove with
    | Rock, Scissors | Paper, Rock | Scissors, Paper -> Winner.Human
    | Scissors, Rock | Rock, Paper | Paper, Scissors -> Winner.Computer
    | _ -> Winner.Nobody
```

### [Keyword 'rec'](https://learn.microsoft.com/en-us/dotnet/fsharp/language-reference/functions/recursive-functions-the-rec-keyword)
```fsharp
let rec gameLoop () =
    printfn "%s" "Choose your move: (1) Rock, (2) Paper, (3) Scissors, or (q) to quit:"
    match Console.ReadLine() |> parseInput with
    | Choose playerMove -> playRound playerMove |> printRoundResult
    | Quit -> printfn "%s" "Thanks for playing! Goodbye!"; exit 0
    | Invalid -> printfn "%s" "Invalid input. Please try again."
    gameLoop ()
```

### [Entry Point](https://learn.microsoft.com/en-us/dotnet/fsharp/language-reference/functions/entry-point#explicit-entry-point)
```fsharp
[<EntryPoint>]
let main argv =
    gameLoop ()
    0
```

### You can see the whole code [here](https://github.com/ondrejsvorc/Rock-Paper-Scissors/blob/main/RockPaperScissors/Program.fs).