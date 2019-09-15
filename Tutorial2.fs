namespace HelloFSharp.Tutorial2

module Quicksort =
    let rec quicksort list =
        match list with
        | [] -> []
        | firstElement::otherElements ->
            let smallerElements =
                otherElements
                |> List.filter (fun element -> element < firstElement)
                |> quicksort
            let largerElements =
                otherElements
                |> List.filter (fun element -> element >= firstElement)
                |> quicksort
            
            List.concat [smallerElements; [firstElement]; largerElements]