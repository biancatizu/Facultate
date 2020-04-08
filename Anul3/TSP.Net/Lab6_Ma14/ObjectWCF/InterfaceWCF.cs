using System.Collections.Generic;
using System.ServiceModel;
using PostComment;

namespace ObjectWCF
{
    [ServiceContract]
    interface InterfacePost
    {
        [OperationContract]
        bool AddPost(Post post);
        [OperationContract]
        Post UpdatePost(Post post);
        [OperationContract]
        int DeletePost(int id);
        [OperationContract]
        Post GetPostById(int id);
        [OperationContract]
        List<Post> GetPosts();
    }
    [ServiceContract]
    interface InterfaceComment
    {
        [OperationContract]
        bool AddComment(Comments comment);
        [OperationContract]
        Comments UpdateComment(Comments newComment);
        [OperationContract]
        Comments GetCommentById(int id);
    }
    [ServiceContract]
    interface IPostComment : InterfacePost, InterfaceComment
    {
    }
}
