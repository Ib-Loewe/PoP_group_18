module MyList

type 'a MyList = 
    | Empty 
    | Something of 'a * 'a MyList


// Takes a positive integer n and a 'a MyList lst, and returns a 'a MyList of the first n elements in lst.
// take: int -> 'a MyList -> 'a MyList
val take: int -> 'a MyList -> 'a MyList


// Takes a positive integer n and a 'a MyList lst, and returns a MyList without the first n elements in lst.
// drop: int -> 'a MyList -> 'a MyList
val drop : int -> 'a MyList -> 'a MyList


// Takes a 'a MyList lst and returns the number of elements lst.
// length: 'a MyList -> int
val length : 'a MyList -> int


// Takes a function f, and a 'a MyList lst and returns a MyList with the function applied to each element in lst.
// map: ('a -> 'b) -> 'a MyList -> 'b MyList
val map : ('a -> 'b) -> 'a MyList -> 'b MyList