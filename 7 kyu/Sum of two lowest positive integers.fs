// -----------------------------------------------------------
// Create a function that returns the sum of the two lowest positive numbers given an array of minimum 4 positive integers. No floats or non-positive 
// integers will be passed.
// 
// For example, when an array is passed like [19, 5, 42, 2, 77], the output should be 7.
// 
// [10, 343445353, 3453445, 3453545353453] should return 3453455.
// -----------------------------------------------------------

let sumTwoSmallestNumbers (numbers : seq<int64>) : int64 =
    numbers
    |> Seq.sort
    |> Seq.take 2
    |> Seq.sum;;

// or

let sumTwoSmallestNumbers (numbers : int64[]) : int64 =
    numbers
    |> Array.sort
    |> Array.take 2
    |> Array.sum;;

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