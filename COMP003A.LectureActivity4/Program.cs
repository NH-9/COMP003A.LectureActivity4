using System;

namespace COMP003A.LectureActivity4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // displays which numbered task has been completed
            int taskNumber = 1;
            while (taskNumber <= 5)
            {
                Console.WriteLine($"Task {taskNumber} completed");
                taskNumber++;
            }

            /*
            this loop will execute at least once 
            because the condition is only checked
            after the code block runs
            */
            int attempt = 1;
            do
            {
                Console.WriteLine($"Attempt {attempt}");
                attempt++;
            }
            while (attempt <= 3);

            // a for loop is appropiate here because there is a known number of iterations to be completed
            for (int loopCounter = 1; loopCounter <= 4;  loopCounter++)
            {
                Console.WriteLine($"Step {loopCounter}");
            }

            /* 
            The instructions here state to declare "number" as "1" and then within the while loop 
            the number is incremented before displaying its value. The expected output for this step 
            lists "Step 1" as the first outputed line, but this would not happen given the previously
            explained instructions. 
            */
            int number = 1;
            while (number <= 6)
            {
                number++;
                if (number == 4)
                {
                    continue; // continue is used to skip the rest of the current iteration
                }
                if (number == 6)
                {
                    break; // break is used to stop the immediately stop the loop
                }
                Console.WriteLine(number);
            }

            /* 
            1. Which loop was easiest for you to understand?
            For me, the "while loop" was easiest to understand since it has the simplest syntax
            and its function feels intuitive to me; you don't have to think about how it will
            behave as much.

            2. Which loop required the most careful tracing?
            The "for loop" required the most careful tracing because it is set to run an exact 
            number of iterations and would not function properly if the comparison statement was
            just slightly off. 
            
            3. How did comments help you understand your loops?
            Although I already had a good understanding of loops, writing comments helped me be 
            able to articulate their purpose and function. This is an important skill to build as 
            having a clear understanding of one's program leads both to cleaner code and better
            readability for future revisions or working in team environments. 
            */
        }
    }
}
