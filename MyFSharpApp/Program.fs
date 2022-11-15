// For more information see https://aka.ms/fsharp-console-apps
// Repeats a phrase n times:


// Define a new function to print a name.
let printGreeting name =
    printfn $"Hello {name} from F#!"

// Call the function.
//printGreeting "World"

// Define a new function to print a name n times.
let printGreetingNTimes name n =
    for i in 1..n do
        printGreeting name

// Call the function.
printGreetingNTimes "World" 5