import clientHttp from '@/core/services/clientHttp';
import type { Todo } from '../models.ts/todo';

export const getAllTodos = async (): Promise<Todo[]> => {
  return (await clientHttp.get('/todo')).data;
};
