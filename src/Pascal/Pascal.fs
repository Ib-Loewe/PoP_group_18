module Pascal

// Takes a pair of natural numbers n and k, and returns the corresponding binomial coefficient for n choose k
let rec pascal (n: int, k: int) : int = 
    match (n,k) with
    | (a, b) when b = 0 || a = b -> 1
    | _ -> pascal (n - 1, k - 1) + pascal (n - 1, k)

// Takes a pair of natural numbers n and k, and returns the corresponding binomial coefficient for n choose k
// pascalNoRec: int * int -> int
let pascalNoRec (n: int, k: int) : int =
    0

