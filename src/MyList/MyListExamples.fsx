#load "MyList.fs"
open MyList

// List to use in examples
let intListLong = Something (2, Something (3, Something (4, Something(9, Something(13, Empty)))))
let intListShort = Something (19, Something (-30, Empty))
let stringList = Something("Hej", Something("Med", Something("Dig", Something ("Verden", Something("!", Empty)))))
let emptyList = Empty


// take examples
printfn "Take examples: "
take 3 intListLong |> printfn "take 3 intListLong returns %A"
take 1 stringList |> printfn "take 1 stringList  returns %A"
take 0 intListShort |> printfn "take 0 intListShort returns %A"
take 10 intListShort |> printfn "take 10 intListShort returns %A"

// drop examples
printfn "Drop examples: "
drop 2 intListLong |> printfn "drop 2 intListLong returns %A"
drop 1 stringList |> printfn "drop 1 stringList returns %A"
drop 10 intListShort |> printfn "drop 10 intListShort returns %A"
drop 0 stringList |> printfn "drop 0 stringList returns %A"

// length examples
printfn "Length examples: "
length intListLong |> printfn "length intListLong returns %A"
length intListShort |> printfn "length intListShort returns %A"
length stringList |> printfn "length stringList returns %A"
length emptyList |> printfn "length emptyList returns %A"

// map examples
printfn "Map examples: "
map (fun e -> e * e) intListShort |> printfn "map (fun e -> e * e) intListShort returns %A"
map (fun x -> x * 2) intListLong |> printfn "map (fun x -> x * 2) intListLong returns %A"
map (fun s -> s + "!") stringList |> printfn "map (fun s -> s + \"!\") stringList returns %A"
map (fun x -> x + 1) emptyList |> printfn "map (fun x -> x + 1) emptyList returns %A"



