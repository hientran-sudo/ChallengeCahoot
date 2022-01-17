using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Challenge.Models
{
    public class Post
    {
        [Key]
        public int Id { get; set;}
        public long AcceptedAnswerId { get; set; }
        public int AnswerCount { get; set;}
        public string Body { get; set; }
        public DateTime ClosedDate { get; set; }
        public int CommentCount { get; set; }
        public DateTime CommunityOwnedDate { get; set; }
        public DateTime CreationDate { get; set; }
        public long FavoriteCount { get; set; }
        public DateTime LastActivityDate { get; set; }
        public DateTime LastEditDate { get; set; }
        public string LastEditorDisplayName { get; set; }
        public long LastEditorUserId { get; set; }
        public long OwnerUserId { get; set; }
        public long ParentId { get; set; }
        public int PostTypeId { get; set; }
        public long Score { get; set; }
        public string Tags { get; set; }
        public string Title { get; set; }
        public long ViewCount { get; set; }

    }
}
