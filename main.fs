open System
//
// Main program for testing hw #03 functions.
//
// <<YOUR NAME>>
// U. of Illinois, Chicago
// CS 341, Fall 2023
//
open homework

//##################################################################
//
// main
//
// Compiles the simple C program; the filename is input by the user.
//
[<EntryPoint>]
let main argv =
   printfn "** Starting **"
   printfn ""
   //
   let L1 = [1; 2; 3]
   let L2 = [1..5]
   printfn "L1: %A" L1
   printfn "L2: %A" L2
   printfn "Subset(L1,L2): %A" (hw03.subset L1 L2)
   //
   printfn ""
   printfn "** Done **"
   0

