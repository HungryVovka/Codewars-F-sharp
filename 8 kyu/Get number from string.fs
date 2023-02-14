// -----------------------------------------------------------
// Write a function which removes from string all non-digit characters and parse the remaining to number. E.g: "hell5o wor6ld" -> 56
// 
// Function:
// 
// getNumberFromString(s)
// -----------------------------------------------------------

let getNumberFromString s =
    s 
    |> String.filter (fun num -> num >= '0' && num <= '9')
    |> int;;