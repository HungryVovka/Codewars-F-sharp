// -----------------------------------------------------------
// Write a function which calculates the average of the numbers in a given list.
// 
// Note: Empty arrays should return 0.
// -----------------------------------------------------------

let avg =
    function
    | [] -> 0.0
    | x -> List.average x;;

// or

let avg x = (List.sum x) / (List.length x |> float);;