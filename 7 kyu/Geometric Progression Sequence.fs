// -----------------------------------------------------------
// In your class, you have started lessons about geometric progression. Since you are also a programmer, you have decided to write a function that will 
// print first n elements of the sequence with the given constant r and first element a.
// 
// Result should be separated by comma and space.
// 
// Example
// geometric_sequence_elements(2, 3, 5) == '2, 6, 18, 54, 162'
// 
// More info: https://en.wikipedia.org/wiki/Geometric_progression
// -----------------------------------------------------------

let geometricSequenceElements (a: int)(r: int)(n: int) =
    Seq.unfold (fun x -> Some(x, r * x)) a
    |> Seq.take n
    |> Seq.map string
    |> String.concat ", ";;

// or

let geometricSequenceElements (a: int)(r: int)(n: int) =
    [2..n]
    |> List.scan (fun x _ -> r * x) a
    |> List.map string
    |> String.concat ", ";;