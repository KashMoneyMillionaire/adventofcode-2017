﻿// Learn more about F# at http://fsharp.org

open Utilities
open System

[<EntryPoint>]
let main argv =
    let input = Ut.SplitLinesSplitOn(',')
    printfn "%A" input
    0 // return an integer exit code
    

