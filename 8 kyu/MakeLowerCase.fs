// -----------------------------------------------------------
// Write function makeLowerCase.
// -----------------------------------------------------------

open System

let makeLowerCase (s: string) = String.map Char.ToLower s;;

// or

let makeLowerCase (s: string) = s.ToLower();;