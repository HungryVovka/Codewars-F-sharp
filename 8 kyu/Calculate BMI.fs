// -----------------------------------------------------------
// Write function bmi that calculates body mass index (bmi = weight / height2).
// 
// if bmi <= 18.5 return "Underweight"
// 
// if bmi <= 25.0 return "Normal"
// 
// if bmi <= 30.0 return "Overweight"
// 
// if bmi > 30 return "Obese"
// -----------------------------------------------------------

let bmi weight height =
    match weight / (height * height) with
        | bmi when bmi <= 18.5 -> "Underweight"
        | bmi when bmi <= 25.0 -> "Normal"
        | bmi when bmi <= 30.0 -> "Overweight"
        | bmi when bmi > 30.0 -> "Obese"
        | _ -> "Invalid value";;