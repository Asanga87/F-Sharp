﻿open System

let Main_func()=
    
    let rand_list =[1;2;3]


    printfn "Doublie List %A" rand_list_2

    [5;6;7;8]
    |> List.filter (fun v ->(v%2)=0)
    |> List.map (fun x-> x*2)
    |> printfn"Even Double %A"

Main_func()

