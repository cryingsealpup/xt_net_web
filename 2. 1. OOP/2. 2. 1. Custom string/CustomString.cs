using System;
using System.Linq;
using System.Collections;
using System.Text;
using System.Runtime.InteropServices;
using System.Collections.Generic;

namespace Custom_string
{
    class CustomString
    {
        private char[] text;

        public CustomString() => text = new char[256];

        private CustomString(int length) => text = new char[length];

        public CustomString(char[] userInput)
        {
            text = new char[userInput.Length];
            for (int i = 0; i < userInput.Length; i++) text[i] = userInput[i];
        }

        public CustomString(string userInput)
        {
            text = new char[userInput.Length];
            for (int i = 0; i < userInput.Length; i++) text[i] = userInput[i];
        }

        public int length => text.Length;
        private int Length
        {
            get => text.Length;
        }

        public char this[int index] 
        {
            get => text[index]; 

            set => text[index] = value;
        }

        // Concatenation
        public static CustomString operator +(CustomString firstString, CustomString secondString)
        {
            CustomString newText = new CustomString(firstString.Length + secondString.Length);

            for (int i = 0; i < firstString.Length; i++)
                newText.text[i] = firstString.text[i];
            for (int i = 0; i < secondString.Length; i++)
                newText.text[i + firstString.Length] = secondString.text[i];
            return newText;
        }

        /// <summary>
        /// This operator returns string multiplied N times (Python-style string operation)
        /// </summary>
        /// <param name="firstString"> String which needed to be multiplied</param>
        /// <param name="numberOfRepetitions"> Numerical number of multiplitions </param>
        /// <returns>Multiplied string</returns>
        public static CustomString operator *(CustomString firstString, int numberOfRepetitions)
        {
            CustomString newText = firstString;

            for (int i = 1; i < numberOfRepetitions; i++)
            {
                newText = firstString + newText;
            }
            return newText;
        }

        public override bool Equals(object userInput)
        {
            if (!(userInput is CustomString other)) return false;
            return text.SequenceEqual(other.text);
        }

        public override int GetHashCode() =>
            ((IStructuralEquatable)text).GetHashCode(EqualityComparer<char>.Default) + length.GetHashCode();

        public static implicit operator string(CustomString userInput) => new string(userInput.text);

        public static implicit operator CustomString(string userInput) => new CustomString(userInput);
        
        public static char[] ToCharArray (CustomString userInput) => (char[])userInput.text.Clone();

        /// <summary>
        /// This method returns True if all characters in the string are digits 
        /// </summary>
        /// <param name="userInput"> String which needed to be checked</param>
        /// <returns></returns>
        public static bool IsDigit(CustomString userInput)
        {
            bool flag = false;
            for (int i = 0; i < userInput.Length; i++)
                if (new char[] { '1', '2', '3', '4', '5', '6', '7', '8', '9', '0' }.Contains((char)userInput[i])) 
                    flag = true;
            return flag;
        }

        /// <summary>
        /// Returns true if a symbol in the string.
        /// </summary>
        /// <param name="userInput"> String which needed to be checked </param>
        /// <param name="symbol"> Character of interest</param>
        /// <returns>True or false</returns>
        public bool Find(char symbol) 
        {
            for (int i = 0; i < Length; i++)
            {
                if (text[i] == symbol) return true;
            }

            return false;
        }



    }
}
