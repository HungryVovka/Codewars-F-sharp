// -----------------------------------------------------------
// Write a function that checks if a given string (case insensitive) is a palindrome.
// -----------------------------------------------------------

let isPalindrom (s: string) =
    let answer = s.ToLower().ToCharArray()
    answer = Array.rev answer;;