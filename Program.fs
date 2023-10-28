// Learn more about F# at http://fsharp.org

open System

let quadrado numero = 
    numero * numero

let somaQuadrado =
    [1..10] |> List.map quadrado |> List.sum
    
let ePar numero =
    if numero % 2 = 0 then 
        2
    else 
        0

let modulo numero = 
    if numero <= 0 then
        numero * -1
    else 
        numero

let media numero1 numero2 = 
    (numero1 + numero2) / 2

let menorValor numero1 numero2 numero3 = 
    if numero1 < numero2 && numero1 < numero3 then 
        numero1
    else
        if numero2 < numero3 then
            numero2
        else 
            numero3
            

let  triangulo lado1 lado2 lado3 = 
    if lado1 = lado2 && lado2 = lado3 then
        "EQUILÁTERO"
        0
    else 
        if lado1 = lado2 || lado2 = lado3 || lado3 = lado1 then
            "ISÓSCELES"
            1
        else 
            "ESCALENO"
            2

[<EntryPoint>]
let main argv =
    printfn "O quadrado do numero é: %i" (quadrado 5)
    printfn "Modulo do valor é: %i" (modulo 2)
    printfn "Media dos valores é: %i" (media 10 10)
    printfn "Menor valor é: %i" (menorValor 0 1 -1)
    printfn "Menor valor é: %i" (triangulo 0 1 1)

    0 // return an integer exit code
