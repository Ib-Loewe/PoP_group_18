module MyList

type 'a MyList = 
    | Empty 
    | Something of 'a * 'a MyList


//Takes an integer n and a MyList, and returns a MyList of the first n elements in the original list.
let rec take (n: int) (lst: 'a MyList) : 'a MyList = 
    match lst with
    | Empty -> Empty
    | Something (head, tail) -> 
        if n <= 0 then
            Empty
        else
            Something (head, take (n - 1) tail)


//Takes an integer n and a MyList, and returns a MyList without the first n elements of the original list.
let rec drop (n: int) (lst : 'a MyList) : 'a MyList =
    match lst with
    | Empty -> Empty
    | Something (head, tail) ->
        if n <= 0  then lst
        else drop (n - 1) tail

//Takes a MyList and returns the number of elements in the list.
let rec length (lst: 'a MyList) : int = 
    match lst with
    | Empty -> 0
    | Something (head, tail) -> 1 + length tail


//Takes a function, and a MyList and returns a MyList with the function applied to each element.
let rec map (f: 'a -> 'b) (lst: 'a MyList) : 'b MyList = 
    match lst with
    | Empty -> Empty
    | Something (head, tail) -> Something (f head, map f tail)