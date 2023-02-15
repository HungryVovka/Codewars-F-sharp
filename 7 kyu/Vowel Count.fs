// -----------------------------------------------------------
// Return the number (count) of vowels in the given string.
// 
// We will consider a, e, i, o, u as vowels for this Kata (but not y).
// 
// The input string will only consist of lower case letters and/or spaces.
// -----------------------------------------------------------

module VowelCount.Solution

let answer char =
    match char with
    |'a'|'e'|'i'|'o'|'u'|'A'|'E'|'I'|'O'|'U' -> 1
    | _ -> 0

let vowelCount (s: string): int =
    s |> Seq.sumBy answer;;