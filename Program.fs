namespace HelloFSharp.Program

open HelloFSharp.Tutorial1

module Main =
    [<EntryPoint>]
    let mainTutorial1 _ =
        let evens = Basics.evens [1..100]
        printfn "%A" evens
        printfn "%A" Basics.sumOfSquaresTo100
        printfn "%A" DataTypes.worker
        0 // return an integer exit code
