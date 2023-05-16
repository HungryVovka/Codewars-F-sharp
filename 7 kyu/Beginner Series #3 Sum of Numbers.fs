// -----------------------------------------------------------
// Given two integers a and b, which can be positive or negative, find the sum of all the integers between and including them and return it. If the two 
// numbers are equal return a or b.
// 
// Note: a and b are not ordered!
// 
// Examples (a, b) --> output (explanation)
// (1, 0) --> 1 (1 + 0 = 1)
// (1, 2) --> 3 (1 + 2 = 3)
// (0, 1) --> 1 (0 + 1 = 1)
// (1, 1) --> 1 (1 since both are same)
// (-1, 0) --> -1 (-1 + 0 = -1)
// (-1, 2) --> 2 (-1 + 0 + 1 + 2 = 2)
// 
// Your function should only return a number, not the explanation about how you get that number.
// -----------------------------------------------------------

let getSum (a : int) (b : int) =
    let maxnum = max a b
    let minnum = min a b
    (1 + maxnum - minnum) * (maxnum + minnum) / 2;;

// or

let getSum (a : int) (b : int) =
    [|min a b .. max a b|]
    |> Array.sum;;

// or

let getSum (a : int) (b : int) =
    [min a b .. max a b]
    |> Seq.sum;;

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