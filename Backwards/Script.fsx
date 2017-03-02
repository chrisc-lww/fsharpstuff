open System.Drawing
open System.IO
open System

let naiveLine (x0, y0) (x1, y1) color (bitmap:Bitmap) =
    let xLen = float (x1-x0)
    let yLen = float (y1-y0)

    let x0,y0,x1,y1 = if x0 > x1 then x1,y1,x0,y0 else x0,y0,x1,y1
    if xLen <> 0.0 then
        for x in x0..x1 do
            let proportion = float (x - x0) / xLen
            let y = int (Math.Round(proportion * yLen)) + y0
            printfn "%i" y
            bitmap.SetPixel(x,y, color)

    let x0,y0,x1,y1 = if y0 > y1 then x1,y1,x0,y0 else x0,y0,x1,y1  
    if yLen <> 0.0 then  
        for y in y0..y1 do
            let proportion = float (y - y0) / yLen
            let x = int (Math.Round(proportion * xLen)) + x0
            printfn "%i" x
            bitmap.SetPixel(x,y, color)

let pathAndfileName = 
    Path.Combine(__SOURCE_DIRECTORY__, "envelope2.png")

let bitmap = new Bitmap(33,26)  

//naiveLine (1,1) (25,2)  Color.Orange bitmap

//envelope

//fill in envelope background
let fill color (bitmap:Bitmap) =
    for x in 0..bitmap.Width-1 do
        for y in 0..bitmap.Height-1 do
        bitmap.SetPixel(x,y, color)
fill Color.Purple bitmap    

naiveLine (1,1) (31,1)  Color.Green bitmap
naiveLine (31,1) (31,24)  Color.Green bitmap
naiveLine (31,24) (1,24)  Color.Green bitmap
naiveLine (1,24) (1,1)  Color.Green bitmap
naiveLine (2,2) (16,16)  Color.Green bitmap
naiveLine (16,16) (31,1)  Color.Green bitmap

bitmap.Save(pathAndfileName)










