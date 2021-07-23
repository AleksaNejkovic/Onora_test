using System;
class Drawing {
  static void Main() {
      
    int row, colElements;
    char c;
    
    Console.Write("Unesite broj elemenata koje želite u jednom redu (broj mora da bude neparan zbog simetričnosti same figure): ");
    colElements = Convert.ToInt32(Console.ReadLine());
    SimpleValidation(colElements);
    row=(colElements/2)+1;
    Console.Write("Na osnovu unetog broja elemenata broj redova će biti: " + row);
    Console.WriteLine();
    
    Console.Write("Unesite slovo kojim želite da počnete iscrtavanje: ");
    c=Convert.ToChar(Console.ReadLine());
    Console.WriteLine();
    
    DrawingFigure(row,colElements,c);
    
  }
  public static void SimpleValidation(int x){
      
      if(x % 2 == 0 || x < 0 || x == 0){
          Console.WriteLine("Morate uneti neparan broj zbog simetričnosti figure. Ne smete unositi 0 ili negativan broj!");
          System.Environment.Exit(1);
      }
      
  }
  public static void DrawingFigure(int row, int colElements, char c){
      
      char helpC=c;
      
      for (int i = 1; i <= row; i++){
          
          c=helpC;
          
          for (int j = 1; j <= colElements; j++){
              
              if (j <= (row+1) - i || j >= (row-1) + i){
                  
                  Console.Write(c);
                  if(j<row){
                      c++;
                  }
                  else{
                      c--;
                  }
                  
              }
              else{
                  
                  Console.Write(" ");
                  if(j==row){
                      c--;
                  }
                  
              }
          }
          Console.WriteLine();
      }
  }
}
