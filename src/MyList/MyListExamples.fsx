#load "MyList.fs"

open MyList

printfn "Running MyList examples..."
let ex1 : int MyList =  Something (1, Something (2, Something (3, Something (4, Something (5, Empty)))))
let ex2 : string MyList = Something ("a", Something ("b", Something ("c", Empty)))

// take
let ex1Take3 = take 3 ex1 // expected Something (1, Something (2, Something (3, Empty)))
let ex2Take2 = take 2 ex2 // expected Something ("a", Something ("b", Empty))

// drop
let ex1Drop2 = drop 2 ex1 // expected Something (3, Something (4, Something (5, Empty)))    
let ex2Drop1 = drop 1 ex2 // expected Something ("b", Something ("c", Empty))

// Length
let ex1Length = length ex1 // expected 5
let ex2Length = length ex2 // expected 3
let exEmptyLength = length Empty // expected 0

// Map
let ex1Mappedx2 = map (fun x -> x * 2) ex1 // expected Something (2, Something (4, Something (6, Something (8, Something (10, Empty)))))

printfn "Examples executed."
printfn "Example lists:"
printfn "Example list 1: int MyList = %A" ex1
printfn "Example list 2: string MyList = %A" ex2

printfn "\nTake examples:"
printfn "Example list 1: Take 3: = %A" ex1Take3
printfn "Example list 2: Take 2 = %A" ex2Take2

printfn "\nDrop examples:"
printfn "Example list 1: Drop 2 = %A" ex1Drop2
printfn "Example list 2: Drop 3 = %A" ex2Drop1

printfn "\nLength examples:"
printfn "Example list 1 Length = %A" ex1Length
printfn "Example list 2 Length = %A" ex2Length
printfn "Example empty list length = %A" exEmptyLength

printfn "\nmap example:"
printfn "Example list 1 mapped x2: %A" ex1Mappedx2