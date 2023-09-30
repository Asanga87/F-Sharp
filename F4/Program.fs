open System

let Main_func()=

    let rec factorial x=
        if x<1 then 1
        else x * factorial (x-1)

    printfn "Factorial of your Number is %i" (factorial (int32(Console.ReadLine())))


Console.ReadKey() |> ignore