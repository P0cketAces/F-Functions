//
// F# functions
//
// Joey Nelson
//

#light

module Functions

//
// fix:
//
let rec fix_helper LB UB L newL =
  if L = [] then
    List.rev(newL)
  else if L.Head > UB then
    fix_helper LB UB L.Tail (UB::newL)
  else if L.Head < LB then
    fix_helper LB UB L.Tail (LB::newL)
  else
    fix_helper LB UB L.Tail (L.Head::newL)

let rec fix LB UB L = 
  fix_helper LB UB L []


// 
// fix2:
//
let fix2 LB UB LL = 
  List.map(fun x -> fix LB UB x) LL


//
// reduce:
//
let rec reduce_helper F (L: 'a List) A =
  if L = [] then
    A
  else
    reduce_helper F L.Tail (F A L.Head)

let rec reduce F (L: 'a List) = 
  reduce_helper F L.Tail L.Head
  

//
// intAverage:
//
let intAverage L = 
  let s = List.sum L
  let l = List.length L
  s / l


//
// averages:
//
let averages SL LL = 
  let avg = List.map(fun x -> intAverage x) LL
  let final = List.zip SL avg
  final


// 
// histogram:
//
let rec hist_helper LB UB L num =
  if L = [] then 
    num
  else if L.Head < UB && L.Head >= LB then
    hist_helper LB UB L.Tail (num + 1)
  else if UB = 100 && L.Head <= 100 && L.Head >= 90 then
    hist_helper LB UB L.Tail (num + 1)
  else
    hist_helper LB UB L.Tail num

let histogram L = 
  let grade10 = hist_helper 0 10 L 0
  let grade20 = hist_helper 10 20 L 0
  let grade30 = hist_helper 20 30 L 0
  let grade40 = hist_helper 30 40 L 0
  let grade50 = hist_helper 40 50 L 0
  let grade60 = hist_helper 50 60 L 0
  let grade70 = hist_helper 60 70 L 0
  let grade80 = hist_helper 70 80 L 0
  let grade90 = hist_helper 80 90 L 0
  let grade100 = hist_helper 90 100 L 0
  let final = [grade10;grade20;grade30;grade40;grade50;grade60;grade70;grade80;grade90;grade100]
  final

    
  
  
