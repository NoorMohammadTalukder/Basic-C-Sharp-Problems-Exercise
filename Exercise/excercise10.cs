using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise
{
    //When you post a message on Facebook, depending on the number
    //of people who like your post, Facebook displays different information.
    //If no one likes your post, it doesn't display anything.
    //If only one person likes your post, it displays: [Friend's Name] likes your post.
    //If two people like your post, it displays: [Friend 1] and[Friend 2] like your post.
    //If more than two people like your post, it displays: [Friend 1], [Friend 2]
    //and[Number of Other People] others like your post.
    //Write a program and continuously ask the user to enter different names,
    //until the user presses Enter (without supplying a name). Depending on the
    //number of names provided, display a message based on the above pattern.
    public class excercise10
    {
        public void func()
        {
            List<string> friends = new List<string>();

            Console.WriteLine("Enter Friend Name");

            while (true)
            {   
                var friend=Console.ReadLine();
                if (friend != "")
                {
                    friends.Add(friend);
                    continue;
                }

                break;
            }
            var count=friends.Count();

            if (count == 1)
            {
                Console.WriteLine(friends[0] +  " likes your post");
            }
            else if(count == 2)
            {
                Console.WriteLine(friends[0] + " and "+ friends[1] + " likes your post");
            }
            else
            {
                Console.WriteLine(friends[0] + "," + friends[1] + " and "+(count-2) + " others like your post");
            }


        }
    }
}
