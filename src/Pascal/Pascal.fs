module Pascal

// Takes a pair of natural numbers n and k, and returns the corresponding binomial coefficient for n choose k
let rec pascal (n: int, k: int): int = 
    match k with
    | 0 -> 1
    | k when k = n -> 1
    | _ -> pascal (n - 1, k - 1) + pascal (n - 1, k)

// Takes a pair of natural numbers n and k, and returns the corresponding binomial coefficient for n choose k
let pascalNoRec (n: int, k: int): int =
    let mutable rows: list<array<int>> = [];

    // Early return if n = k?

    // Only compute until k rows!?

    for i in 0..n do
        match i with
        | 0 -> rows <- [|1|] :: rows
        | 1 -> rows <- [|1; 1|] :: rows
        | _ -> 
            let column = Array.zeroCreate (i + 1)
            Array.set column 0 1
            Array.set column (column.Length - 1) 1

            for j in 1..(i - 1) do
                Array.set column j (rows.Head[j - 1] + rows.Head[j])      
            
            // printfn "%A" column
            rows <- column :: rows

        // if rows.Length % 100 = 0 then
        //     printfn "rows: %A" rows.Length
    
    printfn "%A" rows[0]
    rows[0][k]