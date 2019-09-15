namespace HelloFSharp.Tutorial7

module ListMatching =
    let listMatcher aList =
        match aList with
        | [] -> printfn "this list is empty"
        | [firstElement] -> printfn "this list has one element %A" firstElement
        | [firstElement; secondElement] -> printfn "this list has two elements %A %A"
                                               firstElement secondElement
        | _ -> printfn "This list has multiple elements %A" aList