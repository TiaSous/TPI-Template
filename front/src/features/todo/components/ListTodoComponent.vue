<script setup lang="ts">
import type { Todo } from '../models.ts/todo';
import TodoCardComponent from './TodoCardComponent.vue';

defineProps<{
    todos: Todo[];
    isLoading: boolean;
}>();
</script>

<template>
    <div class="list-todo">
        <div v-if="isLoading">Loading...</div>
        <div v-else>
            <ul style="list-style-type: none;">
                <li v-for="todo in todos" :key="todo.id">
                    <TodoCardComponent :title="todo.title" />
                </li>
            </ul>
        </div>
    </div>
</template>

<style scoped>
.list-todo {
    background-color: var(--blue-teal);
    padding: 16px;
    width: 25%;
    border-radius: 20px;
}
</style>
