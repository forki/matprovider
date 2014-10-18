﻿System.IO.Directory.SetCurrentDirectory(__SOURCE_DIRECTORY__)

#r "../../lib/zlib.net.dll"
#r "bin/Debug/MatDataProvider.dll"

open MatDataProvider

[<Literal>]
let fileName = "/Users/natallie/projects/matprovider/data/varTypes.mat"

type M = MatDataProvider.MatFile<fileName>

let inline print x = printfn "Type: %A  |  Values: %A" (x.GetType()) x

print M.x.bools
print M.y.doubleint32
print M.z.scalar
print M.z.arr2d
print M.z.arr4d.[3].[1].[0].[2] 

//Output:
//Type: System.Boolean[]  |  Values: [|true; false|]
//Type: System.Double[]  |  Values: [|2147483647.0; 0.0; -2147483648.0|]
//Type: System.Double  |  Values: 42.0
//Type: System.Double[][]  |  Values: [|[|11.0; 12.0|]; [|21.0; 22.0|]|]
//Type: System.Double  |  Values: 4213.0
