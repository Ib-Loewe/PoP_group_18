module MyList

type 'a MyList = 
    |Empty 
    |Something of 'a * 'a MyList


//Takes an integer n and a MyList, and returns a MyList of the first n elements in the original list.
let rec take (n, lst : 'a MyList) : 'a Mylist = 


//Takes an integer n and a MyList, and returns a MyList without the first n elements of the original list.
let rec drop (n, lst : 'a MyList) : 'a Mylist =

//Takes a MyList and returns the number of elements in the list.
let rec length (lst: 'a MyList) : int = 


//Takes a function, and a MyList and returns a MyList with the function applied to each element.
let rec map (f, lst : 'a MyList) : 'b MyList = 