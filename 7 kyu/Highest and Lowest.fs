// -----------------------------------------------------------
// In this little assignment you are given a string of space separated numbers, and have to return the highest and lowest number.
// 
// Examples
// highAndLow "1 2 3 4 5"  // return "5 1"
// highAndLow "1 2 -3 4 5" // return "5 -3"
// highAndLow "1 9 3 4 -5" // return "9 -5"
// 
// Notes
// All numbers are valid Int32, no need to validate them.
// There will always be at least one number in the input string.
// Output string must be two numbers separated by a single space, and highest number is first.
// -----------------------------------------------------------

module HighestLowest.Solution

let highAndLow (numbers : string): string = 
    let nArr =
        numbers.Split(" ") |> Array.map int
    sprintf "%d %d" (Array.max nArr) (Array.min nArr);;

// or

module HighestLowest.Solution

let highAndLow (numbers : string): string = 
    numbers.Split(" ")
    |> Array.map int
    |> fun highlow ->
        sprintf "%d %d" (Array.max highlow) (Array.min highlow);;

// -----------------------------------------------------------
// License
// Tasks are the property of Codewars (https://www.codewars.com/) 
// and users of this resource.
// 
// All solution code in this repository 
// is the personal property of Vladimir Rukavishnikov
// (vladimirrukavishnikovmail@gmail.com).
// 
// Copyright (C) 2023 Vladimir Rukavishnikov
// 
// This file is part of the HungryVovka/Codewars-F-sharp
// (https://github.com/HungryVovka/Codewars-F-sharp)
// 
// License is GNU General Public License v3.0
// (https://github.com/HungryVovka/Codewars-F-sharp/blob/main/LICENSE)
// 
// You should have received a copy of the GNU General Public License v3.0
// along with this code. If not, see http://www.gnu.org/licenses/
// -----------------------------------------------------------