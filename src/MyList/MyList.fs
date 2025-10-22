module MyList

type 'a MyList = 
    | Empty 
    | Something of 'a * 'a MyList

let rec take (n: int) (lst: 'a MyList) : 'a MyList = 
    match n, lst with
    | _, Empty -> Empty
    | 0, _ -> Empty
    | _, Something (x, xs) -> Something (x, take (n - 1) xs)

let rec drop (n: int) (lst : 'a MyList) : 'a MyList =
    match n, lst with
    | _, Empty -> Empty
    | 0, _ -> lst
    | _, Something (x, xs) -> drop (n - 1) xs

let rec length (lst: 'a MyList) : int = 
    match lst with
    | Empty -> 0
    | Something (x, xs) -> length xs + 1

let rec map (f: 'a -> 'b) (lst: 'a MyList) : 'b MyList = 
    match lst with
    | Empty -> Empty
    | Something (x, xs) -> Something (f x, map f xs)