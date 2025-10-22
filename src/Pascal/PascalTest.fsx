#load "Pascal.fs"
open Pascal

let hasPropertyZeroTest f (n: int, k: int): bool =
    if n < 0 || k < 0 || k > n then
        f (n, k) = 0
    else
        true

let hasPropertyZero (n: int, k: int): bool =
    hasPropertyZeroTest pascal (n, k)

let hasPropertyZeroNoRec (n: int, k: int): bool =
    hasPropertyZeroTest pascalNoRec (n, k)


let hasPropertyOneTest f (n: int, k: int): bool = 
    f (n, 0) = 1 && f (n, k) = 1 

let hasPropertyOne (n: int, k: int): bool = 
    hasPropertyOneTest pascal (n,k)

let hasPropertyOneNoRec (n: int, k: int): bool = 
    hasPropertyOneTest pascalNoRec (n,k)

let hasPropertyTwoTest f (n: int, k: int): bool =
    f (n, k) = f (n - 1, k - 1) + f (n - 1, k) 

let hasPropertyTwo (n, k): bool =
    hasPropertyTwoTest pascal (n,k)

let hasPropertyTwoNoRec (n, k): bool =
    hasPropertyTwoTest pascalNoRec (n,k)


// Following is the property tests for the recursive and iterative implementation
let intMax = System.Int32.MaxValue
let intMin = System.Int32.MinValue

printfn "Recursive Property 0:"
printfn "- (-1,-1): %A" (hasPropertyZero (-1, -1))
printfn "- (intMin,intMin): %A" (hasPropertyZero (intMin, intMin))
printfn "- (0,-1): %A" (hasPropertyZero (0, -1))
printfn "- (0,intMin): %A" (hasPropertyZero (0, intMin))
printfn "- (0,1): %A" (hasPropertyZero (0, 1))
printfn "- (1,2): %A" (hasPropertyZero (1, 2))
printfn "- (intMax-1,intMax): %A" (hasPropertyZero (intMax - 1, intMax))
printfn "- (0,intMax): %A" (hasPropertyZero (0, intMax))
printfn "- (1,intMax): %A" (hasPropertyZero (1, intMax))

printfn "Recursive Property 1:"
printfn "- (0,0): %A" (hasPropertyOne (0, 0))
printfn "- (1,1): %A" (hasPropertyOne (1, 1))
printfn "- (1,0): %A" (hasPropertyOne (1, 0))
printfn "- (intMax,0): %A" (hasPropertyOne (intMax, 0))
printfn "- (intMax,intMax): %A" (hasPropertyOne (intMax, intMax))
printfn "- (33,33): %A" (hasPropertyOne (33, 33))
printfn "- (33,0): %A" (hasPropertyOne (33, 0))
printfn "- (36,36): %A" (hasPropertyOne (36, 36))
printfn "- (36,0): %A" (hasPropertyOne (36, 0))

printfn "Recursive Property 2:"
printfn "- (2,1): %A" (hasPropertyTwo (2,1))
printfn "- (33,32): %A" (hasPropertyTwo (33,32))
printfn "- (33, 33/2): %A" (hasPropertyTwo (33,33/2))
printfn "- (33, 1): %A" (hasPropertyTwo (33,1))
printfn "- (36,32): %A" (hasPropertyTwo (36,35))
//printfn "- (36, 36/2): %A" (hasPropertyTwo (36,36/2)) // Takes too much time to complete
printfn "- (36, 1): %A" (hasPropertyTwo (36,1))
//printfn "- (intMax,intMax-1): %A" (hasPropertyTwo (intMax,intMax-1)) // Stack overflow
//printfn "- (intMax, intMax/2): %A" (hasPropertyTwo (intMax,intMax/2)) // Stack overflow
//printfn "- (intMax, 1): %A" (hasPropertyTwo (intMax,1)) // Stack overflow

printfn "Iterative Property 0:"
printfn "- (-1,-1): %A" (hasPropertyZeroNoRec (-1, -1))
printfn "- (intMin,intMin): %A" (hasPropertyZeroNoRec (intMin, intMin))
printfn "- (0,-1): %A" (hasPropertyZeroNoRec (0, -1))
printfn "- (0,intMin): %A" (hasPropertyZeroNoRec (0, intMin))
printfn "- (0,1): %A" (hasPropertyZeroNoRec (0, 1))
printfn "- (1,2): %A" (hasPropertyZeroNoRec (1, 2))
printfn "- (intMax-1,intMax): %A" (hasPropertyZeroNoRec (intMax - 1, intMax))
printfn "- (0,intMax): %A" (hasPropertyZeroNoRec (0, intMax))
printfn "- (1,intMax): %A" (hasPropertyZeroNoRec (1, intMax))

printfn "Iterative Property 1:"
printfn "- (0,0): %A" (hasPropertyOneNoRec (0, 0))
printfn "- (1,1): %A" (hasPropertyOneNoRec (1, 1))
printfn "- (1,0): %A" (hasPropertyOneNoRec (1, 0))
//printfn "- (intMax-1,0): %A" (hasPropertyOneNoRec (intMax-1, 0)) // System.OutOfMemoryException
//printfn "- (intMax-1,intMax-1): %A" (hasPropertyOneNoRec (intMax-1, intMax-1)) // System.OutOfMemoryException
printfn "- (33,33): %A" (hasPropertyOneNoRec (33, 33))
printfn "- (33,0): %A" (hasPropertyOneNoRec (33, 0))
printfn "- (36,36): %A" (hasPropertyOneNoRec (36, 36))
printfn "- (36,0): %A" (hasPropertyOneNoRec (36, 0))

printfn "Iterative Property 2:"
printfn "- (2,1): %A" (hasPropertyTwoNoRec (2,1))
printfn "- (33,32): %A" (hasPropertyTwoNoRec (33,32))
printfn "- (33, 33/2): %A" (hasPropertyTwoNoRec (33,33/2))
printfn "- (33, 1): %A" (hasPropertyTwoNoRec (33,1))
printfn "- (36,32): %A" (hasPropertyTwoNoRec (36,35))
printfn "- (36, 36/2): %A" (hasPropertyTwoNoRec (36,36/2))
printfn "- (36, 1): %A" (hasPropertyTwoNoRec (36,1))
//printfn "- (intMax-1,intMax-2): %A" (hasPropertyTwoNoRec (intMax-1,intMax-2)) // System.OutOfMemoryException
//printfn "- (intMax-1, (intMax-1)/2): %A" (hasPropertyTwoNoRec (intMax-1,(intMax-1)/2)) // System.OutOfMemoryException
//printfn "- (intMax-1, 1): %A" (hasPropertyTwoNoRec (intMax-1,1)) // System.OutOfMemoryException




