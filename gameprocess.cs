using System;

namespace game
{
    class gameprocess
    {
        private string num1 = " ";
        private string num2 = " ";
        private string num3 = " ";
        private string num4 = " ";
        private string num5 = " ";
        private string num6 = " ";
        private string num7 = " ";
        private string num8 = " ";
        private string num9 = " ";
        
        public void show()
        {
            Console.WriteLine(" " + num1 + " | " + num2 + " | " + num3);
            Console.WriteLine(" ------------");
            Console.WriteLine(" " + num4 + " | " + num5 + " | " + num6);
            Console.WriteLine(" ------------");
            Console.WriteLine(" " + num7 + " | " + num8 + " | " + num9);
        } 
        
        public void set_process1(string play1)
        {
            if (play1 == "1" & num1 == " "){this.num1 = "X";}
            else if (play1 == "2" & num2 == " ") { this.num2 = "X"; }
            else if (play1 == "3" & num3 == " ") { this.num3 = "X"; }
            else if (play1 == "4" & num4 == " ") { this.num4 = "X"; }
            else if (play1 == "5" & num5 == " ") { this.num5 = "X"; }
            else if (play1 == "6" & num6 == " ") { this.num6 = "X"; }
            else if (play1 == "7" & num7 == " ") { this.num7 = "X"; }
            else if (play1 == "8" & num8 == " ") { this.num8 = "X"; }
            else if (play1 == "9" & num9 == " ") { this.num9 = "X"; }
        }
        public void set_process2(string play2)
        {
            if (play2 == "1" & num1 == " ") { this.num1 = "X"; }
            else if (play2 == "2" & num2 == " ") { this.num2 = "O"; }
            else if (play2 == "3" & num3 == " ") { this.num3 = "O"; }
            else if (play2 == "4" & num4 == " ") { this.num4 = "O"; }
            else if (play2 == "5" & num5 == " ") { this.num5 = "O"; }
            else if (play2 == "6" & num6 == " ") { this.num6 = "O"; }
            else if (play2 == "7" & num7 == " ") { this.num7 = "O"; }
            else if (play2 == "8" & num8 == " ") { this.num8 = "O"; }
            else if (play2 == "9" & num9 == " ") { this.num9 = "O"; }
        }
        public bool CheckWin1()
        {
            if(num1 == num2 & num2 == num3)
            {
                if (num1 == "X") { return true; }
            }
            else if (num4 == num5 & num5 == num6)
            {
                if (num1 == "X") { return true; }
            }
            else if (num7 == num8 & num8 == num9)
            {
                if (num1 == "X") { return true; }
            }
            else if (num1 == num5 & num5 == num9)
            {
                if (num1 == "X") { return true; }
            }
            else if (num3 == num5 & num5 == num7)
            {
                if (num1 == "X") { return true; }
            }
            else if (num1 == num4 & num4 == num7)
            {
                if (num1 == "X") { return true; }
            }
            else if (num3 == num6 & num6 == num9)
            {
                if (num1 == "X") { return true; } 
            }else return false;
        }
        public bool CheckWin2()
        {
            if (num1 == num2 & num2 == num3)
            {
                if (num1 == "O") { return true; }
            }
            else if (num4 == num5 & num5 == num6)
            {
                if (num1 == "O") { return true; }
            }
            else if (num7 == num8 & num8 == num9)
            {
                if (num1 == "O") { return true; }
            }
            else if (num1 == num5 & num5 == num9)
            {
                if (num1 == "O") { return true; }
            }
            else if (num3 == num5 & num5 == num7)
            {
                if (num1 == "O") { return true; }
            }
            else if (num1 == num4 & num4 == num7)
            {
                if (num1 == "O") { return true; }
            }
            else if (num3 == num6 & num6 == num9)
            {
                if (num1 == "O") { return true; }
            }
            else return false;
        }

    }
}