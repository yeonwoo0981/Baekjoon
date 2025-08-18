while (true)
{
    string str = Console.ReadLine();
    
    if (str == ".")
        break;
        
    Stack<char> stack = new Stack<char>();
    bool shadowAndLight = true;
    
    foreach(char c in str)
    {
        if(c == '(' || c == '[')
            stack.Push(c);
        else if(c == ')' || c == ']')
        {
            if(stack.Count == 0)
            {
                shadowAndLight = false;
                break;
            }
            char top = stack.Pop();
            if((c == ')' && top != '(') || (c == ']' && top != '['))
            {
                shadowAndLight = false;
                break;
            }
        }
    }
    
    if(stack.Count > 0)
        shadowAndLight = false;
        
    Console.WriteLine(shadowAndLight ? "yes" : "no");
}