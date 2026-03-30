import TodoView from '@/features/todo/views/TodoView.vue';
import { createRouter, createWebHistory } from 'vue-router';

const router = createRouter({
  history: createWebHistory(import.meta.env.BASE_URL),
  routes: [{ path: '/', component: TodoView }],
});

export default router;
