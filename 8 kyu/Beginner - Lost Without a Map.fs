// -----------------------------------------------------------
// Given an array of integers, return a new array with each value doubled.
// 
// For example:
// 
// [1, 2, 3] --> [2, 4, 6]
// -----------------------------------------------------------

let maps (x: int[]) =
    x
    |> Array.map (fun i -> i * 2);;

// or

let maps = Array.map (fun i -> i * 2);;