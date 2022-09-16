string[] Sequence(string[] seq)
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

void OutputSequence(string[] seq)
{
    for (int i =0; i < seq.Length; i++)
    {
        Console.Write($" {seq[i]}, ");
    }
}

string[] rows = {"as", "asdfgh", "asd"};

OutputSequence(Sequence(rows));
