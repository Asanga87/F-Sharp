open System

let Hello()= 
    printf "Enter Your Name :"

    let PI= float32 (Console.ReadLine())

    printfn "Hello %.4f" PI

Hello()

Console.ReadKey() |> ignore