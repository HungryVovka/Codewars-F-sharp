// -----------------------------------------------------------
// Task
// Sum all the numbers of a given array ( cq. list ), except the highest and the lowest element ( by value, not by index! ).
// 
// The highest or lowest element respectively is a single element at each edge, even if there are more than one with the same value.
// 
// Mind the input validation.
// 
// Example
// { 6, 2, 1, 8, 10 } => 16
// { 1, 1, 11, 2, 3 } => 6
// 
// Input validation
// If an empty value ( null, None, Nothing etc. ) is given instead of an array, or the given array is an empty list or a list with only 1 element, return 
// 0.
// -----------------------------------------------------------

let sumArray (array: int list Option) =
    match array with
    | None | Some [_] | Some [] -> 0
    | Some arr -> List.sum arr - List.max arr - List.min arr;;

// or

let sumArray (array: int list Option) =
    match array with
    | Some(a::b::n) -> (a::b::n 
                        |> List.sort 
                        |> List.skip 1 
                        |> List.rev 
                        |> List.skip 1 
                        |> List.sum)
    | _ -> 0;;