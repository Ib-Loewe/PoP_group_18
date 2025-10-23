module Pascal

// Takes a pair of natural numbers n and k, and returns the corresponding binomial coefficient for n choose k
// pascal: int * int -> int
let rec pascal (n: int, k: int) : int =
    if n >= k && n >= 0 && k >= 0 then
        match n, k with
        |_, 0 -> 1
        |n, k when n = k -> 1 
        |n, k -> pascal (n - 1, k - 1) + pascal (n - 1, k)
    else 
        0

(*let rec pascal (n: int, k: int) : int =
    if n < k || n < 0 || k < 0 then
        0
    else
        match n, k with
        |_, 0 -> 1
        |n, k when n = k -> 1 
        |n, k -> pascal (n - 1, k - 1) + pascal (n - 1, k)
*)




// Takes a pair of natural numbers n and k, and returns the corresponding binomial coefficient for n choose k
// pascalNoRec: int * int -> int
let pascalNoRec (n: int, k: int) : int =
    if n < k || n < 0 || k < 0 then
        0
    else
        if k = 0 || k = n then 
            1
        else
            let pascalTriangle = Array.zeroCreate (n + 1)
            for i = 0 to n do
                pascalTriangle.[i] <- Array.zeroCreate (i + 1)
            
            pascalTriangle.[0].[0] <- 1
            
            for i = 0 to n do
                for j = 1 to i - 1 do 
                    pascalTriangle.[i].[j] <- pascalTriangle.[i - 1].[j - 1] + pascalTriangle.[i - 1].[j]
                    pascalTriangle.[n].[k]
                
                pascalTriangle.[i].[0] <- 1
                pascalTriangle.[i].[i] <- 1

            pascalTriangle.[n].[k]