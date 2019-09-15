namespace HelloFSharp.Tutorial4

type Shape =
    | Circle of radius:int
    | Rectangle of height:int * width:int
    | Point of x:int * y:int
    | Polygon of pointList:(int * int) list

module Renderer =
    let draw shape =
        match shape with
        | Circle radius ->
            printfn "The circle has a radius of %d" radius
        | Rectangle (height,width) ->
            printfn "The rectangle has a height of % d and a width of %d" height width
        | Polygon points ->
            printfn "The polygon is made of these points %A" points
        | Point (x, y) ->
            printfn "The point has coordinates x: %d and y: %d" x y