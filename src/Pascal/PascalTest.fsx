#load "Pascal.fs"
open Pascal

let hasPropertyOneTest f (n: int, _k: int) : bool = 
    f (n,0) = 1 && f (n, n) = 1 

//hasPropertyOne: int * int -> bool
let hasPropertyOne (n: int, k: int) : bool = 
    hasPropertyOneTest pascal (n,k)


//hasPropertyOneNoRec: int * int -> bool
let hasPropertyOneNoRec (n: int, k: int): bool = 
    hasPropertyOneTest pascalNoRec (n,k)

//hasPropertyTwo: int * int -> bool
let hasPropertyTwo (n , k) : bool =
    false

//hasPropertyTwoNoRec: int * int -> bool
let hasPropertyTwoNoRec ( n , k) : bool =
    false