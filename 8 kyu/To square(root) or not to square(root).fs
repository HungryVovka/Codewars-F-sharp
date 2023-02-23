// -----------------------------------------------------------
// Write a method, that will get an integer array as parameter and will process every number from this array.
// 
// Return a new array with processing every number of the input-array like this:
// 
// If the number has an integer square root, take this, otherwise square the number.
// 
// Example
// [4,3,9,7,2,1] -> [2,9,3,49,4,1]
// 
// Notes
// The input array will always contain only positive numbers, and will never be empty or null.
// -----------------------------------------------------------

let squareOrSquareRoot (array: int[]) =
    let squareCheck number =
        match (sqrt(float number)) % 1.0 = 0.0 with
        | true -> number |> float |> sqrt |> int
        | _    -> number * number
    array |> Array.map squareCheck;;

// or

let squareOrSquareRoot =
    Array.map (fun num ->
        let sqrtNum = (num |> float
                           |> sqrt
                           |> int)
        if sqrtNum * sqrtNum = num then sqrtNum
        else num * num);;