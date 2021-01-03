using System;
using System.Data.SqlClient;
using System.Configuration;



namespace Corona_console
{
    class Program
    {
      
        static void Main(string[] args)

        {

            person p1 = new person(4, "zack", "dd5565", 06251478, "zaaz", "dkkjjf");
            Persistance per = new Persistance();
            per.Addperson(p1);


            
            }
    }

   
}
    
    


