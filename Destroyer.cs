﻿
//you may not have methods and the like directly in the namespace, unlike the c family
namespace Destroyer
{
    //i believe this is known as declaring directives (very similar to c++ #include<DASASD>)
    using System;
    //creating classes is essential in c# 
    class darthDestroyer
    {
        public int _kill;

        public int destroy()
        {
            _kill -= 0;
            return _kill;
        }
        // methods belong in Main-- i am still fuzzy on what goes inside parentheses after Main
        static void Main(string[] args)
        {
            //declaring variables
            int vader = 1, trooper = 9000000, force = 20, time = 0;
            //i am creating an object of class darthDestroyer, which allows me to access it and the
            //new variable will be of that class
            //specifics not quite known but I believe new directly causes an instance of whatever was 
            //meant to happen to happen, which in this case is to decrease _kill by one
            darthDestroyer death = new darthDestroyer();
            while (trooper != 0)
            {
                if ((time % 20) != 0)
                {
                    //creating a variable to represent death.destroy() is an option but this is a method
                    //to create an instance in an object? sorry my semantics is weak.
                    trooper = trooper + (vader * death.destroy());
                    time = time + 1;
                    death.destroy();
                }
                else
                {
                    
                    trooper = trooper - (vader * force);
                    time = time + 1;
                    death.destroy();
                }
            }
            //similar to cout<< and cin? >> in c++; of type void so u MUST have empty return. I believe 
            //i had issues compiling without the return
            Console.WriteLine("troopers remaining" + trooper);
            Console.WriteLine("time passed" + time);
            return;
        }
    }
}