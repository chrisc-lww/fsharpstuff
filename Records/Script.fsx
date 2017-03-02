let person = ("Chris", "Clancy", "Red Sox", 27)

type Date = {
    day    : int
    month  : int
    year   : int 
}

type Person = {
    firstName   : string
    lastName    : string
    favClub     : string
    myAge       : int
    dateOfBirth : Date
}

let me = { 
    firstName = "Chris"
    lastName = "Clancy"
    favClub = "Spurs"
    myAge = 23 
    dateOfBirth = {day=1;month=1;year=1900}
}
let ageTest = me.myAge

let { firstName=myFirstName } = me // clone record elements
let { lastName=myLastName } = me 
let { favClub=myFavClub } = me 
let { myAge=myNewAge } = me 

let myFullName = me.firstName + " " + me.lastName

let temp = { me with myAge = 30 }

let updateDOB person birthday =
    let updated = { person with dateOfBirth = birthday }
    printfn "%A" updated
    printfn "%A" person
    updated


















