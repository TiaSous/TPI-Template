export class Todo {
  id: number;
  title: string;
  description?: string;
  completed: boolean;
  userId?: number;
  createdAt: Date;

  constructor(
    id: number,
    title: string,
    description: string | undefined,
    completed: boolean,
    userId: number | undefined,
    createdAt: Date
  ) {
    this.id = id;
    this.title = title;
    this.description = description;
    this.completed = completed;
    this.userId = userId;
    this.createdAt = createdAt;
  }
}
