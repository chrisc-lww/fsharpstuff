open System.Drawing

let bitmap = new Bitmap(70,70)

let path = __SOURCE_DIRECTORY__ + "/"

bitmap.SetPixel(20,20, Color.GreenYellow)
bitmap.SetPixel(20,21, Color.GreenYellow)
bitmap.SetPixel(21,20, Color.GreenYellow)
bitmap.SetPixel(21,21, Color.GreenYellow)

bitmap.SetPixel(40,20, Color.GreenYellow)
bitmap.SetPixel(40,21, Color.GreenYellow)
bitmap.SetPixel(41,20, Color.GreenYellow)
bitmap.SetPixel(41,21, Color.GreenYellow)

//nose
bitmap.SetPixel(30,40, Color.DarkOrange)
bitmap.SetPixel(30,41, Color.DarkOrange)
bitmap.SetPixel(31,40, Color.DarkOrange)
bitmap.SetPixel(31,41, Color.DarkOrange)
bitmap.SetPixel(32,40, Color.DarkOrange)
bitmap.SetPixel(32,41, Color.DarkOrange)
bitmap.SetPixel(33,40, Color.DarkOrange)
bitmap.SetPixel(33,41, Color.DarkOrange)

bitmap.SetPixel(10,50, Color.Red)
bitmap.SetPixel(11,51, Color.Red)
bitmap.SetPixel(12,52, Color.Red)
bitmap.SetPixel(13,53, Color.Red)
bitmap.SetPixel(14,54, Color.DarkOrange)
bitmap.SetPixel(15,55, Color.DarkOrange)
bitmap.SetPixel(16,55, Color.DarkOrange)
bitmap.SetPixel(17,55, Color.DarkOrange)
bitmap.SetPixel(18,55, Color.DarkOrange)
bitmap.SetPixel(19,55, Color.DarkOrange)
bitmap.SetPixel(20,55, Color.DarkOrange)
bitmap.SetPixel(21,55, Color.DarkOrange)
bitmap.SetPixel(22,55, Color.DarkOrange)
bitmap.SetPixel(23,55, Color.DarkOrange)
bitmap.SetPixel(24,55, Color.DarkOrange)
bitmap.SetPixel(25,55, Color.DarkOrange)
bitmap.SetPixel(26,55, Color.DarkOrange)
bitmap.SetPixel(27,55, Color.DarkOrange)
bitmap.SetPixel(28,55, Color.DarkOrange)
bitmap.SetPixel(29,55, Color.DarkOrange)
bitmap.SetPixel(30,55, Color.DarkOrange)
bitmap.SetPixel(31,55, Color.DarkOrange)
bitmap.SetPixel(32,55, Color.DarkOrange)
bitmap.SetPixel(33,55, Color.DarkOrange)
bitmap.SetPixel(34,55, Color.DarkOrange)
bitmap.SetPixel(35,55, Color.DarkOrange)
bitmap.SetPixel(36,55, Color.DarkOrange)
bitmap.SetPixel(37,55, Color.DarkOrange)
bitmap.SetPixel(38,55, Color.DarkOrange)
bitmap.SetPixel(39,55, Color.DarkOrange)
bitmap.SetPixel(40,55, Color.DarkOrange)
bitmap.SetPixel(41,55, Color.DarkOrange)
bitmap.SetPixel(42,55, Color.DarkOrange)
bitmap.SetPixel(43,55, Color.DarkOrange)
bitmap.SetPixel(44,55, Color.DarkOrange)
bitmap.SetPixel(45,55, Color.DarkOrange)
bitmap.SetPixel(46,54, Color.DarkOrange)
bitmap.SetPixel(47,53, Color.Red)
bitmap.SetPixel(48,52, Color.Red)
bitmap.SetPixel(49,51, Color.Red)
bitmap.SetPixel(50,50, Color.Red)

bitmap.Save(path + "plot.png")




