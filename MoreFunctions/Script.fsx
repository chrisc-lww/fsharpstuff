// bob, sam

let childAges = 2,4

let addChildAges ages = 
    let bob, sam = ages
    bob + sam

//printfn "%A" (addChildAges childAges)
addChildAges childAges

let addAges dave mick = 
    dave + mick

let fnChildAges bob = 
    let addSamsAgeToBobs sam =
        bob + sam
    addSamsAgeToBobs

let samsFn = fnChildAges 34

samsFn 41

addAges 23 52

//calculate the area of a triangle (height * width / 2)
//fn
let areaTriangle height width =
    (height * width) / 2

areaTriangle 30 60

// partial function - this will give one input so a temp function will be created to await the 2nd input
areaTriangle 22

// the temp function is called 'it', so we can run thsi with the 2nd input and this will gie the same result as if we had given two inputs to the areaTrianlge function last time.
it 7



