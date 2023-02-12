// -----------------------------------------------------------
// Given a non-empty array of integers, return the result of multiplying the values together in order. Example:
// 
// [1, 2, 3, 4] => 1 * 2 * 3 * 4 = 24
// -----------------------------------------------------------

let Grow (x : int[]) = Array.reduce (*) x;;

// or

let Grow = Array.reduce (*);;