// -----------------------------------------------------------
// Write a function which converts the input string to uppercase.
// -----------------------------------------------------------

open System

let makeUpperCase (s: string) = String.map Char.ToUpper s;;

// or

let makeUpperCase (s: string) = s.ToUpper();;