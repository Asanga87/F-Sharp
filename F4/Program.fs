open System

let Main_func()=
    
    let rand_list =[1;2;3]

    let rand_list_2 = List.map (fun x -> x * 2) rand_list

    printfn "Doublie List %A" rand_list_2

Main_func()

Console.ReadKey() |> ignore