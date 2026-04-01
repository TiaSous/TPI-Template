import clientHttp from '@/core/services/clientHttp';
import type { Todo } from '../models/todo';

export const getAllTodos = async (): Promise<Todo[]> => {
  return (await clientHttp.get('/todo')).data;
};
