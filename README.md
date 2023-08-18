# AstroMathTests
======= Steps ======
sln -> add new proj (Class Library(.NET Framework)) -> name: xxxTests - add reference(dll file) ->
NeGet.Packages -> install: 1.xunit, 2.xunit.runner.console, 3.xunit.runner.visualstudio

Then, under the new proj, add class -> method - nameconvention eg:
public void xxx_ShouldWork/Valid/etc()
{
// Arrange
...
// Act
...
// Assert
...
}

[Fact] VS [Theory] br [InlineData(input, input, output)]

NB: 1. change version framework: proj.properties -> change target framework
    2. refactor: change code w/o change input/output

    3.shorten name: proj -> add new item (JSON File) -> rename: xunit.runner.json -> properties: copy to output: copy it new   {methodDisplay: "method"} -> build sln -> close VS

Test edge case: [InlineData(double.MaxValue, 5, double.MaxValue)]

// Set an acceptable tolerance based on your precision requirements
const double tolerance = 0.005;
Assert.Equal(expected, actual, tolerance);

![image](https://github.com/2022Dong/AstroMathTests/assets/110579171/7de26926-48db-44d9-bc4b-d396f5da3949)
