#load "MyList.fs"

open MyList

//List for testing 
let lst = Something(1, Something(2, Something(3, Empty)))


//Examples for the function take
//Example 1 - Edge case
let ex1 = take 0 lst
printfn "take 0 lst = %A" ex1

//Example 2 - Normal case
let ex2 = take 2 lst
printfn "take 2 lst = %A" ex2

//Example 3 - Edge case: n > length(lst)
let ex3 = take 5 lst
printfn "take 5 lst = %A" ex3

//Example 4 - Edge case: n = 0
let ex4 = take 0 lst
printfn "take 0 lst = %A" ex4

//example 5 - Edge case: n < 0
let ex5 = take -1 lst
printfn "take -1 lst %A" ex5


//Examples for the function drop
//Example 1 - Edge case

