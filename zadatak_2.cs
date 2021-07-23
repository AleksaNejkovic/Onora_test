using System;
class Numbers {
   static void Main() {

     int x, y, startNum, endNum;

     Console.Write("Unesite prvi broj kojim želite da se deli: ");
     x = Convert.ToInt32(Console.ReadLine());
     SimpleValidationX(x);
     Console.Write("Unesite drugi broj kojim želite da se deli: ");
     y = Convert.ToInt32(Console.ReadLine());
     SimpleValidationX(y);
     Console.Write("Unesite broj od koga će početi ispitivanje: ");
     startNum = Convert.ToInt32(Console.ReadLine());
     SimpleValidationX(startNum);

     Console.Write("Unesite broj do kog će se vršiti ispitivanje: ");
     endNum = Convert.ToInt32(Console.ReadLine());
     SimpleValidationY(endNum ,startNum);

     Console.WriteLine();

     Console.Write(BumBam(startNum,endNum,x,y));

   }

   public static string BumBam(int startNum, int endNum, int x, int y){

       string sub = "";

       for(int br = startNum; br <= endNum; br++){
             sub += (br % x == 0 && br % y == 0) ? "BumBam " : ((br % x == 0) ? "Bum " : ((br % y == 0) ? "Bam " : br+" "));
         }
       return sub;

   }
   public static void SimpleValidationX(int x){

       if(x == 0 || x < 0)
       {
         Console.Write("Morate uneti broj koji je veći od 0 i koji nije negativan!");
         System.Environment.Exit(1);

       }
   }
   public static void SimpleValidationY(int y,int x){

       if(x > y || y < 0 || y == 0)
       {
         Console.Write("Morate uneti broj koji je veći od broja koji označava početak i koji nije negativan i nije 0!");
         System.Environment.Exit(1);
       }
   }

}
