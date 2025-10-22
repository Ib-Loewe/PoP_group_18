module Pascal

// Takes a pair of natural numbers n and k, and returns the corresponding binomial coefficient for n choose k
// Returns 0 if n < 0, k < 0 or k > n
// Warning: Large numbers will result in stack overflow
// pascal: int * int -> int
val pascal: (int * int) -> int;

// Takes a pair of natural numbers n and k, and returns the corresponding binomial coefficient for n choose k
// Returns 0 if n < 0, k < 0 or k > n
// Warning: Large numbers will result in System.OutOfMemoryException.
// pascalNoRec: int * int -> int
val pascalNoRec: (int * int) -> int


