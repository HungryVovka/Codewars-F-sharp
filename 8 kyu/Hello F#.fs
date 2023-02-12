// -----------------------------------------------------------
// Your task is to write function hello that will take an option type of string.
// 
// Function should return "Hello World" if None is passed otherwise it should return "Hello, " + given string.
// -----------------------------------------------------------

let hello inputName = 
    match inputName with
    | None -> "Hello World"
    | Some inputName -> "Hello, " + inputName;;