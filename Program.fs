namespace HelloFSharp.Program

open HelloFSharp.Tutorial1
open HelloFSharp.Tutorial2

module Main =
    let mainTutorial1 _ =
        let evens = Basics.evens [1..100]
        printfn "%A" evens
        printfn "%A" Basics.sumOfSquaresTo100
        printfn "%A" DataTypes.worker
        0 // return an integer exit code
        
    [<EntryPoint>]
    let mainTutorial2 _ =
        let sortedNums = Quicksort.quicksort [43;54;21;65;32;65;21;9999;-9999]
        printfn "%A" sortedNums
        0
