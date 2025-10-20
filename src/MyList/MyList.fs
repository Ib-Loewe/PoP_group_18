module MyList

type 'a MyList = 
    | Empty 
    | Something of 'a * 'a MyList


// Takes an integer n and a MyList, and returns a MyList of the first n elements in the original list.
let rec take (n: int) (list: 'a MyList): 'a MyList = 
    match n, list with
    | 0, _ -> Empty
    | _, Empty -> Empty
    | 1, Something (head, _tail) ->  Something (head, Empty) 
    | _, Something (head, tail) -> 
        match take (n - 1) tail with
        | Empty -> Something (head, Empty)
        | Something (headhead, tail) -> Something (head, Something (headhead, tail))



// Takes an integer n and a MyList, and returns a MyList without the first n elements of the original list.
let rec drop (n: int) (list : 'a MyList) : 'a MyList =
    match n, list with
    | 0, _ -> list
    | _, Empty -> Empty
    | _, Something (_head, tail) -> drop (n - 1) tail  

// Takes a MyList and returns the number of elements in the list.
let rec length (list: 'a MyList): int = 
    match list with
    | Empty -> 0
    | Something (_head, tail) -> 1 + length tail 

// Takes a function, and a MyList and returns a MyList with the function applied to each element.
let rec map (f: 'a -> 'b) (list: 'a MyList) : 'b MyList = 
    match list with
    | Empty -> Empty
    | Something (head, tail) -> Something (f head, map f tail)