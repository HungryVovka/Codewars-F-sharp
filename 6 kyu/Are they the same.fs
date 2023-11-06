// -----------------------------------------------------------
// Given two arrays a and b write a function comp(a, b) (orcompSame(a, b)) that checks whether the two arrays have the "same" elements, with 
// the same multiplicities (the multiplicity of a member is the number of times it appears). "Same" means, here, that the elements in b are the 
// elements in a squared, regardless of the order.
// 
// Examples
// Valid arrays
// a = [121, 144, 19, 161, 19, 144, 19, 11]  
// b = [121, 14641, 20736, 361, 25921, 361, 20736, 361]
// 
// comp(a, b) returns true because in b 121 is the square of 11, 14641 is the square of 121, 20736 the square of 144, 361 the square of 19, 25921 
// the square of 161, and so on. It gets obvious if we write b's elements in terms of squares:
// 
// a = [121, 144, 19, 161, 19, 144, 19, 11] 
// b = [11*11, 121*121, 144*144, 19*19, 161*161, 19*19, 144*144, 19*19]
// 
// Invalid arrays
// If, for example, we change the first number to something else, comp is not returning true anymore:
// 
// a = [121, 144, 19, 161, 19, 144, 19, 11]  
// b = [132, 14641, 20736, 361, 25921, 361, 20736, 361]
// 
// comp(a,b) returns false because in b 132 is not the square of any number of a.
// 
// a = [121, 144, 19, 161, 19, 144, 19, 11]  
// b = [121, 14641, 20736, 36100, 25921, 361, 20736, 361]
// 
// comp(a,b) returns false because in b 36100 is not the square of any number of a.
// 
// Remarks
// a or b might be [] or {} (all languages except R, Shell).
// a or b might be nil or null or None or nothing (except in C++, COBOL, Crystal, D, Dart, Elixir, Fortran, F#, Haskell, Nim, OCaml, Pascal, 
// Perl, PowerShell, Prolog, PureScript, R, Racket, Rust, Shell, Swift).
// 
// If a or b are nil (or null or None, depending on the language), the problem doesn't make sense so return false.
// -----------------------------------------------------------

let comp(a, b): bool =
    if List.length a <> List.length b then
        false
    else
        let array1 = a |> List.map (fun i -> i * i) |> List.sort
        let array2 = b |> List.sort
        array1 = array2;;

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