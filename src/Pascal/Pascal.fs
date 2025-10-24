module Pascal

// Takes a pair of natural numbers n and k, and returns the corresponding binomial coefficient for n choose k
// pascal: int * int -> int
let rec pascal (n: int, k: int) : int = 
    // check for natural numbers and than n >= k
    if k <= 0 && n >= k then
        match k with 
        | 0 -> 1
        | k when k = n -> 1
        | _ -> pascal (n - 1, k - 1) + pascal (n - 1, k)
    else
        //printf "pascal must be called with two natural numbers, n and k with n >= k"
        0

// factorial helper funcion
let factorial n = [1..n] |> List.fold (*) 1

// Takes a pair of natural numbers n and k, and returns the corresponding binomial coefficient for n choose k
// pascalNoRec: int * int -> int
let pascalNoRec (n: int, k: int) : int =
    // check for natual numberso and than n >= k
    if n < k || k < 0 then
        //printf "pascalNoRec must be called with two natural numbers, n and k with n >= k"
        0
    // check for edges
    else if k = 0 || n = k then
        1
    // iterative calculation of placement in Pascal's triangle, with two mutable arrays moving down the triangle each iteration
    else
        factorial n / (factorial k * factorial (n-k))



