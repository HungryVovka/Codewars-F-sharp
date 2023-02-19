// -----------------------------------------------------------
// Write function parseFloat which takes an input and returns a number or Nothing if conversion is not possible.
// -----------------------------------------------------------

let parseFloat str =
    try
        Some (float str)
    with | :? System.FormatException ->
        None