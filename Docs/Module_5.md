###  Methods in C# Console Applications

1. create method in C#
    To create the method signature, you declare the return type, method name, and parameters. Create the method body by using brackets {} that contain the code.
    eg: 
      i> Void DisplayRandomNumbers();  //method declaration
      
      ii> Method Definition  
       void DisplayRandomNumbers() 
        {
            Random random = new Random();
        }

        iii> call the method
        - DisplayRandomNumbers();