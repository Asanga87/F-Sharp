open System

let Main_func()=

    printfn "Enter Intiger number:"
    
    let gettnum= int32(Console.ReadLine())

    printfn "Enter Float  number:"

    let  floatnum= float(Console.ReadLine())

    printfn "Your number is %A" (gettnum.GetType())

    printfn "Sqrt of your number is %.2f" (sqrt (float(gettnum)))

    printfn "abs of your num is %i" (abs -1)

    printfn "Ceil of your num is %f" (ceil floatnum)

    printfn "floor of your num is %f" (floor floatnum)






    

Main_func()

Console.ReadKey() |> ignore