string[] Sequence(string[] seq) // Возвращает массив строк, в котором строки <= 3
{
    int quantity = 0;
    for (int i = 0; i < seq.Length; i++)
    {
        if (seq[i].Length <= 3) quantity++;
    }
    string[] newSeq = new string[quantity];
    quantity = 0;
    for (int j = 0; j < seq.Length; j++)
    {
        if (seq[j].Length <= 3)
        {
            newSeq[quantity] = seq[j];
            quantity++;
        }
    }
    return newSeq;
}

void OutputSequence(string[] seq) // Выводит в консоль массив строк
{
    string result = string.Join(", ", seq);
    Console.Write(result);
}

string[] SequenceRandomString(int sizeSequence) //Создает массив строк случайного размера и из случайных букв
{
    string alphanumeric = "qwertyuiopasdfghjklzxcvbnm";
    string secondRows = string.Empty;
    string[] sequence = new string[sizeSequence];
    for (int j = 0; j < sizeSequence; j++)
    {
        int sizeString = new Random().Next(1, 10);
        for (int i = 0; i < sizeString; i++)
        {
            int randomLetter = new Random().Next(0, alphanumeric.Length);
            secondRows += alphanumeric[randomLetter];
        }
        sequence[j] = secondRows;
        secondRows = string.Empty;
    }
    return sequence;
}

OutputSequence(Sequence(SequenceRandomString(10)));