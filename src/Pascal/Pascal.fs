module Pascal

// Takes a pair of natural numbers n and k, and returns the corresponding binomial coefficient for n choose k
// pascal: int * int -> int
let rec pascal (n: int, k: int) : int = 
    // check for natural numbers and than n >= k
    if k <= 0 && n <= 0 && n >= k then
        match n, k with 
        | _, 0 -> 1
        | n, k when n = k -> 1
        | _ -> pascal (n - 1, k - 1) + pascal (n - 1, k)
    else
        //printf "pascal must be called with two natural numbers, n and k with n >= k"
        0

let pascalNoRec (n: int, k: int) : int =
    // check for natual numberso and than n >= k
    if n < k || k < 0 then
        //printf "pascalNoRec must be called with two natural numbers, n and k with n >= k"
        0
    // check for edges
    else if n = k || k = 0 then
        1
    else
        // create 2d array (matrix) to store values, initialized to 1
        let matrix : int array array = Array.zeroCreate (n + 1)
        for i = 0 to n do
            matrix.[i] <- Array.create (i + 1) 1
        // fill in the matrix using pascal's rule
        for i = 2 to n do
            for j = 1 to i - 1 do
                matrix.[i].[j] <- matrix.[i - 1].[j - 1] + matrix.[i - 1].[j]
        // return matrix value n choose k
        matrix.[n].[k]


// factorial helper function
let rec factorial n = 
    match n with
    | 0 | 1 -> 1
    | _ -> factorial (n - 1) * n

// Takes a pair of natural numbers n and k, and returns the corresponding binomial coefficient for n choose k.
// Uses factorail helper function, so can overflowwith number that are too large
// pascalFactCalc: int * int -> int
let pascalFactCalc (n: int, k: int) : int =
    // check for natual numberso and than n >= k
    if n < k || k < 0 then
        //printf "pascalNoRec must be called with two natural numbers, n and k with n >= k"
        0
    // check for edges
    else if n = k || k = 0 then
        1
    else
        factorial n / (factorial k * factorial (n-k))



