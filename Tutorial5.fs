namespace HelloFSharp.Tutorial5

module Max =
    let findMax list =
        let findMaxOnNonEmpty initialValue rest =
            let action maxSoFar x = if x > maxSoFar then x else maxSoFar
            rest |> List.fold action initialValue
        match list with
        | [] -> None
        | initialValue::rest ->
            let max = rest |> findMaxOnNonEmpty initialValue
            Some max