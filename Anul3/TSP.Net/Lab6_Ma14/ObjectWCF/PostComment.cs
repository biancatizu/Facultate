using System;
using System.Collections.Generic;
using PostComment;

namespace ObjectWCF
{
    public class PostComment : IPostComment
    {
        public bool AddComment(Comments comment)
        {
            throw new NotImplementedException();
        }

        public Comments GetCommentById(int id)
        {
            throw new NotImplementedException();
        }

        public Comments UpdateComment(Comments newComment)
        {
            throw new NotImplementedException();
        }

        bool InterfaceComment.AddComment(Comments comment)
        {
            return comment.AddComment();
        }
        bool InterfacePost.AddPost(Post post)
        {
            return post.AddPost();
            //return API.AddPost(post);
        }
        int InterfacePost.DeletePost(int id)
        {
            Post post = new Post();
            return post.DeletePost(id);
            // static
            //return API.DeletePost(id);
        }
        Comments InterfaceComment.GetCommentById(int id)
        {
            Comments comment = new Comments();
            return comment.GetCommentById(id);
        }
        Post InterfacePost.GetPostById(int id)
        {
            // E nevoie de ac instanta. Metodele din API sunt metode ale instantei.
            Post post = new Post();
            // Mesaj ce apare in server CUI. Nu e necesar.
            Console.WriteLine("GetPostById. Id = {0}", id);
            post = post.GetPostById(id); // Neclar acest cod.
            Console.WriteLine("Post returnat. Id = {0} , Description = {1}",
           post.PostId, post.Description);
            return post;
        }
        List<Post> InterfacePost.GetPosts()
        {
            Post post = new Post();
            return post.GetAllPosts();
        }
        Comments InterfaceComment.UpdateComment(Comments newComment)
        {
            return newComment.UpdateComment(newComment);
        }
        Post InterfacePost.UpdatePost(Post post)
        {
            return post.UpdatePost(post);
        }
    }
}
