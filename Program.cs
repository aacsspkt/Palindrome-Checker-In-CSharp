// running program
run();


void run()
{
    Console.Clear();
    // ask for input
    Console.Write("Enter a value to check palindrome: ");

    // capture input
    string? input = Console.ReadLine();
    if (!string.IsNullOrEmpty(input))
    {
        string output = isPalindrome(input) ? "It is a palindrome" : "It is not palindrome";
        Console.WriteLine(output);
    }
    else
    {
        run();
    }



}

bool isPalindrome(string input)
{
    // len is length of input value 
    int len = input.Length;

    // looping up to half of length of string
    for (int i = 0; i < len / 2; i++)
    {
        // if first not equals last it is not palindrome;
        if (input[i] != input[len - i - 1]) return false;
    }

    // if method does not return false till now then it is palindrome.
    return true;
}


