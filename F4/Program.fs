open System

module coding=
    let votingage=18
    printfn "How old are you?"
    let yourage= Convert.ToInt32 (Console.ReadLine())
    let validevoter age minage=
    if age > minage then " eligible to vote"
    elif age< minage then "not eligible to vote"
    else  "Just old enough"

module counting=
    let charcount (word:string)=
    if word.Length=0 then
        None
    else

    let mutable count=0
    for i in word do
        count <- count+1  
    Some(count)

module yearcountong=
    let termlimt()=
        for i=0 to 4 do
        printfn $"Prasident is in {i} year of service"

    let findremaining cterm=

        let mutable inoffice= true
        while inoffice do
            for i=cterm to 5 do
                printfn $"Prasident is in {i} year of service"
            printfn $"Prasident is in permanent vacation"
            inoffice <- false


      
    let termcalculation cutermno=
        if cutermno>5 then 
            printfn $"Enter correct year count"
        else
        let remainingyears = 5- cutermno
    
        printfn $"Praisdent has only {remainingyears} years to serve" 
        remainingyears
        |> findremaining 
            

module run=
    open coding
    open counting
    open yearcountong
    let result= validevoter yourage votingage
    printfn $"You are {result}"
    let countno= charcount result
    printfn $"{countno}" 
    termlimt()
   // findremaining 
    termcalculation (Convert.ToInt32(Console.ReadLine()))

