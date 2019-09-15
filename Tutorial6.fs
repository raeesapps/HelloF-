namespace HelloFSharp.Tutorial6

module Composition =
    let add2 x = x + 2
    let square x = x * x
    let mult3 x = x * 3
    let logMsgN msg x = printfn "%s%i" msg x;x
    let listOfFunctions = [
        mult3;
        logMsgN "result after mult3=";
        square;
        logMsgN "result after square=";
        add2;
        logMsgN "result after add2=";
    ]
    let applyAll = List.reduce (>>) listOfFunctions