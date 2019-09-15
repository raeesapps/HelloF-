namespace HelloFSharp.Tutorial1

module Basics =
    let myInt = 5
    let myFloat = 3.14
    let myString = "hello"
    let square x = x * x
    let add x y = x + y
    let evens list =
        let isEven number = number % 2 = 0
        List.filter isEven list
    let evensPiped list =
        let filterEven = (fun x -> x % 2 = 0) |> List.filter
        list |> filterEven
    let sumOfSquaresTo100 = [1..100] |> List.map square |> List.sum
    let simplePatternMatch =
        let x = "a"
        match x with
        | "a" -> printfn "x is a"
        | "b" -> printfn "x is b"
        | _ -> printfn "x is something else"
    let optionPatternMatch input =
        match input with
        | Some i -> printfn "input is an int=%d" i
        | None -> printfn "input is missing"

module DataTypes =
    type Person = {First:string; Last:string}
    let person1 = {First="John"; Last="Doe"}
    
    type Temp =
        | DegreesC of float
        | DegreesF of float
    let temp = DegreesF 98.6
    
    type Employee =
        | Worker of Person
        | Manager of Employee list
    let jdoe = {First="John"; Last="Doe"}
    let worker = Worker jdoe