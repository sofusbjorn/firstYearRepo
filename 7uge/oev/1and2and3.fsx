type Weekday = Monday | Tuesday | Wednesday | Thursday | Friday | Saturday | Sunday

let dayToNumber (w : Weekday) : int = 
    match w with
    | Monday -> 1
    | Tuesday -> 2
    | Wednesday -> 3
    | Thursday -> 4
    | Friday -> 5
    | Saturday -> 6
    | Sunday -> 7

printfn "this day has the number: %A" (dayToNumber (Thursday))

let nextDay  (w : Weekday) : Weekday =
    match w with
    | Monday -> Tuesday
    | Tuesday -> Wednesday
    | Wednesday -> Thursday
    | Thursday -> Friday
    | Friday -> Saturday
    | Saturday -> Sunday
    | Sunday -> Monday

printfn "the day after this is: %A" (nextDay (Thursday))

let numberToDay (n : int) : Weekday option =
    match n with
    | 1 -> Some Monday
    | 2 -> Some Tuesday
    | 3 -> Some Wednesday
    | 4 -> Some Thursday
    | 5 -> Some Friday
    | 6 -> Some Saturday
    | 7 -> Some Sunday
    | _ -> None

printfn "the day corresponding to this number is: %A" (numberToDay (4))
printfn "the day corresponding to this number is: %A" (numberToDay (100))

