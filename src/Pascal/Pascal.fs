module Pascal

// Takes a pair of natural numbers n and k, and returns the corresponding binomial coefficient for n choose k
// pascal: int * int -> int
let rec pascal (n: int, k: int) : int = 
    match k with 
    | 0 -> 1
    | _ when k = n -> 1
    | _ -> pascal (n - 1, k - 1) + pascal (n - 1, k)

// Takes a pair of natural numbers n and k, and returns the corresponding binomial coefficient for n choose k
// pascalNoRec: int * int -> int
let pascalNoRec (n: int, k: int) : int =
    // check for natual numbers
    if n < k || k < 0 then
        printf "pascalNoRec must be called with two natural numbers, n and k with n >= k"
        0
    else if k = 0 || n = k then
        1
    else
        let mutable currRow: int array = Array.init (k+1) (fun i -> if i = 0 then 1 else 0)
        let mutable prevRow: int array = Array.init (k+1) (fun i -> if i = 0 then 1 else 0)

        for i in 1 .. n do
            for j in 1 .. (min i k) do
                currRow.[j] <- prevRow.[j - 1] + prevRow.[j]
            // swap rows
            let temp = prevRow
            prevRow <- currRow
            currRow <- temp
        prevRow.[k]



