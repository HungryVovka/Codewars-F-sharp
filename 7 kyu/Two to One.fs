// -----------------------------------------------------------
// Take 2 strings s1 and s2 including only letters from a to z. Return a new sorted string, the longest possible, containing distinct letters - each 
// taken only once - coming from s1 or s2.
// 
// Examples:
// a = "xyaabbbccccdefww"
// b = "xxxxyyyyabklmopq"
// longest(a, b) -> "abcdefklmopqwxy"
// 
// a = "abcdefghijklmnopqrstuvwxyz"
// longest(a, a) -> "abcdefghijklmnopqrstuvwxyz"
// -----------------------------------------------------------

open System

let longest (s1: string) (s2: string) =
    s1 + s2
    |> Seq.toList
    |> List.distinct
    |> List.sort
    |> Array.ofList
    |> String.Concat;;

// or


open System

let longest (s1: string) (s2: string) =
    s1 + s2
    |> Seq.distinct
    |> Seq.sort
    |> String.Concat;;

// or

open System

let longest (s1: string) (s2: string) =
    (s1 + s2).ToCharArray()
    |> Set
    |> String.Concat;;

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