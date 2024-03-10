


using ClassPractice_07_03_2024.Helpers.Exceptions;

void Calculate()
{
    bool isCorrectCalculate = true;

    try
    {
        


        int[] arr = { 1, 2, 3 };
        //arr[5] = 100;


        int a = 5;
        int b = 0;
        //var result = a / b;
        //Console.WriteLine(result);

        //if(b == 0)
        //{
        //    Console.WriteLine("dont divide to zero");
        //    return;
        //}

    
    }
    //catch (DivideByZeroException ex)
    //{
    //    Console.WriteLine(ex.Message);
    //}
    //catch (IndexOutOfRangeException ex)
    //{
    //    Console.WriteLine(ex.Message);
    //}
    catch (Exception ex)
    {
        //Console.WriteLine(ex.Message);

        isCorrectCalculate = false;
    }
    finally
    {
        SendMessage(isCorrectCalculate);
    }


}

//Calculate();


void SendMessage(bool isCorrect)
{

    if (isCorrect)
    {
        Console.WriteLine("Your message sent successfully");
    }
    else
    {
        Console.WriteLine("Your message failed");
    }
}



string GetById(int? id)
{
    try
    {
        if (id == null)
        {
            //throw new ArgumentNullException("id");

            throw new CustomArgumentNullException("Argument cannot be null");
        }

        return "kamran bey";
    }
    catch (Exception ex)
    {

        return ex.Message;
    }
}

GetById(null);