string[] CreateStringArray()
{
    string[] array={"Hello", "2", "world", ":-)"};
    //string[] array={"1234", "1567", "-2", "computer science"};
    //string[] array={"Russia", "Denmark", "Kazan"};
    return array;
}

void PrintStringArray(string[] array)
{
    for (int i=0;i<array.Length;i++){
        Console.Write($"{array[i]} ");
    }
}

string[] ParseStringArray(string[] array,int amountChar)
{
    int sizeNewArray=0;
    for(int i=0;i<array.Length;i++){
        if (array[i].Length<=amountChar)
        {
            sizeNewArray++;
        }
    }
    string[] newArray=new string[sizeNewArray];
    int index=0;
    for(int i=0;i<array.Length;i++){
        if (array[i].Length<=amountChar)
        {
            newArray[index]=array[i];
            index++;
        }
    }
    return newArray;
}

int amountChar=3;
string[] array=CreateStringArray();
array=ParseStringArray(array,amountChar);
PrintStringArray(array);
