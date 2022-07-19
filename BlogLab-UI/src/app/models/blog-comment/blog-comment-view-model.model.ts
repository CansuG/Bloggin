export class BlogCommentViewModel{

    constructor(
        public parentBlogCommentId: number,
        public blogCommentId: number,
        public blogId: number,
        public content: string,
        public applicationUserId: number,
        public username: string,
        public publishDate: Date,
        public updateDate: Date,
        public deleteConfirm: boolean = false,
        public isEditable: boolean = false,
        public isReplying: boolean = false,
        public comments: BlogCommentViewModel[]
    ){}

}