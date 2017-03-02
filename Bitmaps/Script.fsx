open System.Drawing


// 16 x 16 bitmap
let bitmap = new Bitmap(16,16)

let path = __SOURCE_DIRECTORY__ + "/"

bitmap.Save(path + "bitmap.png")

// 32 x 32 bitmap
let large = new Bitmap(32,32)

let largePath = __SOURCE_DIRECTORY__ + "/"

bitmap.Save(largePath + "largebitmap.png")






