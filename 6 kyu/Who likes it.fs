// -----------------------------------------------------------
// You probably know the "like" system from Facebook and other pages. People can "like" blog posts, pictures or other items. We want to create the 
// text that should be displayed next to such an item.
// 
// Implement the function which takes an array containing the names of people that like an item. It must return the display text as shown in the 
// examples:
// 
// []                                -->  "no one likes this"
// ["Peter"]                         -->  "Peter likes this"
// ["Jacob", "Alex"]                 -->  "Jacob and Alex like this"
// ["Max", "John", "Mark"]           -->  "Max, John and Mark like this"
// ["Alex", "Jacob", "Mark", "Max"]  -->  "Alex, Jacob and 2 others like this"
// 
// Note: For 4 or more names, the number in "and 2 others" simply increases.
// -----------------------------------------------------------

module WhoLikesIt.Solution

let likes (names: string list): string =
    match names with
    | [] -> "no one likes this"
    | [name] -> sprintf "%s likes this" name
    | [name1; name2] -> sprintf "%s and %s like this" name1 name2
    | [name1; name2; name3] -> sprintf "%s, %s and %s like this" name1 name2 name3
    | _ -> sprintf "%s, %s and %d others like this" names.[0] names.[1] (List.length names - 2);;

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