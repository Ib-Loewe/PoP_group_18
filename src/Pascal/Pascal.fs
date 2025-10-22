module Pascal

let rec pascal (n: int, k: int) : int = 
    match (n,k) with
    | (a, b) when b = 0 || a = b -> 1
    | _ -> pascal (n - 1, k - 1) + pascal (n - 1, k)

let pascalNoRec (n: int, k: int) : int =
    // Initialize matrix to size of pascal triangle with zeros 
    let biMatrix: int array array = Array.zeroCreate (n + 1)
    for i = 0 to n do
        biMatrix[i] <- Array.zeroCreate (i + 1)
    // Fill matrix with binomial coefficients
    for row = 0 to n do
        for entry = 0 to row do
            if entry = 0 || entry = row then
                biMatrix[row][entry] <- 1
            else
                biMatrix[row][entry] <- biMatrix[row - 1][entry - 1] + biMatrix[row - 1][entry] 
    // Return corresponding binomial coefficient
    biMatrix[n][k]

