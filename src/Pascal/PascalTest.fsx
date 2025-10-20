#load "Pascal.fs"
open Pascal

let hasPropertyOneTest f (n: int, k: int) : bool = 
    f (n, 0) = 1 && f (n, k) = 1 

let hasPropertyOne (n: int, k: int) : bool = 
    hasPropertyOneTest pascal (n,k)


let hasPropertyOneNoRec (n: int, k: int): bool = 
    hasPropertyOneTest pascalNoRec (n,k)


let hasPropertyTwoTest f (n: int, k: int) : bool =
    f (n, k) = f (n - 1, k - 1) + f (n - 1, k) 

let hasPropertyTwo (n, k) : bool =
    hasPropertyTwoTest pascal (n,k)

let hasPropertyTwoNoRec ( n , k) : bool =
    hasPropertyTwoTest pascalNoRec (n,k)


// Following is the property tests for the recursive and iterative implementation
let n = 1_078_456_392 // a random integer in the middle of the input domain ± 10 million
let max = 2_147_483_647

printfn "Recursive Property 1:"
printfn "- (0,0): %A" (hasPropertyOne (0, 0))
printfn "- (1,1): %A" (hasPropertyOne (1, 1))
printfn "- (max,0): %A" (hasPropertyOne (max, 0))
printfn "- (max,max): %A" (hasPropertyOne (max, max))
printfn "- (n,n): %A" (hasPropertyOne (n, n))
printfn "- (n,0): %A" (hasPropertyOne (n, 0))

printfn "Recursive Property 2:"
printfn "- (2,1): %A" (hasPropertyTwo (2,1))
printfn "- (n,n-1): %A" (hasPropertyTwo (n,n-1))
printfn "- (n,n/2): %A" (hasPropertyTwo (n,n/2))
printfn "- (max-1,max-2): %A" (hasPropertyTwo (max - 1, max-2))
printfn "- (max-1,n): %A" (hasPropertyTwo (max-1,n))
printfn "- (max-1,1): %A" (hasPropertyTwo (max-1,1))
printfn "- (max,max-1): %A" (hasPropertyTwo (max, max-1))
printfn "- (max,n): %A" (hasPropertyTwo (max,n))
printfn "- (max,1): %A" (hasPropertyTwo (max,1)) 

printfn "Iterative Property 1:"
printfn "- (0,0): %A" (hasPropertyOneNoRec (0, 0))
printfn "- (1,1): %A" (hasPropertyOneNoRec (1, 1))
printfn "- (max,0): %A" (hasPropertyOneNoRec (max, 0))
printfn "- (max,max): %A" (hasPropertyOneNoRec (max, max))
printfn "- (n,n): %A" (hasPropertyOneNoRec (n, n))
printfn "- (n,0): %A" (hasPropertyOneNoRec (n, 0))

printfn "Iterative Property 2:"
printfn "- (2,1): %A" (hasPropertyTwoNoRec (2,1))
printfn "- (n,n-1): %A" (hasPropertyTwoNoRec (n,n-1))
printfn "- (n,n/2): %A" (hasPropertyTwoNoRec (n,n/2))
printfn "- (max-1,max-2): %A" (hasPropertyTwoNoRec (max - 1, max-2))
printfn "- (max-1,n): %A" (hasPropertyTwoNoRec (max-1,n))
printfn "- (max-1,1): %A" (hasPropertyTwoNoRec (max-1,1))
printfn "- (max,max-1): %A" (hasPropertyTwoNoRec (max, max-1))
printfn "- (max,n): %A" (hasPropertyTwoNoRec (max,n))
printfn "- (max,1): %A" (hasPropertyTwoNoRec (max,1)) 


