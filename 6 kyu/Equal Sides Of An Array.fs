// -----------------------------------------------------------
// You are going to be given an array of integers. Your job is to take that array and find an index N where the sum of the integers to the left of N is equal 
// to the sum of the integers to the right of N. If there is no index that would make this happen, return -1.
// 
// For example:
// 
// Let's say you are given the array {1,2,3,4,3,2,1}:
// Your function will return the index 3, because at the 3rd position of the array, the sum of left side of the index ({1,2,3}) and the sum of the right 
// side of the index ({3,2,1}) both equal 6.
// 
// Let's look at another one.
// You are given the array {1,100,50,-51,1,1}:
// Your function will return the index 1, because at the 1st position of the array, the sum of left side of the index ({1}) and the sum of the right side of 
// the index ({50,-51,1,1}) both equal 1.
// 
// Last one:
// You are given the array {20,10,-80,10,10,15,35}
// At index 0 the left side is {}
// The right side is {10,-80,10,10,15,35}
// They both are equal to 0 when added. (Empty arrays are equal to 0 in this problem)
// Index 0 is the place where the left side and right side are equal.
// 
// Note: Please remember that in most programming/scripting languages the index of an array starts at 0.
// 
// Input:
// An integer array of length 0 < arr < 1000. The numbers in the array can be any integer positive or negative.
// 
// Output:
// The lowest index N where the side to the left of N is equal to the side to the right of N. If you do not find an index that fits these rules, then you will 
// return -1.
// 
// Note:
// If you are given an array with multiple answers, return the lowest correct index.
// -----------------------------------------------------------

let findEvenIndex (items : int array) = 
    let mutable answer = -1
    let mutable check1 = 0
    let mutable check2 = Array.sum items
    let mutable i = 0
    let mutable noLoop = false
    for i in 0..(items.Length - 1) do
        if check1 = (check2 - check1 - items.[i]) && noLoop = false then
            answer <- i
            noLoop <- true
        check1 <- check1 + items.[i]
    answer;;

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