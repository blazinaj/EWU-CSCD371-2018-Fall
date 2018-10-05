using System;

namespace Assignment2
{
    public class SimpleCalculator
    {
        public static void Main(string[] args)
        {
            bool doAgain = false;
            do
            {
                Console.WriteLine("Welcome to Simple Calculator, please enter an expression to evaluate");
                string inputString = Console.ReadLine();
                string outputResult = 
            } while (doAgain);
        }

        public static string[] InfixConverter(string[] infix)
        {
            //Create temp stack for holding operators
            var tempStack = new Stack<string>();
            //Create stack that will hold the completed postfix expression
            var postfixStack = new Stack<string>();
            //Create temp string to pass a character around
            var tempString = "";

            //Main for loop to walk through infix expression and convert it to postfix
            for (int i = 0; i < infix.Length; i++)
            {
                //Check if current character is NOT an operator
                if ( !( "+-/*()" ).Contains( infix[ i ] ) )
                {
                    //If current character is NOT an operator, push to postfix stack
                    postfixStack.push( infix[ i ] );
                }
                //If current character IS an operator
                else
                {
                    //Check if current character is a left parens '('
                    if ( infix[ i ].equals( "(" ) )
                    {
                        //If current character is a left parens '(', push to the temp operator stack
                        tempStack.push( infix[ i ] );
                    }

                    //Check if current character is right parens ')'
                    else if ( infix[ i ].equals( ")" ) )
                    {
                        //If current character is right parens ')', pop from temp operator stack and set it to temp string
                        tempString = tempStack.pop();
                        //While loop to walk through the rest of the tempString until the closing parens is found '('
                        while ( !( tempString.Equals( "(" ) ) )
                        {
                            //If tempString does not equal left parent '(', push that character to the postfix stack
                            postfixStack.push( tempString );
                            //Then pop the top character off of the temp operator stack and set it to the tempString
                            tempString = tempStack.pop(); 
                        }
                    }

                    //Finally, current character should now be a proper operator ( + - * /)
                    else
                    {
                        //While loop to walk through the temp operator stack
                        while ( tempStack.count > 0)
                        {
                            //Pop top operator on temp operator stack and assign it to tempString
                            tempString = tempStack.pop();
                            //Check if tempString operator has higher than or equal precedence than the current character (operator)
                            if (CalculatePrecedence( tempString ) >= CalculatePrecedence( infix[ i ] ) )
                            {
                                //If tempString operator has greater precedence than the current character operator, push it to postfixStack
                                postfixStack.push(tempString);
                            }
                            else
                            {
                                //If tempString operator has less precedence than the current character operator, push it to the temp operator stack
                                tempStack.push( tempString );
                            }
                        }
                        //When walked down to last operator in the temp operator stack, push the current character operator to the temp operator stack
                        tempStack.push( infix[ i ] );
                    }
                }
            }

            //After the main for loop, if temp operator stack is not empty, pop the stack and push the item to the postfix stack, repeat until empty
            while ( tempStack.count > 0 )
            {
                postfixStack.push( tempStack.pop() );
            }

            //Post fix stack will be backwards, reverse it, and then convert the stack to an array and return it.
            return postfixStack.Reverse.ToArray();
        }
    }
}
