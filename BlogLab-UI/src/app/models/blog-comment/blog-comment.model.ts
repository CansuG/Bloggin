export class BlogComment{

    constructor(
        public blogCommentId: number,
        public blogId: number,
        public content: string,
        public applicationUserId: number,
        public username: string,
        public publishDate: Date,
        public updateDate: Date,
        public parentBlogCommentId?: number
    ){}

}