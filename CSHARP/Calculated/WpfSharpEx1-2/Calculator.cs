using System;
using System.Threading.Tasks;

namespace WpfSharpEx1_2
{
    class Calculator
    {
        public string LastLine { get; private set; }
        public string PreCalculateLine { get; private set; }

        private Calculator() {
            PreCalculateLine = "";
            LastLine = "";
        }

        public static Calculator Create() => new Calculator();

        //считает, и возвращает
        public string Calculate(string calculateString, string errorMessage)
        {
            try
            {
                return CalculateSecond(CalculateFirst(LastLine = calculateString));
            }
            catch
            {
                return errorMessage;
            }
        }

        //считает в потоке, и записывает в PreCalculateLine
        public void PreCalculate(string calculateString)=>
            Task.Run(() => PreCalculateLine = Calculate(calculateString, ""));
        
        //считает умножения и деления
        private string CalculateFirst(string calculateLine)
        {
            for (int i = 0; i < calculateLine.Length; i++)
                if (calculateLine[i] == '*' || calculateLine[i] == '/')
                {
                    string firstNumber = "", secondNumber = "";
                    int firstI = 0, lastI = calculateLine.Length - 1;
                    int tempI = i - 1;

                    while(tempI >= 0 && calculateLine[tempI] != '*' && calculateLine[tempI] != '/')
                    {                      
                        if(calculateLine[tempI] == '-' || calculateLine[tempI] == '+')
                            if(tempI != 0)
                                if (calculateLine[tempI - 1] >= 48 && calculateLine[tempI - 1] <= 57) break;

                        firstNumber += calculateLine[tempI];
                        firstI = --tempI;
                    }

                    firstNumber = firstNumber.StringReverse();

                    tempI = i + 1;

                    while (tempI < calculateLine.Length && calculateLine[tempI] != '*' && calculateLine[tempI] != '/')
                    {
                        if (calculateLine[tempI] == '-' || calculateLine[tempI] == '+')
                            if (tempI != 0)
                                if (calculateLine[tempI - 1] >= 48 && calculateLine[tempI - 1] <= 57) break;

                        secondNumber += calculateLine[tempI];
                        lastI = ++tempI;
                    }

                    double result = 0;

                    switch (calculateLine[i])
                    {
                        case '*':
                            result = Double.Parse(firstNumber) * Double.Parse(secondNumber);
                            break;
                        case '/':
                            result = Double.Parse(firstNumber) / Double.Parse(secondNumber);
                            break;
                        default:
                            break;
                    }

                    calculateLine = CalculateFirst(calculateLine.InsertInLine(result.ToString(), firstI, lastI));

                    break;
                }

            return calculateLine;
        }

        //считает плюсы и минусы
        private string CalculateSecond(string calculateLine)
        {
            for (int i = 0; i < calculateLine.Length; i++)
                if (calculateLine[i] == '+' || calculateLine[i] == '-')
                {
                    if (i == 0) continue;

                    string firstNumber = "", secondNumber = "";
                    int firstI = 0, lastI = calculateLine.Length - 1;
                    int tempI = i - 1;

                    while (tempI >= 0 && calculateLine[tempI] != '*' && calculateLine[tempI] != '/')
                    {
                        if (calculateLine[tempI] == '-' || calculateLine[tempI] == '+')
                            if (tempI != 0)
                                if (calculateLine[tempI - 1] >= 48 && calculateLine[tempI - 1] <= 57) break;

                        firstNumber += calculateLine[tempI];
                        firstI = --tempI;
                    }

                    firstNumber = firstNumber.StringReverse();

                    tempI = i + 1;

                    while (tempI < calculateLine.Length && calculateLine[tempI] != '*' && calculateLine[tempI] != '/')
                    {
                        if (calculateLine[tempI] == '-' || calculateLine[tempI] == '+')
                            if (tempI != 0)
                                if (calculateLine[tempI - 1] >= 48 && calculateLine[tempI - 1] <= 57) break;

                        secondNumber += calculateLine[tempI];
                        lastI = ++tempI;
                    }

                    double result = 0;

                    if (firstNumber != string.Empty && secondNumber != string.Empty)
                    {
                        switch (calculateLine[i])
                        {
                            case '+':
                                result = Double.Parse(firstNumber) + Double.Parse(secondNumber);
                                break;
                            case '-':
                                result = Double.Parse(firstNumber) - Double.Parse(secondNumber);
                                break;
                            default:
                                break;
                        }
                    }
                    else break;
                    
                    calculateLine = CalculateSecond(calculateLine.InsertInLine(result.ToString(), firstI, lastI));

                    break;
                }

            return calculateLine;
        }
    }
}
