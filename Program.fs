﻿namespace HelloFSharp.Program

open System.IO

open HelloFSharp.Tutorial1
open HelloFSharp.Tutorial2
open HelloFSharp.Tutorial3

module Main =
    let mainTutorial1 _ =
        let evens = Basics.evens [1..100]
        printfn "%A" evens
        printfn "%A" Basics.sumOfSquaresTo100
        printfn "%A" DataTypes.worker
        0 // return an integer exit code
        
    let mainTutorial2 _ =
        let sortedNums = Quicksort.quicksort [43;54;21;65;32;65;21;9999;-9999]
        printfn "%A" sortedNums
        0
    
    [<EntryPoint>]
    let mainTutorial3 _ =
        let callback (reader:StreamReader) url =
            let html = reader.ReadToEnd()
            let htmlSubstring = html.Substring(0, 1000)
            printfn "Downloaded %s. First 1000 is %s." url htmlSubstring
            html
        let snapshotOfHackernews =
            "https://news.ycombinator.com"
            |> DownloadWebpage.fetchUrl callback
        printfn "%A" snapshotOfHackernews
        0