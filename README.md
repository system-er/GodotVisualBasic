# GodotVisualBasic    
VisualBasic through C# for Godot4 (tested with Godot4.3 mono win64).   
i found several examples for F# through C# but not for VisualBasic (searched with google and in the forum)    
So i tried to get it to work, heres the first test.     
like F# you can use another language without GDExtension!    

i made a benchmark and the result is that Visual Basic is 30times faster than gdscript (see example benchmark)    


# HowTo:    
0. use this exampleproject for start or:    
1. create with Godot4* mono a new project (mono cause we use C#) for example a node2d    
2. add a C#-script
3. open VisualStudio, add a new VisualBasicProject to projectmap (select in the same directory, select .NET 6.0)
4. in the first project add the VisualBasicProject as reference
5. in the VisualBasicProject add in the references to the packets the packet GodotSharp
6. create in your VisualBasicClass methods for _Ready and so on and start them from the C#-methods - now you can continue in VisualBasic...    


# Examples:   
- 2D, Sprite2D, comparable to the GDExtension-demo, https://github.com/system-er/GodotVisualBasic_example_2D_Sprite2D
- 2D, Draw, benchmark drawing mandelbrot, https://github.com/system-er/GodotVisualBasic_example_benchmark_mandelbrot     

  
# Last changes:    
- Added first example 2D, Sprite2D, comparable to the GDExtension-demo
- Added a constructor in VisualBasic class
  

  
