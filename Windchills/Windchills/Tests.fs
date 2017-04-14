//
// F# program to compute windchills.
//
// Joey Nelson
//

#light

module Tests

open NUnit.Framework

[<TestFixture>] 
type Tests() =

  [<Test>] 
  member this.Windchill_Test_01() = 
    let R = Functions.windchill 0.0 25.0 
    let Correct = -24.05009 
    Assert.IsTrue(System.Math.Abs(R-Correct) < 0.0001)

  [<Test>]
  member this.Windchill_Test_02() =
    let R = Functions.windchill 12.0 23.0 
    let Correct = -7.536563229
    Assert.IsTrue(System.Math.Abs(R-Correct) < 0.0001) 

  [<Test>]
  member this.Windchill_Test_03() =
    let R = Functions.windchill 3.0 12.0
    let Correct = -13.70986984
    Assert.IsTrue(System.Math.Abs(R-Correct) < 0.0001)

