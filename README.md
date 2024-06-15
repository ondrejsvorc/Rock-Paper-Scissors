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
let getComputerMove =
    let rnd = Random()
    fun () ->
        match rnd.Next(3) with
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

### [Entry Point](https://learn.microsoft.com/en-us/dotnet/fsharp/language-reference/functions/entry-point#explicit-entry-point)
```fsharp
[<EntryPoint>]
let main argv =
    printMoveOptions ()
    gameLoop ()
    0
```

### You can see the whole code [here](https://github.com/ondrejsvorc/Rock-Paper-Scissors/blob/main/RockPaperScissors/Program.fs).