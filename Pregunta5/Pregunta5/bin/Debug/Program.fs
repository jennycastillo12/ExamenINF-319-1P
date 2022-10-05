// Más información acerca de F# en http://fsharp.net
// Vea el proyecto "Tutorial de F#" para obtener más ayuda.

open System


let suma a b = a + b
let resta a b = a - b
let multi a b = a * b
let div a b = a / b

[<EntryPoint>]
let main argv = 
 
    Console.WriteLine("Instroduzca el primer número")
    let num1=Console.ReadLine()
    Console.WriteLine("Instroduzca el segundo número")
    let num2=Console.ReadLine()
    let valor1=Convert.ToInt32(num1)
    let valor2=Convert.ToInt32(num2)
    let valor3=suma valor1 valor2
    let valor4=resta valor1 valor2
    let valor5=multi valor1 valor2
    let valor6=div valor1 valor2
    Console.WriteLine("La suma de:"+num1+"+"+num2+"= "+valor3.ToString())
    Console.WriteLine("La resta de:"+num1+"-"+num2+"= "+valor4.ToString())
    Console.WriteLine("La multiplicación de:"+num1+"*"+num2+"= "+valor5.ToString())
    Console.WriteLine("La división de:"+num1+"/"+num2+"= "+valor6.ToString())
    let tecla=Console.ReadKey()
    0 // devolver un código de salida entero