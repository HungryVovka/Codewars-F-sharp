// -----------------------------------------------------------
// Simple, given a string of words, return the length of the shortest word(s).
// 
// String will never be empty and you do not need to account for different data types.
// -----------------------------------------------------------

let findShort (s : string) = 
    let l = s.Split(' ')
    let mutable w = System.Int32.MaxValue
    for i in l do
        w <- min (i.Length) w
    w;;

// or

let findShort (s : string) =
    s.Split(' ')
    |> Array.map (fun i -> i.Length)
    |> Array.min;;

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