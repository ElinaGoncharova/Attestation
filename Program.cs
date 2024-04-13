string [] Array = {"1234", "1567", "-2", "computer science"};
string [] newArray = new string[Array.Length];
int count = 0;
{
    foreach (string str in Array)
    {
        if (str.Length <= 3)
        {
            newArray[count] = str;
            count++;
        }
    }

}
{
    {
        for (int i = 0; i < newArray.Length; i++)
        Console.Write(newArray[i] + " ");
    }
}