namespace _04.SocialMediaPosts
{
    using System;
    using System.Collections.Generic;

    public class SocialMediaPosts
    {
        public static void Main()
        {
            var likesDict = new Dictionary<string, int>();
            var dislikesDict = new Dictionary<string, int>();
            var commentsDict = new Dictionary<string, List<string>>();

            while (true)
            {
                string line = Console.ReadLine();
                if (line == "drop the media") break;

                string[] input = line.Split(' ');

                string action = input[0];
                string post = input[1];

                if (action == "post")
                {
                    likesDict.Add(post, 0);
                    dislikesDict.Add(post, 0);
                    commentsDict.Add(post, new List<string>());
                }
                else if (action == "like")
                {
                    likesDict[post]++;
                }
                else if (action == "dislike")
                {
                    dislikesDict[post]++;
                }
                else
                {
                    string commentator = input[2];

                    int commentStartIndex = action.Length + post.Length + commentator.Length + 3;

                    string comment = line.Substring(commentStartIndex);

                    commentsDict[post].Add($"*  {commentator}: {comment}");
                }
            }

            foreach (var post in likesDict)
            {
                string postName = post.Key;
                int likes = post.Value;

                Console.WriteLine($"Post: {postName} | Likes: {likes} | Dislikes: {dislikesDict[postName]}");
                Console.WriteLine("Comments:");
                if (commentsDict[postName].Count > 0)
                {
                    foreach (var comment in commentsDict[postName])
                    {
                        Console.WriteLine(comment);
                    }
                }
                else
                {
                    Console.WriteLine("None");
                }
            }
        }
    }
}
