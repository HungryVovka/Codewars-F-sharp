// -----------------------------------------------------------
// Complete the function which converts hex number (given as a string) to a decimal number.
// -----------------------------------------------------------

let hexToDec s = float <| System.Convert.ToInt32(s, 16);;