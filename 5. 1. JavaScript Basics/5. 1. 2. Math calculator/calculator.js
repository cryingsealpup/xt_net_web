"use strict";
function calculate(stringValue)
{
    let result = 0;
    let expression = stringValue.match(/(\d+\.\d+)|(\d+)|(\+|\-|\/|\*|\=)/g);

    if (expression[0] !== NaN) result += Number(expression[0]);

    for (let i = 0; i < expression.length; i++)
    {
        switch (expression[i])
        {
            case "+": 
                result += Number(expression[i + 1]);
                break;
            case "-": 
                result -= Number(expression[i + 1]);
                break;
            case "*": 
                result *= Number(expression[i + 1]);
                break;
            case "/": 
                result /= Number(expression[i + 1]);
                break;
            case "=":
                return result.toFixed(2);
        }
    }
}


console.log(calculate("3.5 +4*10-5.3 /5 ="));