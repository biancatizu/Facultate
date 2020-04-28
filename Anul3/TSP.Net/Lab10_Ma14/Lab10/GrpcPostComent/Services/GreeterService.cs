using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Grpc.Core;
using Microsoft.Extensions.Logging;

namespace GrpcPostComent
{
    public class PostCommentService : Greeter.GreeterBase
    {
        public override Task<GetBoolResult> AddPost(GetPostObject post, ServerCallContext context)
        {
            return base.AddPost(post, context);
        }

        public override Task<GetPostObjectResult> UpdatePost(GetPostObject post, ServerCallContext context)
        {
            return base.UpdatePost(post, context);
        }

        public override Task<GetPostIdResult> DeletePost(GetId postId, ServerCallContext context)
        {
            return base.DeletePost(postId, context);
        }

        public override Task<GetPostObjectResult> GetPostById(GetId postId, ServerCallContext context)
        {
            return base.GetPostById(postId, context);
        }

        public override Task<GetBoolResult> AddComment(GetCommentObject comment, ServerCallContext context)
        {
            return base.AddComment(comment, context);
        }

        public override Task<GetCommentObjectResult> GetCommentById(GetId commentId, ServerCallContext context)
        {
            return base.GetCommentById(commentId, context);
        }

        public override Task<GetCommentObjectResult> UpdateComment(GetCommentObject comment, ServerCallContext context)
        {
            return base.UpdateComment(comment, context);
        }
    }
}
