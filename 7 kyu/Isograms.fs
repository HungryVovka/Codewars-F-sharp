// -----------------------------------------------------------
// An isogram is a word that has no repeating letters, consecutive or non-consecutive. Implement a function that determines whether a string that 
// contains only letters is an isogram. Assume the empty string is an isogram. Ignore letter case.
// 
// Example: (Input --> Output)
// 
// "Dermatoglyphics" --> true "aba" --> false "moOse" --> false (ignore letter case)
// 
// isIsogram "Dermatoglyphics" = true
// isIsogram "moose" = false
// isIsogram "aba" = false
// -----------------------------------------------------------

module Solution

open System

let isIsogram (str : string) = 
    let s = 
        str
        |> Seq.map Char.ToUpperInvariant
        |> Seq.distinct
        |> Seq.length
    s = str.Length;;

// or

module Solution

open System

let isIsogram (str : string) = 
    str.Length = Seq.length (Seq.distinct (str.ToUpper()));;

// or

module Solution

open System

let isIsogram (str : string) = 
    str.Length = (str.ToUpper() |> Seq.distinct |> Seq.length);;

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