# ResDiary Challenge

## Solution Structure
There are 3 projects within the solution:

1. ResDiaryChallenge - This contains the extension method to split an array into equal sided groups.
2. ResDiaryChallenge.ConsoleApp - This contains a console application that calls the extension method on sample array.
3. ResDiaryChallenge.Tests - This contains the tests.

## How it works
1. We divide the source array by the number of groups specified to get the equal group size.
2. We use the modulo operator to get the remainder. If there is a remainder, it needs to be spread across the groups until there is no remainder left.
3. We create a new blank 2D result array. We know the number of groups that will be in the result so we set the result array size now so that we aren't constantly resizing the array.
4. We loop through the number of groups we'll need:
   5. We set the subgroup size. If there is still a remainder do be distributed we add it to this size.
   6. We create the new subgroup and add it to the result array.
   7. We iterate through the source array, starting at `nextStartIndex` and add each value to the subgroup until we reach the subgroup length
   8. We set the `nextStartIndex` appropriately so we can iterate through next group of values
7. We return the result.


## Run the example console application
### Terminal (Linux)
1. Go to the ResDiaryChallenge.ConsoleApp direct in your terminal
2. Run `dotnet publish`
3. Run `./bin/Debug/net7.0/ResDiaryChallenge.ConsoleApp`

### Rider/Visual Studio
1. Open the solution in Rider/Visual Studio
2. Right click ResDiaryChallenge.ConsoleApp and Run