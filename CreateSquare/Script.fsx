open System.Drawing
open System.IO

let bitmap = new Bitmap(32,32)

let pathAndFileName 
    = Path.Combine(__SOURCE_DIRECTORY__, "square.png")

let squareInner () = 
    for x in 8..24 do bitmap.SetPixel(x, 8, Color.Red)
    for x in 8..24 do bitmap.SetPixel(x, 24, Color.Red)
    for y in 8..24 do bitmap.SetPixel(8, y, Color.Red)
    for y in 8..24 do bitmap.SetPixel(24, y, Color.Red)

let squareOuter () = 
    for x in 2..30 do bitmap.SetPixel(x, 2, Color.DarkOrange)
    for x in 2..30 do bitmap.SetPixel(x, 30, Color.DarkOrange)
    for y in 2..30 do bitmap.SetPixel(2, y, Color.DarkOrange)
    for y in 2..30 do bitmap.SetPixel(30, y, Color.DarkOrange)

squareInner()
squareOuter()

bitmap.Save(pathAndFileName)







