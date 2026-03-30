import { defineStore } from 'pinia';
import type { Todo } from '../models.ts/todo';
import { getAllTodos } from '../service/todoService';

export const useTodoStore = defineStore('todo', {
  state: () => ({
    todos: [] as Todo[],
    isLoading: false,
  }),
  actions: {
    async fetchTodos() {
      this.isLoading = true;
      const response = await getAllTodos();
      this.todos = response;
      this.isLoading = false;
    },
  },
});
