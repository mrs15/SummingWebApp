using MathWorks.MATLAB.NET.Arrays;

namespace DataAbstractionLayer
{
    public class Class1
    {
        //the web api requests a sum response by calling a method in this class
        //the method in this class will receive 2 parameters; the parameters will then be
        //used to call upon the matlab function
        //from here we call on the matlab dll

        //once a response is received from the matlab dll; the method of this class
        //will return the summed amount to the web api
        //the web api will send the response to the frontend

        public MWArray sum_result(int a, int b)
        {
            addNumbersAlgorithm.Class1 class1 = new addNumbersAlgorithm.Class1();
            MWArray result = class1.sum_func((MWArray)a, b);
            return result;

            
        }

        
        




    }
   
    


}