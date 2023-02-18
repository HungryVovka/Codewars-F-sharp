// -----------------------------------------------------------
// Given a string of digits, you should replace any digit below 5 with '0' and any digit 5 and above with '1'. Return the resulting string.
// 
// Note: input will never be an empty string
// -----------------------------------------------------------

let fakeBin x =
    String.map(fun binstr ->
        match binstr with
        |'0'|'1'|'2'|'3'|'4' -> '0'
        | _ -> '1') x;;

// or

let fakeBin x =
    String.map (fun binstr -> if binstr < '5' then '0' else '1') x;;

// or

let fakeBin =
    (fun binstr -> if binstr < '5' then "0" else "1")
    |> String.collect;;