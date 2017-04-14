//
// F# program to compute windchills.
//
// Joey Nelson
//

#light

[<EntryPoint>]
let main argv = 
  printf "Please enter temperature (degrees F): "
  let input = System.Console.ReadLine()
  let T = System.Convert.ToDouble(input)

  printf "Please enter max wind speed (MPH): "
  let input = System.Console.ReadLine()
  let MaxWS = System.Convert.ToDouble(input)

  let WS = [1.0 .. MaxWS]
  let windchills = List.map(fun W -> Functions.windchill T W) WS
  
  printfn ""
  printfn "Windchills:"
  printfn "%A" windchills
  printfn ""
  printfn ""
  0
