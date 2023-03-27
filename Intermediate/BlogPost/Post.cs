using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlogPost
{
    internal class Post
    {
        private string? _title;
        private string? _description;
        private DateTime _createdAt;
        private int _votes;

        public Post(string title, string description)
        {
            _title = title;
            _description = description;
            _createdAt = DateTime.Now;
            _votes = 0;
        }

        public void Upvote() 
        {
            _votes += 1;
        }

        public void Downvote()
        {
            _votes -= 1;
        }

        public int GetVotes()
        {
            return _votes;
        }
    }
}
