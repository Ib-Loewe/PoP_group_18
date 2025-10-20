#load "MyList.fs"
open MyList

let list = Something (1, Something (2, Something (3, Something (4, Something (5, Something(6, Empty))))))

printfn "Length: %A" (length list)
printfn "Take: %A" (take 4 list)
printfn "Drop: %A" (drop 4 list)
printfn "Map: %A" (map (fun item -> string (item * 2)) list)

